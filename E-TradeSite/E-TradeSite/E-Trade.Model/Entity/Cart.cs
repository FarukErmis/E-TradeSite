using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Trade.Model.Entity
{
    public class Cart
    {
        public Cart()
        {
            CartItems = new HashSet<CartItem>();
        }
        public int Id { get; set; }
        public string SessionId { get; set; }
        public bool Locked { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        [ForeignKey("ShopCampaign")]
        public int ShopCampaignId { get; set; }
        [ForeignKey("Member")]
        public int MemberId { get; set; }
        [ForeignKey("ShopToken")]
        public int ShopTokenId { get; set; }
        public ShopCampaign ShopCampaign { get; set; }
        public Member Member { get; set; }
        public ShopToken ShopToken { get; set; }
        public ICollection<CartItem> CartItems { get; set; }
    }
}
