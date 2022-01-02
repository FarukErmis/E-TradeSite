using E_Trade.Model.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Trade.Model.Map
{
    public class ProductDetailMap : BaseMap<ProductDetail>
    {
        public ProductDetailMap()
        {
            ToTable("dbo.ProductDetails");

            Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.Sku).HasMaxLength(255).IsOptional();
            Property(x => x.Details).IsOptional();
            Property(x => x.ExtraDetails).IsOptional();
            Property(x => x.ProductId).IsRequired();
        }
    }
}
