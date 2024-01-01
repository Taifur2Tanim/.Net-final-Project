using DAL.Interfaces;
using DAL.Models;
using System.Collections.Generic;
using System.Linq;

namespace DAL.Repos
{
    internal class HotelRepo : Repo, IRepo<Hotel, int, Hotel>
    {
        public Hotel Create(Hotel obj)
        {
            db.Hotels.Add(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }

        public List<Hotel> Read()
        {
            return db.Hotels.ToList();
        }

        public Hotel Read(int id)
        {
            return db.Hotels.Find(id);
        }

        public bool Delete(int id)
        {
            var ex = Read(id);
            db.Hotels.Remove(ex);
            return db.SaveChanges() > 0;
        }

        public Hotel Update(Hotel obj)
        {
            var ex = Read(obj.HotelID);
            db.Entry(ex).CurrentValues.SetValues(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }
    }
}

