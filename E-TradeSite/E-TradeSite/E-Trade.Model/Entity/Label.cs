using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Trade.Model.Entity
{
    public class Label
    {
        public Label()
        {
            Label2 = new List<Label>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        [Range(0,1000)]
        public int SortOrder { get; set; }
        public bool HasChildren { get; set; }
        public string Slug { get; set; }
        public string MetaTitle { get; set; }
        public string MetaKeyWords { get; set; }
        public string MetaDescription { get; set; }
        public bool Status { get; set; }
        [ForeignKey("Label1")]
        public int Parent { get; set; }
        public Label Label1 { get; set; }
        public ICollection<Label> Label2 { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
