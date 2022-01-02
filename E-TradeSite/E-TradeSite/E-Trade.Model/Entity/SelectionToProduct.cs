using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Trade.Model.Entity
{
    public class SelectionToProduct
    {
        public int Id { get; set; }
        [ForeignKey("Selection")]
        public int SelectionId { get; set; }
        [ForeignKey("Product")]
        public int ProductId { get; set; }
        public Selection Selection { get; set; }
        public Product Product { get; set; }
    }
}
