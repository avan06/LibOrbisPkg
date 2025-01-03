﻿using LibOrbisPkg.Util;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.MemoryMappedFiles;
using System.Threading.Tasks;
using System.Linq;
using System.Security.Cryptography;

namespace LibOrbisPkg.PFS
{
  /// <summary>
  /// Contains the functionality to construct a PFS disk image.
  /// </summary>
  public class PfsBuilder
  {
    static int CeilDiv(int a, int b) => a / b + (a % b == 0 ? 0 : 1);
    static long CeilDiv(long a, long b) => a / b + (a % b == 0 ? 0 : 1);

    private PfsHeader pfsHdr;
    private List<Inode> inodes;
    private List<PfsDirent> super_root_dirents;

    private Inode super_root_ino, fpt_ino, cr_ino;

    private List<FSDir> allDirs;
    private List<FSFile> allFiles;
    private List<FSNode> allNodes;

    private FlatPathTable fpt;
    private CollisionResolver colResolver;

    private PfsProperties properties;

    private int emptyBlock = 0x4;
    const int xtsSectorSize = 0x1000;

    private struct BlockSigInfo
    {
      public long Block;
      public long SigOffset;
      public int Size;
      public BlockSigInfo(long block, long offset, int size = 0x10000)
      {
        Block = block;
        SigOffset = offset;
        Size = size;
      }
    }
    private Stack<BlockSigInfo> final_sigs = new Stack<BlockSigInfo>();
    private Stack<BlockSigInfo> data_sigs = new Stack<BlockSigInfo>();

    Action<object> logger;
    private void Log(object s) => logger?.Invoke(s);

    /// <summary>
    /// Constructs a PfsBuilder with the given properties and logger.
    /// </summary>
    /// <param name="p">Properties for the image to be built</param>
    /// <param name="logger">Function that is called to report realtime PFS build status.</param>
    public PfsBuilder(PfsProperties p, Action<object> logger = null)
    {
      this.logger = logger;
      properties = p;
      Setup();
    }

    /// <summary>
    /// Computes the final size of this image as it will be written to disk.
    /// </summary>
    /// <returns>PFS Image size</returns>
    public long CalculatePfsSize() => pfsHdr.Ndblock * pfsHdr.BlockSize;

    /// <summary>
    /// This gets called by the constructor.
    /// </summary>
    void Setup()
    {
      // TODO: Combine the superroot-specific stuff with the rest of the data block writing.
      // I think this is as simple as adding superroot and flat_path_table to allNodes

      // Insert header digest to be calculated with the rest of the digests
      final_sigs.Push(new BlockSigInfo(0, 0x380, 0x5A0));
      pfsHdr = new PfsHeader {
        BlockSize = properties.BlockSize,
        ReadOnly = 1,
        Mode = (properties.Sign ? PfsMode.Signed : 0)
             | (properties.Encrypt ? PfsMode.Encrypted : 0)
             | PfsMode.UnknownFlagAlwaysSet,
        Unk_Index = 1,
        Seed = properties.Encrypt || properties.Sign ? properties.Seed : null
      };
      inodes = new List<Inode>();

      Log("Setting up filesystem structure...");
      allDirs = properties.root.GetAllChildrenDirs();
      // The trp file under the sce_sys/trophy/ directory should be considered an Entry rather than an FSFile.
      allFiles = properties.root.GetAllChildrenFiles().Where(f => !f.FullPath().StartsWith("/sce_sys") || !PKG.EntryNames.NameToId.ContainsKey(f.FullPath().Replace("/sce_sys/", ""))).ToList();
      allNodes = new List<FSNode>(allDirs); //.OrderBy(d => d.FullPath(), StringComparer.Ordinal).ToList() //https://stackoverflow.com/a/67052496/22545576
      allNodes.AddRange(allFiles);

      SetupRootStructure(FlatPathTable.HasCollision(allNodes));

      Log($"Creating inodes ({allDirs.Count} dirs and {allFiles.Count} files)...");
      addDirInodes();
      addFileInodes();

      (fpt, colResolver) = FlatPathTable.Create(allNodes);

      Log("Calculating data block layout...");
      allNodes.Insert(0, properties.root);
      CalculateDataBlockLayout();
    }

