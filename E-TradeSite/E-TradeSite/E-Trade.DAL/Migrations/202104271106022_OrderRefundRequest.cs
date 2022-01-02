namespace E_Trade.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class OrderRefundRequest : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.OrderRefundRequests",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Code = c.String(nullable: false, maxLength: 255),
                        Status = c.Int(nullable: false),
                        Fee = c.Single(nullable: false),
                        CancellationReason = c.String(maxLength: 512),
                        CreatedAt = c.DateTime(precision: 7, storeType: "datetime2"),
                        UpdatedAt = c.DateTime(precision: 7, storeType: "datetime2"),
                        MemberId = c.Int(nullable: false),
                        OrderId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Members", t => t.MemberId, cascadeDelete: true)
                .ForeignKey("dbo.Orders", t => t.OrderId)
                .Index(t => t.MemberId)
                .Index(t => t.OrderId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.OrderRefundRequests", "OrderId", "dbo.Orders");
            DropForeignKey("dbo.OrderRefundRequests", "MemberId", "dbo.Members");
            DropIndex("dbo.OrderRefundRequests", new[] { "OrderId" });
            DropIndex("dbo.OrderRefundRequests", new[] { "MemberId" });
            DropTable("dbo.OrderRefundRequests");
        }
    }
}
