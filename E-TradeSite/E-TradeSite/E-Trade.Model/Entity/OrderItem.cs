using E_Trade.Model.Enum;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace E_Trade.Model.Entity
{
    public class OrderItem
    {
        public OrderItem()
        {
            OrderRefundRequestItems = new HashSet<OrderRefundRequestItem>();
            ShipmentItems = new HashSet<ShipmentItem>();
        }
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string ProductSku { get; set; }
        public string ProductBarcode { get; set; }
        [Range(0, 10000)]
        public float ProductPrice { get; set; }
        public string ProductCurrency { get; set; }
        [Range(0.001, 10000)]
        public float ProductQuantity { get; set; }
        [Range(0, 10000)]
        public int ProductTax { get; set; }
        public float ProductDiscount { get; set; }
        [Range(0, 10000)]
        public float ProductMoneyOrderDiscount { get; set; }
        [Range(0, 10000)]
        public float ProductWeight { get; set; }
        public ProductStockTypeLabel ProductStockTypeLabel { get; set; }
        public bool IsProductPromotioned { get; set; }
        public float Discount { get; set; }
        [ForeignKey("Order")]
        public int OrderId { get; set; }
        [ForeignKey("Product")]
        public int ProductId { get; set; }
        [ForeignKey("OrderItemCustomization")]
        public int OrderItemCustomazitionId { get; set; }
        [ForeignKey("OrderItemSubscription")]
        public int OrderItemSubscriptionId { get; set; }
        public Order Order { get; set; }
        public Product Product { get; set; }
        public OrderItemCustomization OrderItemCustomization { get; set; }
        public OrderItemSubscription OrderItemSubscription { get; set; }
        public ICollection<OrderRefundRequestItem> OrderRefundRequestItems { get; set; }
        public ICollection<ShipmentItem> ShipmentItems { get; set; }
    }
}
