using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EMS.Util;
using EMS.Model;
using System.Threading;

namespace EMS.View
{
    public partial class ActivityForm : Form
    {
        private ActivityManager tM;
        private Activity t;
        private Topic e;

        public ActivityForm(ActivityManager t, Topic e)
        {
            InitializeComponent();
            tM = t;
            this.e = e;
            typeComboBox.DataSource = tM.getActivityTypes();
            Text = "Add new activity";
        }
        public ActivityForm(ActivityManager tM, Activity t, Topic ev) : this(tM, ev)
        {
            this.t = t;
            Text = "Edit activity";
            titleTextBox.Text = t.Title;
            typeComboBox.DataSource = tM.getActivityTypes();
            typeComboBox.SelectedItem = t.ActivityType;
            locationTextBox.Text = t.Location;
            activityDateTimePicker.Value = (DateTime)t.Date;
            descriptionTextBox.Text = t.Description;
        }

        private void ActivityForm_Load(object sender, EventArgs e)
        {
            hideErrors();
        }

        private void hideErrors()
        {
            activityTableLayout.RowStyles[1].Height = 0;
            activityTableLayout.RowStyles[3].Height = 0;
            activityTableLayout.RowStyles[5].Height = 0;
        }

        private bool checkForErrors()
        {
            hideErrors();
            bool hasErrors = false;
            if (titleTextBox.Text == "")
            {
                activityTableLayout.RowStyles[1].Height = 30;
                hasErrors = true;
            }
            if (typeComboBox.SelectedIndex == -1)
            {
                activityTableLayout.RowStyles[3].Height = 30;
                hasErrors = true;
            }
            if (locationTextBox.Text == "")
            {
                activityTableLayout.RowStyles[5].Height = 30;
                hasErrors = true;
            }
            return hasErrors;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (!checkForErrors())
            {
                if (Text == "Add new activity")
                {
                    Activity t = new Activity();
                    t.Title = titleTextBox.Text;
                    t.TypeID = ((ActivityType)typeComboBox.SelectedItem).ID;
                    t.Location = locationTextBox.Text;
                    t.Date = activityDateTimePicker.Value;
                    t.Description = descriptionTextBox.Text;
                    t.Active = true;
                    t.Topic = this.e;
                    t.TopicID = this.e.ID;
                    tM.addActivity(t);
                }
                else
                {
                    t.Title = titleTextBox.Text;
                    t.TypeID = ((ActivityType)typeComboBox.SelectedItem).ID;
                    t.Location = locationTextBox.Text;
                    t.Date = activityDateTimePicker.Value;
                    t.Description = descriptionTextBox.Text;
                    t.Active = true;
                    tM.updateActivity(t);
                }
                DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
