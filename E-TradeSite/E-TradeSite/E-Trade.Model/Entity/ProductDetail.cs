using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Trade.Model.Entity
{
    public class ProductDetail
    {
        public int Id { get; set; }
        public string Sku { get; set; }
        public string Details { get; set; }
        public string ExtraDetails { get; set; }
        [ForeignKey("Product")]
        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
