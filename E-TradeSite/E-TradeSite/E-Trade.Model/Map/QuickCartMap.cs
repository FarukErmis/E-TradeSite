using E_Trade.Model.Entity;
using System.ComponentModel.DataAnnotations.Schema;

namespace E_Trade.Model.Map
{
    public class QuickCartMap : BaseMap<QuickCart>
    {
        public QuickCartMap()
        {
            ToTable("dbo.QuickCart");

            Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.Name).HasMaxLength(255).IsRequired();
            Property(x => x.Url).HasMaxLength(2048).IsRequired();
            Property(x => x.ShortUrl).HasMaxLength(255).IsOptional();
        }
    }
}
