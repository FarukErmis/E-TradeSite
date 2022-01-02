using E_Trade.Model.Entity;
using System.ComponentModel.DataAnnotations.Schema;

namespace E_Trade.Model.Map
{
    public class SelectionGroupMap : BaseMap<SelectionGroup>
    {
        public SelectionGroupMap()
        {
            ToTable("dbo.SelectionGroups");

            Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.Title).HasMaxLength(255).IsRequired();
            Property(x => x.SortOrder).IsRequired();
        }
    }
}
