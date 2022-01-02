using E_Trade.Model.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Trade.Model.Map
{
    public class DistributorMap : BaseMap<Distributor>
    {
        public DistributorMap()
        {
            ToTable("dbo.Distributors");

            Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x => x.Name).HasMaxLength(255).IsRequired();

            Property(x => x.Email).HasMaxLength(255).IsOptional();

            Property(x => x.Phone).HasMaxLength(255).IsOptional();

            Property(x => x.ContactPerson).HasMaxLength(255).IsOptional();
        }
    }
}
