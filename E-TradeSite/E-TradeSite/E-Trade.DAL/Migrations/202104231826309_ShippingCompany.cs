namespace E_Trade.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ShippingCompany : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ShippingCompanies",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 255),
                        Status = c.Boolean(nullable: false),
                        ExtraPrice = c.Int(),
                        ExtraVolumetricWeightPrice = c.Int(),
                        FreeShipmentOrderPrice = c.Int(),
                        FreeShipmentWeightLimit = c.Int(),
                        SortOrder = c.Int(),
                        CompanyCode = c.String(),
                        PaymentType = c.Int(),
                        ShippingProviderId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ShippingProviders", t => t.ShippingProviderId, cascadeDelete: true)
                .Index(t => t.ShippingProviderId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ShippingCompanies", "ShippingProviderId", "dbo.ShippingProviders");
            DropIndex("dbo.ShippingCompanies", new[] { "ShippingProviderId" });
            DropTable("dbo.ShippingCompanies");
        }
    }
}
