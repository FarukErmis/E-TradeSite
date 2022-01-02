using E_Trade.Model.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Trade.Model.Map
{
    public class PreOrderInfoMap : BaseMap<PreOrderInfo>
    {
        public PreOrderInfoMap()
        {
            ToTable("dbo.PreOrderInfos");

            Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.SessionId).HasMaxLength(255).IsRequired();
            Property(x => x.CustomerFirstName).HasMaxLength(255).IsOptional();
            Property(x => x.CustomerSurName).HasMaxLength(255).IsOptional();
            Property(x => x.CustomerEmail).HasMaxLength(255).IsOptional();
            Property(x => x.ShippingFirstName).HasMaxLength(255).IsRequired();
            Property(x => x.ShippingSurName).HasMaxLength(255).IsRequired();
            Property(x => x.ShippingAddress).HasMaxLength(65535).IsRequired();
            Property(x => x.ShippingPhoneNumber).HasMaxLength(32).IsRequired();
            Property(x => x.ShippingMobilePhoneNumber).HasMaxLength(32).IsRequired();
            Property(x => x.ShippingLocationName).HasMaxLength(128).IsRequired();
            Property(x => x.ShippingTown).HasMaxLength(128).IsRequired();
            Property(x => x.DifferentBillingAddress).IsOptional();
            Property(x => x.BillingFirstName).HasMaxLength(255).IsRequired();
            Property(x => x.BillingSurName).HasMaxLength(255).IsRequired();
            Property(x => x.BillingAddress).HasMaxLength(65535).IsRequired();
            Property(x => x.BillingPhoneNumber).HasMaxLength(32).IsRequired();
            Property(x => x.BillingMobilePhoneNumber).HasMaxLength(32).IsRequired();
            Property(x => x.BillingLocationName).HasMaxLength(128).IsRequired();
            Property(x => x.BillingTown).HasMaxLength(128).IsRequired();
            Property(x => x.BillingInvoiceType).IsRequired();
            Property(x => x.BillingIdentityRegistrationNumber).HasMaxLength(32).IsOptional();
            Property(x => x.BillingTaxOffice).HasMaxLength(255).IsOptional();
            Property(x => x.BillingTaxNo).HasMaxLength(128).IsOptional();
            Property(x => x.IsEinvoiceUser).IsOptional();
            Property(x => x.UseGiftPackage).IsOptional();
            Property(x => x.GiftNote).HasMaxLength(65535).IsOptional();
            Property(x => x.ImageFile).HasMaxLength(128).IsOptional();
            Property(x => x.DeliveryDate).HasColumnType("datetime2").IsOptional();
            Property(x => x.DeliveryTime).HasColumnType("datetime2").IsOptional();
            Property(x => x.CreatedAt).HasColumnType("datetime2").IsOptional();
            Property(x => x.UpdatedAt).HasColumnType("datetime2").IsOptional();
            Property(x => x.BillingCountryId).IsRequired();
            Property(x => x.BillingLocationId).IsOptional();
            Property(x => x.ShippingCompanyId).IsRequired();
            Property(x => x.ShippingCountryId).IsOptional();
            Property(x => x.ShippingLocationId).IsOptional();
            Property(x => x.MemberShippingAddressId).IsOptional();
            Property(x => x.MemberBillingAddressId).IsOptional();
        }
    }
}
