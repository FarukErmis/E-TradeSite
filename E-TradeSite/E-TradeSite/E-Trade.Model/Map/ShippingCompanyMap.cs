using E_Trade.Model.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Trade.Model.Map
{
    public class ShippingCompanyMap : BaseMap<ShippingCompany>
    {
        public ShippingCompanyMap()
        {
            ToTable("dbo.ShippingCompanies");

            Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.Name).HasMaxLength(255).IsRequired();
            Property(x => x.Status).IsRequired();
            Property(x => x.ExtraPrice).IsOptional();
            Property(x => x.ExtraVolumetricWeightPrice).IsOptional();
            Property(x => x.FreeShipmentOrderPrice).IsOptional();
            Property(x => x.FreeShipmentWeightLimit).IsOptional();
            Property(x => x.SortOrder).IsOptional();
            Property(x => x.CompanyCode).HasMaxLength(255).IsOptional();
            Property(x => x.PaymentType).IsOptional();
            Property(x => x.ShippingProviderId).IsRequired();
        }
    }
}
