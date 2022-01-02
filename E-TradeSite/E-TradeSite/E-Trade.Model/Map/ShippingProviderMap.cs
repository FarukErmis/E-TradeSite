using E_Trade.Model.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Trade.Model.Map
{
    public class ShippingProviderMap : BaseMap<ShippingProvider>
    {
        public ShippingProviderMap()
        {
            ToTable("dbo.ShippingProviders");

            Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.Code).HasMaxLength(64).IsRequired();
            Property(x => x.Name).HasMaxLength(255).IsRequired();
            Property(x => x.TrackingUrl).HasMaxLength(1024).IsRequired();
            Property(x => x.TrackingFormMethod).IsOptional();
            Property(x => x.TrackingUrl).HasMaxLength(65535).IsOptional();
            Property(x => x.ShippingProviderSettingId).IsOptional();
        }
    }
}
