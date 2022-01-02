namespace E_Trade.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MemberAddress : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MemberAddresses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 255),
                        Type = c.String(maxLength: 20),
                        FirstName = c.String(maxLength: 255),
                        SurName = c.String(maxLength: 255),
                        Address = c.String(),
                        SubLocation = c.String(maxLength: 255),
                        PhoneNumber = c.String(maxLength: 32),
                        MobilePhoneNumber = c.String(maxLength: 32),
                        TcId = c.String(maxLength: 55),
                        TaxNumber = c.String(maxLength: 255),
                        TaxOffice = c.String(maxLength: 255),
                        InvoiceType = c.Int(),
                        IsEinvoiceUser = c.Boolean(),
                        CreatedAt = c.DateTime(precision: 7, storeType: "datetime2"),
                        UpdatedAt = c.DateTime(precision: 7, storeType: "datetime2"),
                        MemberId = c.Int(),
                        CountryId = c.Int(),
                        LocationId = c.Int(),
                        TownId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Countries", t => t.CountryId)
                .ForeignKey("dbo.Locations", t => t.LocationId)
                .ForeignKey("dbo.Members", t => t.MemberId)
                .ForeignKey("dbo.Towns", t => t.TownId)
                .Index(t => t.MemberId)
                .Index(t => t.CountryId)
                .Index(t => t.LocationId)
                .Index(t => t.TownId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.MemberAddresses", "TownId", "dbo.Towns");
            DropForeignKey("dbo.MemberAddresses", "MemberId", "dbo.Members");
            DropForeignKey("dbo.MemberAddresses", "LocationId", "dbo.Locations");
            DropForeignKey("dbo.MemberAddresses", "CountryId", "dbo.Countries");
            DropIndex("dbo.MemberAddresses", new[] { "TownId" });
            DropIndex("dbo.MemberAddresses", new[] { "LocationId" });
            DropIndex("dbo.MemberAddresses", new[] { "CountryId" });
            DropIndex("dbo.MemberAddresses", new[] { "MemberId" });
            DropTable("dbo.MemberAddresses");
        }
    }
}
