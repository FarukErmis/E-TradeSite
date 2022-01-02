namespace E_Trade.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Order : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CustomerFirstName = c.String(nullable: false, maxLength: 255),
                        CustomerSurname = c.String(nullable: false, maxLength: 255),
                        CustomerEmail = c.String(nullable: false, maxLength: 255),
                        CustomerPhone = c.String(maxLength: 32),
                        PaymentTypeName = c.String(nullable: false, maxLength: 128),
                        PaymentProviderCode = c.String(nullable: false, maxLength: 128),
                        PaymentProviderName = c.String(nullable: false, maxLength: 128),
                        PaymentGatewayCode = c.String(nullable: false, maxLength: 128),
                        PaymentGatewayName = c.String(nullable: false, maxLength: 128),
                        BankName = c.String(maxLength: 128),
                        ClientIp = c.String(nullable: false, maxLength: 32),
                        UserAgent = c.String(maxLength: 1024),
                        Currency = c.String(nullable: false, maxLength: 32),
                        CurrencyRates = c.String(nullable: false),
                        Amount = c.Single(nullable: false),
                        CouponDiscount = c.Single(nullable: false),
                        TaxAmount = c.Single(nullable: false),
                        PromotionDiscount = c.Single(nullable: false),
                        GeneralAmount = c.Single(nullable: false),
                        ShippingAmount = c.Single(nullable: false),
                        AdditionalServiceAmount = c.Single(nullable: false),
                        FinalAmount = c.Single(nullable: false),
                        SumOfGainedPoints = c.Single(nullable: false),
                        Installment = c.Single(),
                        InstallmentRate = c.Int(),
                        ExtraInstallment = c.Int(),
                        TransactionId = c.String(),
                        HasUserNote = c.Boolean(nullable: false),
                        Status = c.Int(nullable: false),
                        PaymentStatus = c.Int(nullable: false),
                        ErrorMessage = c.String(),
                        DeviceType = c.Int(nullable: false),
                        Referrer = c.String(),
                        InvoicePrintCount = c.Int(),
                        UseGiftPackage = c.Boolean(nullable: false),
                        GiftNote = c.String(),
                        MemberGroupName = c.String(maxLength: 255),
                        UsePromotion = c.Boolean(nullable: false),
                        ShippingProviderCode = c.String(maxLength: 128),
                        ShippingProviderName = c.String(maxLength: 128),
                        ShippingCompanyName = c.String(maxLength: 128),
                        ShippingPaymentType = c.Int(),
                        ShippingTrackingCode = c.String(maxLength: 255),
                        Source = c.String(nullable: false, maxLength: 255),
                        CreatedAt = c.DateTime(precision: 7, storeType: "datetime2"),
                        UpdatedAt = c.DateTime(precision: 7, storeType: "datetime2"),
                        MailListId = c.Int(),
                        MemberId = c.Int(),
                        ShippingAddressId = c.Int(),
                        BillingAddressId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.BillingAddresses", t => t.BillingAddressId)
                .ForeignKey("dbo.MailLists", t => t.MailListId)
                .ForeignKey("dbo.Members", t => t.MemberId)
                .ForeignKey("dbo.ShippingAddresses", t => t.ShippingAddressId)
                .Index(t => t.MailListId)
                .Index(t => t.MemberId)
                .Index(t => t.ShippingAddressId)
                .Index(t => t.BillingAddressId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Orders", "ShippingAddressId", "dbo.ShippingAddresses");
            DropForeignKey("dbo.Orders", "MemberId", "dbo.Members");
            DropForeignKey("dbo.Orders", "MailListId", "dbo.MailLists");
            DropForeignKey("dbo.Orders", "BillingAddressId", "dbo.BillingAddresses");
            DropIndex("dbo.Orders", new[] { "BillingAddressId" });
            DropIndex("dbo.Orders", new[] { "ShippingAddressId" });
            DropIndex("dbo.Orders", new[] { "MemberId" });
            DropIndex("dbo.Orders", new[] { "MailListId" });
            DropTable("dbo.Orders");
        }
    }
}
