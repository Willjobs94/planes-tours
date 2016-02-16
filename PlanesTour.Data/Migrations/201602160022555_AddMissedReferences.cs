namespace PlanesTour.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMissedReferences : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.FeedBacks", "Hotel_Id", "dbo.Hotels");
            DropIndex("dbo.Feedbacks", new[] { "Hotel_Id" });
            RenameColumn(table: "dbo.Feedbacks", name: "Hotel_Id", newName: "HotelId");
            AddColumn("dbo.Hotels", "ViewCount", c => c.Int(nullable: false));
            AddColumn("dbo.Reservations", "HotelId", c => c.Int(nullable: false));
            AddColumn("dbo.Feedbacks", "isAproved", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Feedbacks", "HotelId", c => c.Int(nullable: false));
            CreateIndex("dbo.Feedbacks", "HotelId");
            CreateIndex("dbo.Reservations", "HotelId");
            AddForeignKey("dbo.Reservations", "HotelId", "dbo.Hotels", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Feedbacks", "HotelId", "dbo.Hotels", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Feedbacks", "HotelId", "dbo.Hotels");
            DropForeignKey("dbo.Reservations", "HotelId", "dbo.Hotels");
            DropIndex("dbo.Reservations", new[] { "HotelId" });
            DropIndex("dbo.Feedbacks", new[] { "HotelId" });
            AlterColumn("dbo.Feedbacks", "HotelId", c => c.Int());
            DropColumn("dbo.Feedbacks", "isAproved");
            DropColumn("dbo.Reservations", "HotelId");
            DropColumn("dbo.Hotels", "ViewCount");
            RenameColumn(table: "dbo.Feedbacks", name: "HotelId", newName: "Hotel_Id");
            CreateIndex("dbo.Feedbacks", "Hotel_Id");
            AddForeignKey("dbo.FeedBacks", "Hotel_Id", "dbo.Hotels", "Id");
        }
    }
}
