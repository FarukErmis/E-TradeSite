namespace E_Trade.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Town : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Towns",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 255),
                        Status = c.Boolean(nullable: false),
                        LocationId = c.Int(),
                        TownGroupId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Locations", t => t.LocationId)
                .ForeignKey("dbo.TownGroup", t => t.TownGroupId, cascadeDelete: true)
                .Index(t => t.LocationId)
                .Index(t => t.TownGroupId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Towns", "TownGroupId", "dbo.TownGroup");
            DropForeignKey("dbo.Towns", "LocationId", "dbo.Locations");
            DropIndex("dbo.Towns", new[] { "TownGroupId" });
            DropIndex("dbo.Towns", new[] { "LocationId" });
            DropTable("dbo.Towns");
        }
    }
}
