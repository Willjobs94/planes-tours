namespace PlanesTour.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initialMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Children",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Age = c.Int(nullable: false),
                        Created = c.DateTime(nullable: false),
                        Reservation_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Reservations", t => t.Reservation_Id)
                .Index(t => t.Reservation_Id);
            
            CreateTable(
                "dbo.Feedbacks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Score = c.Int(nullable: false),
                        Description = c.String(),
                        HotelId = c.Int(nullable: false),
                        isAproved = c.Boolean(nullable: false),
                        Created = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Hotels", t => t.HotelId, cascadeDelete: true)
                .Index(t => t.HotelId);
            
            CreateTable(
                "dbo.Hotels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        LocationId = c.Int(nullable: false),
                        Name = c.String(),
                        Description = c.String(maxLength: 300),
                        ViewCount = c.Int(nullable: false),
                        Created = c.DateTime(nullable: false),
                        Photo_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Locations", t => t.LocationId, cascadeDelete: true)
                .ForeignKey("dbo.Photos", t => t.Photo_Id)
                .Index(t => t.LocationId)
                .Index(t => t.Photo_Id);
            
            CreateTable(
                "dbo.Locations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Created = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Photos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Path = c.String(),
                        Created = c.DateTime(nullable: false),
                        Hotel_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Hotels", t => t.Hotel_Id)
                .Index(t => t.Hotel_Id);
            
            CreateTable(
                "dbo.Offerts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        HotelId = c.Int(nullable: false),
                        Description = c.String(maxLength: 200),
                        StartDate = c.DateTime(nullable: false),
                        ExpirationDate = c.DateTime(nullable: false),
                        OffertAmount = c.Int(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                        Created = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Reservations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        HotelId = c.Int(nullable: false),
                        CheckInDate = c.DateTime(nullable: false),
                        CheckOutDate = c.DateTime(nullable: false),
                        RoomsAmount = c.Int(nullable: false),
                        PeopleAmount = c.Int(nullable: false),
                        Created = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Hotels", t => t.HotelId, cascadeDelete: true)
                .Index(t => t.HotelId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 50),
                        PhoneNumber = c.String(maxLength: 15),
                        Email = c.String(maxLength: 40),
                        Created = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Reservations", "HotelId", "dbo.Hotels");
            DropForeignKey("dbo.Children", "Reservation_Id", "dbo.Reservations");
            DropForeignKey("dbo.Photos", "Hotel_Id", "dbo.Hotels");
            DropForeignKey("dbo.Hotels", "Photo_Id", "dbo.Photos");
            DropForeignKey("dbo.Hotels", "LocationId", "dbo.Locations");
            DropForeignKey("dbo.Feedbacks", "HotelId", "dbo.Hotels");
            DropIndex("dbo.Reservations", new[] { "HotelId" });
            DropIndex("dbo.Photos", new[] { "Hotel_Id" });
            DropIndex("dbo.Hotels", new[] { "Photo_Id" });
            DropIndex("dbo.Hotels", new[] { "LocationId" });
            DropIndex("dbo.Feedbacks", new[] { "HotelId" });
            DropIndex("dbo.Children", new[] { "Reservation_Id" });
            DropTable("dbo.Users");
            DropTable("dbo.Reservations");
            DropTable("dbo.Offerts");
            DropTable("dbo.Photos");
            DropTable("dbo.Locations");
            DropTable("dbo.Hotels");
            DropTable("dbo.Feedbacks");
            DropTable("dbo.Children");
        }
    }
}
