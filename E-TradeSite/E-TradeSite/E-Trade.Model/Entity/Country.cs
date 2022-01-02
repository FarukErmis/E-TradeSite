using E_Trade.Model.Enum;
using System.Collections.Generic;

namespace E_Trade.Model.Entity
{
    public class Country
    {
        public Country()
        {
            Regions = new HashSet<Region>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public CountryStatus Status { get; set; }
        public ICollection<Region> Regions { get; set; }
    }
}