    private void WriteData(Stream stream)
    {
      Log("Writing data...");
      pfsHdr.WriteToStream(stream);
      WriteInodes(stream);
      WriteSuperrootDirents(stream);

      allNodes.Insert(0, new FSFile(s => fpt.WriteToStream(s), "flat_path_table", fpt.Size)
      {
        ino = fpt_ino
      });
      if (colResolver != null)
      {
        allNodes.Insert(1, new FSFile(s => colResolver.WriteToStream(s), "collision_resolver", colResolver.Size)
        {
          ino = cr_ino
        });
      }

      for (var x = 0; x < allNodes.Count; x++)
      {
        var f = allNodes[x];
        stream.Position = f.ino.StartBlock * pfsHdr.BlockSize;
        WriteFSNode(stream, f);
      }
    }

    /// <summary>
    /// Enumerates the sectors that should be encrypted with AES-XTS
    /// </summary>
    /// <returns>Sector indices</returns>
    private IEnumerable<long> XtsSectorGen()
    {
      long totalSectors = (CalculatePfsSize() + 0xFFF) / xtsSectorSize;
      long xtsSector = 16;
      while (xtsSector < totalSectors)
      {
        if (xtsSector / 0x10 == emptyBlock)
        {
          xtsSector += 16;
        }
        yield return xtsSector;
        xtsSector += 1;
      }
    }

    /// <summary>
    /// Writes the PFS image using a memory mapped file. This allows for parallelization of signing and encrypting.
    /// </summary>
    /// <param name="file">The memory mapped file</param>
    /// <param name="offset">Start offset of the PFS image in the file</param>
    /// <param name="newCrypt">
    /// Generate using the old method when pfs_flags is 0x80000000000003CC, 
    /// Generate using the new method when pfs_flags is 0xA0000000000003CC</param>
    public void WriteImage(MemoryMappedFile file, long offset, bool newCrypt = false)
    {
      using (var viewStream = file.CreateViewStream(offset, CalculatePfsSize(), MemoryMappedFileAccess.ReadWrite))
      {
        WriteData(viewStream);
      }
      using (var view = file.CreateViewAccessor(offset, CalculatePfsSize(), MemoryMappedFileAccess.ReadWrite))
      {
        if (pfsHdr.Mode.HasFlag(PfsMode.Signed))
        {
          Log("Signing in parallel...");
          var signKey = Crypto.PfsGenSignKey(properties.EKPFS, pfsHdr.Seed);
          // We can do the actual data blocks in parallel
          Parallel.ForEach(
            data_sigs,
            new ParallelOptions { MaxDegreeOfParallelism = 10 },
            () => Tuple.Create(new byte[properties.BlockSize], new HMACSHA256(signKey)),
            (sig, status, local) =>
            {
              (byte[] sig_buffer, HMACSHA256 hmac) = local;
              var position = sig.Block * sig_buffer.Length;
              view.ReadArray(position, sig_buffer, 0, sig_buffer.Length);
              position = sig.SigOffset;
              view.WriteArray(position, Crypto.HmacSha256(signKey, sig_buffer), 0, 32);
              view.Write(position + 32, (int)sig.Block);
              return local;
            },
            local => local.Item2.Dispose());
          // The indirect blocks must be done after, since they rely on data block signatures
          foreach (var sig in final_sigs)
          {
            var sig_buffer = new byte[sig.Size];
            var position = sig.Block * properties.BlockSize;
            view.ReadArray(position, sig_buffer, 0, sig_buffer.Length);
            position = sig.SigOffset;
            view.WriteArray(position, Crypto.HmacSha256(signKey, sig_buffer), 0, 32);
            view.Write(position + 32, (int)sig.Block);
          }
          Log(40); //Returning the current execution progress: 40%, PfsBuilder(WriteImage) => PkgBuilder(Write) => GP4View(BuildPkg)
        }

        if (pfsHdr.Mode.HasFlag(PfsMode.Encrypted))
        {
          Log("Encrypting in parallel...");
          (byte[] tweakKey, byte[] dataKey) = Crypto.PfsGenEncKey(properties.EKPFS, pfsHdr.Seed, newCrypt);
          Parallel.ForEach(
            // generates sector indices for each sector to be encrypted
            XtsSectorGen(),
            new ParallelOptions { MaxDegreeOfParallelism = 10 },
            // generates thread-local data
            () => Tuple.Create(new XtsBlockTransform(dataKey, tweakKey), new byte[xtsSectorSize]),
            // Loop body
            (xtsSector, loopState, localData) =>
            {
              (XtsBlockTransform transformer, byte[] sectorBuffer) = localData;
              var sectorOffset = xtsSector * xtsSectorSize;
              view.ReadArray(sectorOffset, sectorBuffer, 0, xtsSectorSize);
              transformer.EncryptSector(sectorBuffer, (ulong)xtsSector);
              view.WriteArray(sectorOffset, sectorBuffer, 0, xtsSectorSize);
              return localData;
            },
            // Finalizer
            local => { });
        }
      }
    }

