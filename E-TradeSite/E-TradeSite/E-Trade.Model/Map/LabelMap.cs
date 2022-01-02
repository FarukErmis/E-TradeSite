using E_Trade.Model.Entity;
using System.ComponentModel.DataAnnotations.Schema;

namespace E_Trade.Model.Map
{
    public class LabelMap : BaseMap<Label>
    {
        public LabelMap()
        {
            ToTable("dbo.Labels");

            Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.Name).HasMaxLength(255).IsRequired();
            Property(x => x.SortOrder).IsOptional();
            Property(x => x.HasChildren).IsOptional();
            Property(x => x.Slug).HasMaxLength(255).IsOptional();
            Property(x => x.MetaTitle).HasMaxLength(255).IsOptional();
            Property(x => x.MetaKeyWords).HasMaxLength(255).IsOptional();
            Property(x => x.MetaDescription).HasMaxLength(255).IsOptional();
            Property(x => x.Status).IsRequired();
            Property(x => x.Parent).IsOptional();
            Property(x => x.CreatedAt).HasColumnType("datetime2").IsOptional();
            Property(x => x.UpdatedAt).HasColumnType("datetime2").IsOptional();
        }
    }
}
