using DAL.Interfaces;
using DAL.Models;
using System.Collections.Generic;
using System.Linq;

namespace DAL.Repos
{
    internal class UserReviewRepo : Repo, IRepo<UserReview, int, UserReview>
    {
        public UserReview Create(UserReview obj)
        {
            db.UserReviews.Add(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }

        public bool Delete(int id)
        {
            var ex = Read(id);
            db.UserReviews.Remove(ex);
            return db.SaveChanges() > 0;
        }

        public List<UserReview> Read()
        {
            return db.UserReviews.ToList();
        }

        public UserReview Read(int id)
        {
            return db.UserReviews.Find(id);
        }

        public UserReview Update(UserReview obj)
        {
            var ex = Read(obj.UserReviewID);
            db.Entry(ex).CurrentValues.SetValues(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }
    }
}

