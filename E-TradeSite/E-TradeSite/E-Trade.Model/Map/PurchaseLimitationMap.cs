using E_Trade.Model.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Trade.Model.Map
{
    public class PurchaseLimitationMap : BaseMap<PurchaseLimitation>
    {
        public PurchaseLimitationMap()
        {
            ToTable("dbo.PurchaseLimitations");

            Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.Name).HasMaxLength(255).IsRequired();
            Property(x => x.MinumumLimit).IsOptional();
            Property(x => x.MaximumLimit).IsOptional();
            Property(x => x.Type).IsRequired();
            Property(x => x.Status).IsOptional();
        }
    }
}
