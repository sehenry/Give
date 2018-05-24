namespace Give.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MessageTableUpdated : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Messages", "MessageContent", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Messages", "MessageContent");
        }
    }
}
