using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Trade.Model.Entity
{
    public class OptionGroup
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Slug { get; set; }
        [Range(0, 10000)]
        public int SortOrder { get; set; }
        public bool FilterStatus { get; set; }

    }
}
