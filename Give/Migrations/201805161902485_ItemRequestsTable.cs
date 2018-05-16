namespace Give.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ItemRequestsTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ItemRequests",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ItemName = c.String(),
                        UserName = c.String(),
                        ItemRequestMessage = c.String(),
                        DateTime = c.DateTime(nullable: false),
                        Location = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ItemRequests");
        }
    }
}
