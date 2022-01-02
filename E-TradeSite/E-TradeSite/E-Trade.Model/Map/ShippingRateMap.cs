using E_Trade.Model.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Trade.Model.Map
{
    public class ShippingRateMap : BaseMap<ShippingRate>
    {
        public ShippingRateMap()
        {
            ToTable("dbo.ShippingRates");
            Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.VolumetricWeightStart).IsRequired();
            Property(x => x.VolumetricWeightEnd).IsRequired();
            Property(x => x.Rate).IsRequired();
            Property(x => x.ShippingCompanyId).IsOptional();
            Property(x => x.RegionId).IsOptional();
        }
        
    }
}
