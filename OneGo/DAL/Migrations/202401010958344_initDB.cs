namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Events",
                c => new
                    {
                        EventID = c.Int(nullable: false, identity: true),
                        EventName = c.String(nullable: false),
                        EventDate = c.DateTime(nullable: false),
                        Location = c.String(nullable: false),
                        Description = c.String(nullable: false),
                        OrganizerID = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.EventID)
                .ForeignKey("dbo.Users", t => t.OrganizerID)
                .Index(t => t.OrganizerID);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserName = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false, maxLength: 20),
                        Email = c.String(nullable: false),
                        Contact = c.String(nullable: false),
                        Password = c.String(nullable: false, maxLength: 20),
                        Age = c.Int(nullable: false),
                        Gender = c.String(nullable: false),
                        Profession = c.String(nullable: false),
                        Type = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.UserName);
            
            CreateTable(
                "dbo.Hotels",
                c => new
                    {
                        HotelID = c.Int(nullable: false, identity: true),
                        HotelName = c.String(nullable: false),
                        Location = c.String(nullable: false),
                        Description = c.String(nullable: false),
                        ContactNumber = c.String(nullable: false),
                        Email = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.HotelID);
            
            CreateTable(
                "dbo.UserReviews",
                c => new
                    {
                        UserReviewID = c.Int(nullable: false, identity: true),
                        ReviewDescription = c.String(nullable: false),
                        ReviewedBy = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.UserReviewID)
                .ForeignKey("dbo.Users", t => t.ReviewedBy)
                .Index(t => t.ReviewedBy);
            
            CreateTable(
                "dbo.WishProducts",
                c => new
                    {
                        WishlistID = c.Int(nullable: false, identity: true),
                        WishProductName = c.String(nullable: false),
                        WishProductDescription = c.String(nullable: false),
                        AskedBy = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.WishlistID)
                .ForeignKey("dbo.Users", t => t.AskedBy)
                .Index(t => t.AskedBy);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.WishProducts", "AskedBy", "dbo.Users");
            DropForeignKey("dbo.UserReviews", "ReviewedBy", "dbo.Users");
            DropForeignKey("dbo.Events", "OrganizerID", "dbo.Users");
            DropIndex("dbo.WishProducts", new[] { "AskedBy" });
            DropIndex("dbo.UserReviews", new[] { "ReviewedBy" });
            DropIndex("dbo.Events", new[] { "OrganizerID" });
            DropTable("dbo.WishProducts");
            DropTable("dbo.UserReviews");
            DropTable("dbo.Hotels");
            DropTable("dbo.Users");
            DropTable("dbo.Events");
        }
    }
}
