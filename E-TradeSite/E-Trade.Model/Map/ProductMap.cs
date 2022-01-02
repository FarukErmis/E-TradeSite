using E_Trade.Model.Entity;
using System.ComponentModel.DataAnnotations.Schema;

namespace E_Trade.Model.Map
{
    public class ProductMap : BaseMap<Product>
    {
        public ProductMap()
        {
            ToTable("dbo.Products");

            Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.ProuductName).HasMaxLength(100).IsRequired();
            Property(x => x.CategoryId).IsRequired();
            Property(x => x.BrandId).IsRequired();
            Property(x => x.TotalPrice).IsOptional();
            Property(x => x.TrullyPrice).IsRequired();
            Property(x => x.Discount).IsOptional();
            Property(x => x.Rates).IsOptional();
            Property(x => x.IsShippingFree).IsOptional();
        }
    }
}