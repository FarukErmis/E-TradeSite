namespace E_Trade.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ProductToCountDown : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ProductToCountDowns",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StartDate = c.DateTime(precision: 7, storeType: "datetime2"),
                        EndDate = c.DateTime(precision: 7, storeType: "datetime2"),
                        ExpireDate = c.DateTime(precision: 7, storeType: "datetime2"),
                        UseCountDown = c.Boolean(nullable: false),
                        ProductId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Products", t => t.ProductId, cascadeDelete: true)
                .Index(t => t.ProductId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ProductToCountDowns", "ProductId", "dbo.Products");
            DropIndex("dbo.ProductToCountDowns", new[] { "ProductId" });
            DropTable("dbo.ProductToCountDowns");
        }
    }
}
