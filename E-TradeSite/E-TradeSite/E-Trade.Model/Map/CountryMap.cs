using E_Trade.Model.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Trade.Model.Map
{
    public class CountryMap : BaseMap<Country>
    {
        public CountryMap()
        {
            ToTable("dbo.Countries");

            Property(x => x.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x => x.Name).HasMaxLength(255).IsRequired();

            Property(x => x.Code).HasMaxLength(255).IsRequired();

            Property(x => x.Status).IsRequired();
        }
    }
}
