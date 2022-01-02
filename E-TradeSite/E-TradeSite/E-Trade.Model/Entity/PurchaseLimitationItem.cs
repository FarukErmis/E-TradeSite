using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Trade.Model.Entity
{
    public class PurchaseLimitationItem
    {
        public int Id { get; set; }
        [ForeignKey("Brand")]
        public int BrandId { get; set; }
        [ForeignKey("Category")]
        public int CategoryId { get; set; }
        [ForeignKey("PurchaseLimitation")]
        public int PurchaseLimitationId { get; set; }
        [ForeignKey("MemberGroup")]
        public int MemberGroupId { get; set; }
        [ForeignKey("Product")]
        public int ProductId { get; set; }
        public Brand Brand { get; set; }
        public Category Category { get; set; }
        public PurchaseLimitation PurchaseLimitation { get; set; }
        public MemberGroup MemberGroup { get; set; }
        public Product Product { get; set; }
    }
}