    /// <summary>
    /// Writes the PFS image to the given stream
    /// </summary>
    public void WriteImage(Stream stream, bool newCrypt = false)
    {
      WriteData(stream);

      if (pfsHdr.Mode.HasFlag(PfsMode.Signed))
      {
        Log("Signing...");
        var signKey = Crypto.PfsGenSignKey(properties.EKPFS, pfsHdr.Seed);
        foreach (var sig in data_sigs.Concat(final_sigs))
        {
          var sig_buffer = new byte[sig.Size];
          stream.Position = sig.Block * properties.BlockSize;
          stream.Read(sig_buffer, 0, sig.Size);
          stream.Position = sig.SigOffset;
          stream.Write(Crypto.HmacSha256(signKey, sig_buffer), 0, 32);
          stream.WriteLE((int)sig.Block);
        }
      }

      if (pfsHdr.Mode.HasFlag(PfsMode.Encrypted))
      {
        Log("Encrypting...");
        (byte[] tweakKey, byte[] dataKey) = Crypto.PfsGenEncKey(properties.EKPFS, pfsHdr.Seed, newCrypt);
        var transformer = new XtsBlockTransform(dataKey, tweakKey);
        byte[] sectorBuffer = new byte[xtsSectorSize];
        foreach (var xtsSector in XtsSectorGen())
        {
          stream.Position = xtsSector * xtsSectorSize;
          stream.Read(sectorBuffer, 0, xtsSectorSize);
          transformer.EncryptSector(sectorBuffer, (ulong)xtsSector);
          stream.Position = xtsSector * xtsSectorSize;
          stream.Write(sectorBuffer, 0, xtsSectorSize);
        }
      }
    }

    /// <summary>
    /// Adds inodes for each dir.
    /// </summary>
    void addDirInodes()
    {
      inodes.Add(properties.root.ino);
      foreach (var dir in allDirs.OrderBy(x => x.FullPath(), StringComparer.Ordinal)) //https://stackoverflow.com/a/67052496/22545576
      {
        var ino = MakeInode(
          Mode: InodeMode.dir | Inode.RXOnly,
          Number: (uint)inodes.Count,
          Blocks: 1,
          Size: 65536,
          Flags: InodeFlags.@readonly,
          Nlink: 2 // 1 link each for its own dirent and its . dirent
        );
        dir.ino = ino;
        dir.Dirents.Add(new PfsDirent { Name = ".", InodeNumber = ino.Number, Type = DirentType.Dot });
        dir.Dirents.Add(new PfsDirent { Name = "..", InodeNumber = dir.Parent.ino.Number, Type = DirentType.DotDot });

        var dirent = new PfsDirent { Name = dir.name, InodeNumber = (uint)inodes.Count, Type = DirentType.Directory };
        dir.Parent.Dirents.Add(dirent);
        dir.Parent.ino.Nlink++;
        inodes.Add(ino);
      }
    }

