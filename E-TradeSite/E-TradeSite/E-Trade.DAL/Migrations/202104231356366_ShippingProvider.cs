namespace E_Trade.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ShippingProvider : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ShippingProviders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Code = c.String(nullable: false, maxLength: 64),
                        Name = c.String(nullable: false, maxLength: 255),
                        TrackingUrl = c.String(nullable: false),
                        TrackingFormMethod = c.Int(),
                        Payload = c.String(),
                        ShippingProviderSettingId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ShippingProviderSettings", t => t.ShippingProviderSettingId, cascadeDelete: true)
                .Index(t => t.ShippingProviderSettingId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ShippingProviders", "ShippingProviderSettingId", "dbo.ShippingProviderSettings");
            DropIndex("dbo.ShippingProviders", new[] { "ShippingProviderSettingId" });
            DropTable("dbo.ShippingProviders");
        }
    }
}
