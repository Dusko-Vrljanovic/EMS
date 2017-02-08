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

namespace EMS.View
{
    public partial class MainForm : Form
    {

        private EventManager eM;
        private ActivityManager aM;
        private TopicManager tM;
        private EMSEntities entities = new EMSEntities();

        public MainForm()
        {
            InitializeComponent();
            eM = new EventManager(entities);
            tM = new TopicManager(entities);
            aM = new ActivityManager(entities);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            eventBindingSource.DataSource = eM.getEvents();
            eventListView.DataSource = eventBindingSource;
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

        private void addNewTopicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TopicForm form = new TopicForm(tM);
            form.ShowDialog();
        }

        private void addNewActivityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ActivityForm form = new ActivityForm(aM);
            DialogResult result = form.ShowDialog();
        }
    }
}
