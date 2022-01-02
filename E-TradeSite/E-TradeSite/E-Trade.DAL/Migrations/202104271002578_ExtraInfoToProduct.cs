namespace E_Trade.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ExtraInfoToProduct : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ExtraInfoToProducts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Value = c.String(nullable: false, maxLength: 255),
                        ExtraInfoId = c.Int(nullable: false),
                        ProductId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ExtraInfos", t => t.ExtraInfoId, cascadeDelete: true)
                .ForeignKey("dbo.Products", t => t.ProductId, cascadeDelete: true)
                .Index(t => t.ExtraInfoId)
                .Index(t => t.ProductId);
            
            AddColumn("dbo.ExtraInfos", "ExtraInfo_Id", c => c.Int());
            AddColumn("dbo.ExtraInfos", "Product_Id", c => c.Int());
            CreateIndex("dbo.ExtraInfos", "ExtraInfo_Id");
            CreateIndex("dbo.ExtraInfos", "Product_Id");
            AddForeignKey("dbo.ExtraInfos", "ExtraInfo_Id", "dbo.ExtraInfos", "Id");
            AddForeignKey("dbo.ExtraInfos", "Product_Id", "dbo.Products", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ExtraInfoToProducts", "ProductId", "dbo.Products");
            DropForeignKey("dbo.ExtraInfoToProducts", "ExtraInfoId", "dbo.ExtraInfos");
            DropForeignKey("dbo.ExtraInfos", "Product_Id", "dbo.Products");
            DropForeignKey("dbo.ExtraInfos", "ExtraInfo_Id", "dbo.ExtraInfos");
            DropIndex("dbo.ExtraInfoToProducts", new[] { "ProductId" });
            DropIndex("dbo.ExtraInfoToProducts", new[] { "ExtraInfoId" });
            DropIndex("dbo.ExtraInfos", new[] { "Product_Id" });
            DropIndex("dbo.ExtraInfos", new[] { "ExtraInfo_Id" });
            DropColumn("dbo.ExtraInfos", "Product_Id");
            DropColumn("dbo.ExtraInfos", "ExtraInfo_Id");
            DropTable("dbo.ExtraInfoToProducts");
        }
    }
}
