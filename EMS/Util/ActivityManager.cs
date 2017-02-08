using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EMS.Model;
using System.Windows.Forms;

namespace EMS.Util
{
    public class ActivityManager
    {
        private EMSEntities entities;

        public ActivityManager(EMSEntities entities)
        {
            this.entities = entities;
        }

        public void addActivity(Activity a)
        {
            try
            {
                entities.Activities.Add(a);
                entities.SaveChangesAsync();
            }
            catch (Exception)
            {
                MessageBox.Show("Uh, oh imamo Hjuston");
            }
        }

        public List<ActivityType> getActivityTypes()
        {
            return entities.ActivityTypes.ToList();
        }
    }
}
