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
    public partial class EventForm : Form
    {
        private EventManager eM;
        private Event ev;
        private bool edit;

        public EventForm(EventManager e)
        {
            InitializeComponent();
            eM = e;
            typeComboBox.DataSource = eM.getEventTypes();
        }

        public EventForm(EventManager e, Event ev, bool edit) : this(e)
        {
            this.ev = ev;
            this.edit = edit;
            if(edit == false)
            {
                saveButton.Hide();
            }
            titleTextBox.Text = ev.Title;
            //todo combobox
            locationTextBox.Text = ev.Location;
            eventDateTimePicker.Value = (DateTime) ev.Date;
            descriptionTextBox.Text = ev.Description;
        }

        private void EventForm_Load(object sender, EventArgs e)
        {
            hideErrors(); 
        }

        private void hideErrors()
        {
            eventTableLayout.RowStyles[1].Height = 0;
            eventTableLayout.RowStyles[3].Height = 0;
            eventTableLayout.RowStyles[5].Height = 0;
        }

        private bool checkForErrors()
        {
            hideErrors();
            bool hasErrors = false;
            if(titleTextBox.Text == "")
            {
                eventTableLayout.RowStyles[1].Height = 30;
                hasErrors = true;
            }
            if(typeComboBox.SelectedIndex == -1)
            {
                eventTableLayout.RowStyles[3].Height = 30;
                hasErrors = true;
            }
            if (locationTextBox.Text == "")
            {
                eventTableLayout.RowStyles[5].Height = 30;
                hasErrors = true;
            }
            return hasErrors;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (!checkForErrors())
            {
                Event ev = new Event();
                ev.Title = titleTextBox.Text;
                ev.TypeID = ((EventType)typeComboBox.SelectedItem).ID;
                ev.Location = locationTextBox.Text;
                ev.Date = eventDateTimePicker.Value;
                ev.Description = descriptionTextBox.Text;
                ev.Active = true;
                new Thread(() =>
                {
                    eM.addEvent(ev);
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
