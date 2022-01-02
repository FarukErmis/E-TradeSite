using E_Trade.Model.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Trade.Model.Map
{
    public class ProductButtonMap : BaseMap<ProductButton>
    {
        public ProductButtonMap()
        {
            ToTable("dbo.ProductButton");

            Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.FastShipping).IsOptional();
            Property(x => x.SameDayShipping).IsOptional();
            Property(x => x.ThreeDaysDelivery).IsOptional();
            Property(x => x.FiveDaysDelivery).IsOptional();
            Property(x => x.SevenDaysDelivery).IsOptional();
            Property(x => x.FreeShipping).IsOptional();
            Property(x => x.DeliveryFromStock).IsOptional();
            Property(x => x.PreOrderedProduct).IsOptional();
            Property(x => x.LimitedStock).IsOptional();
            Property(x => x.CampaignedProduct).IsOptional();
            Property(x => x.ProductId).IsOptional();
        }
    }
}
