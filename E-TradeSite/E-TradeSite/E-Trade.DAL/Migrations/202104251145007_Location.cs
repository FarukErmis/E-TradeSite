namespace E_Trade.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Location : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                 "dbo.Locations",
                 c => new
                 {
                     Id = c.Int(nullable: false, identity: true),
                     Name = c.String(nullable: false, maxLength: 255),
                     Status = c.Boolean(nullable: false),
                     Predefined = c.Boolean(),
                     CountryId = c.Int(),
                     RegionId = c.Int(),

                 })
                 .PrimaryKey(t => t.Id)
                 .ForeignKey("dbo.Countries", t => t.CountryId)
                 .ForeignKey("dbo.Regions", t => t.RegionId)
                 .Index(t => t.CountryId)
                 .Index(t => t.RegionId);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Locations", "CountryId", "dbo.Countries");
            DropForeignKey("dbo.Locations", "RegionId", "dbo.Regions");
            DropIndex("dbo.Locations", new[] { "CountryId" });
            DropIndex("dbo.Locations", new[] { "RegionId" });
            DropTable("dbo.Locations");
        }
    }
}
