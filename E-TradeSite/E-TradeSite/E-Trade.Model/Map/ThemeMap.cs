using E_Trade.Model.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Trade.Model.Map
{
    public class ThemeMap : BaseMap<Theme>
    {
        public ThemeMap()
        {
            ToTable("dbo.Themes");
            Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.Name).HasMaxLength(255).IsRequired();
            Property(x => x.Platform).IsRequired();
            Property(x => x.Type).IsOptional();
            Property(x => x.Preset).HasMaxLength(255).IsOptional();
            Property(x => x.DirectoryName).HasMaxLength(255).IsOptional();
            Property(x => x.Status).IsRequired();
            Property(x => x.Revision).IsOptional();
            Property(x => x.Version).IsOptional();
            Property(x => x.CreatedAt).HasColumnType("datetime2").IsOptional();
            Property(x => x.UpdatedAt).HasColumnType("datetime2").IsOptional();
            Property(x => x.Attachment).IsOptional();
        }
    }
}