    /// <summary>
    /// Adds inodes for each file.
    /// </summary>
    void addFileInodes()
    {
      // The path processing here is because the original sorting method places files with fewer folder layers towards the end.
      // For example, files located in the root directory like "/eboot.bin" will be sorted after all folders, such as paths like "/data/..."
      //https://learn.microsoft.com/en-us/dotnet/standard/base-types/string-comparison-net-5-plus
      foreach (var file in allFiles.OrderBy(x => x.FullPath().Replace(x.name, "") + "zzzzzzzzzz/" + x.name, StringComparer.Ordinal))
      {
        var ino = MakeInode(
          Mode: InodeMode.file | Inode.RXOnly,
          Size: file.Size,
          SizeCompressed: file.CompressedSize,
          Number: (uint)inodes.Count,
          Blocks: (uint)CeilDiv(file.Size, pfsHdr.BlockSize),
          Flags: InodeFlags.@readonly | (file.Compress ? InodeFlags.compressed : 0)
        );
        if (properties.Sign) // HACK: Outer PFS images don't use readonly?
        {
          ino.Flags &= ~InodeFlags.@readonly;
        }
        file.ino = ino;
        var dirent = new PfsDirent { Name = file.name, Type = DirentType.File, InodeNumber = (uint)inodes.Count };
        file.Parent.Dirents.Add(dirent);
        inodes.Add(ino);
      }
    }

    long roundUpSizeToBlock(long size) => CeilDiv(size, pfsHdr.BlockSize) * pfsHdr.BlockSize;
    long calculateIndirectBlocks(long size)
    {
      var sigs_per_block = pfsHdr.BlockSize / 36;
      var blocks = CeilDiv(size, pfsHdr.BlockSize);
      var ib = 0L;
      if (blocks > 12)
      {
        blocks -= 12;
        ib++;
      }
      if (blocks > sigs_per_block)
      {
        blocks -= sigs_per_block;
        ib += 1 + CeilDiv(blocks, sigs_per_block);
      }
      return ib;
    }

    ///<summary>
    ///Given an inode number and an index into the db[] array, returns the absolute offset of that array value
    ///</summary>
    long inoNumberToOffset(uint number, int db = 0)
      => pfsHdr.BlockSize + (DinodeS32.SizeOf * number) + 0x64 + (36 * db);

