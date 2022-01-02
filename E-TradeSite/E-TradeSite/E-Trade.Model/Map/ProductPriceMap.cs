using E_Trade.Model.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Trade.Model.Map
{
    public class ProductPriceMap : BaseMap<ProductPrice>
    {
        public ProductPriceMap()
        {
            ToTable("dbo.ProductPrices");

            Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.Value).IsRequired();
            Property(x => x.Type).IsRequired();
            Property(x => x.ProductId).IsRequired();
        }
    }
}
