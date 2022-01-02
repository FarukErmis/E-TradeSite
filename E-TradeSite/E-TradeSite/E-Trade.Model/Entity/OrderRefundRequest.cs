using E_Trade.Model.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace E_Trade.Model.Entity
{
    public class OrderRefundRequest
    {
        public OrderRefundRequest()
        {
            OrderRefundRequestItems = new HashSet<OrderRefundRequestItem>();
        }
        public int Id { get; set; }
        public string Code { get; set; }
        public OrderRefundRequestStatus Status { get; set; }
        [Range(0,10000)]
        public float Fee { get; set; }
        public string CancellationReason { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        [ForeignKey("Member")]
        public int MemberId { get; set; }
        [ForeignKey("Order")]
        public int OrderId { get; set; }
        public Member Member { get; set; }
        public Order Order { get; set; }
        public ICollection<OrderRefundRequestItem> OrderRefundRequestItems { get; set; }
    }
}
