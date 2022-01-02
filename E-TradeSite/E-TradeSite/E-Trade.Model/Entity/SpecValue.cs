using E_Trade.Model.Enum;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace E_Trade.Model.Entity
{
    public class SpecValue
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Slug { get; set; }
        [Range(0, 1000)]
        public int SortOrder { get; set; }
        public Logo Logo { get; set; }
        public bool Status { get; set; }
        public string Attachment { get; set; }
        [ForeignKey("SpecGroup")]
        public int SpecGroupId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public SpecGroup SpecGroup { get; set; }
    }
}
