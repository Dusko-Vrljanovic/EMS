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
        private EMSEntities entities = new EMSEntities();

        public MainForm()
        {
            InitializeComponent();
            eM = new EventManager(entities);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void addEventButton_Click(object sender, EventArgs e)
        {
            EventForm form = new EventForm(eM);
            form.ShowDialog();
        }
    }
}
