namespace Give.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class GiverTableUpdated : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Givers", "Address", c => c.String(nullable: false, maxLength: 8000, unicode: false));
            AddColumn("dbo.Givers", "AboutMe", c => c.String(nullable: false, maxLength: 8000, unicode: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Givers", "AboutMe");
            DropColumn("dbo.Givers", "Address");
        }
    }
}
