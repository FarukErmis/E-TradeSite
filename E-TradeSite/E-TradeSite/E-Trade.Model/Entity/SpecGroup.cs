using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace E_Trade.Model.Entity
{
    public class SpecGroup
    {
        public SpecGroup()
        {
            SpecNames = new HashSet<SpecName>();
            SpecValues = new HashSet<SpecValue>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        [Range(0, 100)]
        public int SortOrder { get; set; }
        public bool Status { get; set; }
        public ICollection<SpecName> SpecNames { get; set; }
        public ICollection<SpecValue> SpecValues { get; set; }
    }
}
