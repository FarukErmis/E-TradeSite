using E_Trade.Model.Enum;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace E_Trade.Model.Entity
{
    public class ShippingCompany
    {
        public ShippingCompany()
        {
            ShippingRates = new HashSet<ShippingRate>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Status { get; set; }
        [Range(0,100000)]
        public float ExtraPrice { get; set; }
        [Range(0, 100000)]
        public float ExtraVolumetricWeightPrice { get; set; }
        [Range(0, 100000)]
        public float FreeShipmentOrderPrice { get; set; }
        [Range(0, 100000)]
        public float FreeShipmentWeightLimit { get; set; }
        [Range(0, 100000)]
        public int SortOrder { get; set; }
        public string CompanyCode { get; set; }
        public ShippingCompanyPaymentType PaymentType { get; set; }
        [ForeignKey("ShippingProvider")]
        public int ShippingProviderId { get; set; }
        public ShippingProvider ShippingProvider { get; set; }
        public ICollection<ShippingRate> ShippingRates { get; set; }
    }
}
