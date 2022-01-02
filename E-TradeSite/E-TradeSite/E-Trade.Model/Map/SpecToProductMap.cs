using E_Trade.Model.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Trade.Model.Map
{
    public class SpecToProductMap : BaseMap<SpecToProduct>
    {
        public SpecToProductMap()
        {
            ToTable("dbo.SpecToProducts");

            Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.ProductId).IsOptional();
            Property(x => x.SpecGroupId).IsOptional();
            Property(x => x.SpecNameId).IsOptional();
            Property(x => x.SpecValueId).IsRequired();
        }
    }
}
