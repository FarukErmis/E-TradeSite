using E_Trade.Model.Entity;
using System.ComponentModel.DataAnnotations.Schema;

namespace E_Trade.Model.Map
{
    public class PaymentTypeMap : BaseMap<PaymentType>
    {
        public PaymentTypeMap()
        {
            ToTable("dbo.PaymentTypes");

            Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.Name).HasMaxLength(255).IsRequired();
        }
    }
}
