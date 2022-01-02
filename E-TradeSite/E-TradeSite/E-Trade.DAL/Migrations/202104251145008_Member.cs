namespace E_Trade.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Member : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Members",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    FirstName = c.String(nullable: false, maxLength: 255),
                    SurName = c.String(nullable: false, maxLength: 255),
                    Email = c.String(nullable: false, maxLength: 255),
                    Gender = c.Int(),
                    BirthDate = c.String(),
                    PhoneNumber = c.String(maxLength: 255),
                    MobilePhoneNumber = c.String(nullable: false, maxLength: 255),
                    OtherLocation = c.String(maxLength: 255),
                    Address = c.String(maxLength: 65535),
                    TaxNumber = c.String(maxLength: 255),
                    TcId = c.String(maxLength: 255),
                    Status = c.Int(nullable: false),
                    LastLoginDate = c.DateTime(precision: 7, storeType: "datetime2"),
                    CreatedAt = c.DateTime(precision: 7, storeType: "datetime2"),
                    UpdatedAt = c.DateTime(precision: 7, storeType: "datetime2"),
                    ZipCode = c.String(maxLength: 50),
                    CommercialName = c.String(maxLength: 255),
                    TaxOffice = c.String(maxLength: 255),
                    LastMailSentDate = c.DateTime(precision: 7, storeType: "datetime2"),
                    LastIp = c.String(maxLength: 255),
                    GainedPointAmount = c.Single(),
                    SpentPointAmount = c.Single(),
                    AllowedToCampaigns = c.Boolean(nullable: false),
                    IysStatus = c.Int(nullable: false),
                    allowedToCampaignsUpdatedAt = c.DateTime(precision: 7, storeType: "datetime2"),
                    referredMemberGainedPointAmount = c.Single(),
                    district = c.String(maxLength: 255),
                    DeviceType = c.String(nullable: false, maxLength: 255),
                    DeviceInfo = c.String(maxLength: 65535),
                    CountryId = c.Int(),
                    LocationId = c.Int(),
                    MemberGroupId = c.Int(),
                    ReferredMember = c.Int(),
                })
                .PrimaryKey(t => t.Id)
                 .ForeignKey("dbo.Countries", t => t.CountryId)
                 .ForeignKey("dbo.Locations", t => t.LocationId)
                 .ForeignKey("dbo.MemberGroups", t => t.MemberGroupId)
                 .ForeignKey("dbo.Members", t => t.ReferredMember)
                 .Index(t => t.CountryId)
                 .Index(t => t.LocationId)
                 .Index(t => t.MemberGroupId)
                 .Index(t => t.ReferredMember);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Members", "CountryId", "dbo.Countries");
            DropForeignKey("dbo.Members", "LocationId", "dbo.Locations");
            DropForeignKey("dbo.Members", "MemberGroupId", "dbo.MemberGroups");
            DropForeignKey("dbo.Members", "ReferredMember", "dbo.Members");
            DropIndex("dbo.Members", new[] { "CountryId" });
            DropIndex("dbo.Members", new[] { "LocationId" });
            DropIndex("dbo.Members", new[] { "MemberGroupId" });
            DropIndex("dbo.Members", new[] { "ReferredMember" });
            DropTable("dbo.Members");
        }
    }
}
