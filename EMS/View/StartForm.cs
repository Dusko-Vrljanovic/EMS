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

            detailLayoutPanel.RowStyles[0].Height = 142;
            detailLayoutPanel.RowStyles[1].Height = 0;

            topicBindingSource.DataSource = new List<Topic>(1);
            topicDataListView.DataSource = topicBindingSource;
            disableTopicButtons();
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
            Event ev = (Event)eventListView.SelectedObject;
            if (eM.deleteEvent(ev))
            {
                eventBindingSource.Remove(ev);
            }
        }

        private void eventListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (eventListView.SelectedIndex == -1)
            {
                eventButtonEnabled(false);
                disableTopicButtons();
                detailLayoutPanel.RowStyles[0].Height = 142;
                detailLayoutPanel.RowStyles[1].Height = 0;
            }
            else
            {
                eventButtonEnabled(true);
                topicButtonEnabled(false);
                detailLayoutPanel.RowStyles[1].Height = 142;
                detailLayoutPanel.RowStyles[0].Height = 0;
                Event ev = (Event)eventListView.SelectedObject;
                titleLabel.Text = ev.Title;
                typeLabel.Text = ev.EventType.Name;
                locationLabel.Text = ev.Location;
                dateTimeLabel.Text = ((DateTime)ev.Date).ToShortDateString() + " at " + ((DateTime)ev.Date).ToShortTimeString();
                descriptionLabel.Text = ev.Description;
                topicBindingSource.DataSource = ev.Topics.Where(t => t.Active == true).ToList();
            }

        }

        private void eventButtonEnabled(bool enabled)
        {
            editEventButton.Enabled = deleteEventButton.Enabled = enabled;
        }

        private void disableTopicButtons()
        {
            editTopicButton.Enabled = addTopicButton.Enabled = deleteTopicButton.Enabled = false;
        }

        private void topicButtonEnabled(bool enabled)
        {
            addTopicButton.Enabled = true;
            editTopicButton.Enabled = deleteTopicButton.Enabled = viewTopicButton.Enabled = enabled;
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
            Topic t = (Topic)topicDataListView.SelectedObject;
            if (tM.deleteTopic(t))
            {
                topicBindingSource.Remove(t);
            }
        }

        private void topicDataListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (topicDataListView.SelectedIndex == -1)
            {
                topicButtonEnabled(false);
            }
            else
            {
                topicButtonEnabled(true);
            }

        }

        private void eventSearchTextBox_TextChanged(object sender, EventArgs e)
        {
            searchEvents();
        }

        private void topicSearchTextBox_TextChanged(object sender, EventArgs e)
        {
            searchTopics();
        }

        private void viewTopicButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new TopicDetailViewForm(this, (Topic)topicDataListView.SelectedObject, aM).ShowDialog();
            this.Show();

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

        private void searchTopics()
        {
            topicDataListView.UseFiltering = true;
            topicDataListView.ModelFilter = new ModelFilter(x =>
            {
                var t = x as Topic;
                return x != null && (t.Title.ToLower().Contains(topicSearchTextBox.Text.ToLower()));
            });
        }
    }
}
