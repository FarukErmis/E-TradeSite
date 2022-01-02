using E_Trade.Model.Entity;
using System.ComponentModel.DataAnnotations.Schema;

namespace E_Trade.Model.Map
{
    public class RegionMap : BaseMap<Region>
    {
        public RegionMap()
        {
            ToTable("dbo.Regions");

            Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.Name).HasMaxLength(255).IsRequired();
            Property(x => x.CountryId);
        }
    }
}
