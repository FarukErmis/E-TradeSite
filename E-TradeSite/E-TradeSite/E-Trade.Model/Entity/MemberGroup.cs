using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Trade.Model.Entity
{
    public class MemberGroup
    {
        public MemberGroup()
        {
            Users = new HashSet<User>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        [Range(1,5)]
        public int PriceIndex { get; set; }
        public string AllowedPaymentGateWays { get; set; }
        public ICollection<User> Users { get; set; }
    }
}
