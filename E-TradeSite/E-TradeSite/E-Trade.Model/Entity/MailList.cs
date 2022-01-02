using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace E_Trade.Model.Entity
{
    public class MailList
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string LastMailSentDate { get; set; }
        public string CreatorIpAddress { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        [ForeignKey("MailListGroup")]
        public int MailListGroupId { get; set; }
        public MailListGroup MailListGroup { get; set; }
    }
}
