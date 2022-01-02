using E_Trade.Model.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Trade.Model.Map
{
    public class SpecGroupMap : BaseMap<SpecGroup>
    {
        public SpecGroupMap()
        {
            ToTable("dbo.SpecGroup");

            Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.Name).HasMaxLength(255).IsRequired();
            Property(x => x.Id).IsOptional();
            Property(x => x.Status).IsRequired();

        }
    }
}
