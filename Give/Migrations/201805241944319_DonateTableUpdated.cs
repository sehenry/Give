namespace Give.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DonateTableUpdated : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Donates", "DonationType");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Donates", "DonationType", c => c.String());
        }
    }
}
