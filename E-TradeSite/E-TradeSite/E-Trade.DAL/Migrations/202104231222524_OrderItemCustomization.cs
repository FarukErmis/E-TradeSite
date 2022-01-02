namespace E_Trade.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class OrderItemCustomization : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.OrderItemCustomization",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        GroupId = c.Int(),
                        GroupName = c.String(maxLength: 255),
                        SortOrder = c.Int(),
                        FieldId = c.Int(),
                        FieldType = c.String(maxLength: 64),
                        FieldName = c.String(maxLength: 255),
                        FieldValue = c.String(),
                        CartItemAttributed = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.OrderItemCustomization");
        }
    }
}
