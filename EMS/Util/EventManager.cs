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
                entities.SaveChanges();
            }
            catch (Exception)
            {
                MessageBox.Show("Something went horribly wrong.");
            }
        }

        public void updateEvent(Event e)
        {
            this.e = e;
            try
            {
                entities.Events.Attach(e);
                entities.Entry(e).State = System.Data.Entity.EntityState.Modified;
                entities.SaveChanges();
            }
            catch (Exception)
            {
                entities.Entry(e).State = System.Data.Entity.EntityState.Detached;
                MessageBox.Show("Something went horribly wrong.");
            }
        }

        public List<EventType> getEventTypes()
        {
            return entities.EventTypes.ToList();
        }

        public EventType getEventType(Event ev)
        {
            return entities.EventTypes.Find(ev.ID);
        }

        public List<Event> getEvents()
        {
            return entities.Events.Where(e => e.Active == true).ToList();
        }

        public Event getLastEvent()
        {
            return e;
        }

        public bool deleteEvent(Event ev)
        {
            ev.Active = false;
            try
            {
                entities.Events.Attach(ev);
                entities.Entry(ev).State = System.Data.Entity.EntityState.Modified;
                entities.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                entities.Entry(ev).State = System.Data.Entity.EntityState.Detached;
                MessageBox.Show("Something went horribly wrong.");
                return false;
            }
        }
    }
}
