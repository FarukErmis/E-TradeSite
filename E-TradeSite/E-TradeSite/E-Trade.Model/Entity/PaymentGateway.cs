using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace E_Trade.Model.Entity
{
    public class PaymentGateway
    {
        public PaymentGateway()
        {
            PaymentGatewaySettings = new HashSet<PaymentGatewaySetting>();
            InstallmentRates = new HashSet<InstallmentRate>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public bool Status { get; set; }
        [Range(0,10000)]
        public int SortOrder { get; set; }
        [ForeignKey("PaymentProvider")]
        public int PaymentProviderId { get; set; }
        public PaymentProvider PaymentProvider { get; set; }
        public ICollection<PaymentGatewaySetting> PaymentGatewaySettings { get; set; }
        public ICollection<InstallmentRate> InstallmentRates { get; set; }
    }
}
