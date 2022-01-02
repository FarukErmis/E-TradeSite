namespace E_Trade.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class User : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(maxLength: 255),
                        SurName = c.String(maxLength: 255),
                        Email = c.String(nullable: false, maxLength: 255),
                        UserName = c.String(nullable: false, maxLength: 255),
                        PhoneNumber = c.String(maxLength: 255),
                        Status = c.Int(nullable: false),
                        IsOwner = c.Boolean(),
                        SmsApproved = c.Boolean(),
                        ShopUserLevelId = c.Int(),
                        MemberGroupId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.MemberGroups", t => t.MemberGroupId, cascadeDelete: true)
                .ForeignKey("dbo.ShopUserLevel", t => t.ShopUserLevelId, cascadeDelete: true)
                .Index(t => t.ShopUserLevelId)
                .Index(t => t.MemberGroupId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Users", "ShopUserLevelId", "dbo.ShopUserLevel");
            DropForeignKey("dbo.Users", "MemberGroupId", "dbo.MemberGroups");
            DropIndex("dbo.Users", new[] { "MemberGroupId" });
            DropIndex("dbo.Users", new[] { "ShopUserLevelId" });
            DropTable("dbo.Users");
        }
    }
}
