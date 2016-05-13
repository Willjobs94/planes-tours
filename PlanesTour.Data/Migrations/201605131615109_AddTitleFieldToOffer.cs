namespace PlanesTour.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTitleFieldToOffer : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Offers", "Title", c => c.String(maxLength: 50));
            CreateIndex("dbo.Offers", "HotelId");
            AddForeignKey("dbo.Offers", "HotelId", "dbo.Hotels", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Offers", "HotelId", "dbo.Hotels");
            DropIndex("dbo.Offers", new[] { "HotelId" });
            DropColumn("dbo.Offers", "Title");
        }
    }
}
