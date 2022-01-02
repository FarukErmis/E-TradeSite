namespace E_Trade.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PreOrderInfo : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PreOrderInfos",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    SessionId = c.String(nullable: false, maxLength: 255),
                    CustomerFirstName = c.String(maxLength: 255),
                    CustomerSurName = c.String(maxLength: 255),
                    CustomerEmail = c.String(maxLength: 255),
                    ShippingFirstName = c.String(nullable: false, maxLength: 255),
                    ShippingSurName = c.String(nullable: false, maxLength: 255),
                    ShippingAddress = c.String(nullable: false),
                    ShippingPhoneNumber = c.String(nullable: false, maxLength: 32),
                    ShippingMobilePhoneNumber = c.String(nullable: false, maxLength: 32),
                    ShippingLocationName = c.String(nullable: false, maxLength: 128),
                    ShippingTown = c.String(nullable: false, maxLength: 128),
                    DifferentBillingAddress = c.Boolean(),
                    BillingFirstName = c.String(nullable: false, maxLength: 255),
                    BillingSurName = c.String(nullable: false, maxLength: 255),
                    BillingAddress = c.String(nullable: false),
                    BillingPhoneNumber = c.String(nullable: false, maxLength: 32),
                    BillingMobilePhoneNumber = c.String(nullable: false, maxLength: 32),
                    BillingLocationName = c.String(nullable: false, maxLength: 128),
                    BillingTown = c.String(nullable: false, maxLength: 128),
                    BillingInvoiceType = c.Int(nullable: false),
                    BillingIdentityRegistrationNumber = c.String(maxLength: 32),
                    BillingTaxOffice = c.String(maxLength: 255),
                    BillingTaxNo = c.String(maxLength: 128),
                    IsEinvoiceUser = c.Boolean(),
                    UseGiftPackage = c.Boolean(),
                    GiftNote = c.String(),
                    ImageFile = c.String(maxLength: 128),
                    DeliveryDate = c.DateTime(precision: 7, storeType: "datetime2"),
                    DeliveryTime = c.DateTime(precision: 7, storeType: "datetime2"),
                    CreatedAt = c.DateTime(precision: 7, storeType: "datetime2"),
                    UpdatedAt = c.DateTime(precision: 7, storeType: "datetime2"),
                    BillingCountryId = c.Int(nullable: false),
                    BillingLocationId = c.Int(),
                    ShippingCompanyId = c.Int(nullable: false),
                    ShippingCountryId = c.Int(),
                    ShippingLocationId = c.Int(),
                    MemberShippingAddressId = c.Int(),
                    MemberBillingAddressId = c.Int()
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Countries", t => t.BillingCountryId, cascadeDelete: true)
                .ForeignKey("dbo.Countries", t => t.ShippingCountryId)
                .ForeignKey("dbo.Locations", t => t.BillingLocationId)
                .ForeignKey("dbo.Locations", t => t.ShippingLocationId)
                .ForeignKey("dbo.MemberAddresses", t => t.MemberShippingAddressId)
                .ForeignKey("dbo.MemberAddresses", t => t.MemberBillingAddressId)
                .ForeignKey("dbo.ShippingCompanies", t => t.ShippingCompanyId, cascadeDelete: true)
                .Index(t => t.BillingCountryId)
                .Index(t => t.BillingLocationId)
                .Index(t => t.ShippingCompanyId)
                .Index(t => t.ShippingCountryId)
                .Index(t => t.ShippingLocationId)
                .Index(t => t.MemberShippingAddressId)
                .Index(t => t.MemberBillingAddressId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PreOrderInfos", "ShippingCompanyId", "dbo.ShippingCompanies");
            DropForeignKey("dbo.PreOrderInfos", "MemberBillingAddressId", "dbo.MemberAddresses");
            DropForeignKey("dbo.PreOrderInfos", "MemberShippingAddressId", "dbo.MemberAddresses");
            DropForeignKey("dbo.PreOrderInfos", "ShippingLocationId", "dbo.Locations");
            DropForeignKey("dbo.PreOrderInfos", "BillingLocationId", "dbo.Locations");
            DropForeignKey("dbo.PreOrderInfos", "ShippingCountryId", "dbo.Countries");
            DropForeignKey("dbo.PreOrderInfos", "BillingCountryId", "dbo.Countries");
            DropIndex("dbo.PreOrderInfos", new[] { "MemberBillingAddressId" });
            DropIndex("dbo.PreOrderInfos", new[] { "MemberShippingAddressId" });
            DropIndex("dbo.PreOrderInfos", new[] { "ShippingLocationId" });
            DropIndex("dbo.PreOrderInfos", new[] { "ShippingCountryId" });
            DropIndex("dbo.PreOrderInfos", new[] { "ShippingCompanyId" });
            DropIndex("dbo.PreOrderInfos", new[] { "BillingLocationId" });
            DropIndex("dbo.PreOrderInfos", new[] { "BillingCountryId" });
            DropTable("dbo.PreOrderInfos");
        }
    }
}
