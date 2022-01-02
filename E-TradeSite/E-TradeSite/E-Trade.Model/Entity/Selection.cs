using System.ComponentModel.DataAnnotations.Schema;

namespace E_Trade.Model.Entity
{
    public class Selection
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int SortOrder { get; set; }
        [ForeignKey("SelectionGroup")]
        public int SelectionGroupId { get; set; }
        public SelectionGroup SelectionGroup { get; set; }
    }
}
