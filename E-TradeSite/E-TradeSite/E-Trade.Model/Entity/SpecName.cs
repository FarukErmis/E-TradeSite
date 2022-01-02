using E_Trade.Model.Enum;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace E_Trade.Model.Entity
{
    public class SpecName
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Slug { get; set; }
        public SpecNameChoiceType ChoiceType { get; set; }
        [Range(0, 1000)]
        public int SortOrder { get; set; }
        public bool Status { get; set; }
        [ForeignKey("SpecGroup")]
        public int SpecGroupId { get; set; }
        public SpecGroup SpecGroup { get; set; }

    }
}
