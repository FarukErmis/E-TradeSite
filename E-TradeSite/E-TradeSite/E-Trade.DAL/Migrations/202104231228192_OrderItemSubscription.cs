namespace E_Trade.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class OrderItemSubscription : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.OrderItemSubscription",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.OrderItemSubscription");
        }
    }
}
