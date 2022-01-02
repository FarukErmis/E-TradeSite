using E_Trade.Model.Entity;
using System.ComponentModel.DataAnnotations.Schema;

namespace E_Trade.Model.Map
{
    public class CategoryMap : BaseMap<Category>
    {
        public CategoryMap()
        {
            ToTable("dbo.Categories");

            Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.CategoryName).HasMaxLength(50).IsRequired();
        }
    }
}