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

        public TopicManager(EMSEntities entities)
        {
            this.entities = entities;
        }

        public void addTopic(Topic e)
        {
            try
            {
                entities.Topics.Add(e);
                entities.SaveChangesAsync();
            }
            catch (Exception)
            {
                MessageBox.Show("Uh, oh imamo Hjuston");
            }
        }

        public List<TopicType> getTopicTypes()
        {
            return entities.TopicTypes.ToList();
        }
    }
}
