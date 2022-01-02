using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Trade.Model.Entity
{
    public class OrderItemCustomization
    {
        public int Id { get; set; }
        public int GroupId { get; set; }
        public string GroupName { get; set; }
        public int SortOrder { get; set; }
        public int FieldId { get; set; }
        public string FieldType { get; set; }
        public string FieldName { get; set; }
        public string FieldValue { get; set; }
        public int CartItemAttributed { get; set; }
    }
}
