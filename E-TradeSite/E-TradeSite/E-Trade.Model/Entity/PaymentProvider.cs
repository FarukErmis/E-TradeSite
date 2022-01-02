using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Trade.Model.Entity
{
    public class PaymentProvider
    {
        public PaymentProvider()
        {
            PaymentGateways = new HashSet<PaymentGateway>();
        }
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public bool Status { get; set; }
        [ForeignKey("Payment")]
        public int PaymentId { get; set; }
        [ForeignKey("PaymentProviderSetting")]
        public int PaymentProviderSettingId { get; set; }
        public Payment Payment { get; set; }
        public PaymentProviderSetting PaymentProviderSetting { get; set; }
        public ICollection<PaymentGateway> PaymentGateways { get; set; }
    }
}
