using E_Trade.Model.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Trade.Model.Map
{
    public class PaymentProviderMap : BaseMap<PaymentProvider>
    {
        public PaymentProviderMap()
        {
            ToTable("dbo.PaymentProviders");

            Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.Code).HasMaxLength(255).IsRequired();
            Property(x => x.Name).HasMaxLength(255).IsRequired();
            Property(x => x.Status).IsRequired();
            Property(x => x.PaymentId).IsRequired();
            Property(x => x.PaymentProviderSettingId).IsOptional();
        }
    }
}
