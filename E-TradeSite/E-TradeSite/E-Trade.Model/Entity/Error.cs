using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Trade.Model.Entity
{
    public class Error
    {
        public int Id { get; set; }
        [Range(100,600)]
        public int Code { get; set; }
        public string ErrorMassage { get; set; }
        public int ErrorCode { get; set; }
    }
}
