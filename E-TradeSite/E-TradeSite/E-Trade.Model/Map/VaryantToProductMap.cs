using E_Trade.Model.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Trade.Model.Map
{
    public class VaryantToProductMap : BaseMap<VaryantToProduct>
    {
        public VaryantToProductMap()
        {
            ToTable("dbo.VaryantToProducts");

            Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.ParentProductId).IsRequired();
            Property(x => x.OptionGroupId).IsRequired();
            Property(x => x.OptionId).IsRequired();
            Property(x => x.ProductId).IsRequired();
        }
    }
}
