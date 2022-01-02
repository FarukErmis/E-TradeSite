namespace E_Trade.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PurchaseLimitation : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PurchaseLimitations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 255),
                        MinumumLimit = c.Int(),
                        MaximumLimit = c.Int(),
                        Type = c.Int(nullable: false),
                        Status = c.Boolean(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.PurchaseLimitations");
        }
    }
}
