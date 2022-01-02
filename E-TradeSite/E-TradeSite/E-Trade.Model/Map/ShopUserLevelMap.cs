using E_Trade.Model.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Trade.Model.Map
{
    public class ShopUserLevelMap : BaseMap<ShopUserLevel>
    {
        public ShopUserLevelMap()
        {
            ToTable("dbo.ShopUserLevel");

            Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.Label).IsOptional();
            Property(x => x.Roles).IsOptional();
        }
    }
}
