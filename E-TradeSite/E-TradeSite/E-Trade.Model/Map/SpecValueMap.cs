using E_Trade.Model.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Trade.Model.Map
{
    public class SpecValueMap : BaseMap<SpecValue>
    {
        public SpecValueMap()
        {
            ToTable("dbo.SpecValues");

            Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.Name).HasMaxLength(255).IsRequired();
            Property(x => x.Slug).HasMaxLength(255).IsOptional();
            Property(x => x.SortOrder).IsOptional();
            Property(x => x.Logo).IsOptional();
            Property(x => x.Status).IsRequired();
            Property(x => x.Attachment).IsOptional();
            Property(x => x.SpecGroupId).IsRequired().IsRequired();
            Property(x => x.CreatedAt).HasColumnType("datetime2");
            Property(x => x.UpdatedAt).HasColumnType("datetime2");
        }
    }
}
