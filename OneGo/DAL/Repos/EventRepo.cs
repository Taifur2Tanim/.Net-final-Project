using DAL.Interfaces;
using DAL.Models;
using System.Collections.Generic;
using System.Linq;

namespace DAL.Repos
{
    internal class EventRepo : Repo, IRepo<Event, int, Event>
    {
        public Event Create(Event obj)
        {
            db.Events.Add(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }

        public bool Delete(int id)
        {
            var ex = Read(id);
            db.Events.Remove(ex);
            return db.SaveChanges() > 0;
        }

        public List<Event> Read()
        {
            return db.Events.ToList();
        }

        public Event Read(int id)
        {
            return db.Events.Find(id);
        }

        public Event Update(Event obj)
        {
            var ex = Read(obj.EventID);
            db.Entry(ex).CurrentValues.SetValues(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }
    }
}