    /// <summary>
    /// Sets the data blocks. Also updates header for total number of data blocks.
    /// </summary>
    void CalculateDataBlockLayout()
    {
      // TODO: Consolidate of all this duplicate code
      if (properties.Sign)
      {
        // Include the header block in the total count
        pfsHdr.Ndblock = 1;
        var inodesPerBlock = pfsHdr.BlockSize / DinodeS32.SizeOf;
        pfsHdr.DinodeCount = inodes.Count;
        pfsHdr.DinodeBlockCount = CeilDiv(inodes.Count, inodesPerBlock);
        pfsHdr.InodeBlockSig.Blocks = (uint)pfsHdr.DinodeBlockCount;
        pfsHdr.InodeBlockSig.Size = pfsHdr.DinodeBlockCount * pfsHdr.BlockSize;
        pfsHdr.InodeBlockSig.SizeCompressed = pfsHdr.DinodeBlockCount * pfsHdr.BlockSize;
        pfsHdr.InodeBlockSig.SetTime(properties.FileTime);
        pfsHdr.InodeBlockSig.Flags = 0;
        for (var i = 0; i < pfsHdr.DinodeBlockCount; i++)
        {
          pfsHdr.InodeBlockSig.SetDirectBlock(i, 1 + i);
          final_sigs.Push(new BlockSigInfo(1 + i, 0xB8 + (36 * i)));
        }
        pfsHdr.Ndblock += pfsHdr.DinodeBlockCount;
        super_root_ino.SetDirectBlock(0, (int)(pfsHdr.DinodeBlockCount + 1));
        final_sigs.Push(new BlockSigInfo(super_root_ino.StartBlock, inoNumberToOffset(super_root_ino.Number)));
        pfsHdr.Ndblock += super_root_ino.Blocks;

        // flat path table
        fpt_ino.SetDirectBlock(0, super_root_ino.StartBlock + 1);
        fpt_ino.Size = fpt.Size;
        fpt_ino.SizeCompressed = fpt.Size;
        fpt_ino.Blocks = (uint)CeilDiv(fpt.Size, pfsHdr.BlockSize);
        final_sigs.Push(new BlockSigInfo(fpt_ino.StartBlock, inoNumberToOffset(fpt_ino.Number)));

        for (int i = 1; i < fpt_ino.Blocks && i < 12; i++)
        {
          fpt_ino.SetDirectBlock(i, (int)pfsHdr.Ndblock++);
          final_sigs.Push(new BlockSigInfo(fpt_ino.StartBlock, inoNumberToOffset(fpt_ino.Number, i)));
        }

        // DATs I've found include an empty block after the FPT
        pfsHdr.Ndblock++;
        // HACK: outer PFS has a block of zeroes that is not encrypted???
        emptyBlock = (int)pfsHdr.Ndblock;
        pfsHdr.Ndblock++;

        var ibStartBlock = pfsHdr.Ndblock;
        pfsHdr.Ndblock += allNodes.Select(s => calculateIndirectBlocks(s.Size)).Sum();

        var sigs_per_block = pfsHdr.BlockSize / 36;
        // Fill in DB/IB pointers
        foreach (var n in allNodes)
        {
          var blocks = CeilDiv(n.Size, pfsHdr.BlockSize);
          n.ino.SetDirectBlock(0, (int)pfsHdr.Ndblock);
          n.ino.Blocks = (uint)blocks;
          n.ino.Size = n is FSDir ? roundUpSizeToBlock(n.Size) : n.Size;
          if (n.ino.SizeCompressed == 0)
            n.ino.SizeCompressed = n.ino.Size;

          for (var i = 0; (blocks - i) > 0 && i < 12; i++)
          {
            data_sigs.Push(new BlockSigInfo((int)pfsHdr.Ndblock++, inoNumberToOffset(n.ino.Number, i)));
          }
          if(blocks > 12)
          {
            // More than 12 blocks -> use 1 indirect block
            // ib[0]
            final_sigs.Push(new BlockSigInfo(ibStartBlock, inoNumberToOffset(n.ino.Number, 12)));
            for(int i = 12, pointerOffset = 0; (blocks - i) > 0 && i < (12 + sigs_per_block); i++, pointerOffset += 36)
            {
              // ib[0][i]
              data_sigs.Push(new BlockSigInfo((int)pfsHdr.Ndblock++, ibStartBlock * pfsHdr.BlockSize + pointerOffset));
            }
            ibStartBlock++;
          }
          if(blocks > 12 + sigs_per_block)
          {
            uint blockSigsDone = 12 + sigs_per_block;
            // More than 12 + one block of pointers -> use 1 doubly-indirect block + any number of indirect blocks
            // ib[1] = signature for block of signatures for block of signatures for data blocks
            final_sigs.Push(new BlockSigInfo(ibStartBlock, inoNumberToOffset(n.ino.Number, 13)));
            var ib_1_block = ibStartBlock;
            for(var i = 0; i < sigs_per_block && blockSigsDone < blocks; i++)
            {
              // ib[1][i] = signature for block of signatures for data blocks
              final_sigs.Push(new BlockSigInfo((int)++ibStartBlock, ib_1_block * pfsHdr.BlockSize + i*36));
              for (int j = 0; j < sigs_per_block && blockSigsDone < blocks; j++, blockSigsDone++)
              {
                // ib[1][i][j] = signature for data block
                data_sigs.Push(new BlockSigInfo((int)pfsHdr.Ndblock++, ibStartBlock * pfsHdr.BlockSize + (j*36)));
              }
            }
          }
        }
      }
      else
      {
        // Include the header block in the total count
        pfsHdr.Ndblock = 1;
        var inodesPerBlock = pfsHdr.BlockSize / DinodeD32.SizeOf;
        pfsHdr.DinodeCount = inodes.Count;
        pfsHdr.DinodeBlockCount = CeilDiv(inodes.Count, inodesPerBlock);
        pfsHdr.InodeBlockSig.Blocks = (uint)pfsHdr.DinodeBlockCount;
        pfsHdr.InodeBlockSig.Size = pfsHdr.DinodeBlockCount * pfsHdr.BlockSize;
        pfsHdr.InodeBlockSig.SizeCompressed = pfsHdr.DinodeBlockCount * pfsHdr.BlockSize;
        pfsHdr.InodeBlockSig.SetDirectBlock(0, (int)pfsHdr.Ndblock++);
        pfsHdr.InodeBlockSig.SetTime(properties.FileTime);
        for (var i = 1; i < pfsHdr.DinodeBlockCount; i++)
        {
          if(i < 12)
            pfsHdr.InodeBlockSig.SetDirectBlock(i, -1);
          pfsHdr.Ndblock++;
        }
        super_root_ino.SetDirectBlock(0, (int)pfsHdr.Ndblock);
        pfsHdr.Ndblock += super_root_ino.Blocks;

        // flat path table
        fpt_ino.SetDirectBlock(0, (int)pfsHdr.Ndblock++);
        fpt_ino.Size = fpt.Size;
        fpt_ino.SizeCompressed = fpt.Size;
        fpt_ino.Blocks = (uint)CeilDiv(fpt.Size, pfsHdr.BlockSize);

        for (int i = 1; i < fpt_ino.Blocks && i < 12; i++)
          fpt_ino.SetDirectBlock(i, (int)pfsHdr.Ndblock++);

        // DATs I've found include an empty block after the FPT if there's no collision resolver
        if(cr_ino == null)
        {
          pfsHdr.Ndblock++;
        }
        else
        {
          // collision resolver
          cr_ino.SetDirectBlock(0, (int)pfsHdr.Ndblock++);
          cr_ino.Size = colResolver.Size;
          cr_ino.SizeCompressed = colResolver.Size;
          cr_ino.Blocks = (uint)CeilDiv(colResolver.Size, pfsHdr.BlockSize);

          for (int i = 1; i < cr_ino.Blocks && i < 12; i++)
            cr_ino.SetDirectBlock(i, (int)pfsHdr.Ndblock++);
        }

        // Calculate length of all dirent blocks
        foreach (var n in allNodes)
        {
          var blocks = CeilDiv(n.Size, pfsHdr.BlockSize);
          n.ino.SetDirectBlock(0, (int)pfsHdr.Ndblock);
          n.ino.Blocks = (uint)blocks;
          n.ino.Size = n is FSDir ? roundUpSizeToBlock(n.Size) : n.Size;
          if(n.ino.SizeCompressed == 0)
            n.ino.SizeCompressed = n.ino.Size;
          for (int i = 1; i < blocks && i < 12; i++)
          {
            n.ino.SetDirectBlock(i, -1);
          }
          pfsHdr.Ndblock += blocks;
        }
      }
      // Hack: set a minimum size for the PFS image.
      pfsHdr.Ndblock = Math.Max(pfsHdr.Ndblock, properties.MinBlocks);
    }

