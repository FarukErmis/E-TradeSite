using E_Trade.Model.Entity;
using System.ComponentModel.DataAnnotations.Schema;

namespace E_Trade.Model.Map
{
    public class ErrorMap : BaseMap<Error>
    {
        public ErrorMap()
        {
            ToTable("dbo.Errors");

            Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x => x.Code).IsOptional();

            Property(x => x.ErrorMassage).IsOptional();

            Property(x => x.ErrorCode).IsOptional();
        }
    }
}
