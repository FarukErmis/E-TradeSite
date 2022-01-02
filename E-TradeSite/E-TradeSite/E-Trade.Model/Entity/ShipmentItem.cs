using E_Trade.Model.Enum;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace E_Trade.Model.Entity
{
    public class ShipmentItem
    {
        public int Id { get; set; }
        [Range(0,10000)]
        public int RootProductId { get; set; }
        [Range(0, 10000)]
        public int Amount { get; set; }
        [Range(0, 10000)]
        public float Price { get; set; }
        public string ProductLabel { get; set; }
        public ShipmentItemCurrency Currency { get; set; }
        [Range(0, 10000)]
        public int Tax { get; set; }
        [Range(0, 10000)]
        public float Dm3 { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public bool Status { get; set; }
        [ForeignKey("OrderItem")]
        public int OrderItemId { get; set; }
        [ForeignKey("Product")]
        public int ProductId { get; set; }
        [ForeignKey("Shipment")]
        public int ShipmentId { get; set; }
        public OrderItem OrderItem { get; set; }
        public Product Product { get; set; }
        public Shipment Shipment { get; set; }
    }
}
