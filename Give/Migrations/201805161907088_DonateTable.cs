namespace Give.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DonateTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Donates",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        DonationType = c.String(),
                        CashDonation = c.Double(nullable: false),
                        ItemDonation = c.String(),
                        GiverName = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Donates");
        }
    }
}
