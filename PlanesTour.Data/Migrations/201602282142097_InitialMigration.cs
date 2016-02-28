namespace PlanesTour.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration : DbMigration
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
                        Description = c.String(maxLength: 500),
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
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Locations", t => t.LocationId, cascadeDelete: true)
                .Index(t => t.LocationId);
            
            CreateTable(
                "dbo.Locations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 100),
                        Created = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.HotelPhotos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        HotelId = c.Int(nullable: false),
                        PhotoId = c.Int(nullable: false),
                        Created = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Hotels", t => t.HotelId, cascadeDelete: true)
                .ForeignKey("dbo.Photos", t => t.PhotoId, cascadeDelete: true)
                .Index(t => t.HotelId)
                .Index(t => t.PhotoId);
            
            CreateTable(
                "dbo.Photos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Path = c.String(maxLength: 254),
                        Description = c.String(maxLength: 100),
                        Created = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.LocationPhotos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        LocationId = c.Int(nullable: false),
                        PhotoId = c.Int(nullable: false),
                        Created = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Locations", t => t.LocationId, cascadeDelete: true)
                .ForeignKey("dbo.Photos", t => t.PhotoId, cascadeDelete: true)
                .Index(t => t.LocationId)
                .Index(t => t.PhotoId);
            
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
                        ImagePath = c.String(maxLength: 254),
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
                        PhoneNumber = c.String(maxLength: 20),
                        Email = c.String(maxLength: 40),
                        Created = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Reservations", "HotelId", "dbo.Hotels");
            DropForeignKey("dbo.Children", "Reservation_Id", "dbo.Reservations");
            DropForeignKey("dbo.LocationPhotos", "PhotoId", "dbo.Photos");
            DropForeignKey("dbo.LocationPhotos", "LocationId", "dbo.Locations");
            DropForeignKey("dbo.HotelPhotos", "PhotoId", "dbo.Photos");
            DropForeignKey("dbo.HotelPhotos", "HotelId", "dbo.Hotels");
            DropForeignKey("dbo.Hotels", "LocationId", "dbo.Locations");
            DropForeignKey("dbo.Feedbacks", "HotelId", "dbo.Hotels");
            DropIndex("dbo.Reservations", new[] { "HotelId" });
            DropIndex("dbo.LocationPhotos", new[] { "PhotoId" });
            DropIndex("dbo.LocationPhotos", new[] { "LocationId" });
            DropIndex("dbo.HotelPhotos", new[] { "PhotoId" });
            DropIndex("dbo.HotelPhotos", new[] { "HotelId" });
            DropIndex("dbo.Hotels", new[] { "LocationId" });
            DropIndex("dbo.Feedbacks", new[] { "HotelId" });
            DropIndex("dbo.Children", new[] { "Reservation_Id" });
            DropTable("dbo.Users");
            DropTable("dbo.Reservations");
            DropTable("dbo.Offerts");
            DropTable("dbo.LocationPhotos");
            DropTable("dbo.Photos");
            DropTable("dbo.HotelPhotos");
            DropTable("dbo.Locations");
            DropTable("dbo.Hotels");
            DropTable("dbo.Feedbacks");
            DropTable("dbo.Children");
        }
    }
}
