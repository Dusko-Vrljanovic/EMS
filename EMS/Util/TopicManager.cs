using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EMS.Model;
using System.Windows.Forms;

namespace EMS.Util
{
    public class TopicManager
    {
        private EMSEntities entities;
        private Topic t;

        public TopicManager(EMSEntities entities)
        {
            this.entities = entities;
        }

        public void addTopic(Topic t)
        {
            this.t = t;
            try
            {
                entities.Topics.Add(t);
                entities.SaveChanges();
            }
            catch (Exception)
            {
                MessageBox.Show("Something went horribly wrong.");
            }
        }

        public void updateTopic(Topic t)
        {
            this.t = t;
            try
            {
                entities.Topics.Attach(t);
                entities.Entry(t).State = System.Data.Entity.EntityState.Modified;
                entities.SaveChanges();
            }
            catch (Exception)
            {
                entities.Entry(t).State = System.Data.Entity.EntityState.Detached;
                MessageBox.Show("Something went horribly wrong.");
            }
        }

        public List<TopicType> getTopicTypes()
        {
            return entities.TopicTypes.ToList();
        }

        public TopicType getTopicType(Topic t)
        {
            return entities.TopicTypes.Find(t.ID);
        }

        public List<Topic> getTopics()
        {
            return entities.Topics.Where(t => t.Active == true).ToList();
        }

        public Topic getLastTopic()
        {
            return t;
        }

        public bool deleteTopic(Topic t)
        {
            t.Active = false;
            try
            {
                entities.Topics.Attach(t);
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
