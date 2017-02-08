namespace EMS.View
{
    partial class EventForm
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
            this.eventTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.eventDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.titleLabel = new System.Windows.Forms.Label();
            this.titleErrorLabel = new System.Windows.Forms.Label();
            this.typeLabel = new System.Windows.Forms.Label();
            this.typeErrorLabel = new System.Windows.Forms.Label();
            this.locationLabel = new System.Windows.Forms.Label();
            this.locationErrorLabel = new System.Windows.Forms.Label();
            this.dateTimeLabel = new System.Windows.Forms.Label();
            this.descriptionPanel = new System.Windows.Forms.Panel();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.controlPanel = new System.Windows.Forms.Panel();
            this.cancelButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.locationTextBox = new System.Windows.Forms.TextBox();
            this.typeComboBox = new System.Windows.Forms.ComboBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.eventTableLayout.SuspendLayout();
            this.descriptionPanel.SuspendLayout();
            this.controlPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // eventTableLayout
            // 
            this.eventTableLayout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.eventTableLayout.ColumnCount = 2;
            this.eventTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.68189F));
            this.eventTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85.31811F));
            this.eventTableLayout.Controls.Add(this.typeLabel, 0, 2);
            this.eventTableLayout.Controls.Add(this.titleErrorLabel, 1, 1);
            this.eventTableLayout.Controls.Add(this.typeErrorLabel, 1, 3);
            this.eventTableLayout.Controls.Add(this.locationLabel, 0, 4);
            this.eventTableLayout.Controls.Add(this.locationErrorLabel, 1, 5);
            this.eventTableLayout.Controls.Add(this.titleLabel, 0, 0);
            this.eventTableLayout.Controls.Add(this.eventDateTimePicker, 1, 6);
            this.eventTableLayout.Controls.Add(this.dateTimeLabel, 0, 6);
            this.eventTableLayout.Controls.Add(this.descriptionPanel, 0, 7);
            this.eventTableLayout.Controls.Add(this.controlPanel, 0, 8);
            this.eventTableLayout.Controls.Add(this.titleTextBox, 1, 0);
            this.eventTableLayout.Controls.Add(this.locationTextBox, 1, 4);
            this.eventTableLayout.Controls.Add(this.typeComboBox, 1, 2);
            this.eventTableLayout.Location = new System.Drawing.Point(12, 12);
            this.eventTableLayout.Name = "eventTableLayout";
            this.eventTableLayout.RowCount = 9;
            this.eventTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.eventTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.eventTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.eventTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.eventTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.eventTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.eventTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.eventTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 161F));
            this.eventTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.eventTableLayout.Size = new System.Drawing.Size(613, 426);
            this.eventTableLayout.TabIndex = 0;
            // 
            // eventDateTimePicker
            // 
            this.eventDateTimePicker.AllowDrop = true;
            this.eventDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.eventDateTimePicker.CustomFormat = "                                  dd/MM/yyyy                                     " +
    "        HH:mm:ss";
            this.eventDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.eventDateTimePicker.Location = new System.Drawing.Point(93, 183);
            this.eventDateTimePicker.MaxDate = new System.DateTime(2500, 12, 31, 0, 0, 0, 0);
            this.eventDateTimePicker.MinDate = new System.DateTime(2017, 1, 1, 0, 0, 0, 0);
            this.eventDateTimePicker.Name = "eventDateTimePicker";
            this.eventDateTimePicker.Size = new System.Drawing.Size(517, 21);
            this.eventDateTimePicker.TabIndex = 3;
            // 
            // titleLabel
            // 
            this.titleLabel.Location = new System.Drawing.Point(3, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(84, 30);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "Title :";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // titleErrorLabel
            // 
            this.titleErrorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.titleErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.titleErrorLabel.Location = new System.Drawing.Point(93, 30);
            this.titleErrorLabel.Name = "titleErrorLabel";
            this.titleErrorLabel.Size = new System.Drawing.Size(517, 30);
            this.titleErrorLabel.TabIndex = 2;
            this.titleErrorLabel.Text = "Input is not valid. Enter event name.";
            this.titleErrorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // typeLabel
            // 
            this.typeLabel.Location = new System.Drawing.Point(3, 60);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(84, 30);
            this.typeLabel.TabIndex = 3;
            this.typeLabel.Text = "Type :";
            this.typeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // typeErrorLabel
            // 
            this.typeErrorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.typeErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.typeErrorLabel.Location = new System.Drawing.Point(93, 90);
            this.typeErrorLabel.Name = "typeErrorLabel";
            this.typeErrorLabel.Size = new System.Drawing.Size(517, 29);
            this.typeErrorLabel.TabIndex = 4;
            this.typeErrorLabel.Text = "You have to choose event type.";
            this.typeErrorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // locationLabel
            // 
            this.locationLabel.Location = new System.Drawing.Point(3, 120);
            this.locationLabel.Name = "locationLabel";
            this.locationLabel.Size = new System.Drawing.Size(84, 30);
            this.locationLabel.TabIndex = 5;
            this.locationLabel.Text = "Location :";
            this.locationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // locationErrorLabel
            // 
            this.locationErrorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.locationErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.locationErrorLabel.Location = new System.Drawing.Point(93, 150);
            this.locationErrorLabel.Name = "locationErrorLabel";
            this.locationErrorLabel.Size = new System.Drawing.Size(517, 30);
            this.locationErrorLabel.TabIndex = 6;
            this.locationErrorLabel.Text = "Input is not valid. Enter location where event will be held.";
            this.locationErrorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateTimeLabel
            // 
            this.dateTimeLabel.Location = new System.Drawing.Point(3, 180);
            this.dateTimeLabel.Name = "dateTimeLabel";
            this.dateTimeLabel.Size = new System.Drawing.Size(84, 30);
            this.dateTimeLabel.TabIndex = 7;
            this.dateTimeLabel.Text = "Date/Time :";
            this.dateTimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // descriptionPanel
            // 
            this.descriptionPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.eventTableLayout.SetColumnSpan(this.descriptionPanel, 2);
            this.descriptionPanel.Controls.Add(this.descriptionTextBox);
            this.descriptionPanel.Controls.Add(this.descriptionLabel);
            this.descriptionPanel.Location = new System.Drawing.Point(3, 213);
            this.descriptionPanel.Name = "descriptionPanel";
            this.descriptionPanel.Size = new System.Drawing.Size(607, 155);
            this.descriptionPanel.TabIndex = 8;
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
            this.eventTableLayout.SetColumnSpan(this.controlPanel, 2);
            this.controlPanel.Controls.Add(this.saveButton);
            this.controlPanel.Controls.Add(this.cancelButton);
            this.controlPanel.Location = new System.Drawing.Point(3, 376);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(607, 47);
            this.controlPanel.TabIndex = 9;
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
            // titleTextBox
            // 
            this.titleTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.titleTextBox.Location = new System.Drawing.Point(93, 3);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(517, 21);
            this.titleTextBox.TabIndex = 0;
            // 
            // locationTextBox
            // 
            this.locationTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.locationTextBox.Location = new System.Drawing.Point(93, 123);
            this.locationTextBox.Name = "locationTextBox";
            this.locationTextBox.Size = new System.Drawing.Size(517, 21);
            this.locationTextBox.TabIndex = 2;
            // 
            // typeComboBox
            // 
            this.typeComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.typeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeComboBox.FormattingEnabled = true;
            this.typeComboBox.Location = new System.Drawing.Point(93, 63);
            this.typeComboBox.Name = "typeComboBox";
            this.typeComboBox.Size = new System.Drawing.Size(517, 23);
            this.typeComboBox.TabIndex = 1;
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
            // EventForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 450);
            this.Controls.Add(this.eventTableLayout);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "EventForm";
            this.Text = "EventForm";
            this.Load += new System.EventHandler(this.EventForm_Load);
            this.eventTableLayout.ResumeLayout(false);
            this.eventTableLayout.PerformLayout();
            this.descriptionPanel.ResumeLayout(false);
            this.descriptionPanel.PerformLayout();
            this.controlPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel eventTableLayout;
        private System.Windows.Forms.DateTimePicker eventDateTimePicker;
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