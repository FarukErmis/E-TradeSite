using E_Trade.Model.Enum;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace E_Trade.Model.Entity
{
    public class BillingAddress
    {
        public BillingAddress()
        {
            Orders = new HashSet<Order>();
        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string SurName { get; set; }
        public string Country { get; set; }
        public string Location { get; set; }
        public string SubLocation { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string MobilePhoneNumber { get; set; }
        public BillingAddressInvoiceType InvoiceType { get; set; }
        public string TaxNo { get; set; }
        public string TaxOffice { get; set; }
        [MinLength(11)]
        public string IdentityRegistrationNumber { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}
