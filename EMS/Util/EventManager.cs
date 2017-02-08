using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EMS.Model;
using System.Windows.Forms;

namespace EMS.Util
{
    public class EventManager
    {
        private EMSEntities entities;
        private Event e;

        public EventManager(EMSEntities entities)
        {
            this.entities = entities;
        }

        public void addEvent(Event e)
        {
            this.e = e;
            try
            {
                entities.Events.Add(e);
                entities.SaveChangesAsync();
            }
            catch (Exception)
            {
                MessageBox.Show("Uh, oh imamo Hjuston");
            }
        }

        public List<EventType> getEventTypes()
        {
            return entities.EventTypes.ToList();
        }

        public List<Event> getEvents()
        {
            return entities.Events.ToList();
        }

        public Event getLastEvent()
        {
            return e;
        }
    }
}
