using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace E_Trade.Model.Entity
{
    public partial class Category
    {
        public Category()
        {
            Products = new HashSet<Product>();
        }
        public int Id { get; set; }
        [StringLength(50)]
        public string CategoryName { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
