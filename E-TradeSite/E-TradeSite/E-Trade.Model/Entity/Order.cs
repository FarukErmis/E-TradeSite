using E_Trade.Model.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace E_Trade.Model.Entity
{
    public class Order
    {
        public Order()
        {
            OrderDetails = new HashSet<OrderDetail>();
            OrderItems = new HashSet<OrderItem>();
            OrderRefundRequests = new HashSet<OrderRefundRequest>();
            OrderRefundRequests = new HashSet<OrderRefundRequest>();
            OrderUserNotes = new HashSet<OrderUserNote>();
            Shipments = new HashSet<Shipment>();
        }
        public int Id { get; set; }
        public string CustomerFirstName { get; set; }
        public string CustomerSurname { get; set; }
        public string CustomerEmail { get; set; }
        public string CustomerPhone { get; set; }
        public string PaymentTypeName { get; set; }
        public string PaymentProviderCode { get; set; }
        public string PaymentProviderName { get; set; }
        public string PaymentGatewayCode { get; set; }
        public string PaymentGatewayName { get; set; }
        public string BankName { get; set; }
        public string ClientIp { get; set; }
        public string UserAgent { get; set; }
        public string Currency { get; set; }
        public string CurrencyRates { get; set; }
        [Range(0,100000)]
        public float Amount { get; set; }
        [Range(0, 100000)]
        public float CouponDiscount { get; set; }
        [Range(0, 100000)]
        public float TaxAmount { get; set; }
        [Range(0, 100000)]
        public float PromotionDiscount { get; set; }
        [Range(0, 100000)]
        public float GeneralAmount { get; set; }
        [Range(0, 100000)]
        public float ShippingAmount { get; set; }
        public float AdditionalServiceAmount { get; set; }
        [Range(0, 100000)]
        public float FinalAmount { get; set; }
        [Range(0, 100000)]
        public float SumOfGainedPoints { get; set; }
        [Range(0, 18)]
        public float Installment { get; set; }
        public int InstallmentRate { get; set; }
        [Range(0, 12)]
        public int ExtraInstallment { get; set; }
        public string TransactionId { get; set; }
        public bool HasUserNote { get; set; }
        public OrderStatus Status { get; set; }
        public OrderPaymentStatus PaymentStatus { get; set; }
        public string ErrorMessage { get; set; }
        public OrderDeviceType DeviceType { get; set; }
        public string Referrer { get; set; }
        public int InvoicePrintCount { get; set; }
        public bool UseGiftPackage { get; set; }
        public string GiftNote { get; set; }
        public string MemberGroupName { get; set; }
        public bool UsePromotion { get; set; }
        public string ShippingProviderCode { get; set; }
        public string ShippingProviderName { get; set; }
        public string ShippingCompanyName { get; set; }
        public OrderShippingPaymentType ShippingPaymentType { get; set; }
        public string ShippingTrackingCode { get; set; }
        public string Source { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        [ForeignKey("MailList")]
        public int MailListId { get; set; }
        [ForeignKey("Member")]
        public int MemberId { get; set; }
        [ForeignKey("ShippingAddress")]
        public int ShippingAddressId { get; set; }
        [ForeignKey("BillingAddress")]
        public int BillingAddressId { get; set; }
        public MailList MailList { get; set; }
        public Member Member { get; set; }
        public ShippingAddress ShippingAddress { get; set; }
        public BillingAddress BillingAddress { get; set; }
        public ICollection<OrderDetail> OrderDetails { get; set; }
        public ICollection<OrderItem> OrderItems { get; set; }
        public ICollection<OrderRefundRequest> OrderRefundRequests { get; set; }
        public ICollection<OrderUserNote> OrderUserNotes { get; set; }
        public ICollection<Shipment> Shipments { get; set; }
    }
}
