﻿using E_Trade.Model.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Trade.Model.Map
{
    public class OrderItemMap : BaseMap<OrderItem>
    {
        public OrderItemMap()
        {
            ToTable("dbo.OrderItems");

            Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.ProductName).HasMaxLength(255).IsRequired();
            Property(x => x.ProductSku).HasMaxLength(255).IsRequired();
            Property(x => x.ProductBarcode).HasMaxLength(255).IsOptional();
            Property(x => x.ProductPrice).IsRequired();
            Property(x => x.ProductCurrency).HasMaxLength(255).IsRequired();
            Property(x => x.ProductQuantity).IsRequired();
            Property(x => x.ProductTax).IsRequired();
            Property(x => x.ProductDiscount).IsRequired();
            Property(x => x.ProductMoneyOrderDiscount).IsRequired();
            Property(x => x.ProductWeight).IsRequired();
            Property(x => x.ProductStockTypeLabel).IsRequired();
            Property(x => x.IsProductPromotioned).IsRequired();
            Property(x => x.Discount).IsRequired();
            Property(x => x.OrderId).IsOptional();
            Property(x => x.ProductId).IsOptional();
            Property(x => x.OrderItemCustomazitionId).IsOptional();
            Property(x => x.OrderItemSubscriptionId).IsOptional();
        }
    }
}
