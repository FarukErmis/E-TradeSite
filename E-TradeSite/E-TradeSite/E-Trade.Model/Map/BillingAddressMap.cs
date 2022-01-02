using E_Trade.Model.Entity;
using System.ComponentModel.DataAnnotations.Schema;

namespace E_Trade.Model.Map
{
    public class BillingAddressMap : BaseMap<BillingAddress>
    {
        public BillingAddressMap()
        {
            ToTable("dbo.BillingAddresses");

            Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.FirstName).HasMaxLength(255).IsRequired();
            Property(x => x.SurName).HasMaxLength(255).IsRequired();
            Property(x => x.Country).HasMaxLength(128).IsRequired();
            Property(x => x.Location).HasMaxLength(128).IsRequired();
            Property(x => x.SubLocation).HasMaxLength(128).IsOptional();
            Property(x => x.Address).HasMaxLength(65535).IsRequired();
            Property(x => x.PhoneNumber).HasMaxLength(32).IsOptional();
            Property(x => x.MobilePhoneNumber).HasMaxLength(32).IsRequired();
            Property(x => x.InvoiceType).IsOptional();
            Property(x => x.TaxNo).HasMaxLength(64).IsOptional();
            Property(x => x.TaxOffice).HasMaxLength(255).IsOptional();
            Property(x => x.IdentityRegistrationNumber).HasMaxLength(32).IsOptional();
        }
    }
}
