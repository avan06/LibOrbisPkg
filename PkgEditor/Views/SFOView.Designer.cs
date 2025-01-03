﻿namespace PkgEditor.Views
{
  partial class SFOView
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewValueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stringToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.integerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.specialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.defaultsDropDownButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.loadACDefaultsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadGPDefaultsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.stringToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.intToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bytesUtf8SpecialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LanguagesDropDownButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.label1 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.typeDropDown = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.valueTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.maxLengthInput = new System.Windows.Forms.NumericUpDown();
            this.sizeLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.sfoTypeLabel = new System.Windows.Forms.Label();
            this.sfoTypeCombobox = new System.Windows.Forms.ComboBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tableEditorPage = new System.Windows.Forms.TabPage();
            this.editorPanel = new System.Windows.Forms.Panel();
            this.guidedEditorPage = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.TableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.attributes2Enable = new System.Windows.Forms.CheckBox();
            this.attributes2ListBox = new System.Windows.Forms.CheckedListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.attributesListBox = new System.Windows.Forms.CheckedListBox();
            this.Download0SizeComboBox = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.contentIdTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.TableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.appTypeComboBox = new System.Windows.Forms.ComboBox();
            this.versionTextBox = new System.Windows.Forms.TextBox();
            this.appVersionTextBox = new System.Windows.Forms.TextBox();
            this.guidedEditorBottomPanel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label11 = new System.Windows.Forms.Label();
            this.Download1SizeComboBox = new System.Windows.Forms.ComboBox();
            this.contextMenuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxLengthInput)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tableEditorPage.SuspendLayout();
            this.editorPanel.SuspendLayout();
            this.guidedEditorPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.TableLayoutPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.TableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader6,
            this.columnHeader2,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader3});
            this.listView1.ContextMenuStrip = this.contextMenuStrip1;
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 52);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(711, 442);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listView1_ItemSelectionChanged);
            this.listView1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.listView1_KeyUp);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Key";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Description";
            this.columnHeader6.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Type";
            this.columnHeader2.Width = 73;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Size";
            this.columnHeader4.Width = 38;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "MaxSize";
            this.columnHeader5.Width = 52;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Value";
            this.columnHeader3.Width = 300;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem,
            this.addNewValueToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(158, 48);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.DeleteToolStripMenuItem_Click);
            // 
            // addNewValueToolStripMenuItem
            // 
            this.addNewValueToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stringToolStripMenuItem1,
            this.integerToolStripMenuItem,
            this.specialToolStripMenuItem});
            this.addNewValueToolStripMenuItem.Name = "addNewValueToolStripMenuItem";
            this.addNewValueToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.addNewValueToolStripMenuItem.Text = "Add new value";
            // 
            // stringToolStripMenuItem1
            // 
            this.stringToolStripMenuItem1.Name = "stringToolStripMenuItem1";
            this.stringToolStripMenuItem1.Size = new System.Drawing.Size(115, 22);
            this.stringToolStripMenuItem1.Text = "String";
            this.stringToolStripMenuItem1.Click += new System.EventHandler(this.stringToolStripMenuItem_Click);
            // 
            // integerToolStripMenuItem
            // 
            this.integerToolStripMenuItem.Name = "integerToolStripMenuItem";
            this.integerToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.integerToolStripMenuItem.Text = "Integer";
            this.integerToolStripMenuItem.Click += new System.EventHandler(this.intToolStripMenuItem_Click);
            // 
            // specialToolStripMenuItem
            // 
            this.specialToolStripMenuItem.Name = "specialToolStripMenuItem";
            this.specialToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.specialToolStripMenuItem.Text = "Special";
            this.specialToolStripMenuItem.Click += new System.EventHandler(this.bytesUtf8SpecialToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.defaultsDropDownButton,
            this.toolStripDropDownButton1,
            this.LanguagesDropDownButton});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.Size = new System.Drawing.Size(728, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // defaultsDropDownButton
            // 
            this.defaultsDropDownButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadACDefaultsToolStripMenuItem,
            this.loadGPDefaultsToolStripMenuItem});
            this.defaultsDropDownButton.Name = "defaultsDropDownButton";
            this.defaultsDropDownButton.Size = new System.Drawing.Size(66, 22);
            this.defaultsDropDownButton.Text = "Defaults";
            // 
            // loadACDefaultsToolStripMenuItem
            // 
            this.loadACDefaultsToolStripMenuItem.Name = "loadACDefaultsToolStripMenuItem";
            this.loadACDefaultsToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.loadACDefaultsToolStripMenuItem.Text = "Load AC Defaults";
            this.loadACDefaultsToolStripMenuItem.Click += new System.EventHandler(this.loadACDefaultsToolStripMenuItem_Click);
            // 
            // loadGPDefaultsToolStripMenuItem
            // 
            this.loadGPDefaultsToolStripMenuItem.Name = "loadGPDefaultsToolStripMenuItem";
            this.loadGPDefaultsToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.loadGPDefaultsToolStripMenuItem.Text = "Load GP Defaults";
            this.loadGPDefaultsToolStripMenuItem.Click += new System.EventHandler(this.loadGPDefaultsToolStripMenuItem_Click);
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stringToolStripMenuItem,
            this.intToolStripMenuItem,
            this.bytesUtf8SpecialToolStripMenuItem});
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(104, 22);
            this.toolStripDropDownButton1.Text = "Add Key/Value";
            // 
            // stringToolStripMenuItem
            // 
            this.stringToolStripMenuItem.Name = "stringToolStripMenuItem";
            this.stringToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.stringToolStripMenuItem.Text = "String";
            this.stringToolStripMenuItem.Click += new System.EventHandler(this.stringToolStripMenuItem_Click);
            // 
            // intToolStripMenuItem
            // 
            this.intToolStripMenuItem.Name = "intToolStripMenuItem";
            this.intToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.intToolStripMenuItem.Text = "Int";
            this.intToolStripMenuItem.Click += new System.EventHandler(this.intToolStripMenuItem_Click);
            // 
            // bytesUtf8SpecialToolStripMenuItem
            // 
            this.bytesUtf8SpecialToolStripMenuItem.Name = "bytesUtf8SpecialToolStripMenuItem";
            this.bytesUtf8SpecialToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.bytesUtf8SpecialToolStripMenuItem.Text = "String Special";
            this.bytesUtf8SpecialToolStripMenuItem.Click += new System.EventHandler(this.bytesUtf8SpecialToolStripMenuItem_Click);
            // 
            // LanguagesDropDownButton
            // 
            this.LanguagesDropDownButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.LanguagesDropDownButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.LanguagesDropDownButton.Name = "LanguagesDropDownButton";
            this.LanguagesDropDownButton.Size = new System.Drawing.Size(151, 22);
            this.LanguagesDropDownButton.Text = "Add/Delete Languages";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(44, 5);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(241, 22);
            this.nameTextBox.TabIndex = 5;
            this.nameTextBox.TextChanged += new System.EventHandler(this.TableEditor_UpdateValue);
            // 
            // typeDropDown
            // 
            this.typeDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeDropDown.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.typeDropDown.FormattingEnabled = true;
            this.typeDropDown.Items.AddRange(new object[] {
            "String",
            "Integer",
            "Special"});
            this.typeDropDown.Location = new System.Drawing.Point(44, 28);
            this.typeDropDown.Name = "typeDropDown";
            this.typeDropDown.Size = new System.Drawing.Size(59, 20);
            this.typeDropDown.TabIndex = 6;
            this.typeDropDown.SelectedIndexChanged += new System.EventHandler(this.TableEditor_UpdateValue);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(291, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "Value";
            // 
            // valueTextBox
            // 
            this.valueTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.valueTextBox.Location = new System.Drawing.Point(331, 5);
            this.valueTextBox.Multiline = true;
            this.valueTextBox.Name = "valueTextBox";
            this.valueTextBox.Size = new System.Drawing.Size(380, 43);
            this.valueTextBox.TabIndex = 8;
            this.valueTextBox.TextChanged += new System.EventHandler(this.TableEditor_UpdateValue);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(109, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 12);
            this.label3.TabIndex = 9;
            this.label3.Text = "Max Size";
            // 
            // maxLengthInput
            // 
            this.maxLengthInput.Location = new System.Drawing.Point(165, 28);
            this.maxLengthInput.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.maxLengthInput.Name = "maxLengthInput";
            this.maxLengthInput.Size = new System.Drawing.Size(84, 22);
            this.maxLengthInput.TabIndex = 11;
            this.maxLengthInput.ValueChanged += new System.EventHandler(this.TableEditor_UpdateValue);
            // 
            // sizeLabel
            // 
            this.sizeLabel.AutoSize = true;
            this.sizeLabel.Location = new System.Drawing.Point(255, 30);
            this.sizeLabel.Name = "sizeLabel";
            this.sizeLabel.Size = new System.Drawing.Size(27, 12);
            this.sizeLabel.TabIndex = 12;
            this.sizeLabel.Text = "Size:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 13;
            this.label5.Text = "Type";
            // 
            // sfoTypeLabel
            // 
            this.sfoTypeLabel.AutoSize = true;
            this.sfoTypeLabel.Location = new System.Drawing.Point(3, 0);
            this.sfoTypeLabel.Name = "sfoTypeLabel";
            this.sfoTypeLabel.Size = new System.Drawing.Size(52, 12);
            this.sfoTypeLabel.TabIndex = 15;
            this.sfoTypeLabel.Text = "SFO Type";
            // 
            // sfoTypeCombobox
            // 
            this.sfoTypeCombobox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sfoTypeCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sfoTypeCombobox.FormattingEnabled = true;
            this.sfoTypeCombobox.Location = new System.Drawing.Point(3, 15);
            this.sfoTypeCombobox.Name = "sfoTypeCombobox";
            this.sfoTypeCombobox.Size = new System.Drawing.Size(364, 20);
            this.sfoTypeCombobox.TabIndex = 14;
            this.sfoTypeCombobox.SelectedIndexChanged += new System.EventHandler(this.GuidedEditor_Changed);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tableEditorPage);
            this.tabControl1.Controls.Add(this.guidedEditorPage);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 25);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(728, 528);
            this.tabControl1.TabIndex = 16;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.TabControl1_SelectedIndexChanged);
            // 
            // tableEditorPage
            // 
            this.tableEditorPage.Controls.Add(this.editorPanel);
            this.tableEditorPage.Location = new System.Drawing.Point(4, 22);
            this.tableEditorPage.Name = "tableEditorPage";
            this.tableEditorPage.Padding = new System.Windows.Forms.Padding(3);
            this.tableEditorPage.Size = new System.Drawing.Size(720, 502);
            this.tableEditorPage.TabIndex = 0;
            this.tableEditorPage.Text = "Table Editor";
            this.tableEditorPage.UseVisualStyleBackColor = true;
            // 
            // editorPanel
            // 
            this.editorPanel.Controls.Add(this.label1);
            this.editorPanel.Controls.Add(this.listView1);
            this.editorPanel.Controls.Add(this.label5);
            this.editorPanel.Controls.Add(this.nameTextBox);
            this.editorPanel.Controls.Add(this.sizeLabel);
            this.editorPanel.Controls.Add(this.typeDropDown);
            this.editorPanel.Controls.Add(this.maxLengthInput);
            this.editorPanel.Controls.Add(this.label2);
            this.editorPanel.Controls.Add(this.label3);
            this.editorPanel.Controls.Add(this.valueTextBox);
            this.editorPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editorPanel.Location = new System.Drawing.Point(3, 3);
            this.editorPanel.Name = "editorPanel";
            this.editorPanel.Size = new System.Drawing.Size(714, 496);
            this.editorPanel.TabIndex = 17;
            // 
            // guidedEditorPage
            // 
            this.guidedEditorPage.Controls.Add(this.splitContainer1);
            this.guidedEditorPage.Location = new System.Drawing.Point(4, 22);
            this.guidedEditorPage.Name = "guidedEditorPage";
            this.guidedEditorPage.Padding = new System.Windows.Forms.Padding(3);
            this.guidedEditorPage.Size = new System.Drawing.Size(720, 502);
            this.guidedEditorPage.TabIndex = 1;
            this.guidedEditorPage.Text = "Guided Editor";
            this.guidedEditorPage.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.Transparent;
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.AutoScroll = true;
            this.splitContainer1.Panel1.Controls.Add(this.TableLayoutPanel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.guidedEditorBottomPanel);
            this.splitContainer1.Size = new System.Drawing.Size(714, 496);
            this.splitContainer1.SplitterDistance = 374;
            this.splitContainer1.TabIndex = 17;
            // 
            // TableLayoutPanel1
            // 
            this.TableLayoutPanel1.AutoScroll = true;
            this.TableLayoutPanel1.AutoSize = true;
            this.TableLayoutPanel1.ColumnCount = 1;
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 7);
            this.TableLayoutPanel1.Controls.Add(this.groupBox2, 0, 9);
            this.TableLayoutPanel1.Controls.Add(this.groupBox1, 0, 8);
            this.TableLayoutPanel1.Controls.Add(this.sfoTypeLabel, 0, 0);
            this.TableLayoutPanel1.Controls.Add(this.sfoTypeCombobox, 0, 1);
            this.TableLayoutPanel1.Controls.Add(this.label4, 0, 2);
            this.TableLayoutPanel1.Controls.Add(this.contentIdTextBox, 0, 3);
            this.TableLayoutPanel1.Controls.Add(this.label6, 0, 4);
            this.TableLayoutPanel1.Controls.Add(this.titleTextBox, 0, 5);
            this.TableLayoutPanel1.Controls.Add(this.TableLayoutPanel2, 0, 6);
            this.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.TableLayoutPanel1.Name = "TableLayoutPanel1";
            this.TableLayoutPanel1.RowCount = 10;
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TableLayoutPanel1.Size = new System.Drawing.Size(370, 492);
            this.TableLayoutPanel1.TabIndex = 29;
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSize = true;
            this.groupBox2.Controls.Add(this.attributes2Enable);
            this.groupBox2.Controls.Add(this.attributes2ListBox);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 355);
            this.groupBox2.MinimumSize = new System.Drawing.Size(0, 150);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(364, 178);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Attributes 2";
            // 
            // attributes2Enable
            // 
            this.attributes2Enable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.attributes2Enable.AutoSize = true;
            this.attributes2Enable.BackColor = System.Drawing.SystemColors.Window;
            this.attributes2Enable.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.attributes2Enable.Location = new System.Drawing.Point(302, -1);
            this.attributes2Enable.Name = "attributes2Enable";
            this.attributes2Enable.Size = new System.Drawing.Size(56, 16);
            this.attributes2Enable.TabIndex = 2;
            this.attributes2Enable.Text = "Enable";
            this.attributes2Enable.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.attributes2Enable.UseVisualStyleBackColor = false;
            this.attributes2Enable.CheckedChanged += new System.EventHandler(this.GuidedEditor_Changed);
            // 
            // attributes2ListBox
            // 
            this.attributes2ListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.attributes2ListBox.FormattingEnabled = true;
            this.attributes2ListBox.Location = new System.Drawing.Point(3, 18);
            this.attributes2ListBox.Name = "attributes2ListBox";
            this.attributes2ListBox.Size = new System.Drawing.Size(358, 157);
            this.attributes2ListBox.TabIndex = 0;
            this.attributes2ListBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.AttributesListBox_ItemCheck);
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.attributesListBox);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 199);
            this.groupBox1.MinimumSize = new System.Drawing.Size(0, 150);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(364, 150);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Attributes 1";
            // 
            // attributesListBox
            // 
            this.attributesListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.attributesListBox.FormattingEnabled = true;
            this.attributesListBox.Location = new System.Drawing.Point(3, 18);
            this.attributesListBox.Name = "attributesListBox";
            this.attributesListBox.Size = new System.Drawing.Size(358, 129);
            this.attributesListBox.TabIndex = 0;
            this.attributesListBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.AttributesListBox_ItemCheck);
            // 
            // Download0SizeComboBox
            // 
            this.Download0SizeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Download0SizeComboBox.FormattingEnabled = true;
            this.Download0SizeComboBox.Location = new System.Drawing.Point(3, 15);
            this.Download0SizeComboBox.Name = "Download0SizeComboBox";
            this.Download0SizeComboBox.Size = new System.Drawing.Size(143, 20);
            this.Download0SizeComboBox.TabIndex = 28;
            this.Download0SizeComboBox.SelectedIndexChanged += new System.EventHandler(this.GuidedEditor_Changed);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(162, 12);
            this.label10.TabIndex = 27;
            this.label10.Text = "Download Data Size(/download0)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 12);
            this.label4.TabIndex = 18;
            this.label4.Text = "Content ID";
            // 
            // contentIdTextBox
            // 
            this.contentIdTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.contentIdTextBox.Location = new System.Drawing.Point(3, 53);
            this.contentIdTextBox.MaxLength = 36;
            this.contentIdTextBox.Name = "contentIdTextBox";
            this.contentIdTextBox.Size = new System.Drawing.Size(364, 22);
            this.contentIdTextBox.TabIndex = 17;
            this.contentIdTextBox.TextChanged += new System.EventHandler(this.GuidedEditor_Changed);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 12);
            this.label6.TabIndex = 20;
            this.label6.Text = "Title";
            // 
            // titleTextBox
            // 
            this.titleTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.titleTextBox.Location = new System.Drawing.Point(3, 93);
            this.titleTextBox.MaxLength = 127;
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(364, 22);
            this.titleTextBox.TabIndex = 19;
            this.titleTextBox.TextChanged += new System.EventHandler(this.GuidedEditor_Changed);
            // 
            // TableLayoutPanel2
            // 
            this.TableLayoutPanel2.AutoSize = true;
            this.TableLayoutPanel2.ColumnCount = 3;
            this.TableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.TableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.TableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutPanel2.Controls.Add(this.label7, 0, 0);
            this.TableLayoutPanel2.Controls.Add(this.label8, 1, 0);
            this.TableLayoutPanel2.Controls.Add(this.label9, 2, 0);
            this.TableLayoutPanel2.Controls.Add(this.appTypeComboBox, 2, 1);
            this.TableLayoutPanel2.Controls.Add(this.versionTextBox, 0, 1);
            this.TableLayoutPanel2.Controls.Add(this.appVersionTextBox, 1, 1);
            this.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLayoutPanel2.Location = new System.Drawing.Point(0, 118);
            this.TableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.TableLayoutPanel2.Name = "TableLayoutPanel2";
            this.TableLayoutPanel2.RowCount = 2;
            this.TableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TableLayoutPanel2.Size = new System.Drawing.Size(370, 40);
            this.TableLayoutPanel2.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 22;
            this.label7.Text = "Version";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(83, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 12);
            this.label8.TabIndex = 24;
            this.label8.Text = "App Version";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(163, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 12);
            this.label9.TabIndex = 25;
            this.label9.Text = "App Type";
            // 
            // appTypeComboBox
            // 
            this.appTypeComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.appTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.appTypeComboBox.FormattingEnabled = true;
            this.appTypeComboBox.Location = new System.Drawing.Point(163, 15);
            this.appTypeComboBox.Name = "appTypeComboBox";
            this.appTypeComboBox.Size = new System.Drawing.Size(204, 20);
            this.appTypeComboBox.TabIndex = 26;
            this.appTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.GuidedEditor_Changed);
            // 
            // versionTextBox
            // 
            this.versionTextBox.Location = new System.Drawing.Point(3, 15);
            this.versionTextBox.MaxLength = 5;
            this.versionTextBox.Name = "versionTextBox";
            this.versionTextBox.Size = new System.Drawing.Size(64, 22);
            this.versionTextBox.TabIndex = 21;
            this.versionTextBox.TextChanged += new System.EventHandler(this.GuidedEditor_Changed);
            // 
            // appVersionTextBox
            // 
            this.appVersionTextBox.Location = new System.Drawing.Point(83, 15);
            this.appVersionTextBox.MaxLength = 5;
            this.appVersionTextBox.Name = "appVersionTextBox";
            this.appVersionTextBox.Size = new System.Drawing.Size(64, 22);
            this.appVersionTextBox.TabIndex = 23;
            this.appVersionTextBox.TextChanged += new System.EventHandler(this.GuidedEditor_Changed);
            // 
            // guidedEditorBottomPanel
            // 
            this.guidedEditorBottomPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guidedEditorBottomPanel.Location = new System.Drawing.Point(0, 0);
            this.guidedEditorBottomPanel.Name = "guidedEditorBottomPanel";
            this.guidedEditorBottomPanel.Size = new System.Drawing.Size(332, 492);
            this.guidedEditorBottomPanel.TabIndex = 16;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.AutoSize = true;
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 180F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 180F));
            this.tableLayoutPanel3.Controls.Add(this.label10, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.Download0SizeComboBox, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.label11, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.Download1SizeComboBox, 1, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 158);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.Size = new System.Drawing.Size(370, 38);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(188, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(162, 12);
            this.label11.TabIndex = 29;
            this.label11.Text = "Download Data Size(/download1)";
            // 
            // Download1SizeComboBox
            // 
            this.Download1SizeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Download1SizeComboBox.DropDownWidth = 143;
            this.Download1SizeComboBox.FormattingEnabled = true;
            this.Download1SizeComboBox.Location = new System.Drawing.Point(188, 15);
            this.Download1SizeComboBox.Name = "Download1SizeComboBox";
            this.Download1SizeComboBox.Size = new System.Drawing.Size(143, 20);
            this.Download1SizeComboBox.TabIndex = 30;
            this.Download1SizeComboBox.SelectedIndexChanged += new System.EventHandler(this.GuidedEditor_Changed);
            // 
            // SFOView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "SFOView";
            this.Size = new System.Drawing.Size(728, 553);
            this.contextMenuStrip1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxLengthInput)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tableEditorPage.ResumeLayout(false);
            this.editorPanel.ResumeLayout(false);
            this.editorPanel.PerformLayout();
            this.guidedEditorPage.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.TableLayoutPanel1.ResumeLayout(false);
            this.TableLayoutPanel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.TableLayoutPanel2.ResumeLayout(false);
            this.TableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.ListView listView1;
    private System.Windows.Forms.ColumnHeader columnHeader1;
    private System.Windows.Forms.ColumnHeader columnHeader2;
    private System.Windows.Forms.ColumnHeader columnHeader3;
    private System.Windows.Forms.ToolStrip toolStrip1;
    private System.Windows.Forms.ToolStripDropDownButton defaultsDropDownButton;
    private System.Windows.Forms.ToolStripMenuItem loadACDefaultsToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem loadGPDefaultsToolStripMenuItem;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox nameTextBox;
    private System.Windows.Forms.ComboBox typeDropDown;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox valueTextBox;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.NumericUpDown maxLengthInput;
    private System.Windows.Forms.Label sizeLabel;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
    private System.Windows.Forms.ToolStripMenuItem stringToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem intToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem bytesUtf8SpecialToolStripMenuItem;
    private System.Windows.Forms.ColumnHeader columnHeader4;
    private System.Windows.Forms.ColumnHeader columnHeader5;
    private System.Windows.Forms.Label sfoTypeLabel;
    private System.Windows.Forms.ComboBox sfoTypeCombobox;
    private System.Windows.Forms.TabControl tabControl1;
    private System.Windows.Forms.TabPage tableEditorPage;
    private System.Windows.Forms.TabPage guidedEditorPage;
    private System.Windows.Forms.Panel editorPanel;
    private System.Windows.Forms.Panel guidedEditorBottomPanel;
    private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem addNewValueToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem stringToolStripMenuItem1;
    private System.Windows.Forms.ToolStripMenuItem integerToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem specialToolStripMenuItem;
    private System.Windows.Forms.SplitContainer splitContainer1;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.CheckedListBox attributesListBox;
    private System.Windows.Forms.TextBox contentIdTextBox;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.CheckedListBox attributes2ListBox;
    private System.Windows.Forms.CheckBox attributes2Enable;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.TextBox titleTextBox;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.TextBox versionTextBox;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.TextBox appVersionTextBox;
    private System.Windows.Forms.Label label9;
    private System.Windows.Forms.ComboBox appTypeComboBox;
    private System.Windows.Forms.ComboBox Download0SizeComboBox;
    private System.Windows.Forms.Label label10;
    private System.Windows.Forms.ColumnHeader columnHeader6;
    private System.Windows.Forms.ToolStripDropDownButton LanguagesDropDownButton;
    private System.Windows.Forms.TableLayoutPanel TableLayoutPanel1;
    private System.Windows.Forms.TableLayoutPanel TableLayoutPanel2;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
    private System.Windows.Forms.Label label11;
    private System.Windows.Forms.ComboBox Download1SizeComboBox;
  }
}