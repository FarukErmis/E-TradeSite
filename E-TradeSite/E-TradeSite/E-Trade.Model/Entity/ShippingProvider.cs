using E_Trade.Model.Enum;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace E_Trade.Model.Entity
{
    public class ShippingProvider
    {
        public ShippingProvider()
        {
            ShippingCompanies = new HashSet<ShippingCompany>();
        }
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string TrackingUrl { get; set; }
        public ShippingProviderTrackingFormMethod TrackingFormMethod { get; set; }
        public string Payload { get; set; }
        [ForeignKey("ShippingProviderSetting")]
        public int ShippingProviderSettingId { get; set; }
        public ShippingProviderSetting ShippingProviderSetting { get; set; }
        public ICollection<ShippingCompany> ShippingCompanies { get; set; }
    }
}
