namespace PlanesTour.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Hotels", "Photo_Id", "dbo.Photos");
            DropIndex("dbo.Hotels", new[] { "Photo_Id" });
            CreateTable(
                "dbo.HotelPhotos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        HotelId = c.Int(nullable: false),
                        PhotoId = c.Int(nullable: false),
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
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Photos", "Description", c => c.String(maxLength: 100));
            AddColumn("dbo.Photos", "Location_Id", c => c.Int());
            AddColumn("dbo.Offerts", "ImagePath", c => c.String(maxLength: 254));
            AlterColumn("dbo.Feedbacks", "Description", c => c.String(maxLength: 500));
            AlterColumn("dbo.Locations", "Name", c => c.String(maxLength: 100));
            AlterColumn("dbo.Photos", "Path", c => c.String(maxLength: 254));
            AlterColumn("dbo.Users", "PhoneNumber", c => c.String(maxLength: 20));
            CreateIndex("dbo.Photos", "Location_Id");
            AddForeignKey("dbo.Photos", "Location_Id", "dbo.Locations", "Id");
            DropColumn("dbo.Hotels", "Photo_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Hotels", "Photo_Id", c => c.Int());
            DropForeignKey("dbo.Photos", "Location_Id", "dbo.Locations");
            DropIndex("dbo.Photos", new[] { "Location_Id" });
            AlterColumn("dbo.Users", "PhoneNumber", c => c.String(maxLength: 15));
            AlterColumn("dbo.Photos", "Path", c => c.String());
            AlterColumn("dbo.Locations", "Name", c => c.String());
            AlterColumn("dbo.Feedbacks", "Description", c => c.String());
            DropColumn("dbo.Offerts", "ImagePath");
            DropColumn("dbo.Photos", "Location_Id");
            DropColumn("dbo.Photos", "Description");
            DropTable("dbo.LocationPhotos");
            DropTable("dbo.HotelPhotos");
            CreateIndex("dbo.Hotels", "Photo_Id");
            AddForeignKey("dbo.Hotels", "Photo_Id", "dbo.Photos", "Id");
        }
    }
}
