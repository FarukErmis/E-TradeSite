using E_Trade.Model.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Trade.Model.Map
{
    public class MemberMap : BaseMap<Member>
    {
        public MemberMap()
        {
            ToTable("dbo.Members");

            Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.FirstName).HasMaxLength(255).IsRequired();
            Property(x => x.SurName).HasMaxLength(255).IsRequired();
            Property(x => x.Email).HasMaxLength(255).IsRequired();
            Property(x => x.Gender).IsOptional();
            Property(x => x.BirthDate).HasColumnType("datetime2").IsOptional();
            Property(x => x.PhoneNumber).HasMaxLength(255).IsOptional();
            Property(x => x.MobilePhoneNumber).HasMaxLength(255).IsRequired();
            Property(x => x.OtherLocation).HasMaxLength(255).IsOptional();
            Property(x => x.Address).HasMaxLength(65535).IsOptional();
            Property(x => x.TaxNumber).HasMaxLength(255).IsOptional();
            Property(x => x.TcId).HasMaxLength(255).IsOptional();
            Property(x => x.Status).IsRequired();
            Property(x => x.LastLoginDate).HasColumnType("datetime2").IsOptional();
            Property(x => x.CreatedAt).HasColumnType("datetime2").IsOptional();
            Property(x => x.UpdatedAt).HasColumnType("datetime2").IsOptional();
            Property(x => x.ZipCode).HasMaxLength(55).IsOptional();
            Property(x => x.CommercialName).HasMaxLength(255).IsOptional();
            Property(x => x.TaxOffice).HasMaxLength(255).IsOptional();
            Property(x => x.LastMailSentDate).HasColumnType("datetime2").IsOptional();
            Property(x => x.LastIp).HasMaxLength(255).IsOptional();
            Property(x => x.GainedPointAmount).IsOptional();
            Property(x => x.SpendPointAmount).IsOptional();
            Property(x => x.AllowedToCampaigns).IsRequired();
            Property(x => x.IysStatus).IsRequired();
            Property(x => x.AllowedCampaingsUpdatedAt).HasColumnType("datetime2").IsOptional();
            Property(x => x.RefferedMemberGainedPointAmount).IsOptional();
            Property(x => x.Discrict).HasMaxLength(255).IsOptional();
            Property(x => x.DeviceType).HasMaxLength(255).IsRequired();
            Property(x => x.DeviceInfo).HasMaxLength(255).IsOptional();
            Property(x => x.CountryId).IsOptional();
            Property(x => x.LocationId).IsOptional();
            Property(x => x.MemberGroupId).IsOptional();
            Property(x => x.ReferredMemberId).IsOptional();
        }
    }
}
