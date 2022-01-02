namespace E_Trade.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class VaryantToProduct : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.VaryantToProducts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ParentProductId = c.Int(nullable: false),
                        OptionGroupId = c.Int(nullable: false),
                        OptionId = c.Int(nullable: false),
                        ProductId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.OptionGroup", t => t.OptionGroupId, cascadeDelete: true)
                .ForeignKey("dbo.Options", t => t.OptionId, cascadeDelete: true)
                .ForeignKey("dbo.Products", t => t.ProductId, cascadeDelete: true)
                .Index(t => t.OptionGroupId)
                .Index(t => t.OptionId)
                .Index(t => t.ProductId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.VaryantToProducts", "ProductId", "dbo.Products");
            DropForeignKey("dbo.VaryantToProducts", "OptionId", "dbo.Options");
            DropForeignKey("dbo.VaryantToProducts", "OptionGroupId", "dbo.OptionGroup");
            DropIndex("dbo.VaryantToProducts", new[] { "ProductId" });
            DropIndex("dbo.VaryantToProducts", new[] { "OptionId" });
            DropIndex("dbo.VaryantToProducts", new[] { "OptionGroupId" });
            DropTable("dbo.VaryantToProducts");
        }
    }
}
