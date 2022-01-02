using E_Trade.Model.Entity;
using System.ComponentModel.DataAnnotations.Schema;

namespace E_Trade.Model.Map
{
    public class CurrencyMap : BaseMap<Currency>
    {
        public CurrencyMap()
        {
            ToTable("dbo.Currencies");

            Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x => x.Label).HasMaxLength(255).IsOptional();

            Property(x => x.BuyingPrice).IsOptional();

            Property(x => x.SellingPrice).IsOptional();

            Property(x => x.Abbr).HasMaxLength(5).IsOptional();

            Property(x => x.UpdatedAt).HasColumnType("datetime2").IsOptional();

            Property(x => x.Status).IsOptional();

            Property(x => x.IsPrimary).IsOptional();
        }
    }
}
