namespace Give.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class GiveBoardTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.GiveBoards",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ItemName = c.String(),
                        GiverName = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.GiveBoards");
        }
    }
}
