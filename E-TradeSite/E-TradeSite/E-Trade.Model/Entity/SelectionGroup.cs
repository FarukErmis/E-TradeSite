using System.Collections.Generic;

namespace E_Trade.Model.Entity
{
    public class SelectionGroup
    {
        public SelectionGroup()
        {
            Selections = new HashSet<Selection>();
        }
        public int Id { get; set; }
        public string Title { get; set; }
        public int SortOrder { get; set; }
        public ICollection<Selection> Selections { get; set; }
    }
}
