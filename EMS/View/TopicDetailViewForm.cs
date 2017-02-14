using BrightIdeasSoftware;
using EMS.Model;
using EMS.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EMS.View
{
    public partial class TopicDetailViewForm : Form
    {
        private StartForm sF;
        private Topic t;
        private ActivityManager aM;

        public TopicDetailViewForm(StartForm sF, Topic t, ActivityManager aM)
        {
            InitializeComponent();
            this.sF = sF;
            this.t = t;
            this.aM = aM;
            activityBindingSource.DataSource = t.Activities.Where(a => a.Active == true).ToList();
            activityDataListView.DataSource = activityBindingSource;
            activityButtonsEnabled(false);
            topicTable.BorderStyle = BorderStyle.Fixed3D;
        }

        private void addActivityButton_Click(object sender, EventArgs e)
        {
            ActivityForm form = new ActivityForm(aM, t);
            DialogResult result = form.ShowDialog();
            if (result == DialogResult.OK)
            {
                Activity temp = aM.getLastActivity();
                activityBindingSource.Add(temp);
            }
        }

        private void editActivityButton_Click(object sender, EventArgs e)
        {
            if (activityDataListView.SelectedIndex != -1)
            {
                Activity a = (Activity)activityDataListView.SelectedObject;
                ActivityForm form = new ActivityForm(aM, a, t);
                DialogResult result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    activityBindingSource.Remove(a);
                    Activity temp = aM.getLastActivity();
                    activityBindingSource.Add(temp);
                }
            }
        }

        private void deleteActivityButton_Click(object sender, EventArgs e)
        {
            if(activityDataListView.SelectedIndex != -1)
            {
                Activity t = (Activity)activityDataListView.SelectedObject;
                if (aM.deleteActivity(t))
                {
                    activityBindingSource.Remove(t);
                }
            }
        }

        private void activityButtonsEnabled(bool enabled)
        {
            editActivityButton.Enabled = deleteActivityButton.Enabled = enabled;
        }

        private void activityDataListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(activityDataListView.SelectedIndex == -1)
            {
                activityButtonsEnabled(false);
                activityTitleLabel.Text ="Not selected";
                activityTypeLabel.Text = "Not selected";
                activityLocationLabel.Text = "Not selected";
                activityDateTimeLabel.Text = "Not selected";
                activityDescriptionLabel.Text = "Not selected";

            }
            else
            {
                activityButtonsEnabled(true);
                Activity t = (Activity)activityDataListView.SelectedObject;
                activityTitleLabel.Text = t.Title;
                activityTypeLabel.Text = t.ActivityType.Name;
                activityLocationLabel.Text = t.Location;
                activityDateTimeLabel.Text = ((DateTime)t.Date).ToShortDateString() + " at " + ((DateTime)t.Date).ToShortTimeString();
                activityDescriptionLabel.Text = t.Description;
            }
        }

        private void TopicDetailViewForm_Load(object sender, EventArgs e)
        {
            topicTitleLabel.Text = t.Title;
            topicTypeLabel.Text = t.TopicType.Name;
            topicLocationLabel.Text = t.Location;
            topicDateTimeLabel.Text = ((DateTime)t.Date).ToShortDateString() + " at " + ((DateTime)t.Date).ToShortTimeString();
            topicDescription.Text = t.Description;

            activityTitleLabel.Text = "Not selected";
            activityTypeLabel.Text = "Not selected";
            activityLocationLabel.Text = "Not selected";
            activityDateTimeLabel.Text = "Not selected";
            activityDescriptionLabel.Text = "Not selected";
        }

        private void searchActivityTextBox_TextChanged(object sender, EventArgs e)
        {
            searchActivities();
        }

        private void searchActivities()
        {
            activityDataListView.UseFiltering = true;
            activityDataListView.ModelFilter = new ModelFilter(x =>
            {
                var t = x as Activity;
                return x != null && (t.Title.ToLower().Contains(searchActivityTextBox.Text.ToLower()));
            });
        }

        private void addToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            addActivityButton.PerformClick();
        }

        private void editToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if(activityDataListView.SelectedIndex != -1)
            {
                editActivityButton.PerformClick();
            }
            else
            {
                MessageBox.Show("You have to select activity.", "Event Managment System", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void deleteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (activityDataListView.SelectedIndex != -1)
            {
                deleteActivityButton.PerformClick();
            }
            else
            {
                MessageBox.Show("You have to select activity.", "Event Managment System", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
