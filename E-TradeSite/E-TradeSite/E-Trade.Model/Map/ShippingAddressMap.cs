using E_Trade.Model.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Trade.Model.Map
{
    public class ShippingAddressMap : BaseMap<ShippingAddress>
    {
        public ShippingAddressMap()
        {
            ToTable("dbo.ShippingAddresses");

            Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.FirstName).HasMaxLength(255).IsRequired();
            Property(x => x.SurName).HasMaxLength(255).IsRequired();
            Property(x => x.Country).HasMaxLength(128).IsRequired();
            Property(x => x.Location).HasMaxLength(128).IsRequired();
            Property(x => x.SubLocation).HasMaxLength(128).IsOptional();
            Property(x => x.Address).HasMaxLength(65535).IsRequired();
            Property(x => x.PhoneNumber).HasMaxLength(32).IsOptional();
            Property(x => x.MobilePhoneNumber).HasMaxLength(32).IsRequired();
        }
    }
}
