﻿using E_Trade.Model.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Trade.Model.Map
{
    public class ProductImageMap : BaseMap<ProductImage>
    {
        public ProductImageMap()
        {
            ToTable("dbo.ProductImages");

            Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.FileName).HasMaxLength(255).IsRequired();
            Property(x => x.Extension).IsRequired();
            Property(x => x.DirectoryName).HasMaxLength(10).IsOptional();
            Property(x => x.Revision).HasMaxLength(30).IsOptional();
            Property(x => x.SortOrder).IsRequired();
            Property(x => x.ProductId).IsRequired();
            Property(x => x.Attachment).IsRequired();
        }
    }
}
