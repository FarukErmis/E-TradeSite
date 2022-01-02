namespace E_Trade.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PurchaseLimitationItem : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PurchaseLimitationItems",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        BrandId = c.Int(),
                        CategoryId = c.Int(),
                        PurchaseLimitationId = c.Int(),
                        MemberGroupId = c.Int(),
                        ProductId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Brands", t => t.BrandId)
                .ForeignKey("dbo.Categories", t => t.CategoryId)
                .ForeignKey("dbo.MemberGroups", t => t.MemberGroupId)
                .ForeignKey("dbo.Products", t => t.ProductId)
                .ForeignKey("dbo.PurchaseLimitations", t => t.PurchaseLimitationId)
                .Index(t => t.BrandId)
                .Index(t => t.CategoryId)
                .Index(t => t.PurchaseLimitationId)
                .Index(t => t.MemberGroupId)
                .Index(t => t.ProductId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PurchaseLimitationItems", "PurchaseLimitationId", "dbo.PurchaseLimitations");
            DropForeignKey("dbo.PurchaseLimitationItems", "ProductId", "dbo.Products");
            DropForeignKey("dbo.PurchaseLimitationItems", "MemberGroupId", "dbo.MemberGroups");
            DropForeignKey("dbo.PurchaseLimitationItems", "CategoryId", "dbo.Categories");
            DropForeignKey("dbo.PurchaseLimitationItems", "BrandId", "dbo.Brands");
            DropIndex("dbo.PurchaseLimitationItems", new[] { "ProductId" });
            DropIndex("dbo.PurchaseLimitationItems", new[] { "MemberGroupId" });
            DropIndex("dbo.PurchaseLimitationItems", new[] { "PurchaseLimitationId" });
            DropIndex("dbo.PurchaseLimitationItems", new[] { "CategoryId" });
            DropIndex("dbo.PurchaseLimitationItems", new[] { "BrandId" });
            DropTable("dbo.PurchaseLimitationItems");
        }
    }
}
