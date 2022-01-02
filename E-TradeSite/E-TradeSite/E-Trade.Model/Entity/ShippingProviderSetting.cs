using System.Collections.Generic;

namespace E_Trade.Model.Entity
{
    public class ShippingProviderSetting
    {
        public ShippingProviderSetting()
        {
            ShippingProviders = new HashSet<ShippingProvider>();
        }
        public int Id { get; set; }
        public string VarKey { get; set; }
        public string VarValue { get; set; }
        public ICollection<ShippingProvider> ShippingProviders { get; set; }
    }
}
