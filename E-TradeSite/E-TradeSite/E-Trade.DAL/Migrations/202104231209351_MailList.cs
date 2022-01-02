namespace E_Trade.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MailList : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MailLists",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 255),
                        Email = c.String(nullable: false, maxLength: 255),
                        LastMailSentDate = c.String(),
                        CreatorIpAddress = c.String(maxLength: 64),
                        CreatedAt = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        UpdatedAt = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        MailListGroupId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.MailListGroup", t => t.MailListGroupId, cascadeDelete: true)
                .Index(t => t.MailListGroupId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.MailLists", "MailListGroupId", "dbo.MailListGroup");
            DropIndex("dbo.MailLists", new[] { "MailListGroupId" });
            DropTable("dbo.MailLists");
        }
    }
}
