using E_Trade.Model.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace E_Trade.Model.Entity
{
    public class Product
    {
        public Product()
        {
            Product2 = new HashSet<Product>();
            CartItems = new HashSet<CartItem>();
            DistributorToProducts = new HashSet<DistributorToProduct>();
            ExtraInfos = new HashSet<ExtraInfo>();
            FavouritedProducts = new HashSet<FavouritedProduct>();
            LabelToProducts = new List<LabelToProduct>();
            OrderItems = new HashSet<OrderItem>();
            ProductButtons = new HashSet<ProductButton>();
            ProductComments = new HashSet<ProductComment>();
            ProductDetails = new HashSet<ProductDetail>();
            ProductImages = new HashSet<ProductImage>();
            ProductPrices = new HashSet<ProductPrice>();
            ProductProtections = new HashSet<ProductProtection>();
            ProductSpecialInfos = new HashSet<ProductSpecialInfo>();
            ProductToCategories = new HashSet<ProductToCategory>();
            ProductToCountDowns = new HashSet<ProductToCountDown>();
            ProductToTags = new HashSet<ProductToTag>();
            PurchaseLimitationItems = new HashSet<PurchaseLimitationItem>();
            SelectionToProducts = new HashSet<SelectionToProduct>();
            ShipmentItems = new HashSet<ShipmentItem>();
            SpecToProducts = new HashSet<SpecToProduct>();
            VaryantToProducts = new HashSet<VaryantToProduct>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Slug { get; set; }
        public string FullName { get; set; }
        public string Sku { get; set; }
        public string Barcode { get; set; }
        [Range(0, 10000)]
        public float Price1 { get; set; }
        [Range(0, 10)]
        public string Warranty { get; set; }
        [Range(0,10000)]
        public int Tax { get; set; }
        [Range(0, 10000)]
        public float StockAmount { get; set; }
        [Range(0, 10000)]
        public float VolumetricWeight { get; set; }
        [Range(0, 10000)]
        public float BuyingPrice { get; set; }
        [Range(0, 10000)]
        public ProductStockTypeLabel StockTypeLabel { get; set; }
        [Range(0, 10000)]
        public float Discount { get; set; }
        public bool DiscountType { get; set; }
        [Range(0, 99.99)]
        public float MoneyOrderDiscount { get; set; }
        public bool Status { get; set; }
        public bool TaxIncluded { get; set; }
        public string Distributor { get; set; }
        public bool IsGifted { get; set; }
        public string Gift { get; set; }
        public bool CustomShippingDisabled { get; set; }
        [Range(0, 10000)]
        public int CustomShippingCost { get; set; }
        public string MarketPriceDetail { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string MetaKeyword { get; set; }
        public string MetaDescription { get; set; }
        public string PageTitle { get; set; }
        public bool HasOption { get; set; }
        public string ShortDetails { get; set; }
        public string SearchKeywords { get; set; }
        public string InstallmentThreshoId { get; set; }
        [Range(0, 100)]
        public int HomeSortOrder { get; set; }
        [Range(0, 100)]
        public int PopularSortOrder { get; set; }
        [Range(0, 100)]
        public int BrandSortOrder { get; set; }
        [Range(0, 100)]
        public int FeaturedSortOrder { get; set; }
        [Range(0, 100)]
        public int CampaignedSortOrder { get; set; }
        [Range(0, 100)]
        public int NewSortOrder { get; set; }
        [Range(0, 100)]
        public int DiscountedSortOrder { get; set; }
        [ForeignKey("Brand")]
        public int BrandId { get; set; }
        [ForeignKey("Currency")]
        public int CurrencyId { get; set; }
        [ForeignKey("Product1")]
        public int Parent { get; set; }
        public Brand Brand { get; set; }
        public Currency Currency { get; set; }
        public Product Product1 { get; set; }
        public ICollection<Product> Product2 { get; set; }
        public ICollection<CartItem> CartItems { get; set; }
        public ICollection<DistributorToProduct> DistributorToProducts { get; set; }
        public ICollection<ExtraInfo> ExtraInfos { get; set; }
        public ICollection<FavouritedProduct> FavouritedProducts { get; set; }
        public ICollection<LabelToProduct> LabelToProducts { get; set; }
        public ICollection<OrderItem> OrderItems { get; set; }
        public ICollection<ProductButton> ProductButtons { get; set; }
        public ICollection<ProductComment> ProductComments { get; set; }
        public ICollection<ProductDetail> ProductDetails { get; set; }
        public ICollection<ProductImage> ProductImages { get; set; }
        public ICollection<ProductPrice> ProductPrices { get; set; }
        public ICollection<ProductProtection> ProductProtections { get; set; }
        public ICollection<ProductSpecialInfo> ProductSpecialInfos { get; set; }
        public ICollection<ProductToCategory> ProductToCategories { get; set; }
        public ICollection<ProductToCountDown> ProductToCountDowns { get; set; }
        public ICollection<ProductToTag> ProductToTags { get; set; }
        public ICollection<PurchaseLimitationItem> PurchaseLimitationItems { get; set; }
        public ICollection<SelectionToProduct> SelectionToProducts { get; set; }
        public ICollection<ShipmentItem> ShipmentItems { get; set; }
        public ICollection<SpecToProduct> SpecToProducts { get; set; }
        public ICollection<VaryantToProduct> VaryantToProducts { get; set; }
    }
}
