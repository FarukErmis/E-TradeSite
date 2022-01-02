using E_Trade.Model.Entity;
using System.ComponentModel.DataAnnotations.Schema;

namespace E_Trade.Model.Map
{
    public class CartItemMap : BaseMap<CartItem>
    {
        public CartItemMap()
        {
            ToTable("dbo.CartItems");

            Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.ParentProductId).IsOptional();
            Property(x => x.Quantity).IsRequired();
            Property(x => x.CategoryId).IsOptional();
            Property(x => x.CreatedAt).HasColumnType("datetime2").IsOptional();
            Property(x => x.UpdatedAt).HasColumnType("datetime2").IsOptional();
            Property(x => x.CartId).IsRequired();
            Property(x => x.ProductId).IsRequired();
        }
    }
}
