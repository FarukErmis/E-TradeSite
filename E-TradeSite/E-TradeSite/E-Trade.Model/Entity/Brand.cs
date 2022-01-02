using System;
using System.ComponentModel.DataAnnotations;

namespace E_Trade.Model.Entity
{
    public class Brand
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Slug { get; set; }
        [Range(1,999)]
        public int SortOrder { get; set; }
        public bool Status { get; set; }
        public string DistributorCode { get; set; }
        public string Distributor { get; set; }
        public string ImageFile { get; set; }
        public string ShowCaseContent { get; set; }
        public bool DisplayShowContent { get; set; }
        public string MetaKeyWords { get; set; }
        public string Metadescription { get; set; }
        public string PageTitle { get; set; }
        public string Attachment { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        
    }
}
