using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Trade.Model.Entity
{
    public class InstallmentRate
    {
        public int Id { get; set; }
        public int Installment { get; set; }
        [Range(0, 100)]
        public float Rate { get; set; }
        [ForeignKey("PaymentGateway")]
        public int PaymentGatewayId { get; set; }
        public PaymentGateway PaymentGateway { get; set; }
    }
}
