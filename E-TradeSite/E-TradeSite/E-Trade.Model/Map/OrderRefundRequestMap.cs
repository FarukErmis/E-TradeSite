using E_Trade.Model.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Trade.Model.Map
{
    public class OrderRefundRequestMap : BaseMap<OrderRefundRequest>
    {
        public OrderRefundRequestMap()
        {
            ToTable("dbo.OrderRefundRequests");

            Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.Code).HasMaxLength(255).IsRequired();
            Property(x => x.Status).IsRequired();
            Property(x => x.Fee).IsRequired();
            Property(x => x.CancellationReason).HasMaxLength(512).IsOptional();
            Property(x => x.CreatedAt).HasColumnType("datetime2").IsOptional();
            Property(x => x.UpdatedAt).HasColumnType("datetime2").IsOptional();
            Property(x => x.MemberId).IsRequired();
            Property(x => x.OrderId).IsOptional();
        }
    }
}
