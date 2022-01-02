using E_Trade.Model.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Trade.Model.Map
{
    public class InstallmentRateMap : BaseMap<InstallmentRate>
    {
        public InstallmentRateMap()
        {
            ToTable("dbo.InstallmentRates");

            Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.Installment).IsRequired();
            Property(x => x.Rate).IsRequired();
            Property(x => x.PaymentGatewayId).IsRequired();
        }
    }
}
