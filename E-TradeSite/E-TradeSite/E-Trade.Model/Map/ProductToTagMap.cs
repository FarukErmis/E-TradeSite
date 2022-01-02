using E_Trade.Model.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Trade.Model.Map
{
    public class ProductToTagMap : BaseMap<ProductToTag>
    {
        public ProductToTagMap()
        {
            ToTable("dbo.ProductToTags");

            Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.ProductId).IsRequired();
            Property(x => x.TagId).IsRequired();
        }
    }
}
