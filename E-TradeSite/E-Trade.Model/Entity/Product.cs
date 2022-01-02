using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace E_Trade.Model.Entity
{

    public partial class Product
    {
        public Product()
        {
            ProductComments = new HashSet<ProductComment>();
            ProductImages = new HashSet<ProductImage>();
            ProductProperties = new HashSet<ProductProperty>();
        }

        public int Id { get; set; }

        public int CategoryId { get; set; }

        public int BrandId { get; set; }

        [StringLength(100)]
        public string ProuductName { get; set; }

        public double? TotalPrice { get; set; }

        public double TrullyPrice { get; set; }

        [Range(0,100)]
        public double? Discount { get; set; }

        public double? Rates { get; set; }

        public bool? IsShippingFree { get; set; }

        public virtual Brand Brand { get; set; }

        public virtual Category Category { get; set; }

        public virtual ICollection<ProductComment> ProductComments { get; set; }

        public virtual ICollection<ProductImage> ProductImages { get; set; }

        public virtual ICollection<ProductProperty> ProductProperties { get; set; }
    }
}
