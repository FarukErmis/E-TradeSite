namespace E_Trade.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Label : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Labels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 255),
                        SortOrder = c.Int(),
                        HasChildren = c.Boolean(),
                        Slug = c.String(maxLength: 255),
                        MetaTitle = c.String(maxLength: 255),
                        MetaKeyWords = c.String(maxLength: 255),
                        MetaDescription = c.String(maxLength: 255),
                        Status = c.Boolean(nullable: false),
                        Parent = c.Int(),
                        CreatedAt = c.DateTime(precision: 7, storeType: "datetime2"),
                        UpdatedAt = c.DateTime(precision: 7, storeType: "datetime2"),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Labels", t => t.Parent)
                .Index(t => t.Parent);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Labels", "Parent", "dbo.Labels");
            DropIndex("dbo.Labels", new[] { "Parent" });
            DropTable("dbo.Labels");
        }
    }
}
