using E_Trade.Model.Enum;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace E_Trade.Model.Entity
{
    public class PreOrderInfo
    {
        public int Id { get; set; }
        public string SessionId { get; set; }
        public string CustomerFirstName { get; set; }
        public string CustomerSurName { get; set; }
        public string CustomerEmail { get; set; }
        public string ShippingFirstName { get; set; }
        public string ShippingSurName { get; set; }
        public string ShippingAddress { get; set; }
        public string ShippingPhoneNumber { get; set; }
        public string ShippingMobilePhoneNumber { get; set; }
        public string ShippingLocationName { get; set; }
        public string ShippingTown { get; set; }
        public bool DifferentBillingAddress { get; set; }
        public string BillingFirstName { get; set; }
        public string BillingSurName { get; set; }
        public string BillingAddress { get; set; }
        public string BillingPhoneNumber { get; set; }
        public string BillingMobilePhoneNumber { get; set; }
        public string BillingLocationName { get; set; }
        public string BillingTown { get; set; }
        public BillingAddressInvoiceType BillingInvoiceType { get; set; }
        public string BillingIdentityRegistrationNumber { get; set; }
        public string BillingTaxOffice { get; set; }
        public string BillingTaxNo { get; set; }
        public bool IsEinvoiceUser { get; set; }
        public bool UseGiftPackage { get; set; }
        public string GiftNote { get; set; }
        public string ImageFile { get; set; }
        public DateTime DeliveryDate { get; set; }
        public DateTime DeliveryTime { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        [ForeignKey("Country")]
        public int BillingCountryId { get; set; }
        [ForeignKey("Location")]
        public int BillingLocationId { get; set; }
        [ForeignKey("ShippingCompany")]
        public int ShippingCompanyId { get; set; }
        [ForeignKey("Country1")]
        public int ShippingCountryId { get; set; }
        [ForeignKey("Location1")]
        public int ShippingLocationId { get; set; }
        [ForeignKey("MemberAddress")]
        public int MemberShippingAddressId { get; set; }
        [ForeignKey("MemberAddress1")]
        public int MemberBillingAddressId { get; set; }
        public Country Country { get; set; }
        public Location Location { get; set; }
        public ShippingCompany ShippingCompany { get; set; }
        public Country Country1 { get; set; }
        public Location Location1 { get; set; }
        public MemberAddress MemberAddress { get; set; }
        public MemberAddress MemberAddress1 { get; set; }
    }
}
