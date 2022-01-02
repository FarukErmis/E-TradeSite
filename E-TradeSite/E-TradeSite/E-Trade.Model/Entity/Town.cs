using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace E_Trade.Model.Entity
{
    public class Town
    {
        public Town()
        {
            MemberAddresses = new HashSet<MemberAddress>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Status { get; set; }
        [ForeignKey("Location")]
        public int LocationId { get; set; }
        [ForeignKey("TownGroup")]
        public int TownGroupId { get; set; }
        public Location Location { get; set; }
        public TownGroup TownGroup { get; set; }
        public ICollection<MemberAddress> MemberAddresses { get; set; }
    }
}
