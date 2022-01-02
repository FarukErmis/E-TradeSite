using E_Trade.Model.Enum;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace E_Trade.Model.Entity
{
    public class Location
    {
        public Location()
        {
            Members = new HashSet<Member>();
            Towns = new HashSet<Town>();
            MemberAddresses = new HashSet<MemberAddress>();
            PreOrderInfos = new HashSet<PreOrderInfo>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Status { get; set; }
        public LocationPredefined Predefined { get; set; }
        [ForeignKey("Country")]
        public int CountryId { get; set; }
        [ForeignKey("Region")]
        public int RegionId { get; set; }
        public Country Country { get; set; }
        public Region Region { get; set; }
        public ICollection<Member> Members { get; set; }
        public ICollection<Town> Towns { get; set; }
        public ICollection<MemberAddress> MemberAddresses { get; set; }
        public ICollection<PreOrderInfo> PreOrderInfos { get; set; }
    }
}
