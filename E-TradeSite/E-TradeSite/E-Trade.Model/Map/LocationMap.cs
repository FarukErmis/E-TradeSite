using E_Trade.Model.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Trade.Model.Map
{
    public class LocationMap : BaseMap<Location>
    {
        public LocationMap()
        {
            ToTable("dbo.Locations");

            Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.Name).HasMaxLength(255).IsRequired();
            Property(x => x.Status).IsRequired();
            Property(x => x.Predefined).IsOptional();
            Property(x => x.CountryId).IsOptional();
            Property(x => x.RegionId).IsOptional();
        }
    }
}
