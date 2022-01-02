using E_Trade.Model.Enum;
using System;
using System.ComponentModel.DataAnnotations;

namespace E_Trade.Model.Entity
{
    public class Options
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Slug { get; set; }
        [Range(0,10000)]
        public int SortOrder { get; set; }
        public Logo Logo { get; set; }
        public string Attachment { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
