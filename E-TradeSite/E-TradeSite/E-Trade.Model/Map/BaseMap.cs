using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Trade.Model.Map
{
    public class BaseMap<T> : EntityTypeConfiguration<T> where T : class
    {
        //Property(x => x.).HasMaxLength(255);

        //Property(x => x.).IsRequired();

        //Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
        //Property(x => x.).HasMaxLength(255).IsRequired();

        //Property(x => x.CreatedAt).HasColumnType("datetime2");
        //Property(x => x.UpdatedAt).HasColumnType("datetime2");
    }
}
