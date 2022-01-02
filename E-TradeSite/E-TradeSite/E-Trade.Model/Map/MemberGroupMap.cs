using E_Trade.Model.Entity;
using System.ComponentModel.DataAnnotations.Schema;

namespace E_Trade.Model.Map
{
    public class MemberGroupMap : BaseMap<MemberGroup>
    {
        public MemberGroupMap()
        {
            ToTable("dbo.MemberGroups");

            Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.Name).HasMaxLength(255).IsRequired();
            Property(x => x.PriceIndex).IsRequired();
            Property(x => x.Name).HasMaxLength(512).IsRequired();
        }
    }
}
