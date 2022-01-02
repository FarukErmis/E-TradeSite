using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Trade.Model.Entity
{
    public class ExtraInfo
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [Range(0,99)]
        public int SortOrder { get; set; }
    }
}