    Inode MakeInode(InodeMode Mode, uint Blocks, long Size = 0, long SizeCompressed = 0, ushort Nlink = 1, uint Number = 0, InodeFlags Flags = 0)
    {
      Inode ret;
      if (properties.Sign)
      {
        ret = new DinodeS32()
        {
          Mode = Mode,
          Blocks = Blocks,
          Size = Size,
          SizeCompressed = SizeCompressed,
          Nlink = Nlink,
          Number = Number,
          Flags = Flags | InodeFlags.unk2 | InodeFlags.unk3,
        };
      }
      else
      {
        ret = new DinodeD32()
        {
          Mode = Mode,
          Blocks = Blocks,
          Size = Size,
          SizeCompressed = SizeCompressed,
          Nlink = Nlink,
          Number = Number,
          Flags = Flags
        };
      }
      ret.SetTime(properties.FileTime);
      return ret;
    }

    /// <summary>
    /// Creates inodes and dirents for superroot, flat_path_table, and uroot.
    /// Also, creates the root node for the FS tree.
    /// </summary>
    void SetupRootStructure(bool hasCollision)
    {
      var inodeNum = 0u;
      inodes.Add(super_root_ino = MakeInode(
        Mode: InodeMode.dir | Inode.RXOnly,
        Blocks: 1,
        Size: 65536,
        SizeCompressed: 65536,
        Nlink: 1,
        Number: inodeNum++,
        Flags: InodeFlags.@internal | InodeFlags.@readonly
      ));
      inodes.Add(fpt_ino = MakeInode(
        Mode: InodeMode.file | Inode.RXOnly,
        Blocks: 1,
        Number: inodeNum++,
        Flags: InodeFlags.@internal | InodeFlags.@readonly
      ));
      if(hasCollision)
      {
        inodes.Add(cr_ino = MakeInode(
          Mode: InodeMode.file | Inode.RXOnly,
          Blocks: 1,
          Number: inodeNum++,
          Flags: InodeFlags.@internal | InodeFlags.@readonly
        ));
      }
      var uroot_ino = MakeInode(
        Mode: InodeMode.dir | Inode.RXOnly,
        Number: inodeNum++,
        Size: 65536,
        SizeCompressed: 65536,
        Blocks: 1,
        Flags: InodeFlags.@readonly,
        Nlink: 3
      );

      super_root_dirents = new List<PfsDirent>
      {
        new PfsDirent { InodeNumber = fpt_ino.Number, Name = "flat_path_table", Type = DirentType.File },
      };
      if(hasCollision)
      {
        super_root_dirents.Add(
          new PfsDirent { InodeNumber = cr_ino.Number, Name = "collision_resolver", Type = DirentType.File });
      }
      super_root_dirents.Add(
        new PfsDirent { InodeNumber = uroot_ino.Number, Name = "uroot", Type = DirentType.Directory });

      properties.root.name = "uroot";
      properties.root.ino = uroot_ino;
      properties.root.Dirents = new List<PfsDirent>
      {
        new PfsDirent { Name = ".", Type = DirentType.Dot, InodeNumber = uroot_ino.Number },
        new PfsDirent { Name = "..", Type = DirentType.DotDot, InodeNumber = uroot_ino.Number }
      };
      if(properties.Sign) // HACK: Outer PFS lacks readonly flags
      {
        super_root_ino.Flags &= ~InodeFlags.@readonly;
        fpt_ino.Flags &= ~InodeFlags.@readonly;
        uroot_ino.Flags &= ~InodeFlags.@readonly;
      }
    }

