using DAL.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DAL
{
    internal class OneGoContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<UserReview> UserReviews { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<WishProduct> WishProducts { get; set; }

    }
}
