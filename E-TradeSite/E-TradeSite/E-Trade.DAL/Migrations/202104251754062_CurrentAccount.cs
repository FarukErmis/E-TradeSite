namespace E_Trade.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CurrentAccount : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CurrentAccounts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Code = c.String(maxLength: 255),
                        Title = c.String(nullable: false, maxLength: 255),
                        Balance = c.Single(nullable: false),
                        RiskLimit = c.Single(nullable: false),
                        CreatedAt = c.DateTime(precision: 7, storeType: "datetime2"),
                        UpdatedAt = c.DateTime(precision: 7, storeType: "datetime2"),
                        MemberId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Members", t => t.MemberId, cascadeDelete: true)
                .Index(t => t.MemberId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CurrentAccounts", "MemberId", "dbo.Members");
            DropIndex("dbo.CurrentAccounts", new[] { "MemberId" });
            DropTable("dbo.CurrentAccounts");
        }
    }
}
