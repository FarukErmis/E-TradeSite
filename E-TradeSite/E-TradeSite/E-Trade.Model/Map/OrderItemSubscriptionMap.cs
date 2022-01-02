using E_Trade.Model.Entity;
using System.ComponentModel.DataAnnotations.Schema;

namespace E_Trade.Model.Map
{
    public class OrderItemSubscriptionMap : BaseMap<OrderItemSubscription>
    {
        public OrderItemSubscriptionMap()
        {
            ToTable("dbo.OrderItemSubscription");

            Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
        }
    }
}
