namespace E_Trade.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ShippingProviderSetting : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ShippingProviderSettings",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        VarKey = c.String(nullable: false, maxLength: 255),
                        VarValue = c.String(nullable: false, maxLength: 255),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ShippingProviderSettings");
        }
    }
}
