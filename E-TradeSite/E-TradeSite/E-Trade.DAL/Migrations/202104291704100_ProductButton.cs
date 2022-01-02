namespace E_Trade.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ProductButton : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ProductButton",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FastShipping = c.Boolean(),
                        SameDayShipping = c.Boolean(),
                        ThreeDaysDelivery = c.Boolean(),
                        SevenDaysDelivery = c.Boolean(),
                        FiveDaysDelivery = c.Boolean(),
                        FreeShipping = c.Boolean(),
                        DeliveryFromStock = c.Boolean(),
                        PreOrderedProduct = c.Boolean(),
                        LimitedStock = c.Boolean(),
                        AskStock = c.Boolean(nullable: false),
                        CampaignedProduct = c.Boolean(),
                        ProductId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Products", t => t.ProductId)
                .Index(t => t.ProductId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ProductButton", "ProductId", "dbo.Products");
            DropIndex("dbo.ProductButton", new[] { "ProductId" });
            DropTable("dbo.ProductButton");
        }
    }
}
