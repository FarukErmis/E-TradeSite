using E_Trade.Model.Entity;
using System.ComponentModel.DataAnnotations.Schema;

namespace E_Trade.Model.Map
{
    public class PaymentProviderSettingMap : BaseMap<PaymentProviderSetting>
    {
        public PaymentProviderSettingMap()
        {
            ToTable("dbo.PaymentProviderSettings");

            Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.VarKey).IsRequired();
            Property(x => x.VarValue).IsRequired();
        }
    }
}
