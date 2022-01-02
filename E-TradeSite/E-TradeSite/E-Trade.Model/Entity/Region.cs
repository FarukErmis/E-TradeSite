using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace E_Trade.Model.Entity
{
    public class Region
    {
        public Region()
        {
            ShippingRates = new HashSet<ShippingRate>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        [ForeignKey("Country")]
        public int CountryId { get; set; }
        public Country Country { get; set; }
        public ICollection<ShippingRate> ShippingRates { get; set; }
    }
}
