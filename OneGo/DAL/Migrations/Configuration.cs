namespace DAL.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DAL.OneGoContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DAL.OneGoContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
            Random random = new Random();
            for (int i = 1; i <= 10; i++)
            {
                context.Users.AddOrUpdate(new Models.User
                {
                    Name = Guid.NewGuid().ToString().Substring(0, 15),
                    UserName = "User-" + i,
                    Email = Guid.NewGuid().ToString().Substring(0, 6) + "@gmail.com",
                    Contact = "01" + random.Next(111111111, 999999999),
                    Password = Guid.NewGuid().ToString().Substring(0, 10),
                    Age = random.Next(17, 65),
                    Gender = "Male",
                    Profession = Guid.NewGuid().ToString().Substring(0, 7),
                    Type = "General"

                });
            }
            for (int i = 1; i <= 20; i++)
            {
                context.Hotels.AddOrUpdate(new Models.Hotel
                {
                    HotelID = i,
                    HotelName = Guid.NewGuid().ToString().Substring(1, 15),
                    Location = Guid.NewGuid().ToString().Substring(0, 10),
                    Description = Guid.NewGuid().ToString(),
                    ContactNumber = "123-456-7890", // Replace with actual contact number generation logic
                    Email = "hotel" + i + "@example.com", // Replace with actual email generation logic
                });
            }
            for (int i = 1; i <= 100; i++)
            {
                context.WishProducts.AddOrUpdate(new Models.WishProduct
                {
                    WishlistID = i,
                    WishProductName = "WishProduct-" + i,
                    WishProductDescription = Guid.NewGuid().ToString().Substring(1, 10),
                    AskedBy = "User-" + random.Next(1, 11),
                });
            }
            for (int i = 1; i <= 100; i++)
            {
                context.UserReviews.AddOrUpdate(new Models.UserReview
                {
                    UserReviewID = i,
                    ReviewDescription = "Review-" + i,
                    ReviewedBy = "User-" + random.Next(1, 11),
                });
            }
            for (int i = 1; i <= 100; i++)
            {
                context.Events.AddOrUpdate(new Models.Event
                {
                    EventID = i,
                    EventName = "Event-" + i,
                    EventDate = DateTime.Now.AddDays(i),
                    Location = "Location-" + i,
                    Description = "Description-" + i,
                    OrganizerID = "User-" + random.Next(1, 11),
                });
            }



        }
    }
}
