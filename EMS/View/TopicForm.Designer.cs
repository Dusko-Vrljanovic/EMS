namespace EMS.View
{
    partial class TopicForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TopicForm));
            this.topicTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.typeLabel = new System.Windows.Forms.Label();
            this.titleErrorLabel = new System.Windows.Forms.Label();
            this.typeErrorLabel = new System.Windows.Forms.Label();
            this.locationLabel = new System.Windows.Forms.Label();
            this.locationErrorLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.topicDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dateTimeLabel = new System.Windows.Forms.Label();
            this.descriptionPanel = new System.Windows.Forms.Panel();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.controlPanel = new System.Windows.Forms.Panel();
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.locationTextBox = new System.Windows.Forms.TextBox();
            this.typeComboBox = new System.Windows.Forms.ComboBox();
            this.topicTableLayout.SuspendLayout();
            this.descriptionPanel.SuspendLayout();
            this.controlPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // topicTableLayout
            // 
            this.topicTableLayout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.topicTableLayout.ColumnCount = 2;
            this.topicTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.68189F));
            this.topicTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85.31811F));
            this.topicTableLayout.Controls.Add(this.typeLabel, 0, 2);
            this.topicTableLayout.Controls.Add(this.titleErrorLabel, 1, 1);
            this.topicTableLayout.Controls.Add(this.typeErrorLabel, 1, 3);
            this.topicTableLayout.Controls.Add(this.locationLabel, 0, 4);
            this.topicTableLayout.Controls.Add(this.locationErrorLabel, 1, 5);
            this.topicTableLayout.Controls.Add(this.titleLabel, 0, 0);
            this.topicTableLayout.Controls.Add(this.topicDateTimePicker, 1, 6);
            this.topicTableLayout.Controls.Add(this.dateTimeLabel, 0, 6);
            this.topicTableLayout.Controls.Add(this.descriptionPanel, 0, 7);
            this.topicTableLayout.Controls.Add(this.controlPanel, 0, 8);
            this.topicTableLayout.Controls.Add(this.titleTextBox, 1, 0);
            this.topicTableLayout.Controls.Add(this.locationTextBox, 1, 4);
            this.topicTableLayout.Controls.Add(this.typeComboBox, 1, 2);
            this.topicTableLayout.Location = new System.Drawing.Point(12, 12);
            this.topicTableLayout.Name = "topicTableLayout";
            this.topicTableLayout.RowCount = 9;
            this.topicTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.topicTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.topicTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.topicTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.topicTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.topicTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.topicTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.topicTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 161F));
            this.topicTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.topicTableLayout.Size = new System.Drawing.Size(613, 426);
            this.topicTableLayout.TabIndex = 0;
            // 
            // typeLabel
            // 
            this.typeLabel.Location = new System.Drawing.Point(3, 60);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(83, 30);
            this.typeLabel.TabIndex = 3;
            this.typeLabel.Text = "Type :";
            this.typeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // titleErrorLabel
            // 
            this.titleErrorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.titleErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.titleErrorLabel.Location = new System.Drawing.Point(92, 30);
            this.titleErrorLabel.Name = "titleErrorLabel";
            this.titleErrorLabel.Size = new System.Drawing.Size(518, 30);
            this.titleErrorLabel.TabIndex = 2;
            this.titleErrorLabel.Text = "Input is not valid. Enter topic name.";
            this.titleErrorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // typeErrorLabel
            // 
            this.typeErrorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.typeErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.typeErrorLabel.Location = new System.Drawing.Point(92, 90);
            this.typeErrorLabel.Name = "typeErrorLabel";
            this.typeErrorLabel.Size = new System.Drawing.Size(518, 29);
            this.typeErrorLabel.TabIndex = 4;
            this.typeErrorLabel.Text = "You have to choose topic type.";
            this.typeErrorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // locationLabel
            // 
            this.locationLabel.Location = new System.Drawing.Point(3, 120);
            this.locationLabel.Name = "locationLabel";
            this.locationLabel.Size = new System.Drawing.Size(83, 30);
            this.locationLabel.TabIndex = 5;
            this.locationLabel.Text = "Location :";
            this.locationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // locationErrorLabel
            // 
            this.locationErrorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.locationErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.locationErrorLabel.Location = new System.Drawing.Point(92, 150);
            this.locationErrorLabel.Name = "locationErrorLabel";
            this.locationErrorLabel.Size = new System.Drawing.Size(518, 30);
            this.locationErrorLabel.TabIndex = 6;
            this.locationErrorLabel.Text = "Input is not valid. Enter location where topic will be held.";
            this.locationErrorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // titleLabel
            // 
            this.titleLabel.Location = new System.Drawing.Point(3, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(83, 30);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "Title :";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // topicDateTimePicker
            // 
            this.topicDateTimePicker.AllowDrop = true;
            this.topicDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.topicDateTimePicker.CustomFormat = "                                  dd/MM/yyyy                                     " +
    "        HH:mm:ss";
            this.topicDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.topicDateTimePicker.Location = new System.Drawing.Point(92, 183);
            this.topicDateTimePicker.MaxDate = new System.DateTime(2500, 12, 31, 0, 0, 0, 0);
            this.topicDateTimePicker.MinDate = new System.DateTime(2017, 1, 1, 0, 0, 0, 0);
            this.topicDateTimePicker.Name = "topicDateTimePicker";
            this.topicDateTimePicker.Size = new System.Drawing.Size(518, 21);
            this.topicDateTimePicker.TabIndex = 3;
            // 
            // dateTimeLabel
            // 
            this.dateTimeLabel.Location = new System.Drawing.Point(3, 180);
            this.dateTimeLabel.Name = "dateTimeLabel";
            this.dateTimeLabel.Size = new System.Drawing.Size(83, 30);
            this.dateTimeLabel.TabIndex = 7;
            this.dateTimeLabel.Text = "Date/Time :";
            this.dateTimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // descriptionPanel
            // 
            this.descriptionPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.topicTableLayout.SetColumnSpan(this.descriptionPanel, 2);
            this.descriptionPanel.Controls.Add(this.descriptionTextBox);
            this.descriptionPanel.Controls.Add(this.descriptionLabel);
            this.descriptionPanel.Location = new System.Drawing.Point(3, 213);
            this.descriptionPanel.Name = "descriptionPanel";
            this.descriptionPanel.Size = new System.Drawing.Size(607, 155);
            this.descriptionPanel.TabIndex = 8;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.descriptionTextBox.Location = new System.Drawing.Point(4, 47);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(600, 105);
            this.descriptionTextBox.TabIndex = 4;
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.Location = new System.Drawing.Point(0, 9);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(80, 34);
            this.descriptionLabel.TabIndex = 0;
            this.descriptionLabel.Text = "Description :";
            this.descriptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // controlPanel
            // 
            this.controlPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.topicTableLayout.SetColumnSpan(this.controlPanel, 2);
            this.controlPanel.Controls.Add(this.saveButton);
            this.controlPanel.Controls.Add(this.cancelButton);
            this.controlPanel.Location = new System.Drawing.Point(3, 376);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(607, 47);
            this.controlPanel.TabIndex = 9;
            // 
            // saveButton
            // 
            this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveButton.Location = new System.Drawing.Point(448, 17);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 5;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.Location = new System.Drawing.Point(529, 17);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 6;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // titleTextBox
            // 
            this.titleTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.titleTextBox.Location = new System.Drawing.Point(92, 3);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(518, 21);
            this.titleTextBox.TabIndex = 0;
            // 
            // locationTextBox
            // 
            this.locationTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.locationTextBox.Location = new System.Drawing.Point(92, 123);
            this.locationTextBox.Name = "locationTextBox";
            this.locationTextBox.Size = new System.Drawing.Size(518, 21);
            this.locationTextBox.TabIndex = 2;
            // 
            // typeComboBox
            // 
            this.typeComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.typeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeComboBox.FormattingEnabled = true;
            this.typeComboBox.Location = new System.Drawing.Point(92, 63);
            this.typeComboBox.Name = "typeComboBox";
            this.typeComboBox.Size = new System.Drawing.Size(518, 23);
            this.typeComboBox.TabIndex = 1;
            // 
            // TopicForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 450);
            this.Controls.Add(this.topicTableLayout);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TopicForm";
            this.Text = "TopicForm";
            this.Load += new System.EventHandler(this.TopicForm_Load);
            this.topicTableLayout.ResumeLayout(false);
            this.topicTableLayout.PerformLayout();
            this.descriptionPanel.ResumeLayout(false);
            this.descriptionPanel.PerformLayout();
            this.controlPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel topicTableLayout;
        private System.Windows.Forms.DateTimePicker topicDateTimePicker;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.Label titleErrorLabel;
        private System.Windows.Forms.Label typeErrorLabel;
        private System.Windows.Forms.Label locationLabel;
        private System.Windows.Forms.Label locationErrorLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label dateTimeLabel;
        private System.Windows.Forms.Panel descriptionPanel;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Panel controlPanel;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.TextBox locationTextBox;
        private System.Windows.Forms.ComboBox typeComboBox;
    }
}