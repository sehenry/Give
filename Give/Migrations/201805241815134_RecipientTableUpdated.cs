namespace Give.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RecipientTableUpdated : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Recipients", "Address", c => c.String(nullable: false, maxLength: 8000, unicode: false));
            AddColumn("dbo.Recipients", "HouseHoldSize", c => c.Int(nullable: false));
            AddColumn("dbo.Recipients", "AboutMe", c => c.String(nullable: false, maxLength: 8000, unicode: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Recipients", "AboutMe");
            DropColumn("dbo.Recipients", "HouseHoldSize");
            DropColumn("dbo.Recipients", "Address");
        }
    }
}
