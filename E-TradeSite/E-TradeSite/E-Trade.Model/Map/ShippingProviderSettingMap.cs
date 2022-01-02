using E_Trade.Model.Entity;
using System.ComponentModel.DataAnnotations.Schema;

namespace E_Trade.Model.Map
{
    public class ShippingProviderSettingMap : BaseMap<ShippingProviderSetting>
    {
        public ShippingProviderSettingMap()
        {
            ToTable("dbo.ShippingProviderSettings");

            Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.VarKey).HasMaxLength(255).IsRequired();
            Property(x => x.VarValue).HasMaxLength(255).IsRequired();
        }
    }
}
