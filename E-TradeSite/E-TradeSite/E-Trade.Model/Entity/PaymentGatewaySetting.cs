using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Trade.Model.Entity
{
    public class PaymentGatewaySetting
    {
        public int Id { get; set; }
        public string VarKey { get; set; }
        public string VarValue { get; set; }
        [ForeignKey("PaymentGateway")]
        public int PaymentGateWayId { get; set; }
        public PaymentGateway PaymentGateway { get; set; }
    }
}
