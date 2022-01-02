using E_Trade.Model.Enum;
using System.ComponentModel.DataAnnotations.Schema;

namespace E_Trade.Model.Entity
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string SurName { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public string PhoneNumber { get; set; }
        public UserStatus Status { get; set; }
        public bool IsOwner { get; set; }
        public bool SmsApproved { get; set; }
        [ForeignKey("ShopUserLevel")]
        public int ShopUserLevelId { get; set; }
        [ForeignKey("MemberGroup")]
        public int MemberGroupId { get; set; }
        public MemberGroup MemberGroup { get; set; }
        public ShopUserLevel ShopUserLevel { get; set; }
    }
}
