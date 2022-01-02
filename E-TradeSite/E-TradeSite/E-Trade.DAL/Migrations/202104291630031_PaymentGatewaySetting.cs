namespace E_Trade.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PaymentGatewaySetting : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PaymentGatewaySettings",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        VarKey = c.String(nullable: false, maxLength: 255),
                        VarValue = c.String(nullable: false, maxLength: 255),
                        PaymentGateWayId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.PaymentGateways", t => t.PaymentGateWayId)
                .Index(t => t.PaymentGateWayId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PaymentGatewaySettings", "PaymentGateWayId", "dbo.PaymentGateways");
            DropIndex("dbo.PaymentGatewaySettings", new[] { "PaymentGateWayId" });
            DropTable("dbo.PaymentGatewaySettings");
        }
    }
}
