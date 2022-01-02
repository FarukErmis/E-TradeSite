using E_Trade.Model.Entity;
using E_Trade.Model.Map;
using System.Data.Entity;

namespace E_Trade.DAL.Context
{
    public class DataContext : DbContext
    {
        public DataContext() :
            base("Name=E-TradeSite")
        {

        }

        public DbSet<Brand> Brands { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Currency> Currencies { get; set; }
        public DbSet<Distributor> Distributors { get; set; }
        public DbSet<Error> Errors { get; set; }
        public DbSet<ExtraInfo> ExtraInfos { get; set; }
        public DbSet<Label> Labels { get; set; }
        public DbSet<MailListGroup> MailListGroups { get; set; }
        public DbSet<MailList> MailLists { get; set; }
        public DbSet<MemberGroup> MemberGroups { get; set; }
        public DbSet<OrderItemCustomization> OrderItemCustomizations { get; set; }
        public DbSet<OrderItemSubscription> OrderItemSubscriptions { get; set; }
        public DbSet<PaymentProviderSetting> PaymentProviderSettings { get; set; }
        public DbSet<PaymentType> PaymentTypes { get; set; }
        public DbSet<Preference> PPreferences { get; set; }
        public DbSet<PurchaseLimitation> PurchaseLimitations { get; set; }
        public DbSet<QuickCart> QuickCarts { get; set; }
        public DbSet<SelectionGroup> SelectionGroups { get; set; }
        public DbSet<Selection> Selections { get; set; }
        public DbSet<ShippingProviderSetting> ShippingProviderSettings { get; set; }
        public DbSet<ShippingProvider> ShippingProviders { get; set; }
        public DbSet<ShippingCompany> ShippingCompanies { get; set; }
        public DbSet<ShopCampaign> ShopCampaigns { get; set; }
        public DbSet<ShopToken> ShopTokens { get; set; }
        public DbSet<ShopUserLevel> ShopUserLevels { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<Theme> Themes { get; set; }
        public DbSet<TownGroup> TownGroups { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Options> Options { get; set; }
        public DbSet<OptionGroup> OptionGroups { get; set; }
        public DbSet<SpecGroup> SpecGroups { get; set; }
        public DbSet<SpecName> SpecNames { get; set; }
        public DbSet<SpecValue> SpecValues { get; set; }
        public DbSet<Region> Regions { get; set; }
        public DbSet<ShippingRate> ShippingRates { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Member> Members { get; set; }
        public DbSet<CurrentAccount> CurrentAccounts { get; set; }
        public DbSet<Town> Towns { get; set; }
        public DbSet<OrderAddress> OrderAddresses { get; set; }
        public DbSet<ShippingAddress> ShippingAddresses { get; set; }
        public DbSet<BillingAddress> BillingAddresses { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<MemberAddress> MemberAddresses { get; set; }
        public DbSet<PreOrderInfo> PreOrderInfos { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<CartItem> CartItems { get; set; }
        public DbSet<DistributorToProduct> DistributorToProducts { get; set; }
        public DbSet<ExtraInfoToProduct> ExtraInfoToProducts { get; set; }
        public DbSet<FavouritedProduct> FavouritedProducts { get; set; }
        public DbSet<LabelToProduct> LabelToProducts { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<OrderRefundRequest> OrderRefundRequests { get; set; }
        public DbSet<OrderRefundRequestItem> OrderRefundRequestItems { get; set; }
        public DbSet<OrderUserNote> OrderUserNotes { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<PaymentProvider> PaymentProviders { get; set; }
        public DbSet<PaymentGateway> PaymentGateways { get; set; }
        public DbSet<PaymentGatewaySetting> PaymentGatewaySettings { get; set; }
        public DbSet<InstallmentRate> InstallmentRates { get; set; }
        public DbSet<ProductButton> ProductButtons { get; set; }
        public DbSet<ProductComment> ProductComments { get; set; }
        public DbSet<ProductDetail> ProductDetails { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }
        public DbSet<ProductPrice> ProductPrices { get; set; }
        public DbSet<ProductProtection> ProductProtections { get; set; }
        public DbSet<ProductSpecialInfo> ProductSpecialInfos { get; set; }
        public DbSet<ProductToCategory> ProductToCategories { get; set; }
        public DbSet<ProductToCountDown> ProductToCountDowns { get; set; }
        public DbSet<ProductToTag> ProductToTags { get; set; }
        public DbSet<PurchaseLimitationItem> PurchaseLimitationItems { get; set; }
        public DbSet<SelectionToProduct> SelectionToProducts { get; set; }
        public DbSet<Shipment> Shipments { get; set; }
        public DbSet<ShipmentItem> ShipmentItems { get; set; }
        public DbSet<SpecToProduct> SpecToProducts { get; set; }
        public DbSet<VaryantToProduct> VaryantToProducts { get; set; }



        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Burada da normalde yaptığımız mapleri yapmayıp Model'de her sınıfın kendi maplerini oluşturuyoruz. Daha sonra da  miras aldığı configuration sayesinde tek bir satır kod ile mapleme yapıyoruz. Bu sayede DataContext'de hem kod kalabalığını hemde oluşabilecek herhangi bir karışıklığın önüne geçmiş oluyoruz.

            //modelBuilder.Configurations.Add()

            modelBuilder.Configurations.Add(new BrandMap());
            modelBuilder.Configurations.Add(new CategoryMap());
            modelBuilder.Configurations.Add(new CountryMap());
            modelBuilder.Configurations.Add(new CurrencyMap());
            modelBuilder.Configurations.Add(new DistributorMap());
            modelBuilder.Configurations.Add(new ErrorMap());
            modelBuilder.Configurations.Add(new ExtraInfoMap());
            modelBuilder.Configurations.Add(new LabelMap());
            modelBuilder.Configurations.Add(new MailListGroupMap());
            modelBuilder.Configurations.Add(new MailListMap());
            modelBuilder.Configurations.Add(new MemberGroupMap());
            modelBuilder.Configurations.Add(new OrderItemCustomizationMap());
            modelBuilder.Configurations.Add(new OrderItemSubscriptionMap());
            modelBuilder.Configurations.Add(new PaymentProviderSettingMap());
            modelBuilder.Configurations.Add(new PaymentTypeMap());
            modelBuilder.Configurations.Add(new PreferenceMap());
            modelBuilder.Configurations.Add(new PurchaseLimitationMap());
            modelBuilder.Configurations.Add(new QuickCartMap());
            modelBuilder.Configurations.Add(new SelectionGroupMap());
            modelBuilder.Configurations.Add(new SelectionMap());
            modelBuilder.Configurations.Add(new ShippingProviderSettingMap());
            modelBuilder.Configurations.Add(new ShippingProviderMap());
            modelBuilder.Configurations.Add(new ShippingCompanyMap());
            modelBuilder.Configurations.Add(new ShopCampaignMap());
            modelBuilder.Configurations.Add(new ShopTokenMap());
            modelBuilder.Configurations.Add(new ShopUserLevelMap());
            modelBuilder.Configurations.Add(new TagMap());
            modelBuilder.Configurations.Add(new ThemeMap());
            modelBuilder.Configurations.Add(new TownGroupMap());
            modelBuilder.Configurations.Add(new UserMap());
            modelBuilder.Configurations.Add(new OptionsMap());
            modelBuilder.Configurations.Add(new OptionGroupMap());
            modelBuilder.Configurations.Add(new SpecGroupMap());
            modelBuilder.Configurations.Add(new SpecNameMap());
            modelBuilder.Configurations.Add(new SpecValueMap());
            modelBuilder.Configurations.Add(new RegionMap());
            modelBuilder.Configurations.Add(new ShippingRateMap());
            modelBuilder.Configurations.Add(new MemberMap());
            modelBuilder.Configurations.Add(new CurrentAccountMap());
            modelBuilder.Configurations.Add(new TownMap());
            modelBuilder.Configurations.Add(new OrderAddressMap());
            modelBuilder.Configurations.Add(new ShippingAddressMap());
            modelBuilder.Configurations.Add(new BillingAddressMap());
            modelBuilder.Configurations.Add(new OrderMap());
            modelBuilder.Configurations.Add(new MemberAddressMap());
            modelBuilder.Configurations.Add(new PreOrderInfoMap());
            modelBuilder.Configurations.Add(new CartMap());
            modelBuilder.Configurations.Add(new ProductMap());
            modelBuilder.Configurations.Add(new CartItemMap());
            modelBuilder.Configurations.Add(new DistributorToProductMap());
            modelBuilder.Configurations.Add(new ExtraInfoToProductMap());
            modelBuilder.Configurations.Add(new FavouritedProductMap());
            modelBuilder.Configurations.Add(new LabelToProductMap());
            modelBuilder.Configurations.Add(new OrderDetailMap());
            modelBuilder.Configurations.Add(new OrderItemMap());
            modelBuilder.Configurations.Add(new OrderRefundRequestMap());
            modelBuilder.Configurations.Add(new OrderRefundRequestItemMap());
            modelBuilder.Configurations.Add(new OrderUserNoteMap());
            modelBuilder.Configurations.Add(new PaymentMap());
            modelBuilder.Configurations.Add(new LocationMap());
            modelBuilder.Configurations.Add(new PaymentProviderMap());
            modelBuilder.Configurations.Add(new PaymentGatewayMap());
            modelBuilder.Configurations.Add(new PaymentGatewaySettingMap());
            modelBuilder.Configurations.Add(new InstallmentRateMap());
            modelBuilder.Configurations.Add(new ProductButtonMap());
            modelBuilder.Configurations.Add(new ProductCommentMap());
            modelBuilder.Configurations.Add(new ProductDetailMap());
            modelBuilder.Configurations.Add(new ProductImageMap());
            modelBuilder.Configurations.Add(new ProductPriceMap());
            modelBuilder.Configurations.Add(new ProductProtectionMap());
            modelBuilder.Configurations.Add(new ProductSpecialInfoMap());
            modelBuilder.Configurations.Add(new ProductToCategoryMap());
            modelBuilder.Configurations.Add(new ProductToCountDownMap());
            modelBuilder.Configurations.Add(new ProductToTagMap());
            modelBuilder.Configurations.Add(new PurchaseLimitationItemMap());
            modelBuilder.Configurations.Add(new SelectionToProductMap());
            modelBuilder.Configurations.Add(new ShipmentMap());
            modelBuilder.Configurations.Add(new ShipmentItemMap());
            modelBuilder.Configurations.Add(new SpecToProductMap());
            modelBuilder.Configurations.Add(new VaryantToProductMap());

            base.OnModelCreating(modelBuilder);
        }
    }
}
