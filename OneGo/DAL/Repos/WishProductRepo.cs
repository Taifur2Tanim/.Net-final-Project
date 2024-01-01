using DAL.Interfaces;
using DAL.Models;
using System.Collections.Generic;
using System.Linq;

namespace DAL.Repos
{
    internal class WishProductRepo : Repo, IRepo<WishProduct, int, WishProduct>
    {
        public WishProduct Create(WishProduct obj)
        {
            db.WishProducts.Add(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }

        public bool Delete(int id)
        {
            var ex = Read(id);
            db.WishProducts.Remove(ex);
            return db.SaveChanges() > 0;
        }

        public List<WishProduct> Read()
        {
            return db.WishProducts.ToList();
        }

        public WishProduct Read(int id)
        {
            return db.WishProducts.Find(id);
        }

        public WishProduct Update(WishProduct obj)
        {
            var ex = Read(obj.WishlistID);
            db.Entry(ex).CurrentValues.SetValues(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }
    }
}

