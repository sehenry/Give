namespace Give.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class GiveBoardTableUpdated : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.GiveBoards", "ItemDescription", c => c.String());
            AddColumn("dbo.GiveBoards", "ItemLocation", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.GiveBoards", "ItemLocation");
            DropColumn("dbo.GiveBoards", "ItemDescription");
        }
    }
}
