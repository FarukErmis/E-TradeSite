using E_Trade.Model.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Trade.Model.Map
{
    public class UserMap : BaseMap<User>
    {
        public UserMap()
        {
            ToTable("dbo.Users");

            Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.FirstName).HasMaxLength(255).IsOptional();
            Property(x => x.SurName).HasMaxLength(255).IsOptional();
            Property(x => x.Email).HasMaxLength(255).IsRequired();
            Property(x => x.UserName).HasMaxLength(255).IsRequired();
            Property(x => x.PhoneNumber).HasMaxLength(255).IsOptional();
            Property(x => x.Status).IsRequired();
            Property(x => x.IsOwner).IsOptional();
            Property(x => x.MemberGroupId).IsOptional();
            Property(x => x.SmsApproved).IsOptional();
            Property(x => x.ShopUserLevelId).IsOptional();
        }
    }
}
