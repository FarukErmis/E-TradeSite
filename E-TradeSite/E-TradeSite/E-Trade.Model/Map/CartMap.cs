using E_Trade.Model.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Trade.Model.Map
{
    public class CartMap : BaseMap<Cart>
    {
        public CartMap()
        {
            ToTable("dbo.Carts");

            Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.SessionId).HasMaxLength(255).IsRequired();
            Property(x => x.Locked).IsRequired();
            Property(x => x.CreatedAt).HasColumnType("datetime2").IsOptional();
            Property(x => x.UpdatedAt).HasColumnType("datetime2").IsOptional();
            Property(x => x.ShopCampaignId).IsOptional();
            Property(x => x.MemberId).IsOptional();
            Property(x => x.ShopTokenId).IsOptional();
        }
    }
}
