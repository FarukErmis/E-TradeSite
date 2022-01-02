using E_Trade.Model.Entity;
using System.ComponentModel.DataAnnotations.Schema;

namespace E_Trade.Model.Map
{
    public class ProductCommentMap : BaseMap<ProductComment>
    {
        public ProductCommentMap()
        {
            ToTable("dbo.ProductComments");

            Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.ProductId).IsRequired();
            Property(x => x.Comment).IsRequired();
            Property(x => x.Rate).IsRequired();
            Property(x => x.UserName).IsRequired();
            Property(x => x.UserSurname).IsRequired();
            Property(x => x.UserAvatar).IsOptional();
            Property(x => x.WritingDate).IsRequired();
            Property(x => x.ThumbsUp).IsOptional();
            Property(x => x.ThumbsDown).IsOptional();
        }
    }
}