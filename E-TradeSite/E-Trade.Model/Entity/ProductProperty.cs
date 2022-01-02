using System.ComponentModel.DataAnnotations;

namespace E_Trade.Model.Entity
{
    public partial class ProductProperty
    {
        public int Id { get; set; }

        public int ProductId { get; set; }

        [StringLength(50)]
        public string VarKey { get; set; }

        [StringLength(50)]
        public string VarValue { get; set; }

        public int? CategoryId { get; set; }

        public virtual Product Product { get; set; }
    }
}
