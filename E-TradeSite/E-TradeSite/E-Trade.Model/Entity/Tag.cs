using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Trade.Model.Entity
{
    public class Tag
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [Range(0,1000)]
        public int Count { get; set; }
        public string PageTitle { get; set; }
        public string MetaDescription { get; set; }
        public string MetaKeyWords { get; set; }
    }
}
