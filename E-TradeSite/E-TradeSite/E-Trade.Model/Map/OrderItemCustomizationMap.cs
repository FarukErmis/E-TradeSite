using E_Trade.Model.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Trade.Model.Map
{
    public class OrderItemCustomizationMap : BaseMap<OrderItemCustomization>
    {
        public OrderItemCustomizationMap()
        {
            ToTable("dbo.OrderItemCustomization");

            Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.GroupId).IsOptional();
            Property(x => x.GroupName).HasMaxLength(255).IsOptional();
            Property(x => x.SortOrder).IsOptional();
            Property(x => x.FieldId).IsOptional();
            Property(x => x.FieldType).HasMaxLength(64).IsOptional();
            Property(x => x.FieldName).HasMaxLength(255).IsOptional();
            Property(x => x.FieldValue).HasMaxLength(65535).IsOptional();
            Property(x => x.CartItemAttributed).IsOptional();
        }
    }
}
