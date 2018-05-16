namespace Give.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MessageTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Givers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 8000, unicode: false),
                        LastName = c.String(nullable: false, maxLength: 8000, unicode: false),
                        ApplicationUserId = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.ApplicationUserId)
                .Index(t => t.ApplicationUserId);
            
            CreateTable(
                "dbo.Messages",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ReceivedMessage = c.String(),
                        SentMessage = c.String(),
                        DateTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Givers", "ApplicationUserId", "dbo.AspNetUsers");
            DropIndex("dbo.Givers", new[] { "ApplicationUserId" });
            DropTable("dbo.Messages");
            DropTable("dbo.Givers");
        }
    }
}
