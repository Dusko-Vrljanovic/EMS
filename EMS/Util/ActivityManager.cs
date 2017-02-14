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
        private Activity t;

        public ActivityManager(EMSEntities entities)
        {
            this.entities = entities;
        }

        public void addActivity(Activity t)
        {
            this.t = t;
            try
            {
                entities.Activities.Add(t);
                entities.SaveChanges();
            }
            catch (Exception)
            {
                MessageBox.Show("Something went horribly wrong.");
            }
        }

        public void updateActivity(Activity t)
        {
            this.t = t;
            try
            {
                entities.Activities.Attach(t);
                entities.Entry(t).State = System.Data.Entity.EntityState.Modified;
                entities.SaveChanges();
            }
            catch (Exception)
            {
                entities.Entry(t).State = System.Data.Entity.EntityState.Detached;
                MessageBox.Show("Something went horribly wrong.");
            }
        }

        public List<ActivityType> getActivityTypes()
        {
            return entities.ActivityTypes.ToList();
        }

        public ActivityType getActivityType(Activity t)
        {
            return entities.ActivityTypes.Find(t.ID);
        }

        public List<Activity> getActivitys()
        {
            return entities.Activities.Where(t => t.Active == true).ToList();
        }

        public Activity getLastActivity()
        {
            return t;
        }

        public bool deleteActivity(Activity t)
        {
            t.Active = false;
            try
            {
                entities.Activities.Attach(t);
                entities.Entry(t).State = System.Data.Entity.EntityState.Modified;
                entities.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                entities.Entry(t).State = System.Data.Entity.EntityState.Detached;
                MessageBox.Show("Something went horribly wrong.");
                return false;
            }
        }
    }


}
