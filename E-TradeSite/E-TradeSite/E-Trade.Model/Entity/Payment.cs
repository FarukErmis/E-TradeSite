using E_Trade.Model.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace E_Trade.Model.Entity
{
    public class Payment
    {
        public Payment()
        {
            Payments = new HashSet<Payment>();
        }
        public int Id { get; set; }
        public string MemberFirstName { get; set; }
        public string MemberSurName { get; set; }
        public string MemberEmail { get; set; }
        public string MemberPhone { get; set; }
        public string PaymentTypeName { get; set; }
        public string PaymentProviderCode { get; set; }
        public string PaymentProviderName { get; set; }
        public string PaymentGatewayName { get; set; }
        public string PaymentGatewayCode { get; set; }
        public string BankName { get; set; }
        public OrderDeviceType DeviceType { get; set; }
        public string ClientIp { get; set; }
        public string CurrencyRates { get; set; }
        [Range(0,10000)]
        public float Amount { get; set; }
        [Range(0, 10000)]
        public float FinalAmount { get; set; }
        [Range(0, 10000)]
        public float SumOfGainedPoints { get; set; }
        [Range(0, 12)]
        public int Installment { get; set; }
        public float InstallmentRate { get; set; }
        [Range(0, 12)]
        public int ExtraInstallment { get; set; }
        public string Currency { get; set; }
        public string TransactionId { get; set; }
        public string MemberNote { get; set; }
        public string UserNote { get; set; }
        public PaymentStatus Status { get; set; }
        public string ErrorMessage { get; set; }
        public string CardSavingSystem { get; set; }
        public DateTime CreatedAt { get; set; }
        [ForeignKey("Member")]
        public int MemberId { get; set; }
        public Member Member { get; set; }
        public ICollection<Payment> Payments { get; set; }
    }
}
