using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Trade.Model.Entity
{
    public class FavouritedProduct
    {
        public int Id { get; set; }
        [ForeignKey("Member")]
        public int MemberId { get; set; }
        [ForeignKey("Product")]
        public int ProductId { get; set; }
        public Member Member { get; set; }
        public Product Product { get; set; }
    }
}
