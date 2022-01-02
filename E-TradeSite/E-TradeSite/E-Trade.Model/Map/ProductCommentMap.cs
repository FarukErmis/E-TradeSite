using E_Trade.Model.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Trade.Model.Map
{
    public class ProductCommentMap : BaseMap<ProductComment>
    {
        public ProductCommentMap()
        {
            ToTable("dbo.ProductComment");

            Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.Title).HasMaxLength(255).IsRequired();
            Property(x => x.Content).HasMaxLength(65535).IsRequired();
            Property(x => x.Status).IsRequired();
            Property(x => x.Rank).IsRequired();
            Property(x => x.IsAnonymous).IsRequired();
            Property(x => x.CreatedAt).HasColumnType("datetime2").IsOptional();
            Property(x => x.UpdatedAt).HasColumnType("datetime2").IsOptional();
            Property(x => x.ProductId).IsOptional();
            Property(x => x.MemberId).IsOptional();
        }
    }
}
