using E_Trade.Model.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Trade.Model.Map
{
    public class ShopCampaignMap : BaseMap<ShopCampaign>
    {
        public ShopCampaignMap()
        {
            ToTable("dbo.ShopCampaigns");

            Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.Label).HasMaxLength(255).IsOptional();
            Property(x => x.CreatedAt).IsOptional();
            Property(x => x.UpdatedAt).IsOptional();
        }
    }
}
