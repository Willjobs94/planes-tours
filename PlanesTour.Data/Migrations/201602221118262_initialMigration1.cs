namespace PlanesTour.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initialMigration1 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Offerts", "IsActive");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Offerts", "IsActive", c => c.Boolean(nullable: false));
        }
    }
}
