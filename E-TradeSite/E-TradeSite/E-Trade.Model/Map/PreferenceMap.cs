using E_Trade.Model.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Trade.Model.Map
{
    public class PreferenceMap : BaseMap<Preference>
    {
        public PreferenceMap()
        {
            ToTable("dbo.Preferences");

            Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.VarKey).HasMaxLength(255).IsOptional();
            Property(x => x.VarValue).IsRequired().IsOptional();
        }
    }
}
