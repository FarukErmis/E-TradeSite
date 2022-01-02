namespace E_Trade.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PaymentProviderSetting : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PaymentProviderSettings",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        VarKey = c.String(nullable: false),
                        VarValue = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.PaymentProviderSettings");
        }
    }
}
