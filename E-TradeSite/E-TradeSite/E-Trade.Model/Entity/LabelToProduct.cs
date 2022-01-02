using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Trade.Model.Entity
{
    public class LabelToProduct
    {
        public int Id { get; set; }
        [ForeignKey("Label")]
        public int LabelId { get; set; }
        [ForeignKey("Product")]
        public int ProductId { get; set; }
        public Label Label { get; set; }
        public Product Product { get; set; }
    }
}
