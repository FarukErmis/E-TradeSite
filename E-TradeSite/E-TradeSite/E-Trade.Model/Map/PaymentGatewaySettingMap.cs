using E_Trade.Model.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Trade.Model.Map
{
    public class PaymentGatewaySettingMap : BaseMap<PaymentGatewaySetting>
    {
        public PaymentGatewaySettingMap()
        {
            ToTable("dbo.PaymentGatewaySettings");

            Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.VarKey).HasMaxLength(255).IsRequired();
            Property(x => x.VarValue).HasMaxLength(255).IsRequired();
            Property(x => x.PaymentGateWayId).IsOptional();
        }
    }
}
