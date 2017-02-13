using System;

namespace EMS.View
{
    partial class StartForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartForm));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printPreviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.indexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.eventPanel = new System.Windows.Forms.Panel();
            this.eventSearchTextBox = new System.Windows.Forms.TextBox();
            this.eventListView = new BrightIdeasSoftware.DataListView();
            this.Title = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.deleteEventButton = new System.Windows.Forms.Button();
            this.editEventButton = new System.Windows.Forms.Button();
            this.addEventButton = new System.Windows.Forms.Button();
            this.detailLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.topicPanel = new System.Windows.Forms.Panel();
            this.topicDataListView = new BrightIdeasSoftware.DataListView();
            this.topicTitle = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.deleteTopicButton = new System.Windows.Forms.Button();
            this.editTopicButton = new System.Windows.Forms.Button();
            this.addTopicButton = new System.Windows.Forms.Button();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.detailViewTable = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.typeLabel = new System.Windows.Forms.Label();
            this.locationLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimeLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.eventBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.topicBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.topicSearchTextBox = new System.Windows.Forms.TextBox();
            this.menuStrip.SuspendLayout();
            this.startTableLayout.SuspendLayout();
            this.eventPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventListView)).BeginInit();
            this.detailLayoutPanel.SuspendLayout();
            this.topicPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.topicDataListView)).BeginInit();
            this.detailViewTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.topicBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1097, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.toolStripSeparator,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripSeparator1,
            this.printToolStripMenuItem,
            this.printPreviewToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripMenuItem.Image")));
            this.newToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.newToolStripMenuItem.Text = "&New";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
            this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.openToolStripMenuItem.Text = "&Open";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(143, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
            this.saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.saveAsToolStripMenuItem.Text = "Save &As";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(143, 6);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripMenuItem.Image")));
            this.printToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.printToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.printToolStripMenuItem.Text = "&Print";
            // 
            // printPreviewToolStripMenuItem
            // 
            this.printPreviewToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("printPreviewToolStripMenuItem.Image")));
            this.printPreviewToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printPreviewToolStripMenuItem.Name = "printPreviewToolStripMenuItem";
            this.printPreviewToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.printPreviewToolStripMenuItem.Text = "Print Pre&view";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(143, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem,
            this.toolStripSeparator3,
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.toolStripSeparator4,
            this.selectAllToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.undoToolStripMenuItem.Text = "&Undo";
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.redoToolStripMenuItem.Text = "&Redo";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(141, 6);
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cutToolStripMenuItem.Image")));
            this.cutToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.cutToolStripMenuItem.Text = "Cu&t";
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripMenuItem.Image")));
            this.copyToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.copyToolStripMenuItem.Text = "&Copy";
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("pasteToolStripMenuItem.Image")));
            this.pasteToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.pasteToolStripMenuItem.Text = "&Paste";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(141, 6);
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.selectAllToolStripMenuItem.Text = "Select &All";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customizeToolStripMenuItem,
            this.optionsToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.toolsToolStripMenuItem.Text = "&Tools";
            // 
            // customizeToolStripMenuItem
            // 
            this.customizeToolStripMenuItem.Name = "customizeToolStripMenuItem";
            this.customizeToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.customizeToolStripMenuItem.Text = "&Customize";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.optionsToolStripMenuItem.Text = "&Options";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contentsToolStripMenuItem,
            this.indexToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.toolStripSeparator5,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // contentsToolStripMenuItem
            // 
            this.contentsToolStripMenuItem.Name = "contentsToolStripMenuItem";
            this.contentsToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.contentsToolStripMenuItem.Text = "&Contents";
            // 
            // indexToolStripMenuItem
            // 
            this.indexToolStripMenuItem.Name = "indexToolStripMenuItem";
            this.indexToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.indexToolStripMenuItem.Text = "&Index";
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.searchToolStripMenuItem.Text = "&Search";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(119, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.aboutToolStripMenuItem.Text = "&About...";
            // 
            // startTableLayout
            // 
            this.startTableLayout.ColumnCount = 2;
            this.startTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.startTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.startTableLayout.Controls.Add(this.eventPanel, 0, 0);
            this.startTableLayout.Controls.Add(this.detailLayoutPanel, 1, 0);
            this.startTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.startTableLayout.Location = new System.Drawing.Point(0, 24);
            this.startTableLayout.Name = "startTableLayout";
            this.startTableLayout.RowCount = 1;
            this.startTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.startTableLayout.Size = new System.Drawing.Size(1097, 439);
            this.startTableLayout.TabIndex = 1;
            // 
            // eventPanel
            // 
            this.eventPanel.Controls.Add(this.eventSearchTextBox);
            this.eventPanel.Controls.Add(this.eventListView);
            this.eventPanel.Controls.Add(this.deleteEventButton);
            this.eventPanel.Controls.Add(this.editEventButton);
            this.eventPanel.Controls.Add(this.addEventButton);
            this.eventPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.eventPanel.Location = new System.Drawing.Point(3, 3);
            this.eventPanel.Name = "eventPanel";
            this.eventPanel.Size = new System.Drawing.Size(244, 433);
            this.eventPanel.TabIndex = 0;
            // 
            // eventSearchTextBox
            // 
            this.eventSearchTextBox.Location = new System.Drawing.Point(4, 34);
            this.eventSearchTextBox.Name = "eventSearchTextBox";
            this.eventSearchTextBox.Size = new System.Drawing.Size(239, 21);
            this.eventSearchTextBox.TabIndex = 4;
            this.eventSearchTextBox.TextChanged += new System.EventHandler(this.eventSearchTextBox_TextChanged);
            // 
            // eventListView
            // 
            this.eventListView.AllColumns.Add(this.Title);
            this.eventListView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.eventListView.AutoGenerateColumns = false;
            this.eventListView.CellEditUseWholeCell = false;
            this.eventListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Title});
            this.eventListView.Cursor = System.Windows.Forms.Cursors.Default;
            this.eventListView.DataSource = null;
            this.eventListView.FullRowSelect = true;
            this.eventListView.GridLines = true;
            this.eventListView.Location = new System.Drawing.Point(4, 61);
            this.eventListView.Name = "eventListView";
            this.eventListView.ShowGroups = false;
            this.eventListView.Size = new System.Drawing.Size(239, 363);
            this.eventListView.TabIndex = 3;
            this.eventListView.UseCompatibleStateImageBehavior = false;
            this.eventListView.View = System.Windows.Forms.View.Details;
            this.eventListView.SelectedIndexChanged += new System.EventHandler(this.eventListView_SelectedIndexChanged);
            // 
            // Title
            // 
            this.Title.AspectName = "Title";
            this.Title.IsEditable = false;
            this.Title.MaximumWidth = 235;
            this.Title.MinimumWidth = 235;
            this.Title.Text = "Title";
            this.Title.Width = 235;
            // 
            // deleteEventButton
            // 
            this.deleteEventButton.Location = new System.Drawing.Point(168, 4);
            this.deleteEventButton.Name = "deleteEventButton";
            this.deleteEventButton.Size = new System.Drawing.Size(75, 23);
            this.deleteEventButton.TabIndex = 2;
            this.deleteEventButton.Text = "Delete";
            this.deleteEventButton.UseVisualStyleBackColor = true;
            this.deleteEventButton.Click += new System.EventHandler(this.deleteEventButton_Click);
            // 
            // editEventButton
            // 
            this.editEventButton.Location = new System.Drawing.Point(86, 4);
            this.editEventButton.Name = "editEventButton";
            this.editEventButton.Size = new System.Drawing.Size(75, 23);
            this.editEventButton.TabIndex = 1;
            this.editEventButton.Text = "Edit";
            this.editEventButton.UseVisualStyleBackColor = true;
            this.editEventButton.Click += new System.EventHandler(this.editEventButton_Click);
            // 
            // addEventButton
            // 
            this.addEventButton.Location = new System.Drawing.Point(4, 4);
            this.addEventButton.Name = "addEventButton";
            this.addEventButton.Size = new System.Drawing.Size(75, 23);
            this.addEventButton.TabIndex = 0;
            this.addEventButton.Text = "Add";
            this.addEventButton.UseVisualStyleBackColor = true;
            this.addEventButton.Click += new System.EventHandler(this.addEventButton_Click);
            // 
            // detailLayoutPanel
            // 
            this.detailLayoutPanel.ColumnCount = 1;
            this.detailLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.detailLayoutPanel.Controls.Add(this.topicPanel, 0, 2);
            this.detailLayoutPanel.Controls.Add(this.welcomeLabel, 0, 0);
            this.detailLayoutPanel.Controls.Add(this.detailViewTable, 0, 1);
            this.detailLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.detailLayoutPanel.Location = new System.Drawing.Point(253, 3);
            this.detailLayoutPanel.Name = "detailLayoutPanel";
            this.detailLayoutPanel.RowCount = 3;
            this.detailLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 142F));
            this.detailLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 0F));
            this.detailLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.detailLayoutPanel.Size = new System.Drawing.Size(841, 433);
            this.detailLayoutPanel.TabIndex = 1;
            // 
            // topicPanel
            // 
            this.topicPanel.Controls.Add(this.topicSearchTextBox);
            this.topicPanel.Controls.Add(this.topicDataListView);
            this.topicPanel.Controls.Add(this.deleteTopicButton);
            this.topicPanel.Controls.Add(this.editTopicButton);
            this.topicPanel.Controls.Add(this.addTopicButton);
            this.topicPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.topicPanel.Location = new System.Drawing.Point(3, 145);
            this.topicPanel.Name = "topicPanel";
            this.topicPanel.Size = new System.Drawing.Size(835, 285);
            this.topicPanel.TabIndex = 0;
            // 
            // topicDataListView
            // 
            this.topicDataListView.AllColumns.Add(this.topicTitle);
            this.topicDataListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.topicDataListView.AutoGenerateColumns = false;
            this.topicDataListView.CellEditUseWholeCell = false;
            this.topicDataListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.topicTitle});
            this.topicDataListView.Cursor = System.Windows.Forms.Cursors.Default;
            this.topicDataListView.DataSource = null;
            this.topicDataListView.FullRowSelect = true;
            this.topicDataListView.GridLines = true;
            this.topicDataListView.Location = new System.Drawing.Point(4, 34);
            this.topicDataListView.Name = "topicDataListView";
            this.topicDataListView.ShowGroups = false;
            this.topicDataListView.Size = new System.Drawing.Size(831, 245);
            this.topicDataListView.TabIndex = 3;
            this.topicDataListView.UseCompatibleStateImageBehavior = false;
            this.topicDataListView.View = System.Windows.Forms.View.Details;
            this.topicDataListView.SelectedIndexChanged += new System.EventHandler(this.topicDataListView_SelectedIndexChanged);
            // 
            // topicTitle
            // 
            this.topicTitle.AspectName = "Title";
            this.topicTitle.MaximumWidth = 825;
            this.topicTitle.MinimumWidth = 825;
            this.topicTitle.Text = "Title";
            this.topicTitle.Width = 825;
            // 
            // deleteTopicButton
            // 
            this.deleteTopicButton.Location = new System.Drawing.Point(168, 4);
            this.deleteTopicButton.Name = "deleteTopicButton";
            this.deleteTopicButton.Size = new System.Drawing.Size(75, 23);
            this.deleteTopicButton.TabIndex = 2;
            this.deleteTopicButton.Text = "Delete";
            this.deleteTopicButton.UseVisualStyleBackColor = true;
            this.deleteTopicButton.Click += new System.EventHandler(this.deleteTopicButton_Click);
            // 
            // editTopicButton
            // 
            this.editTopicButton.Location = new System.Drawing.Point(86, 4);
            this.editTopicButton.Name = "editTopicButton";
            this.editTopicButton.Size = new System.Drawing.Size(75, 23);
            this.editTopicButton.TabIndex = 1;
            this.editTopicButton.Text = "Edit";
            this.editTopicButton.UseVisualStyleBackColor = true;
            this.editTopicButton.Click += new System.EventHandler(this.editTopicButton_Click);
            // 
            // addTopicButton
            // 
            this.addTopicButton.Location = new System.Drawing.Point(4, 4);
            this.addTopicButton.Name = "addTopicButton";
            this.addTopicButton.Size = new System.Drawing.Size(75, 23);
            this.addTopicButton.TabIndex = 0;
            this.addTopicButton.Text = "Add";
            this.addTopicButton.UseVisualStyleBackColor = true;
            this.addTopicButton.Click += new System.EventHandler(this.addTopicButton_Click);
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.welcomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.Location = new System.Drawing.Point(3, 0);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(835, 142);
            this.welcomeLabel.TabIndex = 1;
            this.welcomeLabel.Text = "Welcome to Event Managment System";
            this.welcomeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // detailViewTable
            // 
            this.detailViewTable.ColumnCount = 4;
            this.detailViewTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.3796F));
            this.detailViewTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 77.6204F));
            this.detailViewTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 96F));
            this.detailViewTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 387F));
            this.detailViewTable.Controls.Add(this.label1, 0, 0);
            this.detailViewTable.Controls.Add(this.label2, 0, 1);
            this.detailViewTable.Controls.Add(this.label3, 0, 2);
            this.detailViewTable.Controls.Add(this.titleLabel, 1, 0);
            this.detailViewTable.Controls.Add(this.typeLabel, 1, 1);
            this.detailViewTable.Controls.Add(this.locationLabel, 1, 2);
            this.detailViewTable.Controls.Add(this.label7, 2, 0);
            this.detailViewTable.Controls.Add(this.label8, 2, 1);
            this.detailViewTable.Controls.Add(this.dateTimeLabel, 3, 0);
            this.detailViewTable.Controls.Add(this.descriptionLabel, 3, 1);
            this.detailViewTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.detailViewTable.Location = new System.Drawing.Point(3, 145);
            this.detailViewTable.Name = "detailViewTable";
            this.detailViewTable.RowCount = 3;
            this.detailViewTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.detailViewTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.detailViewTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.detailViewTable.Size = new System.Drawing.Size(835, 1);
            this.detailViewTable.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 1);
            this.label1.TabIndex = 0;
            this.label1.Text = "Title :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, -17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 1);
            this.label2.TabIndex = 1;
            this.label2.Text = "Type :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, -34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 36);
            this.label3.TabIndex = 2;
            this.label3.Text = "Location :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.titleLabel.Location = new System.Drawing.Point(81, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(267, 1);
            this.titleLabel.TabIndex = 3;
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.typeLabel.Location = new System.Drawing.Point(81, -17);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(267, 1);
            this.typeLabel.TabIndex = 4;
            this.typeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // locationLabel
            // 
            this.locationLabel.AutoSize = true;
            this.locationLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.locationLabel.Location = new System.Drawing.Point(81, -34);
            this.locationLabel.Name = "locationLabel";
            this.locationLabel.Size = new System.Drawing.Size(267, 36);
            this.locationLabel.TabIndex = 5;
            this.locationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(354, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 1);
            this.label7.TabIndex = 6;
            this.label7.Text = "Date/Time :";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(354, -17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 1);
            this.label8.TabIndex = 7;
            this.label8.Text = "Description :";
            // 
            // dateTimeLabel
            // 
            this.dateTimeLabel.AutoSize = true;
            this.dateTimeLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateTimeLabel.Location = new System.Drawing.Point(450, 0);
            this.dateTimeLabel.Name = "dateTimeLabel";
            this.dateTimeLabel.Size = new System.Drawing.Size(382, 1);
            this.dateTimeLabel.TabIndex = 8;
            this.dateTimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.descriptionLabel.Location = new System.Drawing.Point(450, -17);
            this.descriptionLabel.Name = "descriptionLabel";
            this.detailViewTable.SetRowSpan(this.descriptionLabel, 2);
            this.descriptionLabel.Size = new System.Drawing.Size(382, 19);
            this.descriptionLabel.TabIndex = 9;
            // 
            // topicSearchTextBox
            // 
            this.topicSearchTextBox.Location = new System.Drawing.Point(250, 4);
            this.topicSearchTextBox.Name = "topicSearchTextBox";
            this.topicSearchTextBox.Size = new System.Drawing.Size(579, 21);
            this.topicSearchTextBox.TabIndex = 4;
            this.topicSearchTextBox.TextChanged += new System.EventHandler(this.topicSearchTextBox_TextChanged);
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 463);
            this.Controls.Add(this.startTableLayout);
            this.Controls.Add(this.menuStrip);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Name = "StartForm";
            this.Text = "Event Managment System";
            this.Load += new System.EventHandler(this.StartForm_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.startTableLayout.ResumeLayout(false);
            this.eventPanel.ResumeLayout(false);
            this.eventPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventListView)).EndInit();
            this.detailLayoutPanel.ResumeLayout(false);
            this.topicPanel.ResumeLayout(false);
            this.topicPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.topicDataListView)).EndInit();
            this.detailViewTable.ResumeLayout(false);
            this.detailViewTable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.topicBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printPreviewToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem indexToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel startTableLayout;
        private System.Windows.Forms.Panel eventPanel;
        private BrightIdeasSoftware.DataListView eventListView;
        private System.Windows.Forms.Button deleteEventButton;
        private System.Windows.Forms.Button editEventButton;
        private System.Windows.Forms.Button addEventButton;
        private System.Windows.Forms.TextBox eventSearchTextBox;
        private System.Windows.Forms.BindingSource eventBindingSource;
        private BrightIdeasSoftware.OLVColumn Title;
        private System.Windows.Forms.TableLayoutPanel detailLayoutPanel;
        private System.Windows.Forms.Panel topicPanel;
        private System.Windows.Forms.Button deleteTopicButton;
        private System.Windows.Forms.Button editTopicButton;
        private System.Windows.Forms.Button addTopicButton;
        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.TableLayoutPanel detailViewTable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.Label locationLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label dateTimeLabel;
        private System.Windows.Forms.Label descriptionLabel;
        private BrightIdeasSoftware.DataListView topicDataListView;
        private BrightIdeasSoftware.OLVColumn topicTitle;
        private System.Windows.Forms.BindingSource topicBindingSource;
        private System.Windows.Forms.TextBox topicSearchTextBox;
    }
}