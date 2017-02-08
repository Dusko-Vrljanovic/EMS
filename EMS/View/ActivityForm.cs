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
        private ActivityManager aM;

        public ActivityForm(ActivityManager a)
        {
            InitializeComponent();
            aM = a;
            typeComboBox.DataSource = aM.getActivityTypes();
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
            if(titleTextBox.Text == "")
            {
                activityTableLayout.RowStyles[1].Height = 30;
                hasErrors = true;
            }
            if(typeComboBox.SelectedIndex == -1)
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
                Activity a = new Activity();
                a.Title = titleTextBox.Text;
                a.TypeID = ((ActivityType)typeComboBox.SelectedItem).ID;
                a.Location = locationTextBox.Text;
                a.Date = activityDateTimePicker.Value;
                a.Description = descriptionTextBox.Text;
                new Thread(() =>
                {
                    aM.addActivity(a);
                }).Start();
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
