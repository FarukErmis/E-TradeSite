using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Trade.Model.Entity
{
    public class ShopUserLevel
    {
        public ShopUserLevel()
        {
            Users = new HashSet<User>();
        }
        public int Id { get; set; }
        public string Label { get; set; }
        public string Roles { get; set; }
        public ICollection<User> Users { get; set; }
    }
}
