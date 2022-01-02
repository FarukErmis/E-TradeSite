using E_Trade.Model.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Trade.Model.Map
{
    public class PaymentMap : BaseMap<Payment>
    {
        public PaymentMap()
        {
            ToTable("dbo.Payments");

            Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.MemberFirstName).HasMaxLength(255).IsRequired();
            Property(x => x.MemberSurName).HasMaxLength(255).IsRequired();
            Property(x => x.MemberEmail).HasMaxLength(255).IsRequired();
            Property(x => x.MemberPhone).HasMaxLength(255).IsOptional();
            Property(x => x.PaymentTypeName).HasMaxLength(128).IsRequired();
            Property(x => x.PaymentProviderCode).HasMaxLength(64).IsRequired();
            Property(x => x.PaymentProviderName).HasMaxLength(128).IsRequired();
            Property(x => x.PaymentGatewayName).HasMaxLength(128).IsRequired();
            Property(x => x.PaymentGatewayCode).HasMaxLength(64).IsRequired();
            Property(x => x.BankName).HasMaxLength(64).IsOptional();
            Property(x => x.DeviceType).IsRequired();
            Property(x => x.ClientIp).HasMaxLength(32).IsRequired();
            Property(x => x.CurrencyRates).HasMaxLength(255).IsRequired();
            Property(x => x.Amount).IsRequired();
            Property(x => x.FinalAmount).IsRequired();
            Property(x => x.SumOfGainedPoints).IsOptional();
            Property(x => x.Installment).IsRequired();
            Property(x => x.InstallmentRate).IsRequired();
            Property(x => x.ExtraInstallment).IsOptional();
            Property(x => x.Currency).HasMaxLength(32).IsRequired();
            Property(x => x.TransactionId).HasMaxLength(255).IsOptional();
            Property(x => x.MemberNote).HasMaxLength(65535).IsOptional();
            Property(x => x.UserNote).HasMaxLength(65535).IsOptional();
            Property(x => x.Status).IsRequired();
            Property(x => x.ErrorMessage).HasMaxLength(65535).IsOptional();
            Property(x => x.CardSavingSystem).HasMaxLength(255).IsOptional();
            Property(x => x.CreatedAt).IsOptional();
            Property(x => x.MemberId).IsOptional();
        }
    }
}
