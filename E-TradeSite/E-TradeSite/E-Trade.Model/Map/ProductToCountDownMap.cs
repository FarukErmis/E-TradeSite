using E_Trade.Model.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Trade.Model.Map
{
    public class ProductToCountDownMap : BaseMap<ProductToCountDown>
    {
        public ProductToCountDownMap()
        {
            ToTable("dbo.ProductToCountDowns");

            Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.StartDate).HasColumnType("datetime2").IsOptional();
            Property(x => x.EndDate).HasColumnType("datetime2").IsOptional();
            Property(x => x.ExpireDate).HasColumnType("datetime2").IsOptional();
            Property(x => x.UseCountDown).IsRequired();
            Property(x => x.ProductId).IsRequired();
        }
    }
}
