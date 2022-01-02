using E_Trade.Model.Entity;
using System.ComponentModel.DataAnnotations.Schema;

namespace E_Trade.Model.Map
{
    public class ProductImageMap : BaseMap<ProductImage>
    {
        public ProductImageMap()
        {
            ToTable("dbo.ProductImages");

            Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.ProductId).IsRequired();
            Property(x => x.Image).IsRequired();
        }
    }
}