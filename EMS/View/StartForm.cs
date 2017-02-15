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
using BrightIdeasSoftware;

namespace EMS.View
{
    public partial class StartForm : Form
    {
        private EventManager eM;
        private ActivityManager aM;
        private TopicManager tM;
        private EMSEntities entities = new EMSEntities();
        private bool resizing = false;

        public StartForm()
        {
            InitializeComponent();
            eM = new EventManager(entities);
            tM = new TopicManager(entities);
            aM = new ActivityManager(entities);
        }

        private void StartForm_Load(object sender, EventArgs e)
        {
            eventBindingSource.DataSource = eM.getEvents();
            eventListView.DataSource = eventBindingSource;
            eventButtonEnabled(false);
            eventSearchComboBox.SelectedIndex = eventSearchComboBox.FindStringExact("All");

            detailLayoutPanel.RowStyles[0].Height = 90;
            detailLayoutPanel.RowStyles[1].Height = 0;

            topicBindingSource.DataSource = new List<Topic>(0);
            topicDataListView.DataSource = topicBindingSource;
            disableTopicButtons();
            topicLabel.Text = "";
            topicSearchComboBox.SelectedIndex = topicSearchComboBox.FindStringExact("All");

            activityDataListView.DataSource = activityBindingSource;
            disableActivityButtons();
            activitySearchComboBox.SelectedIndex = activitySearchComboBox.FindStringExact("All");

            eventSearchTextBox.Hide();
            topicSearchTextBox.Hide();
            activitySearchTextBox.Hide();
        }



        private void addEventButton_Click(object sender, EventArgs e)
        {
            EventForm form = new EventForm(eM);
            DialogResult result = form.ShowDialog();
            if (result == DialogResult.OK)
            {
                Event temp = eM.getLastEvent();
                eventBindingSource.Add(temp);
            }
        }

        private void editEventButton_Click(object sender, EventArgs e)
        {
            if (eventListView.SelectedIndex != -1)
            {
                Event ev = (Event)eventListView.SelectedObject;
                EventForm form = new EventForm(eM, ev);
                DialogResult result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    eventBindingSource.Remove(ev);
                    Event temp = eM.getLastEvent();
                    eventBindingSource.Add(temp);
                }
            }
        }

