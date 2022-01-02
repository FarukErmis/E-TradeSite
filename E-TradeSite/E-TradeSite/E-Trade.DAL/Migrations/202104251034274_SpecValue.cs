namespace E_Trade.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SpecValue : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SpecValues",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 255),
                        Slug = c.String(maxLength: 255),
                        SortOrder = c.Int(),
                        Logo = c.Int(),
                        Status = c.Boolean(nullable: false),
                        Attachment = c.String(),
                        SpecGroupId = c.Int(nullable: false),
                        CreatedAt = c.DateTime(precision: 7, storeType: "datetime2"),
                        UpdatedAt = c.DateTime(precision: 7, storeType: "datetime2"),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.SpecGroup", t => t.SpecGroupId, cascadeDelete: true)
                .Index(t => t.SpecGroupId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SpecValues", "SpecGroupId", "dbo.SpecGroup");
            DropIndex("dbo.SpecValues", new[] { "SpecGroupId" });
            DropTable("dbo.SpecValues");
        }
    }
}
