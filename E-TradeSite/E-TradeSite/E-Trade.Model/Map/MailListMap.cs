using E_Trade.Model.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Trade.Model.Map
{
    public class MailListMap : BaseMap<MailList>
    {
        public MailListMap()
        {
            ToTable("dbo.MailLists");

            Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.Name).HasMaxLength(255).IsRequired();
            Property(x => x.Email).HasMaxLength(255).IsRequired();
            Property(x => x.LastMailSentDate).IsOptional();
            Property(x => x.CreatorIpAddress).HasMaxLength(64).IsOptional();
            Property(x => x.CreatedAt).HasColumnType("datetime2").IsRequired();
            Property(x => x.UpdatedAt).HasColumnType("datetime2").IsRequired();
            Property(x => x.MailListGroupId).IsRequired();
        }
    }
}
