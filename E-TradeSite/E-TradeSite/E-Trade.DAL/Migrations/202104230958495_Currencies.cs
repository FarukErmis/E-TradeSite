namespace E_Trade.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Currencies : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Currencies",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Label = c.String(maxLength: 255),
                        BuyingPrice = c.Single(),
                        SellingPrice = c.Single(),
                        Abbr = c.String(maxLength: 5),
                        UpdatedAt = c.DateTime(precision: 7, storeType: "datetime2"),
                        Status = c.Boolean(),
                        IsPrimary = c.Boolean(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Currencies");
        }
    }
}
