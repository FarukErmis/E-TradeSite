using E_Trade.Model.Enum;
using System.ComponentModel.DataAnnotations;

namespace E_Trade.Model.Entity
{
    public class PurchaseLimitation
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [Range(0,1000)]
        public int MinumumLimit { get; set; }
        [Range(0, 1000)]
        public int MaximumLimit { get; set; }
        public PurchaseLimitationType Type { get; set; }
        public bool Status { get; set; }
    }
}
