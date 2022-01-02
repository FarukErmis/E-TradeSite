using System.Data.Entity.ModelConfiguration;

namespace E_Trade.Model.Map
{
    public class BaseMap<T>: EntityTypeConfiguration<T> where T: class
    {

    }
}