using E_Trade.Model.Entity;
using System.ComponentModel.DataAnnotations.Schema;

namespace E_Trade.Model.Map
{
    public class BrandMap : BaseMap<Brand>
    {
        public BrandMap()
        {
            ToTable("dbo.Brands");

            Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.BrandName).HasMaxLength(50).IsRequired();
        }
    }
}