namespace E_Trade.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PaymentProvider : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PaymentProviders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Code = c.String(nullable: false, maxLength: 255),
                        Name = c.String(nullable: false, maxLength: 255),
                        Status = c.Boolean(nullable: false),
                        PaymentId = c.Int(nullable: false),
                        PaymentProviderSettingId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Payments", t => t.PaymentId, cascadeDelete: true)
                .ForeignKey("dbo.PaymentProviderSettings", t => t.PaymentProviderSettingId)
                .Index(t => t.PaymentId)
                .Index(t => t.PaymentProviderSettingId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PaymentProviders", "PaymentProviderSettingId", "dbo.PaymentProviderSettings");
            DropForeignKey("dbo.PaymentProviders", "PaymentId", "dbo.Payments");
            DropIndex("dbo.PaymentProviders", new[] { "PaymentProviderSettingId" });
            DropIndex("dbo.PaymentProviders", new[] { "PaymentId" });
            DropTable("dbo.PaymentProviders");
        }
    }
}
