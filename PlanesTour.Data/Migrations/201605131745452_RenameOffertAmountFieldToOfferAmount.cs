namespace PlanesTour.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RenameOffertAmountFieldToOfferAmount : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Offers", "OfferAmount", c => c.Int(nullable: false));
            DropColumn("dbo.Offers", "OffertAmount");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Offers", "OffertAmount", c => c.Int(nullable: false));
            DropColumn("dbo.Offers", "OfferAmount");
        }
    }
}
