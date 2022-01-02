using E_Trade.Model.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Trade.Model.Map
{
    public class PurchaseLimitationItemMap : BaseMap<PurchaseLimitationItem>
    {
        public PurchaseLimitationItemMap()
        {
            ToTable("dbo.PurchaseLimitationItems");

            Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.BrandId).IsOptional();
            Property(x => x.CategoryId).IsOptional();
            Property(x => x.PurchaseLimitationId).IsOptional();
            Property(x => x.MemberGroupId).IsOptional();
            Property(x => x.ProductId).IsOptional();
        }
    }
}
