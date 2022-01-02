namespace E_Trade.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Category : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 255),
                        Slug = c.String(maxLength: 255),
                        SortOrder = c.Int(),
                        Status = c.Boolean(nullable: false),
                        DistributorCode = c.String(maxLength: 255),
                        Percent = c.Byte(),
                        ImageFile = c.String(maxLength: 255),
                        Distributor = c.String(),
                        DisplayShowContent = c.Boolean(nullable: false),
                        ShowcaseContent = c.String(),
                        ShowcaseContentDisplayType = c.Int(nullable: false),
                        DisplayShowcaseFooterContent = c.Int(nullable: false),
                        ShowcaseFooterContent = c.String(),
                        ShowcaseFooterContentDisplayType = c.Int(nullable: false),
                        HasChildren = c.Boolean(),
                        MetaKeyWords = c.String(),
                        MetaDescription = c.String(),
                        PageTitle = c.String(),
                        Parent = c.Int(),
                        Attachment = c.String(),
                        CreatedAt = c.DateTime(precision: 7, storeType: "datetime2"),
                        UpdatedAt = c.DateTime(precision: 7, storeType: "datetime2"),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categories", t => t.Parent)
                .Index(t => t.Parent);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Categories", "Parent", "dbo.Categories");
            DropIndex("dbo.Categories", new[] { "Parent" });
            DropTable("dbo.Categories");
        }
    }
}
