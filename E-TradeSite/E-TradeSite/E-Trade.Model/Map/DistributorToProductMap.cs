
using E_Trade.Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Trade.Model.Map
{
    public class DistributorToProductMap : BaseMap<DistributorToProduct>
    {
        public DistributorToProductMap()
        {
            ToTable("dbo.DistributorToProducts");
        }
    }
}
