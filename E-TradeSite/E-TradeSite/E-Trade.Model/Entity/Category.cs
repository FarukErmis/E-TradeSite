using E_Trade.Model.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace E_Trade.Model.Entity
{
    public class Category
    {
        public Category()
        {
            Category2 = new HashSet<Category>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Slug { get; set; }
        [Range(0,999)]
        public int SortOrder { get; set; }
        public bool Status { get; set; }
        public string DistributorCode { get; set; }
        [Range(0, 10000)]
        public byte Percent { get; set; }
        public string ImageFile { get; set; }
        public string Distributor { get; set; }
        public bool DisplayShowContent { get; set; }
        public string ShowcaseContent{ get; set; }
        public CategoryShowcaseContentDisplayType ShowcaseContentDisplayType { get; set; }
        public int DisplayShowcaseFooterContent { get; set; }
        public string ShowcaseFooterContent { get; set; }
        public int ShowcaseFooterContentDisplayType { get; set; }
        public bool HasChildren { get; set; }
        public string MetaKeyWords { get; set; }
        public string MetaDescription { get; set; }
        public string PageTitle { get; set; }
        [ForeignKey("Category1")]
        public int Parent { get; set; }
        public string Attachment { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public Category Category1 { get; set; }
        public ICollection<Category> Category2 { get; set; }
    }
}
