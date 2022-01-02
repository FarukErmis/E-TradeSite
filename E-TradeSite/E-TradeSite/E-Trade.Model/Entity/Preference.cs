using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Trade.Model.Entity
{
    public class Preference
    {
        public int Id { get; set; }
        public string VarKey { get; set; }
        public string VarValue { get; set; }
    }
}
