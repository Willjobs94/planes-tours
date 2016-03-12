namespace PlanesTour.Data.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class renameOffertTable : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Offerts", newName: "Offers");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.Offers", newName: "Offerts");
        }
    }
}
