using E_Trade.Model.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Trade.Model.Map
{
    public class ProductSpecialInfoMap : BaseMap<ProductSpecialInfo>
    {
        public ProductSpecialInfoMap()
        {
            ToTable("dbo.ProductSpecialInfos");

            Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.Title).HasMaxLength(255).IsRequired();
            Property(x => x.Content).HasMaxLength(65535).IsRequired();
            Property(x => x.Status).IsRequired();
            Property(x => x.ProductId).IsRequired();
        }
    }
}
