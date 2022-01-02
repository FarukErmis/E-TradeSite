namespace E_Trade.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ShippingRate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ShippingRates",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        VolumetricWeightStart = c.Int(nullable: false),
                        VolumetricWeightEnd = c.Int(nullable: false),
                        Rate = c.Int(nullable: false),
                        RegionId = c.Int(nullable: false),
                        ShippingCompanyId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Regions", t => t.RegionId, cascadeDelete: true)
                .ForeignKey("dbo.ShippingCompanies", t => t.ShippingCompanyId, cascadeDelete: true)
                .Index(t => t.RegionId)
                .Index(t => t.ShippingCompanyId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ShippingRates", "ShippingCompanyId", "dbo.ShippingCompanies");
            DropForeignKey("dbo.ShippingRates", "RegionId", "dbo.Regions");
            DropIndex("dbo.ShippingRates", new[] { "ShippingCompanyId" });
            DropIndex("dbo.ShippingRates", new[] { "RegionId" });
            DropTable("dbo.ShippingRates");
        }
    }
}
