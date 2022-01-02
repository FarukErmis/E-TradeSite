using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Trade.Model.Entity
{
    public class OrderUserNote
    {
        public int Id { get; set; }
        public string UserFirstName { get; set; }
        public string UserSurName { get; set; }
        public string UserEmail { get; set; }
        public string Note { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int OrderId { get; set; }
        public Order Order { get; set; }
    }
}
