using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Trade.Model.Entity
{
    public class DistributorToProduct
    {
        public int Id { get; set; }

        [ForeignKey("Distributor")]
        public int DistrubtorId { get; set; }
        [ForeignKey("Product")]
        public int ProductId { get; set; }
        public Distributor Distributor { get; set; }
        public Product Product { get; set; }

    }
}
