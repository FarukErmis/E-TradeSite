using E_Trade.Model.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Trade.Model.Map
{
    public class CurrentAccountMap : BaseMap<CurrentAccount>
    {
        public CurrentAccountMap()
        {
            ToTable("dbo.CurrentAccounts");

            Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.Code).HasMaxLength(255).IsOptional();
            Property(x => x.Title).HasMaxLength(255).IsRequired();
            Property(x => x.Balance);
            Property(x => x.RiskLimit);
            Property(x => x.CreatedAt).HasColumnType("datetime2").IsOptional();
            Property(x => x.UpdatedAt).HasColumnType("datetime2").IsOptional();
        }
    }
}
