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
            this.eventToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.topicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.eventPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.eventSearchTextBox = new System.Windows.Forms.TextBox();
            this.eventListView = new BrightIdeasSoftware.DataListView();
            this.Title = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.deleteEventButton = new System.Windows.Forms.Button();
            this.editEventButton = new System.Windows.Forms.Button();
            this.addEventButton = new System.Windows.Forms.Button();
            this.detailLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.topicPanel = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.viewTopicButton = new System.Windows.Forms.Button();
            this.topicSearchTextBox = new System.Windows.Forms.TextBox();
            this.topicDataListView = new BrightIdeasSoftware.DataListView();
            this.topicTitle = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.eventLocation = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.eventStart = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.eventEnd = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
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
            this.menuStrip.SuspendLayout();
            this.startTableLayout.SuspendLayout();
            this.eventPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventListView)).BeginInit();
            this.detailLayoutPanel.SuspendLayout();
            this.topicPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.topicDataListView)).BeginInit();
            this.detailViewTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.topicBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eventToolStripMenuItem,
            this.topicToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1097, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip";
            // 
            // eventToolStripMenuItem
            // 
            this.eventToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.eventToolStripMenuItem.Name = "eventToolStripMenuItem";
            this.eventToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.eventToolStripMenuItem.Text = "Event";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("addToolStripMenuItem.Image")));
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.addToolStripMenuItem.Text = "Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("editToolStripMenuItem.Image")));
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("deleteToolStripMenuItem.Image")));
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // topicToolStripMenuItem
            // 
            this.topicToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem1,
            this.editToolStripMenuItem1,
            this.deleteToolStripMenuItem1,
            this.viewToolStripMenuItem});
            this.topicToolStripMenuItem.Name = "topicToolStripMenuItem";
            this.topicToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.topicToolStripMenuItem.Text = "Topic";
            // 
            // addToolStripMenuItem1
            // 
            this.addToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("addToolStripMenuItem1.Image")));
            this.addToolStripMenuItem1.Name = "addToolStripMenuItem1";
            this.addToolStripMenuItem1.Size = new System.Drawing.Size(107, 22);
            this.addToolStripMenuItem1.Text = "Add";
            this.addToolStripMenuItem1.Click += new System.EventHandler(this.addToolStripMenuItem1_Click);
            // 
            // editToolStripMenuItem1
            // 
            this.editToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("editToolStripMenuItem1.Image")));
            this.editToolStripMenuItem1.Name = "editToolStripMenuItem1";
            this.editToolStripMenuItem1.Size = new System.Drawing.Size(107, 22);
            this.editToolStripMenuItem1.Text = "Edit";
            this.editToolStripMenuItem1.Click += new System.EventHandler(this.editToolStripMenuItem1_Click);
            // 
            // deleteToolStripMenuItem1
            // 
            this.deleteToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("deleteToolStripMenuItem1.Image")));
            this.deleteToolStripMenuItem1.Name = "deleteToolStripMenuItem1";
            this.deleteToolStripMenuItem1.Size = new System.Drawing.Size(107, 22);
            this.deleteToolStripMenuItem1.Text = "Delete";
            this.deleteToolStripMenuItem1.Click += new System.EventHandler(this.deleteToolStripMenuItem1_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("viewToolStripMenuItem.Image")));
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.viewToolStripMenuItem.Text = "View";
            this.viewToolStripMenuItem.Click += new System.EventHandler(this.viewToolStripMenuItem_Click);
            // 
            // startTableLayout
            // 
            this.startTableLayout.ColumnCount = 2;
            this.startTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 459F));
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
            this.eventPanel.Controls.Add(this.pictureBox1);
            this.eventPanel.Controls.Add(this.label4);
            this.eventPanel.Controls.Add(this.comboBox2);
            this.eventPanel.Controls.Add(this.eventSearchTextBox);
            this.eventPanel.Controls.Add(this.eventListView);
            this.eventPanel.Controls.Add(this.deleteEventButton);
            this.eventPanel.Controls.Add(this.editEventButton);
            this.eventPanel.Controls.Add(this.addEventButton);
            this.eventPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.eventPanel.Location = new System.Drawing.Point(3, 3);
            this.eventPanel.Name = "eventPanel";
            this.eventPanel.Size = new System.Drawing.Size(453, 433);
            this.eventPanel.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(9, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 23);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Image = ((System.Drawing.Image)(resources.GetObject("label4.Image")));
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Location = new System.Drawing.Point(9, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "        List of events :";
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Search by title",
            "Search by type",
            "Search by location",
            "Search by period(in next ? days)"});
            this.comboBox2.Location = new System.Drawing.Point(40, 33);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(203, 23);
            this.comboBox2.TabIndex = 5;
            // 
            // eventSearchTextBox
            // 
            this.eventSearchTextBox.Location = new System.Drawing.Point(249, 34);
            this.eventSearchTextBox.Name = "eventSearchTextBox";
            this.eventSearchTextBox.Size = new System.Drawing.Size(201, 21);
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
            this.eventListView.Location = new System.Drawing.Point(4, 80);
            this.eventListView.Name = "eventListView";
            this.eventListView.ShowGroups = false;
            this.eventListView.Size = new System.Drawing.Size(446, 344);
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
            this.deleteEventButton.FlatAppearance.BorderSize = 0;
            this.deleteEventButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteEventButton.Image = ((System.Drawing.Image)(resources.GetObject("deleteEventButton.Image")));
            this.deleteEventButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deleteEventButton.Location = new System.Drawing.Point(168, 4);
            this.deleteEventButton.Name = "deleteEventButton";
            this.deleteEventButton.Size = new System.Drawing.Size(75, 23);
            this.deleteEventButton.TabIndex = 2;
            this.deleteEventButton.Text = "     Delete";
            this.deleteEventButton.UseVisualStyleBackColor = true;
            this.deleteEventButton.Click += new System.EventHandler(this.deleteEventButton_Click);
            // 
            // editEventButton
            // 
            this.editEventButton.BackColor = System.Drawing.Color.Transparent;
            this.editEventButton.FlatAppearance.BorderSize = 0;
            this.editEventButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editEventButton.Image = ((System.Drawing.Image)(resources.GetObject("editEventButton.Image")));
            this.editEventButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.editEventButton.Location = new System.Drawing.Point(86, 4);
            this.editEventButton.Name = "editEventButton";
            this.editEventButton.Size = new System.Drawing.Size(75, 23);
            this.editEventButton.TabIndex = 1;
            this.editEventButton.Text = "Edit";
            this.editEventButton.UseVisualStyleBackColor = false;
            this.editEventButton.Click += new System.EventHandler(this.editEventButton_Click);
            // 
            // addEventButton
            // 
            this.addEventButton.BackColor = System.Drawing.Color.Transparent;
            this.addEventButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.addEventButton.FlatAppearance.BorderSize = 0;
            this.addEventButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addEventButton.Image = ((System.Drawing.Image)(resources.GetObject("addEventButton.Image")));
            this.addEventButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addEventButton.Location = new System.Drawing.Point(4, 4);
            this.addEventButton.Name = "addEventButton";
            this.addEventButton.Size = new System.Drawing.Size(75, 23);
            this.addEventButton.TabIndex = 0;
            this.addEventButton.Text = "Add";
            this.addEventButton.UseVisualStyleBackColor = false;
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
            this.detailLayoutPanel.Location = new System.Drawing.Point(462, 3);
            this.detailLayoutPanel.Name = "detailLayoutPanel";
            this.detailLayoutPanel.RowCount = 3;
            this.detailLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 0F));
            this.detailLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.detailLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 252F));
            this.detailLayoutPanel.Size = new System.Drawing.Size(632, 433);
            this.detailLayoutPanel.TabIndex = 1;
            // 
            // topicPanel
            // 
            this.topicPanel.Controls.Add(this.pictureBox2);
            this.topicPanel.Controls.Add(this.comboBox1);
            this.topicPanel.Controls.Add(this.viewTopicButton);
            this.topicPanel.Controls.Add(this.topicSearchTextBox);
            this.topicPanel.Controls.Add(this.topicDataListView);
            this.topicPanel.Controls.Add(this.deleteTopicButton);
            this.topicPanel.Controls.Add(this.editTopicButton);
            this.topicPanel.Controls.Add(this.addTopicButton);
            this.topicPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.topicPanel.Location = new System.Drawing.Point(3, 93);
            this.topicPanel.Name = "topicPanel";
            this.topicPanel.Size = new System.Drawing.Size(626, 337);
            this.topicPanel.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.InitialImage")));
            this.pictureBox2.Location = new System.Drawing.Point(312, 7);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(31, 23);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(349, 5);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(117, 23);
            this.comboBox1.TabIndex = 6;
            // 
            // viewTopicButton
            // 
            this.viewTopicButton.FlatAppearance.BorderSize = 0;
            this.viewTopicButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewTopicButton.Image = ((System.Drawing.Image)(resources.GetObject("viewTopicButton.Image")));
            this.viewTopicButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.viewTopicButton.Location = new System.Drawing.Point(249, 4);
            this.viewTopicButton.Name = "viewTopicButton";
            this.viewTopicButton.Size = new System.Drawing.Size(75, 23);
            this.viewTopicButton.TabIndex = 5;
            this.viewTopicButton.Text = "View";
            this.viewTopicButton.UseVisualStyleBackColor = true;
            this.viewTopicButton.Click += new System.EventHandler(this.viewTopicButton_Click);
            // 
            // topicSearchTextBox
            // 
            this.topicSearchTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.topicSearchTextBox.Location = new System.Drawing.Point(472, 6);
            this.topicSearchTextBox.Name = "topicSearchTextBox";
            this.topicSearchTextBox.Size = new System.Drawing.Size(148, 21);
            this.topicSearchTextBox.TabIndex = 4;
            this.topicSearchTextBox.TextChanged += new System.EventHandler(this.topicSearchTextBox_TextChanged);
            // 
            // topicDataListView
            // 
            this.topicDataListView.AllColumns.Add(this.topicTitle);
            this.topicDataListView.AllColumns.Add(this.eventLocation);
            this.topicDataListView.AllColumns.Add(this.eventStart);
            this.topicDataListView.AllColumns.Add(this.eventEnd);
            this.topicDataListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.topicDataListView.AutoGenerateColumns = false;
            this.topicDataListView.CellEditUseWholeCell = false;
            this.topicDataListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.topicTitle,
            this.eventLocation,
            this.eventStart,
            this.eventEnd});
            this.topicDataListView.Cursor = System.Windows.Forms.Cursors.Default;
            this.topicDataListView.DataSource = null;
            this.topicDataListView.FullRowSelect = true;
            this.topicDataListView.GridLines = true;
            this.topicDataListView.Location = new System.Drawing.Point(4, 34);
            this.topicDataListView.Name = "topicDataListView";
            this.topicDataListView.ShowGroups = false;
            this.topicDataListView.Size = new System.Drawing.Size(622, 297);
            this.topicDataListView.TabIndex = 3;
            this.topicDataListView.UseCompatibleStateImageBehavior = false;
            this.topicDataListView.View = System.Windows.Forms.View.Details;
            this.topicDataListView.SelectedIndexChanged += new System.EventHandler(this.topicDataListView_SelectedIndexChanged);
            this.topicDataListView.SizeChanged += new System.EventHandler(this.topicDataListView_SizeChanged);
            // 
            // topicTitle
            // 
            this.topicTitle.AspectName = "Title";
            this.topicTitle.IsEditable = false;
            this.topicTitle.Tag = "2";
            this.topicTitle.Text = "Title";
            this.topicTitle.Width = 148;
            // 
            // eventLocation
            // 
            this.eventLocation.AspectName = "Location";
            this.eventLocation.IsEditable = false;
            this.eventLocation.Tag = "2";
            this.eventLocation.Text = "Location";
            this.eventLocation.Width = 164;
            // 
            // eventStart
            // 
            this.eventStart.AspectName = "Date";
            this.eventStart.IsEditable = false;
            this.eventStart.Tag = "2";
            this.eventStart.Text = "Start time";
            this.eventStart.Width = 137;
            // 
            // eventEnd
            // 
            this.eventEnd.AspectName = "Date";
            this.eventEnd.Tag = "2";
            this.eventEnd.Text = "End time";
            this.eventEnd.Width = 187;
            // 
            // deleteTopicButton
            // 
            this.deleteTopicButton.FlatAppearance.BorderSize = 0;
            this.deleteTopicButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteTopicButton.Image = ((System.Drawing.Image)(resources.GetObject("deleteTopicButton.Image")));
            this.deleteTopicButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deleteTopicButton.Location = new System.Drawing.Point(168, 4);
            this.deleteTopicButton.Name = "deleteTopicButton";
            this.deleteTopicButton.Size = new System.Drawing.Size(75, 23);
            this.deleteTopicButton.TabIndex = 2;
            this.deleteTopicButton.Text = "     Delete";
            this.deleteTopicButton.UseVisualStyleBackColor = true;
            this.deleteTopicButton.Click += new System.EventHandler(this.deleteTopicButton_Click);
            // 
            // editTopicButton
            // 
            this.editTopicButton.FlatAppearance.BorderSize = 0;
            this.editTopicButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editTopicButton.Image = ((System.Drawing.Image)(resources.GetObject("editTopicButton.Image")));
            this.editTopicButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.addTopicButton.FlatAppearance.BorderSize = 0;
            this.addTopicButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addTopicButton.Image = ((System.Drawing.Image)(resources.GetObject("addTopicButton.Image")));
            this.addTopicButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.welcomeLabel.Font = new System.Drawing.Font("Open Sans", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.Location = new System.Drawing.Point(3, 0);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(626, 1);
            this.welcomeLabel.TabIndex = 1;
            this.welcomeLabel.Text = "Welcome to Event Managment System";
            this.welcomeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // detailViewTable
            // 
            this.detailViewTable.ColumnCount = 4;
            this.detailViewTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.12969F));
            this.detailViewTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.87031F));
            this.detailViewTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 118F));
            this.detailViewTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 215F));
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
            this.detailViewTable.Location = new System.Drawing.Point(3, 3);
            this.detailViewTable.Name = "detailViewTable";
            this.detailViewTable.RowCount = 3;
            this.detailViewTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.detailViewTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.detailViewTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.detailViewTable.Size = new System.Drawing.Size(626, 84);
            this.detailViewTable.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "     Title :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(3, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "     Type :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(3, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 36);
            this.label3.TabIndex = 2;
            this.label3.Text = "     Location :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.titleLabel.Location = new System.Drawing.Point(102, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(187, 24);
            this.titleLabel.TabIndex = 3;
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.typeLabel.Location = new System.Drawing.Point(102, 24);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(187, 24);
            this.typeLabel.TabIndex = 4;
            this.typeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // locationLabel
            // 
            this.locationLabel.AutoSize = true;
            this.locationLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.locationLabel.Location = new System.Drawing.Point(102, 48);
            this.locationLabel.Name = "locationLabel";
            this.locationLabel.Size = new System.Drawing.Size(187, 36);
            this.locationLabel.TabIndex = 5;
            this.locationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Image = ((System.Drawing.Image)(resources.GetObject("label7.Image")));
            this.label7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label7.Location = new System.Drawing.Point(295, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 24);
            this.label7.TabIndex = 6;
            this.label7.Text = "     Date/Time :";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Image = ((System.Drawing.Image)(resources.GetObject("label8.Image")));
            this.label8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label8.Location = new System.Drawing.Point(295, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 24);
            this.label8.TabIndex = 7;
            this.label8.Text = "     Description :";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dateTimeLabel
            // 
            this.dateTimeLabel.AutoSize = true;
            this.dateTimeLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateTimeLabel.Location = new System.Drawing.Point(413, 0);
            this.dateTimeLabel.Name = "dateTimeLabel";
            this.dateTimeLabel.Size = new System.Drawing.Size(210, 24);
            this.dateTimeLabel.TabIndex = 8;
            this.dateTimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.descriptionLabel.Location = new System.Drawing.Point(413, 24);
            this.descriptionLabel.Name = "descriptionLabel";
            this.detailViewTable.SetRowSpan(this.descriptionLabel, 2);
            this.descriptionLabel.Size = new System.Drawing.Size(210, 60);
            this.descriptionLabel.TabIndex = 9;
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventListView)).EndInit();
            this.detailLayoutPanel.ResumeLayout(false);
            this.topicPanel.ResumeLayout(false);
            this.topicPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
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
        private System.Windows.Forms.ToolStripMenuItem eventToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem topicToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.Button viewTopicButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private BrightIdeasSoftware.OLVColumn eventLocation;
        private BrightIdeasSoftware.OLVColumn eventStart;
        private BrightIdeasSoftware.OLVColumn eventEnd;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}