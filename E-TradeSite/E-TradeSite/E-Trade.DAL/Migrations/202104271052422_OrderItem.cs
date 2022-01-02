namespace E_Trade.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class OrderItem : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.OrderItems",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProductName = c.String(nullable: false, maxLength: 255),
                        ProductSku = c.String(nullable: false, maxLength: 255),
                        ProductBarcode = c.String(maxLength: 255),
                        ProductPrice = c.Single(nullable: false),
                        ProductCurrency = c.String(nullable: false, maxLength: 255),
                        ProductQuantity = c.Single(nullable: false),
                        ProductTax = c.Int(nullable: false),
                        ProductDiscount = c.Single(nullable: false),
                        ProductMoneyOrderDiscount = c.Single(nullable: false),
                        ProductWeight = c.Single(nullable: false),
                        ProductStockTypeLabel = c.Int(nullable: false),
                        IsProductPromotioned = c.Boolean(nullable: false),
                        Discount = c.Single(nullable: false),
                        OrderId = c.Int(),
                        ProductId = c.Int(),
                        OrderItemCustomazitionId = c.Int(),
                        OrderItemSubscriptionId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Orders", t => t.OrderId)
                .ForeignKey("dbo.OrderItemCustomization", t => t.OrderItemCustomazitionId)
                .ForeignKey("dbo.OrderItemSubscription", t => t.OrderItemSubscriptionId)
                .ForeignKey("dbo.Products", t => t.ProductId)
                .Index(t => t.OrderId)
                .Index(t => t.ProductId)
                .Index(t => t.OrderItemCustomazitionId)
                .Index(t => t.OrderItemSubscriptionId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.OrderItems", "ProductId", "dbo.Products");
            DropForeignKey("dbo.OrderItems", "OrderItemSubscriptionId", "dbo.OrderItemSubscription");
            DropForeignKey("dbo.OrderItems", "OrderItemCustomazitionId", "dbo.OrderItemCustomization");
            DropForeignKey("dbo.OrderItems", "OrderId", "dbo.Orders");
            DropIndex("dbo.OrderItems", new[] { "OrderItemSubscriptionId" });
            DropIndex("dbo.OrderItems", new[] { "OrderItemCustomazitionId" });
            DropIndex("dbo.OrderItems", new[] { "ProductId" });
            DropIndex("dbo.OrderItems", new[] { "OrderId" });
            DropTable("dbo.OrderItems");
        }
    }
}
