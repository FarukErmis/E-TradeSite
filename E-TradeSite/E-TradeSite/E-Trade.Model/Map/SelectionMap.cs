using E_Trade.Model.Entity;
using System.ComponentModel.DataAnnotations.Schema;

namespace E_Trade.Model.Map
{
    public class SelectionMap : BaseMap<Selection>
    {
        public SelectionMap()
        {
            ToTable("dbo.Selections");

            Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.Title).HasMaxLength(255).IsOptional();
            Property(x => x.SortOrder).IsRequired();
            Property(x => x.SelectionGroupId).IsRequired();
        }
    }
}
