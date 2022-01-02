using E_Trade.Model.Entity;
using System.ComponentModel.DataAnnotations.Schema;

namespace E_Trade.Model.Map
{
    public class BrandMap : BaseMap<Brand>
    {
        public BrandMap()
        {
            ToTable("dbo.Brands");

            Property(x => x.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x => x.Name)
                .HasMaxLength(255)
                .IsRequired();

            Property(x => x.Slug)
                .HasMaxLength(255).IsOptional();

            Property(x => x.SortOrder) //
                .IsRequired();

            Property(x => x.Status)
                .IsRequired();

            Property(x => x.DistributorCode)
               .HasMaxLength(255).IsOptional();

            Property(x => x.Distributor)
               .HasMaxLength(255).IsOptional();

            Property(x => x.ImageFile)
               .HasMaxLength(255).IsOptional();

            Property(x => x.ShowCaseContent)
               .HasMaxLength(63535).IsOptional();

            Property(x => x.DisplayShowContent)
               .IsRequired();

            Property(x => x.MetaKeyWords)
               .HasMaxLength(63535).IsOptional();

            Property(x => x.Metadescription)
               .HasMaxLength(63535).IsOptional();

            Property(x => x.PageTitle)
               .HasMaxLength(255).IsOptional();

            Property(x => x.Attachment).IsOptional();

            Property(x => x.CreatedAt)
                .HasColumnType("datetime2").IsOptional();

            Property(x => x.UpdatedAt)
                .HasColumnType("datetime2").IsOptional();
        }
    }
}
