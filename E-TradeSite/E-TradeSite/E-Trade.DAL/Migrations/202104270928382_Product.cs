namespace E_Trade.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Product : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 255),
                        Slug = c.String(maxLength: 255),
                        FullName = c.String(nullable: false, maxLength: 255),
                        Sku = c.String(nullable: false, maxLength: 255),
                        Barcode = c.String(maxLength: 255),
                        Price1 = c.Single(nullable: false),
                        Warranty = c.String(),
                        Tax = c.Int(),
                        StockAmount = c.Single(),
                        VolumetricWeight = c.Single(),
                        BuyingPrice = c.Single(),
                        StockTypeLabel = c.Int(),
                        Discount = c.Single(),
                        DiscountType = c.Boolean(),
                        MoneyOrderDiscount = c.Single(),
                        Status = c.Boolean(nullable: false),
                        TaxIncluded = c.Boolean(nullable: false),
                        Distributor = c.String(),
                        IsGifted = c.Boolean(),
                        Gift = c.String(),
                        CustomShippingDisabled = c.Boolean(),
                        CustomShippingCost = c.Single(),
                        MarketPriceDetail = c.String(maxLength: 255),
                        CreatedAt = c.DateTime(precision: 7, storeType: "datetime2"),
                        UpdatedAt = c.DateTime(precision: 7, storeType: "datetime2"),
                        MetaKeyword = c.String(),
                        MetaDescription = c.String(),
                        PageTitle = c.String(maxLength: 255),
                        HasOption = c.Boolean(nullable: false),
                        ShortDetails = c.String(maxLength: 512),
                        SearchKeywords = c.String(maxLength: 255),
                        InstallmentThreshoId = c.String(maxLength: 10),
                        HomeSortOrder = c.Int(),
                        PopularSortOrder = c.Int(),
                        BrandSortOrder = c.Int(),
                        FeaturedSortOrder = c.Int(),
                        CampaignedSortOrder = c.Int(),
                        NewSortOrder = c.Int(),
                        DiscountedSortOrder = c.Int(),
                        BrandId = c.Int(),
                        CurrencyId = c.Int(nullable: false),
                        Parent = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Brands", t => t.BrandId)
                .ForeignKey("dbo.Currencies", t => t.CurrencyId, cascadeDelete: true)
                .ForeignKey("dbo.Products", t => t.Parent)
                .Index(t => t.BrandId)
                .Index(t => t.CurrencyId)
                .Index(t => t.Parent);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Products", "Parent", "dbo.Products");
            DropForeignKey("dbo.Products", "CurrencyId", "dbo.Currencies");
            DropForeignKey("dbo.Products", "BrandId", "dbo.Brands");
            DropIndex("dbo.Products", new[] { "Parent" });
            DropIndex("dbo.Products", new[] { "CurrencyId" });
            DropIndex("dbo.Products", new[] { "BrandId" });
            DropTable("dbo.Products");
        }
    }
}
