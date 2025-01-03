﻿namespace PkgEditor.Views
{
  partial class PkgView
  {
    /// <summary> 
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary> 
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Component Designer generated code

    /// <summary> 
    /// Required method for Designer support - do not modify 
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.extractToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.extractDecryptedMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.validateResult = new System.Windows.Forms.TextBox();
            this.checkDigestsButton = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.filesTab = new System.Windows.Forms.TabPage();
            this.xtsTweakTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.xtsDataTextBox = new System.Windows.Forms.TextBox();
            this.openWithXtsKeysBtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.ekpfsTextBox = new System.Windows.Forms.TextBox();
            this.openWithEkpfsBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.passcodeTextBox = new System.Windows.Forms.TextBox();
            this.openWithPasscodeBtn = new System.Windows.Forms.Button();
            this.entriesTab = new System.Windows.Forms.TabPage();
            this.entriesListView = new System.Windows.Forms.ListView();
            this.columnHeaderId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderOffset = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderEnc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderKeyIdx = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderFlags = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderNTabOffset = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.infoTab = new System.Windows.Forms.TabPage();
            this.TableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.appVerLabelLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.contentIdTextBox = new System.Windows.Forms.TextBox();
            this.versionLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.typeLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.sizeLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.DecryptEntryCheckBox = new System.Windows.Forms.CheckBox();
            this.appVerLabel = new System.Windows.Forms.Label();
            this.ExportProgressMsg = new System.Windows.Forms.Label();
            this.ExportProgressBar = new System.Windows.Forms.ProgressBar();
            this.ExportGP4Project = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pkgHeaderTabControl = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.pkgHeaderTreeView = new System.Windows.Forms.TreeView();
            this.outerPfsHeaderTabPage = new System.Windows.Forms.TabPage();
            this.pfsHeaderTreeView = new System.Windows.Forms.TreeView();
            this.mainTabControl = new System.Windows.Forms.TabControl();
            this.contextMenuStrip1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.filesTab.SuspendLayout();
            this.entriesTab.SuspendLayout();
            this.infoTab.SuspendLayout();
            this.TableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pkgHeaderTabControl.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.outerPfsHeaderTabPage.SuspendLayout();
            this.mainTabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.extractToolStripMenuItem,
            this.extractDecryptedMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(185, 48);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.ContextMenuStrip1_Opening);
            // 
            // extractToolStripMenuItem
            // 
            this.extractToolStripMenuItem.Name = "extractToolStripMenuItem";
            this.extractToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.extractToolStripMenuItem.Text = "Extract";
            this.extractToolStripMenuItem.Click += new System.EventHandler(this.ExtractToolStripMenuItem_Click);
            // 
            // extractDecryptedMenuItem
            // 
            this.extractDecryptedMenuItem.Name = "extractDecryptedMenuItem";
            this.extractDecryptedMenuItem.Size = new System.Drawing.Size(184, 22);
            this.extractDecryptedMenuItem.Text = "Extract and Decrypt";
            this.extractDecryptedMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.listView1);
            this.tabPage2.Controls.Add(this.validateResult);
            this.tabPage2.Controls.Add(this.checkDigestsButton);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(535, 340);
            this.tabPage2.TabIndex = 4;
            this.tabPage2.Text = "Validate";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(138, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(326, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "Note: These results are only valid for PKGs created with LibOrbisPkg";
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2});
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(6, 32);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(174, 304);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.ListView1_SelectedIndexChanged);
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name";
            this.columnHeader2.Width = 150;
            // 
            // validateResult
            // 
            this.validateResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.validateResult.Location = new System.Drawing.Point(186, 32);
            this.validateResult.Multiline = true;
            this.validateResult.Name = "validateResult";
            this.validateResult.Size = new System.Drawing.Size(343, 304);
            this.validateResult.TabIndex = 0;
            // 
            // checkDigestsButton
            // 
            this.checkDigestsButton.Location = new System.Drawing.Point(6, 6);
            this.checkDigestsButton.Name = "checkDigestsButton";
            this.checkDigestsButton.Size = new System.Drawing.Size(126, 21);
            this.checkDigestsButton.TabIndex = 1;
            this.checkDigestsButton.Text = "Check PKG Digests";
            this.checkDigestsButton.UseVisualStyleBackColor = true;
            this.checkDigestsButton.Click += new System.EventHandler(this.checkDigests_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(535, 340);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "SFO";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // filesTab
            // 
            this.filesTab.Controls.Add(this.xtsTweakTextBox);
            this.filesTab.Controls.Add(this.label9);
            this.filesTab.Controls.Add(this.xtsDataTextBox);
            this.filesTab.Controls.Add(this.openWithXtsKeysBtn);
            this.filesTab.Controls.Add(this.label7);
            this.filesTab.Controls.Add(this.ekpfsTextBox);
            this.filesTab.Controls.Add(this.openWithEkpfsBtn);
            this.filesTab.Controls.Add(this.label1);
            this.filesTab.Controls.Add(this.passcodeTextBox);
            this.filesTab.Controls.Add(this.openWithPasscodeBtn);
            this.filesTab.Location = new System.Drawing.Point(4, 22);
            this.filesTab.Name = "filesTab";
            this.filesTab.Padding = new System.Windows.Forms.Padding(3);
            this.filesTab.Size = new System.Drawing.Size(535, 340);
            this.filesTab.TabIndex = 1;
            this.filesTab.Text = "Files";
            this.filesTab.UseVisualStyleBackColor = true;
            // 
            // xtsTweakTextBox
            // 
            this.xtsTweakTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.xtsTweakTextBox.Location = new System.Drawing.Point(9, 167);
            this.xtsTweakTextBox.MaxLength = 32;
            this.xtsTweakTextBox.Name = "xtsTweakTextBox";
            this.xtsTweakTextBox.Size = new System.Drawing.Size(247, 22);
            this.xtsTweakTextBox.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 128);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(184, 12);
            this.label9.TabIndex = 8;
            this.label9.Text = "Or try using XTS data and tweak keys:";
            // 
            // xtsDataTextBox
            // 
            this.xtsDataTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.xtsDataTextBox.Location = new System.Drawing.Point(9, 143);
            this.xtsDataTextBox.MaxLength = 32;
            this.xtsDataTextBox.Name = "xtsDataTextBox";
            this.xtsDataTextBox.Size = new System.Drawing.Size(247, 22);
            this.xtsDataTextBox.TabIndex = 7;
            // 
            // openWithXtsKeysBtn
            // 
            this.openWithXtsKeysBtn.Location = new System.Drawing.Point(9, 191);
            this.openWithXtsKeysBtn.Name = "openWithXtsKeysBtn";
            this.openWithXtsKeysBtn.Size = new System.Drawing.Size(112, 21);
            this.openWithXtsKeysBtn.TabIndex = 6;
            this.openWithXtsKeysBtn.Text = "Try Data + Tweak";
            this.openWithXtsKeysBtn.UseVisualStyleBackColor = true;
            this.openWithXtsKeysBtn.Click += new System.EventHandler(this.openWithXtsKeysBtn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 12);
            this.label7.TabIndex = 5;
            this.label7.Text = "Or try using an EKPFS:";
            // 
            // ekpfsTextBox
            // 
            this.ekpfsTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.ekpfsTextBox.Location = new System.Drawing.Point(9, 80);
            this.ekpfsTextBox.MaxLength = 64;
            this.ekpfsTextBox.Name = "ekpfsTextBox";
            this.ekpfsTextBox.Size = new System.Drawing.Size(247, 22);
            this.ekpfsTextBox.TabIndex = 4;
            // 
            // openWithEkpfsBtn
            // 
            this.openWithEkpfsBtn.Location = new System.Drawing.Point(9, 104);
            this.openWithEkpfsBtn.Name = "openWithEkpfsBtn";
            this.openWithEkpfsBtn.Size = new System.Drawing.Size(112, 21);
            this.openWithEkpfsBtn.TabIndex = 3;
            this.openWithEkpfsBtn.Text = "Try EKPFS";
            this.openWithEkpfsBtn.UseVisualStyleBackColor = true;
            this.openWithEkpfsBtn.Click += new System.EventHandler(this.openWithEkpfsBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "The package\'s passcode is required to decrypt the PFS image:";
            // 
            // passcodeTextBox
            // 
            this.passcodeTextBox.Location = new System.Drawing.Point(9, 18);
            this.passcodeTextBox.MaxLength = 32;
            this.passcodeTextBox.Name = "passcodeTextBox";
            this.passcodeTextBox.Size = new System.Drawing.Size(247, 22);
            this.passcodeTextBox.TabIndex = 1;
            // 
            // openWithPasscodeBtn
            // 
            this.openWithPasscodeBtn.Location = new System.Drawing.Point(9, 42);
            this.openWithPasscodeBtn.Name = "openWithPasscodeBtn";
            this.openWithPasscodeBtn.Size = new System.Drawing.Size(112, 21);
            this.openWithPasscodeBtn.TabIndex = 0;
            this.openWithPasscodeBtn.Text = "Try Passcode";
            this.openWithPasscodeBtn.UseVisualStyleBackColor = true;
            this.openWithPasscodeBtn.Click += new System.EventHandler(this.openWithPasscodeBtn_Click);
            // 
            // entriesTab
            // 
            this.entriesTab.Controls.Add(this.entriesListView);
            this.entriesTab.Location = new System.Drawing.Point(4, 22);
            this.entriesTab.Name = "entriesTab";
            this.entriesTab.Padding = new System.Windows.Forms.Padding(3);
            this.entriesTab.Size = new System.Drawing.Size(535, 340);
            this.entriesTab.TabIndex = 0;
            this.entriesTab.Text = "Entries";
            this.entriesTab.UseVisualStyleBackColor = true;
            // 
            // entriesListView
            // 
            this.entriesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderId,
            this.columnHeaderSize,
            this.columnHeaderOffset,
            this.columnHeaderEnc,
            this.columnHeaderKeyIdx,
            this.columnHeaderFlags,
            this.columnHeaderNTabOffset});
            this.entriesListView.ContextMenuStrip = this.contextMenuStrip1;
            this.entriesListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.entriesListView.FullRowSelect = true;
            this.entriesListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.entriesListView.HideSelection = false;
            this.entriesListView.Location = new System.Drawing.Point(3, 3);
            this.entriesListView.MultiSelect = false;
            this.entriesListView.Name = "entriesListView";
            this.entriesListView.Size = new System.Drawing.Size(529, 334);
            this.entriesListView.TabIndex = 7;
            this.entriesListView.UseCompatibleStateImageBehavior = false;
            this.entriesListView.View = System.Windows.Forms.View.Details;
            this.entriesListView.DoubleClick += new System.EventHandler(this.entriesListView_DoubleClick);
            // 
            // columnHeaderId
            // 
            this.columnHeaderId.Text = "ID";
            this.columnHeaderId.Width = 223;
            // 
            // columnHeaderSize
            // 
            this.columnHeaderSize.Text = "Size";
            this.columnHeaderSize.Width = 85;
            // 
            // columnHeaderOffset
            // 
            this.columnHeaderOffset.Text = "Offset";
            this.columnHeaderOffset.Width = 116;
            // 
            // columnHeaderEnc
            // 
            this.columnHeaderEnc.Text = "Enc.";
            this.columnHeaderEnc.Width = 39;
            // 
            // columnHeaderKeyIdx
            // 
            this.columnHeaderKeyIdx.Text = "KeyIdx";
            // 
            // columnHeaderFlags
            // 
            this.columnHeaderFlags.Text = "Flags";
            this.columnHeaderFlags.Width = 120;
            // 
            // columnHeaderNTabOffset
            // 
            this.columnHeaderNTabOffset.Text = "NameTableOffset";
            this.columnHeaderNTabOffset.Width = 100;
            // 
            // infoTab
            // 
            this.infoTab.Controls.Add(this.TableLayoutPanel1);
            this.infoTab.Controls.Add(this.ExportProgressMsg);
            this.infoTab.Controls.Add(this.ExportProgressBar);
            this.infoTab.Controls.Add(this.ExportGP4Project);
            this.infoTab.Controls.Add(this.pictureBox1);
            this.infoTab.Controls.Add(this.pkgHeaderTabControl);
            this.infoTab.Location = new System.Drawing.Point(4, 22);
            this.infoTab.Name = "infoTab";
            this.infoTab.Padding = new System.Windows.Forms.Padding(3);
            this.infoTab.Size = new System.Drawing.Size(535, 340);
            this.infoTab.TabIndex = 2;
            this.infoTab.Text = "Info";
            this.infoTab.UseVisualStyleBackColor = true;
            // 
            // TableLayoutPanel1
            // 
            this.TableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TableLayoutPanel1.ColumnCount = 2;
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.TableLayoutPanel1.Controls.Add(this.appVerLabelLabel, 0, 5);
            this.TableLayoutPanel1.Controls.Add(this.label3, 0, 0);
            this.TableLayoutPanel1.Controls.Add(this.contentIdTextBox, 1, 0);
            this.TableLayoutPanel1.Controls.Add(this.versionLabel, 1, 4);
            this.TableLayoutPanel1.Controls.Add(this.label8, 0, 4);
            this.TableLayoutPanel1.Controls.Add(this.label4, 0, 1);
            this.TableLayoutPanel1.Controls.Add(this.titleTextBox, 1, 1);
            this.TableLayoutPanel1.Controls.Add(this.label5, 0, 2);
            this.TableLayoutPanel1.Controls.Add(this.typeLabel, 1, 2);
            this.TableLayoutPanel1.Controls.Add(this.label6, 0, 3);
            this.TableLayoutPanel1.Controls.Add(this.sizeLabel, 1, 3);
            this.TableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 5);
            this.TableLayoutPanel1.Location = new System.Drawing.Point(2, 3);
            this.TableLayoutPanel1.Name = "TableLayoutPanel1";
            this.TableLayoutPanel1.RowCount = 6;
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.TableLayoutPanel1.Size = new System.Drawing.Size(349, 138);
            this.TableLayoutPanel1.TabIndex = 21;
            // 
            // appVerLabelLabel
            // 
            this.appVerLabelLabel.AutoSize = true;
            this.appVerLabelLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.appVerLabelLabel.Location = new System.Drawing.Point(5, 119);
            this.appVerLabelLabel.Margin = new System.Windows.Forms.Padding(3);
            this.appVerLabelLabel.Name = "appVerLabelLabel";
            this.appVerLabelLabel.Size = new System.Drawing.Size(64, 16);
            this.appVerLabelLabel.TabIndex = 14;
            this.appVerLabelLabel.Text = "App Version";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label3.Dock = System.Windows.Forms.DockStyle.Right;
            this.label3.Location = new System.Drawing.Point(12, 3);
            this.label3.Margin = new System.Windows.Forms.Padding(3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Content ID";
            // 
            // contentIdTextBox
            // 
            this.contentIdTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentIdTextBox.Location = new System.Drawing.Point(75, 0);
            this.contentIdTextBox.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.contentIdTextBox.Name = "contentIdTextBox";
            this.contentIdTextBox.ReadOnly = true;
            this.contentIdTextBox.Size = new System.Drawing.Size(283, 22);
            this.contentIdTextBox.TabIndex = 3;
            // 
            // versionLabel
            // 
            this.versionLabel.AutoSize = true;
            this.versionLabel.Location = new System.Drawing.Point(75, 97);
            this.versionLabel.Margin = new System.Windows.Forms.Padding(3);
            this.versionLabel.Name = "versionLabel";
            this.versionLabel.Size = new System.Drawing.Size(26, 12);
            this.versionLabel.TabIndex = 13;
            this.versionLabel.Text = "4.20";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 97);
            this.label8.Margin = new System.Windows.Forms.Padding(3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 12);
            this.label8.TabIndex = 9;
            this.label8.Text = "PKG Version";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label4.Dock = System.Windows.Forms.DockStyle.Right;
            this.label4.Location = new System.Drawing.Point(43, 28);
            this.label4.Margin = new System.Windows.Forms.Padding(3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "Title";
            // 
            // titleTextBox
            // 
            this.titleTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.titleTextBox.Location = new System.Drawing.Point(75, 25);
            this.titleTextBox.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.ReadOnly = true;
            this.titleTextBox.Size = new System.Drawing.Size(283, 22);
            this.titleTextBox.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Right;
            this.label5.Location = new System.Drawing.Point(40, 53);
            this.label5.Margin = new System.Windows.Forms.Padding(3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Type";
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Location = new System.Drawing.Point(75, 53);
            this.typeLabel.Margin = new System.Windows.Forms.Padding(3);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(32, 12);
            this.typeLabel.TabIndex = 11;
            this.typeLabel.Text = "Game";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Right;
            this.label6.Location = new System.Drawing.Point(45, 75);
            this.label6.Margin = new System.Windows.Forms.Padding(3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "Size";
            // 
            // sizeLabel
            // 
            this.sizeLabel.AutoSize = true;
            this.sizeLabel.Location = new System.Drawing.Point(75, 75);
            this.sizeLabel.Margin = new System.Windows.Forms.Padding(3);
            this.sizeLabel.Name = "sizeLabel";
            this.sizeLabel.Size = new System.Drawing.Size(38, 12);
            this.sizeLabel.TabIndex = 12;
            this.sizeLabel.Text = "7.20 gj";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.DecryptEntryCheckBox, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.appVerLabel, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(72, 116);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(289, 22);
            this.tableLayoutPanel2.TabIndex = 15;
            // 
            // DecryptEntryCheckBox
            // 
            this.DecryptEntryCheckBox.AutoSize = true;
            this.DecryptEntryCheckBox.Checked = true;
            this.DecryptEntryCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.DecryptEntryCheckBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DecryptEntryCheckBox.Location = new System.Drawing.Point(113, 3);
            this.DecryptEntryCheckBox.Name = "DecryptEntryCheckBox";
            this.DecryptEntryCheckBox.Size = new System.Drawing.Size(173, 16);
            this.DecryptEntryCheckBox.TabIndex = 20;
            this.DecryptEntryCheckBox.Text = "Decrypt entry file during export";
            this.DecryptEntryCheckBox.UseVisualStyleBackColor = true;
            // 
            // appVerLabel
            // 
            this.appVerLabel.AutoSize = true;
            this.appVerLabel.Location = new System.Drawing.Point(3, 3);
            this.appVerLabel.Margin = new System.Windows.Forms.Padding(3);
            this.appVerLabel.Name = "appVerLabel";
            this.appVerLabel.Size = new System.Drawing.Size(26, 12);
            this.appVerLabel.TabIndex = 15;
            this.appVerLabel.Text = "4.20";
            // 
            // ExportProgressMsg
            // 
            this.ExportProgressMsg.AutoSize = true;
            this.ExportProgressMsg.BackColor = System.Drawing.Color.Transparent;
            this.ExportProgressMsg.Location = new System.Drawing.Point(145, 144);
            this.ExportProgressMsg.Name = "ExportProgressMsg";
            this.ExportProgressMsg.Size = new System.Drawing.Size(41, 12);
            this.ExportProgressMsg.TabIndex = 19;
            this.ExportProgressMsg.Text = "　　　";
            this.ExportProgressMsg.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // ExportProgressBar
            // 
            this.ExportProgressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ExportProgressBar.Location = new System.Drawing.Point(146, 158);
            this.ExportProgressBar.Name = "ExportProgressBar";
            this.ExportProgressBar.Size = new System.Drawing.Size(205, 5);
            this.ExportProgressBar.TabIndex = 18;
            this.ExportProgressBar.Visible = false;
            // 
            // ExportGP4Project
            // 
            this.ExportGP4Project.Location = new System.Drawing.Point(6, 143);
            this.ExportGP4Project.Name = "ExportGP4Project";
            this.ExportGP4Project.Size = new System.Drawing.Size(133, 21);
            this.ExportGP4Project.TabIndex = 17;
            this.ExportGP4Project.Text = "Export to GP4 Project";
            this.ExportGP4Project.UseVisualStyleBackColor = true;
            this.ExportGP4Project.Click += new System.EventHandler(this.ExportGP4Project_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Location = new System.Drawing.Point(357, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(175, 162);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // pkgHeaderTabControl
            // 
            this.pkgHeaderTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pkgHeaderTabControl.Controls.Add(this.tabPage3);
            this.pkgHeaderTabControl.Controls.Add(this.outerPfsHeaderTabPage);
            this.pkgHeaderTabControl.Location = new System.Drawing.Point(3, 170);
            this.pkgHeaderTabControl.Name = "pkgHeaderTabControl";
            this.pkgHeaderTabControl.SelectedIndex = 0;
            this.pkgHeaderTabControl.Size = new System.Drawing.Size(529, 169);
            this.pkgHeaderTabControl.TabIndex = 16;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.pkgHeaderTreeView);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(521, 143);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Header";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // pkgHeaderTreeView
            // 
            this.pkgHeaderTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pkgHeaderTreeView.Location = new System.Drawing.Point(3, 3);
            this.pkgHeaderTreeView.Name = "pkgHeaderTreeView";
            this.pkgHeaderTreeView.Size = new System.Drawing.Size(515, 137);
            this.pkgHeaderTreeView.TabIndex = 0;
            // 
            // outerPfsHeaderTabPage
            // 
            this.outerPfsHeaderTabPage.Controls.Add(this.pfsHeaderTreeView);
            this.outerPfsHeaderTabPage.Location = new System.Drawing.Point(4, 22);
            this.outerPfsHeaderTabPage.Name = "outerPfsHeaderTabPage";
            this.outerPfsHeaderTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.outerPfsHeaderTabPage.Size = new System.Drawing.Size(521, 143);
            this.outerPfsHeaderTabPage.TabIndex = 1;
            this.outerPfsHeaderTabPage.Text = "Outer PFS Header";
            this.outerPfsHeaderTabPage.UseVisualStyleBackColor = true;
            // 
            // pfsHeaderTreeView
            // 
            this.pfsHeaderTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pfsHeaderTreeView.Location = new System.Drawing.Point(3, 3);
            this.pfsHeaderTreeView.Name = "pfsHeaderTreeView";
            this.pfsHeaderTreeView.Size = new System.Drawing.Size(515, 137);
            this.pfsHeaderTreeView.TabIndex = 1;
            // 
            // mainTabControl
            // 
            this.mainTabControl.Controls.Add(this.infoTab);
            this.mainTabControl.Controls.Add(this.entriesTab);
            this.mainTabControl.Controls.Add(this.filesTab);
            this.mainTabControl.Controls.Add(this.tabPage1);
            this.mainTabControl.Controls.Add(this.tabPage2);
            this.mainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTabControl.Location = new System.Drawing.Point(0, 0);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(543, 366);
            this.mainTabControl.TabIndex = 1;
            // 
            // PkgView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mainTabControl);
            this.Name = "PkgView";
            this.Size = new System.Drawing.Size(543, 366);
            this.contextMenuStrip1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.filesTab.ResumeLayout(false);
            this.filesTab.PerformLayout();
            this.entriesTab.ResumeLayout(false);
            this.infoTab.ResumeLayout(false);
            this.infoTab.PerformLayout();
            this.TableLayoutPanel1.ResumeLayout(false);
            this.TableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pkgHeaderTabControl.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.outerPfsHeaderTabPage.ResumeLayout(false);
            this.mainTabControl.ResumeLayout(false);
            this.ResumeLayout(false);

    }

    #endregion
    private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    private System.Windows.Forms.ToolStripMenuItem extractToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem extractDecryptedMenuItem;
    private System.Windows.Forms.TabPage tabPage2;
    private System.Windows.Forms.ListView listView1;
    private System.Windows.Forms.ColumnHeader columnHeader2;
    private System.Windows.Forms.TextBox validateResult;
    private System.Windows.Forms.Button checkDigestsButton;
    private System.Windows.Forms.TabPage tabPage1;
    private System.Windows.Forms.TabPage filesTab;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox passcodeTextBox;
    private System.Windows.Forms.Button openWithPasscodeBtn;
    private System.Windows.Forms.TabPage entriesTab;
    private System.Windows.Forms.ListView entriesListView;
    private System.Windows.Forms.ColumnHeader columnHeaderId;
    private System.Windows.Forms.ColumnHeader columnHeaderSize;
    private System.Windows.Forms.ColumnHeader columnHeaderOffset;
    private System.Windows.Forms.ColumnHeader columnHeaderEnc;
    private System.Windows.Forms.ColumnHeader columnHeaderKeyIdx;
    private System.Windows.Forms.TabPage infoTab;
    private System.Windows.Forms.Button ExportGP4Project;
    private System.Windows.Forms.Label appVerLabel;
    private System.Windows.Forms.Label appVerLabelLabel;
    private System.Windows.Forms.Label versionLabel;
    private System.Windows.Forms.Label sizeLabel;
    private System.Windows.Forms.Label typeLabel;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.PictureBox pictureBox1;
    private System.Windows.Forms.TextBox titleTextBox;
    private System.Windows.Forms.TextBox contentIdTextBox;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TabControl pkgHeaderTabControl;
    private System.Windows.Forms.TabPage tabPage3;
    private System.Windows.Forms.TreeView pkgHeaderTreeView;
    private System.Windows.Forms.TabPage outerPfsHeaderTabPage;
    private System.Windows.Forms.TreeView pfsHeaderTreeView;
    private System.Windows.Forms.TabControl mainTabControl;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.TextBox ekpfsTextBox;
    private System.Windows.Forms.Button openWithEkpfsBtn;
    private System.Windows.Forms.TextBox xtsTweakTextBox;
    private System.Windows.Forms.Label label9;
    private System.Windows.Forms.TextBox xtsDataTextBox;
    private System.Windows.Forms.Button openWithXtsKeysBtn;
    private System.Windows.Forms.ProgressBar ExportProgressBar;
    private System.Windows.Forms.Label ExportProgressMsg;
    private System.Windows.Forms.ColumnHeader columnHeaderFlags;
    private System.Windows.Forms.CheckBox DecryptEntryCheckBox;
    private System.Windows.Forms.TableLayoutPanel TableLayoutPanel1;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    private System.Windows.Forms.ColumnHeader columnHeaderNTabOffset;
  }
}