    /// <summary>
    /// Writes all the inodes to the image file. 
    /// </summary>
    /// <param name="s"></param>
    void WriteInodes(Stream s)
    {
      s.Position = pfsHdr.BlockSize;
      foreach (var di in inodes)
      {
        di.WriteToStream(s);
        if (s.Position % pfsHdr.BlockSize > pfsHdr.BlockSize - (properties.Sign ? DinodeS32.SizeOf : DinodeD32.SizeOf))
        {
          s.Position += pfsHdr.BlockSize - (s.Position % pfsHdr.BlockSize);
        }
      }
    }

    /// <summary>
    /// Writes the dirents for the superroot, which precede the flat_path_table.
    /// </summary>
    /// <param name="stream"></param>
    void WriteSuperrootDirents(Stream stream)
    {
      stream.Position = pfsHdr.BlockSize * (pfsHdr.DinodeBlockCount + 1);
      foreach (var d in super_root_dirents)
      {
        d.WriteToStream(stream);
      }
    }

    /// <summary>
    /// Writes all the data blocks.
    /// </summary>
    /// <param name="s"></param>
    void WriteFSNode(Stream s, FSNode f)
    {
      if (f is FSDir)
      {
        var dir = (FSDir)f;
        var startBlock = f.ino.StartBlock;
        foreach (var d in dir.Dirents)
        {
          d.WriteToStream(s);
          if (s.Position % pfsHdr.BlockSize > pfsHdr.BlockSize - PfsDirent.MaxSize)
          {
            s.Position = (++startBlock * pfsHdr.BlockSize);
          }
        }
      }
      else if (f is FSFile)
      {
        var file = (FSFile)f;
        file.Write(s);
      }
    }
  }
}