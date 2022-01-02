using E_Trade.Model.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Trade.Model.Map
{
    public class ProductToCategoryMap : BaseMap<ProductToCategory>
    {
        public ProductToCategoryMap()
        {
            ToTable("dbo.ProductToCategories");

            Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.SortOrder).IsRequired();
            Property(x => x.ProductId).IsRequired();
            Property(x => x.CategoryId).IsRequired();
        }
    }
}
