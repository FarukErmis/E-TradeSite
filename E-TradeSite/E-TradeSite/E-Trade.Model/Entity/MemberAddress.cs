using E_Trade.Model.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace E_Trade.Model.Entity
{
    public class MemberAddress
    {
        public MemberAddress()
        {
            PreOrderInfos = new HashSet<PreOrderInfo>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string FirstName { get; set; }
        public string SurName { get; set; }
        public string Address { get; set; }
        public string SubLocation { get; set; }
        public string PhoneNumber { get; set; }
        public string MobilePhoneNumber { get; set; }
        public string TcId { get; set; }
        public string TaxNumber { get; set; }
        public string TaxOffice { get; set; }
        public BillingAddressInvoiceType InvoiceType { get; set; }
        public bool IsEinvoiceUser { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        [ForeignKey("Member")]
        public int MemberId { get; set; }
        [ForeignKey("Country")]
        public int CountryId { get; set; }
        [ForeignKey("Location")]
        public int LocationId { get; set; }
        [ForeignKey("Town")]
        public int TownId { get; set; }
        public Member Member { get; set; }
        public Country Country { get; set; }
        public Location Location { get; set; }
        public Town Town { get; set; }
        public ICollection<PreOrderInfo> PreOrderInfos { get; set; }
    }
}
