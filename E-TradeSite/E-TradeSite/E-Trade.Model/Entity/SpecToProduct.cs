using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Trade.Model.Entity
{
    public class SpecToProduct
    {
        public int Id { get; set; }
        [ForeignKey("Product")]
        public int ProductId { get; set; }
        [ForeignKey("SpecGroup")]
        public int SpecGroupId { get; set; }
        [ForeignKey("SpecName")]
        public int SpecNameId { get; set; }
        [ForeignKey("SpecValue")]
        public int SpecValueId { get; set; }
        public Product Product { get; set; }
        public SpecGroup SpecGroup { get; set; }
        public SpecName SpecName { get; set; }
        public SpecValue SpecValue { get; set; }
    }
}
