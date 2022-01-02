using System;
using System.ComponentModel.DataAnnotations;

namespace E_Trade.Model.Entity
{
    public class Currency
    {
        public int Id { get; set; }
        public string Label { get; set; }
        [Range(0,10000)]
        public float BuyingPrice { get; set; }
        [Range(0, 10000)]
        public float SellingPrice { get; set; }
        public string Abbr { get; set; }
        public DateTime UpdatedAt { get; set; }
        public bool Status { get; set; }
        public bool IsPrimary { get; set; }
    }
}
