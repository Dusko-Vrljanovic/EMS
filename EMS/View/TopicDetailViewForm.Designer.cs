namespace EMS.View
{
    partial class TopicDetailViewForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TopicDetailViewForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.activityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.layoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.deleteActivityButton = new System.Windows.Forms.Button();
            this.editActivityButton = new System.Windows.Forms.Button();
            this.addActivityButton = new System.Windows.Forms.Button();
            this.activityDataListView = new BrightIdeasSoftware.DataListView();
            this.topicTitle = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.topicTable = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.topicTitleLabel = new System.Windows.Forms.Label();
            this.topicTypeLabel = new System.Windows.Forms.Label();
            this.topicLocationLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.topicDateTimeLabel = new System.Windows.Forms.Label();
            this.topicDescription = new System.Windows.Forms.Label();
            this.activityTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.activityTitleLabel = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.activityTypeLabel = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.activityLocationLabel = new System.Windows.Forms.Label();
            this.activityDateTimeLabel = new System.Windows.Forms.Label();
            this.activityDescriptionLabel = new System.Windows.Forms.Label();
            this.activityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.searchActivityTextBox = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.layoutPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.activityDataListView)).BeginInit();
            this.topicTable.SuspendLayout();
            this.activityTableLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.activityBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.activityToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(935, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // activityToolStripMenuItem
            // 
            this.activityToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem1,
            this.editToolStripMenuItem1,
            this.deleteToolStripMenuItem1});
            this.activityToolStripMenuItem.Name = "activityToolStripMenuItem";
            this.activityToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.activityToolStripMenuItem.Text = "Activity";
            // 
            // addToolStripMenuItem1
            // 
            this.addToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("addToolStripMenuItem1.Image")));
            this.addToolStripMenuItem1.Name = "addToolStripMenuItem1";
            this.addToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.addToolStripMenuItem1.Text = "Add";
            this.addToolStripMenuItem1.Click += new System.EventHandler(this.addToolStripMenuItem1_Click);
            // 
            // editToolStripMenuItem1
            // 
            this.editToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("editToolStripMenuItem1.Image")));
            this.editToolStripMenuItem1.Name = "editToolStripMenuItem1";
            this.editToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.editToolStripMenuItem1.Text = "Edit";
            this.editToolStripMenuItem1.Click += new System.EventHandler(this.editToolStripMenuItem1_Click);
            // 
            // deleteToolStripMenuItem1
            // 
            this.deleteToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("deleteToolStripMenuItem1.Image")));
            this.deleteToolStripMenuItem1.Name = "deleteToolStripMenuItem1";
            this.deleteToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.deleteToolStripMenuItem1.Text = "Delete";
            this.deleteToolStripMenuItem1.Click += new System.EventHandler(this.deleteToolStripMenuItem1_Click);
            // 
            // layoutPanel
            // 
            this.layoutPanel.ColumnCount = 2;
            this.layoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.16578F));
            this.layoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.83422F));
            this.layoutPanel.Controls.Add(this.panel1, 0, 0);
            this.layoutPanel.Controls.Add(this.topicTable, 1, 0);
            this.layoutPanel.Controls.Add(this.activityTableLayout, 1, 1);
            this.layoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutPanel.Location = new System.Drawing.Point(0, 24);
            this.layoutPanel.Name = "layoutPanel";
            this.layoutPanel.RowCount = 2;
            this.layoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35.49488F));
            this.layoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 64.50512F));
            this.layoutPanel.Size = new System.Drawing.Size(935, 296);
            this.layoutPanel.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.searchActivityTextBox);
            this.panel1.Controls.Add(this.deleteActivityButton);
            this.panel1.Controls.Add(this.editActivityButton);
            this.panel1.Controls.Add(this.addActivityButton);
            this.panel1.Controls.Add(this.activityDataListView);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.layoutPanel.SetRowSpan(this.panel1, 2);
            this.panel1.Size = new System.Drawing.Size(248, 290);
            this.panel1.TabIndex = 0;
            // 
            // deleteActivityButton
            // 
            this.deleteActivityButton.FlatAppearance.BorderSize = 0;
            this.deleteActivityButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteActivityButton.Image = ((System.Drawing.Image)(resources.GetObject("deleteActivityButton.Image")));
            this.deleteActivityButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deleteActivityButton.Location = new System.Drawing.Point(168, 4);
            this.deleteActivityButton.Name = "deleteActivityButton";
            this.deleteActivityButton.Size = new System.Drawing.Size(75, 23);
            this.deleteActivityButton.TabIndex = 3;
            this.deleteActivityButton.Text = "     Delete";
            this.deleteActivityButton.UseVisualStyleBackColor = true;
            this.deleteActivityButton.Click += new System.EventHandler(this.deleteActivityButton_Click);
            // 
            // editActivityButton
            // 
            this.editActivityButton.FlatAppearance.BorderSize = 0;
            this.editActivityButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editActivityButton.Image = ((System.Drawing.Image)(resources.GetObject("editActivityButton.Image")));
            this.editActivityButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.editActivityButton.Location = new System.Drawing.Point(86, 4);
            this.editActivityButton.Name = "editActivityButton";
            this.editActivityButton.Size = new System.Drawing.Size(75, 23);
            this.editActivityButton.TabIndex = 2;
            this.editActivityButton.Text = "Edit";
            this.editActivityButton.UseVisualStyleBackColor = true;
            this.editActivityButton.Click += new System.EventHandler(this.editActivityButton_Click);
            // 
            // addActivityButton
            // 
            this.addActivityButton.FlatAppearance.BorderSize = 0;
            this.addActivityButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addActivityButton.Image = ((System.Drawing.Image)(resources.GetObject("addActivityButton.Image")));
            this.addActivityButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addActivityButton.Location = new System.Drawing.Point(4, 4);
            this.addActivityButton.Name = "addActivityButton";
            this.addActivityButton.Size = new System.Drawing.Size(75, 23);
            this.addActivityButton.TabIndex = 1;
            this.addActivityButton.Text = "Add";
            this.addActivityButton.UseVisualStyleBackColor = true;
            this.addActivityButton.Click += new System.EventHandler(this.addActivityButton_Click);
            // 
            // activityDataListView
            // 
            this.activityDataListView.AllColumns.Add(this.topicTitle);
            this.activityDataListView.AutoGenerateColumns = false;
            this.activityDataListView.CellEditUseWholeCell = false;
            this.activityDataListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.topicTitle});
            this.activityDataListView.Cursor = System.Windows.Forms.Cursors.Default;
            this.activityDataListView.DataSource = null;
            this.activityDataListView.FullRowSelect = true;
            this.activityDataListView.GridLines = true;
            this.activityDataListView.Location = new System.Drawing.Point(4, 61);
            this.activityDataListView.Name = "activityDataListView";
            this.activityDataListView.ShowGroups = false;
            this.activityDataListView.Size = new System.Drawing.Size(239, 223);
            this.activityDataListView.TabIndex = 0;
            this.activityDataListView.UseCompatibleStateImageBehavior = false;
            this.activityDataListView.View = System.Windows.Forms.View.Details;
            this.activityDataListView.SelectedIndexChanged += new System.EventHandler(this.activityDataListView_SelectedIndexChanged);
            // 
            // topicTitle
            // 
            this.topicTitle.AspectName = "Title";
            this.topicTitle.IsEditable = false;
            this.topicTitle.MaximumWidth = 230;
            this.topicTitle.MinimumWidth = 230;
            this.topicTitle.Text = "Title";
            this.topicTitle.Width = 230;
            // 
            // topicTable
            // 
            this.topicTable.BackColor = System.Drawing.SystemColors.Control;
            this.topicTable.ColumnCount = 4;
            this.topicTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.11377F));
            this.topicTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.88623F));
            this.topicTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 129F));
            this.topicTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 211F));
            this.topicTable.Controls.Add(this.label2, 0, 0);
            this.topicTable.Controls.Add(this.label3, 0, 1);
            this.topicTable.Controls.Add(this.label4, 0, 2);
            this.topicTable.Controls.Add(this.topicTitleLabel, 1, 0);
            this.topicTable.Controls.Add(this.topicTypeLabel, 1, 1);
            this.topicTable.Controls.Add(this.topicLocationLabel, 1, 2);
            this.topicTable.Controls.Add(this.label8, 2, 0);
            this.topicTable.Controls.Add(this.label9, 2, 1);
            this.topicTable.Controls.Add(this.topicDateTimeLabel, 3, 0);
            this.topicTable.Controls.Add(this.topicDescription, 3, 1);
            this.topicTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.topicTable.Location = new System.Drawing.Point(257, 3);
            this.topicTable.Name = "topicTable";
            this.topicTable.RowCount = 3;
            this.topicTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.topicTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.topicTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.topicTable.Size = new System.Drawing.Size(675, 99);
            this.topicTable.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 35);
            this.label2.TabIndex = 0;
            this.label2.Text = "     Topic title :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(3, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 35);
            this.label3.TabIndex = 1;
            this.label3.Text = "     Topic type :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Image = ((System.Drawing.Image)(resources.GetObject("label4.Image")));
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Location = new System.Drawing.Point(3, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 35);
            this.label4.TabIndex = 2;
            this.label4.Text = "     Topic location :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // topicTitleLabel
            // 
            this.topicTitleLabel.AutoSize = true;
            this.topicTitleLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.topicTitleLabel.Location = new System.Drawing.Point(147, 0);
            this.topicTitleLabel.Name = "topicTitleLabel";
            this.topicTitleLabel.Size = new System.Drawing.Size(184, 35);
            this.topicTitleLabel.TabIndex = 3;
            this.topicTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // topicTypeLabel
            // 
            this.topicTypeLabel.AutoSize = true;
            this.topicTypeLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.topicTypeLabel.Location = new System.Drawing.Point(147, 35);
            this.topicTypeLabel.Name = "topicTypeLabel";
            this.topicTypeLabel.Size = new System.Drawing.Size(184, 35);
            this.topicTypeLabel.TabIndex = 4;
            this.topicTypeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // topicLocationLabel
            // 
            this.topicLocationLabel.AutoSize = true;
            this.topicLocationLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.topicLocationLabel.Location = new System.Drawing.Point(147, 70);
            this.topicLocationLabel.Name = "topicLocationLabel";
            this.topicLocationLabel.Size = new System.Drawing.Size(184, 35);
            this.topicLocationLabel.TabIndex = 5;
            this.topicLocationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Image = ((System.Drawing.Image)(resources.GetObject("label8.Image")));
            this.label8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label8.Location = new System.Drawing.Point(337, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 35);
            this.label8.TabIndex = 6;
            this.label8.Text = "      Topic                     date/time :";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Image = ((System.Drawing.Image)(resources.GetObject("label9.Image")));
            this.label9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label9.Location = new System.Drawing.Point(337, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(123, 35);
            this.label9.TabIndex = 7;
            this.label9.Text = "      Topic                     description :";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // topicDateTimeLabel
            // 
            this.topicDateTimeLabel.AutoSize = true;
            this.topicDateTimeLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.topicDateTimeLabel.Location = new System.Drawing.Point(466, 0);
            this.topicDateTimeLabel.Name = "topicDateTimeLabel";
            this.topicDateTimeLabel.Size = new System.Drawing.Size(206, 35);
            this.topicDateTimeLabel.TabIndex = 9;
            this.topicDateTimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // topicDescription
            // 
            this.topicDescription.AutoSize = true;
            this.topicDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.topicDescription.Location = new System.Drawing.Point(466, 35);
            this.topicDescription.Name = "topicDescription";
            this.topicTable.SetRowSpan(this.topicDescription, 2);
            this.topicDescription.Size = new System.Drawing.Size(206, 70);
            this.topicDescription.TabIndex = 10;
            // 
            // activityTableLayout
            // 
            this.activityTableLayout.ColumnCount = 4;
            this.activityTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.11377F));
            this.activityTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.88623F));
            this.activityTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 129F));
            this.activityTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 211F));
            this.activityTableLayout.Controls.Add(this.label1, 0, 0);
            this.activityTableLayout.Controls.Add(this.activityTitleLabel, 1, 0);
            this.activityTableLayout.Controls.Add(this.label13, 2, 0);
            this.activityTableLayout.Controls.Add(this.label14, 2, 1);
            this.activityTableLayout.Controls.Add(this.activityTypeLabel, 1, 1);
            this.activityTableLayout.Controls.Add(this.label16, 0, 1);
            this.activityTableLayout.Controls.Add(this.label17, 0, 2);
            this.activityTableLayout.Controls.Add(this.activityLocationLabel, 1, 2);
            this.activityTableLayout.Controls.Add(this.activityDateTimeLabel, 3, 0);
            this.activityTableLayout.Controls.Add(this.activityDescriptionLabel, 3, 1);
            this.activityTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.activityTableLayout.Location = new System.Drawing.Point(257, 108);
            this.activityTableLayout.Name = "activityTableLayout";
            this.activityTableLayout.RowCount = 3;
            this.activityTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.activityTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.activityTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.activityTableLayout.Size = new System.Drawing.Size(675, 185);
            this.activityTableLayout.TabIndex = 2;
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
            this.label1.Size = new System.Drawing.Size(138, 66);
            this.label1.TabIndex = 0;
            this.label1.Text = "     Activity title :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // activityTitleLabel
            // 
            this.activityTitleLabel.AutoSize = true;
            this.activityTitleLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.activityTitleLabel.Location = new System.Drawing.Point(147, 0);
            this.activityTitleLabel.Name = "activityTitleLabel";
            this.activityTitleLabel.Size = new System.Drawing.Size(184, 66);
            this.activityTitleLabel.TabIndex = 1;
            this.activityTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Image = ((System.Drawing.Image)(resources.GetObject("label13.Image")));
            this.label13.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label13.Location = new System.Drawing.Point(337, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(123, 66);
            this.label13.TabIndex = 2;
            this.label13.Text = "      Activity                   date/time :";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Image = ((System.Drawing.Image)(resources.GetObject("label14.Image")));
            this.label14.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label14.Location = new System.Drawing.Point(337, 66);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(123, 66);
            this.label14.TabIndex = 3;
            this.label14.Text = "      Activity                   description :";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // activityTypeLabel
            // 
            this.activityTypeLabel.AutoSize = true;
            this.activityTypeLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.activityTypeLabel.Location = new System.Drawing.Point(147, 66);
            this.activityTypeLabel.Name = "activityTypeLabel";
            this.activityTypeLabel.Size = new System.Drawing.Size(184, 66);
            this.activityTypeLabel.TabIndex = 4;
            this.activityTypeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Image = ((System.Drawing.Image)(resources.GetObject("label16.Image")));
            this.label16.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label16.Location = new System.Drawing.Point(3, 66);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(138, 66);
            this.label16.TabIndex = 5;
            this.label16.Text = "     Activity type :";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Image = ((System.Drawing.Image)(resources.GetObject("label17.Image")));
            this.label17.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label17.Location = new System.Drawing.Point(3, 132);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(138, 51);
            this.label17.TabIndex = 6;
            this.label17.Text = "     Activity location :";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // activityLocationLabel
            // 
            this.activityLocationLabel.AutoSize = true;
            this.activityLocationLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.activityLocationLabel.Location = new System.Drawing.Point(147, 132);
            this.activityLocationLabel.Name = "activityLocationLabel";
            this.activityLocationLabel.Size = new System.Drawing.Size(184, 51);
            this.activityLocationLabel.TabIndex = 7;
            this.activityLocationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // activityDateTimeLabel
            // 
            this.activityDateTimeLabel.AutoSize = true;
            this.activityDateTimeLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.activityDateTimeLabel.Location = new System.Drawing.Point(466, 0);
            this.activityDateTimeLabel.Name = "activityDateTimeLabel";
            this.activityDateTimeLabel.Size = new System.Drawing.Size(206, 66);
            this.activityDateTimeLabel.TabIndex = 8;
            this.activityDateTimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // activityDescriptionLabel
            // 
            this.activityDescriptionLabel.AutoSize = true;
            this.activityDescriptionLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.activityDescriptionLabel.Location = new System.Drawing.Point(466, 66);
            this.activityDescriptionLabel.Name = "activityDescriptionLabel";
            this.activityTableLayout.SetRowSpan(this.activityDescriptionLabel, 2);
            this.activityDescriptionLabel.Size = new System.Drawing.Size(206, 117);
            this.activityDescriptionLabel.TabIndex = 9;
            // 
            // searchActivityTextBox
            // 
            this.searchActivityTextBox.Location = new System.Drawing.Point(4, 34);
            this.searchActivityTextBox.Name = "searchActivityTextBox";
            this.searchActivityTextBox.Size = new System.Drawing.Size(239, 21);
            this.searchActivityTextBox.TabIndex = 4;
            this.searchActivityTextBox.TextChanged += new System.EventHandler(this.searchActivityTextBox_TextChanged);
            // 
            // TopicDetailViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 320);
            this.Controls.Add(this.layoutPanel);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TopicDetailViewForm";
            this.Text = "Event Managment System";
            this.Load += new System.EventHandler(this.TopicDetailViewForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.layoutPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.activityDataListView)).EndInit();
            this.topicTable.ResumeLayout(false);
            this.topicTable.PerformLayout();
            this.activityTableLayout.ResumeLayout(false);
            this.activityTableLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.activityBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem activityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem1;
        private System.Windows.Forms.TableLayoutPanel layoutPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button deleteActivityButton;
        private System.Windows.Forms.Button editActivityButton;
        private System.Windows.Forms.Button addActivityButton;
        private BrightIdeasSoftware.DataListView activityDataListView;
        private BrightIdeasSoftware.OLVColumn topicTitle;
        private System.Windows.Forms.TableLayoutPanel topicTable;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label topicTitleLabel;
        private System.Windows.Forms.Label topicTypeLabel;
        private System.Windows.Forms.Label topicLocationLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label topicDateTimeLabel;
        private System.Windows.Forms.Label topicDescription;
        private System.Windows.Forms.TableLayoutPanel activityTableLayout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label activityTitleLabel;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label activityTypeLabel;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label activityLocationLabel;
        private System.Windows.Forms.Label activityDateTimeLabel;
        private System.Windows.Forms.Label activityDescriptionLabel;
        private System.Windows.Forms.BindingSource activityBindingSource;
        private System.Windows.Forms.TextBox searchActivityTextBox;
    }
}