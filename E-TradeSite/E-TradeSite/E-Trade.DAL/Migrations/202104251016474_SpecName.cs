namespace E_Trade.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SpecName : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SpecNames",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 255),
                        Slug = c.String(maxLength: 255),
                        ChoiceType = c.Int(nullable: false),
                        SortOrder = c.Int(),
                        Status = c.Boolean(nullable: false),
                        SpecGroupId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.SpecGroup", t => t.SpecGroupId, cascadeDelete: true)
                .Index(t => t.SpecGroupId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SpecNames", "SpecGroupId", "dbo.SpecGroup");
            DropIndex("dbo.SpecNames", new[] { "SpecGroupId" });
            DropTable("dbo.SpecNames");
        }
    }
}
