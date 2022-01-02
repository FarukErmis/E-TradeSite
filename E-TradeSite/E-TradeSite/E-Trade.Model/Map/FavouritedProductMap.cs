using E_Trade.Model.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Trade.Model.Map
{
    public class FavouritedProductMap : BaseMap<FavouritedProduct>
    {
        public FavouritedProductMap()
        {
            ToTable("dbo.FavouritedProducts");

            Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.MemberId).IsRequired();
            Property(x => x.ProductId).IsRequired();
        }
    }
}
