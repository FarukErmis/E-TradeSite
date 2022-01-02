using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace E_Trade.Model.Entity
{
    public class CurrentAccount
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Title { get; set; }
        public float Balance { get; set; }
        [Range(0,10000)]
        public float RiskLimit { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        [ForeignKey("Member")]
        public int MemberId { get; set; }
        public Member Member { get; set; }

    }
}
