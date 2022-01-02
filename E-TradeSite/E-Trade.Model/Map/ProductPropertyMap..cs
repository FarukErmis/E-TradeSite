using E_Trade.Model.Entity;
using System.ComponentModel.DataAnnotations.Schema;

namespace E_Trade.Model.Map
{
    public class ProductPropertyMap : BaseMap<ProductProperty>
    {
        public ProductPropertyMap()
        {
            ToTable("dbo.ProductProperties");

            Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.VarKey).HasMaxLength(50).IsRequired();
            Property(x => x.VarValue).HasMaxLength(50).IsRequired();
        }
    }
}