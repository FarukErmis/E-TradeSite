using E_Trade.Model.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Trade.Model.Map
{
    public class SelectionToProductMap : BaseMap<SelectionToProduct>
    {
        public SelectionToProductMap()
        {
            ToTable("dbo.SelectionToProducts");

            Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.SelectionId).IsRequired();
            Property(x => x.ProductId).IsRequired();
        }
    }
}
