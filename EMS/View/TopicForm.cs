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
    public partial class TopicForm : Form
    {
        private TopicManager tM;
        private Topic t;
        private Event e;

        public TopicForm(TopicManager t, Event e)
        {
            InitializeComponent();
            tM = t;
            this.e = e;
            typeComboBox.DataSource = tM.getTopicTypes();
            Text = "Add new topic";
        }
        public TopicForm(TopicManager tM, Topic t, Event ev) : this(tM, ev)
        {
            this.t = t;
            Text = "Edit topic";
            titleTextBox.Text = t.Title;
            typeComboBox.DataSource = tM.getTopicTypes();
            typeComboBox.SelectedItem = t.TopicType;
            locationTextBox.Text = t.Location;
            topicDateTimePicker.Value = (DateTime)t.Date;
            descriptionTextBox.Text = t.Description;
        }

        private void TopicForm_Load(object sender, EventArgs e)
        {
            hideErrors(); 
        }

        private void hideErrors()
        {
            topicTableLayout.RowStyles[1].Height = 0;
            topicTableLayout.RowStyles[3].Height = 0;
            topicTableLayout.RowStyles[5].Height = 0;
        }

        private bool checkForErrors()
        {
            hideErrors();
            bool hasErrors = false;
            if(titleTextBox.Text == "")
            {
                topicTableLayout.RowStyles[1].Height = 30;
                hasErrors = true;
            }
            if(typeComboBox.SelectedIndex == -1)
            {
                topicTableLayout.RowStyles[3].Height = 30;
                hasErrors = true;
            }
            if (locationTextBox.Text == "")
            {
                topicTableLayout.RowStyles[5].Height = 30;
                hasErrors = true;
            }
            return hasErrors;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (!checkForErrors())
            {
                if (Text == "Add new topic")
                {
                    Topic t = new Topic();
                    t.Title = titleTextBox.Text;
                    t.TypeID = ((TopicType)typeComboBox.SelectedItem).ID;
                    t.Location = locationTextBox.Text;
                    t.Date = topicDateTimePicker.Value;
                    t.Description = descriptionTextBox.Text;
                    t.Active = true;
                    t.Event = this.e;
                    t.EventID = this.e.ID;
                    tM.addTopic(t);
                }
                else
                {
                    t.Title = titleTextBox.Text;
                    t.TypeID = ((TopicType)typeComboBox.SelectedItem).ID;
                    t.Location = locationTextBox.Text;
                    t.Date = topicDateTimePicker.Value;
                    t.Description = descriptionTextBox.Text;
                    t.Active = true;
                    tM.updateTopic(t);
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