        private void deleteEventButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete event?", "Event Managment System", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Event ev = (Event)eventListView.SelectedObject;
                if (eM.deleteEvent(ev))
                {
                    eventBindingSource.Remove(ev);
                }
            }
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addEventButton.PerformClick();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (eventListView.SelectedIndex != -1)
            {
                editEventButton.PerformClick();
            }
            else
            {
                MessageBox.Show("You have to select event.", "Event Managment System", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (eventListView.SelectedIndex != -1)
            {
                deleteEventButton.PerformClick();
            }
            else
            {
                MessageBox.Show("You have to select event.", "Event Managment System", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void eventButtonEnabled(bool enabled)
        {
            editEventButton.Enabled = deleteEventButton.Enabled = enabled;
            addTopicButton.Enabled = enabled;
        }

        private void eventListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            

            if (eventListView.SelectedIndex == -1)
            {
                eventButtonEnabled(false);
                disableTopicButtons();
                detailLayoutPanel.RowStyles[0].Height = 90;
                detailLayoutPanel.RowStyles[1].Height = 0;
                topicBindingSource.Clear();
                activityBindingSource.Clear();
            }
            else
            {
                eventButtonEnabled(true);
                topicButtonEnabled(false);
                detailLayoutPanel.RowStyles[1].Height = 90;
                detailLayoutPanel.RowStyles[0].Height = 0;
                Event ev = (Event)eventListView.SelectedObject;
                titleLabel.Text = ev.Title;
                typeLabel.Text = ev.EventType.Name;
                locationLabel.Text = ev.Location;
                dateTimeLabel.Text = ((DateTime)ev.Date).ToShortDateString() + " at " + ((DateTime)ev.Date).ToShortTimeString();
                descriptionLabel.Text = ev.Description;
                topicBindingSource.DataSource = ev.Topics.Where(t => t.Active == true).ToList();
            }

            topicDataListView.SelectedIndex = -1;
            activityDataListView.SelectedIndex = -1;

        }

        private void eventListView_SizeChanged(object sender, EventArgs e)
        {
            DataListView listView = sender as DataListView;
            if (listView != null)
            {
                float totalColumnWidth = 0;

                // Get the sum of all column tags
                for (int i = 0; i < listView.Columns.Count; i++)
                    totalColumnWidth += Convert.ToInt32(listView.Columns[i].Tag);

                // Calculate the percentage of space each column should 
                // occupy in reference to the other columns and then set the 
                // width of the column to that percentage of the visible space.
                for (int i = 0; i < listView.Columns.Count; i++)
                {
                    float colPercentage = (Convert.ToInt32(listView.Columns[i].Tag) / totalColumnWidth);
                    listView.Columns[i].Width = (int)(colPercentage * listView.ClientRectangle.Width);
                }
            }
        }

        private void eventSearchTextBox_TextChanged(object sender, EventArgs e)
        {
            searchEvents();
        }

        private void searchEvents()
        {
            eventListView.UseFiltering = true;
            eventListView.ModelFilter = new ModelFilter(x =>
            {
                var ev = x as Event;
                return x != null && (ev.Title.ToLower().Contains(eventSearchTextBox.Text.ToLower()));
            });
        }




        private void addTopicButton_Click(object sender, EventArgs e)
        {
            TopicForm form = new TopicForm(tM, (Event)eventListView.SelectedObject);
            DialogResult result = form.ShowDialog();
            if (result == DialogResult.OK)
            {
                Topic temp = tM.getLastTopic();
                topicBindingSource.Add(temp);
            }
        }

        private void editTopicButton_Click(object sender, EventArgs e)
        {
            if (topicDataListView.SelectedIndex != -1)
            {
                Event ev = (Event)eventListView.SelectedObject;
                Topic t = (Topic)topicDataListView.SelectedObject;
                TopicForm form = new TopicForm(tM, t, ev);
                DialogResult result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    topicBindingSource.Remove(t);
                    Topic temp = tM.getLastTopic();
                    topicBindingSource.Add(temp);
                }
            }
        }

        private void deleteTopicButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete topic?", "Event Managment System", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Topic t = (Topic)topicDataListView.SelectedObject;
                if (tM.deleteTopic(t))
                {
                    topicBindingSource.Remove(t);
                }
            }
        }

        private void viewTopicButton_Click(object sender, EventArgs e)
        {

        }

        private void addToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (eventListView.SelectedIndex != -1)
            {
                addTopicButton.PerformClick();
            }
            else
            {
                MessageBox.Show("You have to select event.", "Event Managment System", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void editToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (topicDataListView.SelectedIndex != -1)
            {
                editTopicButton.PerformClick();
            }
            else
            {
                MessageBox.Show("You have to select topic.", "Event Managment System", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void deleteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (topicDataListView.SelectedIndex != -1)
            {
                deleteTopicButton.PerformClick();
            }
            else
            {
                MessageBox.Show("You have to select topic.", "Event Managment System", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (topicDataListView.SelectedIndex != -1)
            {
                deleteTopicButton.PerformClick();
            }
            else
            {
                MessageBox.Show("You have to select topic.", "Event Managment System", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void disableTopicButtons()
        {
            addTopicButton.Enabled = editTopicButton.Enabled = deleteTopicButton.Enabled = viewTopicButton.Enabled = false;
        }

        private void topicButtonEnabled(bool enabled)
        {
            editTopicButton.Enabled = deleteTopicButton.Enabled = viewTopicButton.Enabled = enabled;
            addActivityButton.Enabled = enabled;
        }

        private void topicDataListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (topicDataListView.SelectedIndex == -1)
            {
                topicButtonEnabled(false);
                activityButtonEnabled(false);
                activityBindingSource.Clear();
                topicLabel.Text = "";
            }
            else
            {
                topicButtonEnabled(true);
                activityButtonEnabled(false);
                Topic t = (Topic)topicDataListView.SelectedObject;
                activityBindingSource.DataSource = t.Activities.Where(a => a.Active == true).ToList();
                topicLabel.Text = "\"" + t.Title + "\":";
            }

            activityDataListView.SelectedIndex = -1;

        }

        private void topicDataListView_SizeChanged(object sender, EventArgs e)
        {
            // Don't allow overlapping of SizeChanged calls
            if (!resizing)
            {
                // Set the resizing flag
                resizing = true;

                DataListView listView = sender as DataListView;
                if (listView != null)
                {
                    float totalColumnWidth = 0;

                    // Get the sum of all column tags
                    for (int i = 0; i < listView.Columns.Count; i++)
                        totalColumnWidth += Convert.ToInt32(listView.Columns[i].Tag);

                    // Calculate the percentage of space each column should 
                    // occupy in reference to the other columns and then set the 
                    // width of the column to that percentage of the visible space.
                    for (int i = 0; i < listView.Columns.Count; i++)
                    {
                        float colPercentage = (Convert.ToInt32(listView.Columns[i].Tag) / totalColumnWidth);
                        listView.Columns[i].Width = (int)(colPercentage * listView.ClientRectangle.Width);
                    }
                }
            }

            // Clear the resizing flag
            resizing = false;
        }

        private void topicSearchTextBox_TextChanged(object sender, EventArgs e)
        {
            searchTopics();
        }        

        private void searchTopics()
        {
            topicDataListView.UseFiltering = true;
            topicDataListView.ModelFilter = new ModelFilter(x =>
            {
                var t = x as Topic;
                return x != null && (t.Title.ToLower().Contains(topicSearchTextBox.Text.ToLower()));
            });
        }



        private void addActivityButton_Click(object sender, EventArgs e)
        {
            Topic t = (Topic)topicDataListView.SelectedObject;
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
                Topic t = (Topic)topicDataListView.SelectedObject;
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
            DialogResult result = MessageBox.Show("Are you sure you want to delete topic?", "Event Managment System", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (activityDataListView.SelectedIndex != -1)
                {
                    Activity t = (Activity)activityDataListView.SelectedObject;
                    if (aM.deleteActivity(t))
                    {
                        activityBindingSource.Remove(t);
                    }
                }
            }
        }

        private void addToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            addActivityButton.PerformClick();
        }

        private void editToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (activityDataListView.SelectedIndex != -1)
            {
                editActivityButton.PerformClick();
            }
            else
            {
                MessageBox.Show("You have to select activity.", "Event Managment System", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void deleteToolStripMenuItem2_Click(object sender, EventArgs e)
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

        private void viewActivityButton_Click(object sender, EventArgs e)
        {

        }

        private void viewToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void disableActivityButtons()
        {
            addActivityButton.Enabled = editActivityButton.Enabled = deleteActivityButton.Enabled = viewActivityButton.Enabled = false;
        }
        
        private void activityButtonEnabled(bool enabled)
        {
            editActivityButton.Enabled = deleteActivityButton.Enabled = viewActivityButton.Enabled = enabled;
        }

        private void activityDataListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(activityDataListView.SelectedIndex == -1)
            {
                activityButtonEnabled(false);
            }
            else
            {
                activityButtonEnabled(true);
            }
        }

        private void activityDataListView_SizeChanged(object sender, EventArgs e)
        {
            if (!resizing)
            {
                // Set the resizing flag
                resizing = true;

                DataListView listView = sender as DataListView;
                if (listView != null)
                {
                    float totalColumnWidth = 0;

                    // Get the sum of all column tags
                    for (int i = 0; i < listView.Columns.Count; i++)
                        totalColumnWidth += Convert.ToInt32(listView.Columns[i].Tag);

                    // Calculate the percentage of space each column should 
                    // occupy in reference to the other columns and then set the 
                    // width of the column to that percentage of the visible space.
                    for (int i = 0; i < listView.Columns.Count; i++)
                    {
                        float colPercentage = (Convert.ToInt32(listView.Columns[i].Tag) / totalColumnWidth);
                        listView.Columns[i].Width = (int)(colPercentage * listView.ClientRectangle.Width);
                    }
                }
            }

            // Clear the resizing flag
            resizing = false;
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
                return x != null && (t.Title.ToLower().Contains(activitySearchTextBox.Text.ToLower()));
            });
        }

        
    }
}
