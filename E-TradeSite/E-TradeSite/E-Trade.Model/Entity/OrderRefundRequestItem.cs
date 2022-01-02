using E_Trade.Model.Enum;
using System;
using System.ComponentModel.DataAnnotations;

namespace E_Trade.Model.Entity
{
    public class OrderRefundRequestItem
    {
        public int Id { get; set; }
        [Range(0,10000)]
        public float Amount { get; set; }
        public OrderRefundRequestItemReason Reason { get; set; }
        public string Deatils { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int OrderItemId { get; set; }
        public int OrderRefundRequestId { get; set; }
        public OrderItem OrderItem { get; set; }
        public OrderRefundRequest OrderRefundRequest { get; set; }

    }
}
