using E_Trade.Model.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Trade.Model.Map
{
    public class ProductProtectionMap : BaseMap<ProductProtection>
    {
        public ProductProtectionMap()
        {
            ToTable("dbo.ProductProtections");

            Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.IsPriceProtected).IsRequired();
            Property(x => x.IsStockProtected).IsRequired();
            Property(x => x.ProductId).IsRequired();
        }
    }
}
