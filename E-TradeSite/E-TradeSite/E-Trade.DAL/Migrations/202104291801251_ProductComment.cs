namespace E_Trade.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ProductComment : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ProductComment",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false, maxLength: 255),
                        Content = c.String(nullable: false),
                        Status = c.Boolean(nullable: false),
                        Rank = c.Int(nullable: false),
                        IsAnonymous = c.Boolean(nullable: false),
                        CreatedAt = c.DateTime(precision: 7, storeType: "datetime2"),
                        UpdatedAt = c.DateTime(precision: 7, storeType: "datetime2"),
                        MemberId = c.Int(),
                        ProductId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Members", t => t.MemberId)
                .ForeignKey("dbo.Products", t => t.ProductId)
                .Index(t => t.MemberId)
                .Index(t => t.ProductId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ProductComment", "ProductId", "dbo.Products");
            DropForeignKey("dbo.ProductComment", "MemberId", "dbo.Members");
            DropIndex("dbo.ProductComment", new[] { "ProductId" });
            DropIndex("dbo.ProductComment", new[] { "MemberId" });
            DropTable("dbo.ProductComment");
        }
    }
}
