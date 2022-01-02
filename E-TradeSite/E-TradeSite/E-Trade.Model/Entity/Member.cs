using E_Trade.Model.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace E_Trade.Model.Entity
{
    public class Member
    {
        public Member()
        {
            Member2 = new HashSet<Member>();
            CurrentAccount = new HashSet<CurrentAccount>();
            Orders = new HashSet<Order>();
            MemberAddresses = new HashSet<MemberAddress>();
            Carts = new HashSet<Cart>();
            FavouritedProducts = new HashSet<FavouritedProduct>();
            OrderRefundRequests = new HashSet<OrderRefundRequest>();
            Payments = new HashSet<Payment>();
            ProductComments = new HashSet<ProductComment>();
        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string SurName { get; set; }
        public string Email { get; set; }
        public Gender Gender { get; set; }
        public DateTime BirthDate { get; set; }
        public string PhoneNumber { get; set; }
        public string MobilePhoneNumber { get; set; }
        public string OtherLocation { get; set; }
        public string Address { get; set; }
        public string TaxNumber { get; set; }
        public string TcId { get; set; }
        public MemberStatus Status { get; set; }
        public DateTime LastLoginDate { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string ZipCode { get; set; }
        public string CommercialName { get; set; }
        public string TaxOffice { get; set; }
        public DateTime LastMailSentDate { get; set; }
        public string LastIp { get; set; }
        [Range(0,100000)]
        public float GainedPointAmount { get; set; }
        [Range(0, 100000)]
        public float SpendPointAmount { get; set; }
        public bool AllowedToCampaigns { get; set; }
        public MemberIYSStatus IysStatus { get; set; }
        public DateTime AllowedCampaingsUpdatedAt { get; set; }
        [Range(0, 100000)]
        public float RefferedMemberGainedPointAmount { get; set; }
        public string Discrict { get; set; }
        public string DeviceType { get; set; }
        public string DeviceInfo { get; set; }
        [ForeignKey("Country")]
        public int CountryId { get; set; }
        [ForeignKey("Location")]
        public int LocationId { get; set; }
        [ForeignKey("MemberGroup")]
        public int MemberGroupId { get; set; }
        [ForeignKey("Member1")]
        public int ReferredMemberId { get; set; }
        public Country Country { get; set; }
        public Location Location { get; set; }
        public MemberGroup MemberGroup { get; set; }
        public Member Member1 { get; set; }
        public ICollection<Member> Member2 { get; set; }
        public ICollection<CurrentAccount> CurrentAccount { get; set; }
        public ICollection<Order> Orders { get; set; }
        public ICollection<MemberAddress> MemberAddresses { get; set; }
        public ICollection<Cart> Carts { get; set; }
        public ICollection<FavouritedProduct> FavouritedProducts { get; set; }
        public ICollection<OrderRefundRequest> OrderRefundRequests { get; set; }
        public ICollection<Payment> Payments { get; set; }
        public ICollection<ProductComment> ProductComments { get; set; }
    }
}
