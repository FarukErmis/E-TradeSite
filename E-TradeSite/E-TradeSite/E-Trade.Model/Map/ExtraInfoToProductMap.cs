using E_Trade.Model.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Trade.Model.Map
{
    public class ExtraInfoToProductMap : BaseMap<ExtraInfoToProduct>
    {
        public ExtraInfoToProductMap()
        {
            ToTable("dbo.ExtraInfoToProducts");

            Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.Value).HasMaxLength(255).IsRequired();
            Property(x => x.ExtraInfoId).IsRequired();
            Property(x => x.ProductId).IsRequired();
        }
    }
}
