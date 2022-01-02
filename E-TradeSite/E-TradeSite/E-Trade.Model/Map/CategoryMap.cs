using E_Trade.Model.Entity;
using System.ComponentModel.DataAnnotations.Schema;

namespace E_Trade.Model.Map
{
    public class CategoryMap : BaseMap<Category>
    {
        public CategoryMap()
        {
            ToTable("dbo.Categories");

            Property(x => x.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x => x.Name)
                .HasMaxLength(255)
                .IsRequired();

            Property(x => x.Slug)
                .HasMaxLength(255).IsOptional();

            Property(x => x.SortOrder).IsOptional();

            Property(x => x.Status)
                .IsRequired();

            Property(x => x.DistributorCode)
                .HasMaxLength(255).IsOptional();

            Property(x => x.Percent).IsOptional();

            Property(x => x.ImageFile)
                .HasMaxLength(255).IsOptional();

            Property(x => x.Distributor)
                .HasMaxLength(255).IsOptional();

            Property(x => x.DisplayShowContent)
                .IsRequired();

            Property(x => x.ShowcaseContent)
                .HasMaxLength(65535).IsOptional();

            Property(x => x.ShowcaseContentDisplayType)
                .IsRequired();

            Property(x => x.DisplayShowcaseFooterContent)
                .IsRequired();

            Property(x => x.ShowcaseFooterContent)
                .HasMaxLength(65535).IsOptional();

            Property(x => x.ShowcaseFooterContentDisplayType)
                .IsRequired();

            Property(x => x.HasChildren)
                .IsOptional();

            Property(x => x.MetaKeyWords)
                .HasMaxLength(65535).IsOptional();

            Property(x => x.MetaDescription)
                .HasMaxLength(65535).IsOptional();

            Property(x => x.ShowcaseContent)
                .HasMaxLength(65535).IsOptional();

            Property(x => x.PageTitle)
                .HasMaxLength(65535).IsOptional();

            Property(x => x.Parent).IsOptional();

            Property(x => x.PageTitle).IsOptional();
            Property(x => x.Attachment).IsOptional();

            Property(x => x.CreatedAt).IsOptional()
                .HasColumnType("datetime2");

            Property(x => x.UpdatedAt).IsOptional()
                .HasColumnType("datetime2");
        }
    }
}
