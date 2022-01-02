namespace E_Trade.Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TrialInit : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Brand",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        BrandName = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Product",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CategoryId = c.Int(),
                        BrandId = c.Int(),
                        ProuductName = c.String(),
                        TotalPrice = c.Double(),
                        TrullyPrice = c.Double(),
                        Discount = c.Double(),
                        Rates = c.Double(),
                        IsShippingFree = c.Boolean(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Brand", t => t.BrandId)
                .ForeignKey("dbo.Category", t => t.CategoryId)
                .Index(t => t.CategoryId)
                .Index(t => t.BrandId);
            
            CreateTable(
                "dbo.Category",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CategoryName = c.String(maxLength: 250),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ProductComment",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProductId = c.Int(),
                        Comment = c.String(),
                        Rate = c.Double(),
                        UserName = c.String(maxLength: 50),
                        UserSurname = c.String(maxLength: 50),
                        UserAvatar = c.String(),
                        WritingDate = c.String(),
                        WritingTime = c.String(),
                        ThumbsUp = c.Int(),
                        ThumbsDown = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Product", t => t.ProductId)
                .Index(t => t.ProductId);
            
            CreateTable(
                "dbo.ProductImage",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProductId = c.Int(),
                        Image = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Product", t => t.ProductId)
                .Index(t => t.ProductId);
            
            CreateTable(
                "dbo.ProductProperty",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProductId = c.Int(),
                        VarKey = c.String(maxLength: 250),
                        VarValue = c.String(maxLength: 250),
                        CategoryId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Product", t => t.ProductId)
                .Index(t => t.ProductId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ProductProperty", "ProductId", "dbo.Product");
            DropForeignKey("dbo.ProductImage", "ProductId", "dbo.Product");
            DropForeignKey("dbo.ProductComment", "ProductId", "dbo.Product");
            DropForeignKey("dbo.Product", "CategoryId", "dbo.Category");
            DropForeignKey("dbo.Product", "BrandId", "dbo.Brand");
            DropIndex("dbo.ProductProperty", new[] { "ProductId" });
            DropIndex("dbo.ProductImage", new[] { "ProductId" });
            DropIndex("dbo.ProductComment", new[] { "ProductId" });
            DropIndex("dbo.Product", new[] { "BrandId" });
            DropIndex("dbo.Product", new[] { "CategoryId" });
            DropTable("dbo.ProductProperty");
            DropTable("dbo.ProductImage");
            DropTable("dbo.ProductComment");
            DropTable("dbo.Category");
            DropTable("dbo.Product");
            DropTable("dbo.Brand");
        }
    }
}
