using E_Trade.Model.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Trade.Model.Map
{
    public class TagMap : BaseMap<Tag>
    {
        public TagMap()
        {
            ToTable("dbo.Tags");

            Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.Name).HasMaxLength(255).IsRequired();
            Property(x => x.Count).IsOptional();
            Property(x => x.PageTitle).HasMaxLength(65535).IsOptional();
            Property(x => x.MetaDescription).HasMaxLength(65535).IsOptional();
            Property(x => x.MetaKeyWords).HasMaxLength(65535).IsOptional();
        }
    }
}
