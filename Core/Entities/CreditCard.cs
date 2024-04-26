using Core.Constants;

namespace Core.Entities;
    public class CreditCard
    {
        public int Id { get; set; }
        public string Designation {  get; set; } = string.Empty;
        public DateTime? IssueDate { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public string CardNumber { get; set; } = string.Empty;
        public int CVV { get; set; }

        public ECreditCardStatus CreditCardStatus { get; set; } = ECreditCardStatus.Enabled;

        public decimal CreditLimit { get; set; }
        public decimal Availablecredit { get; set; }
        public decimal Currentdebt { get; set; }
        public decimal InterestRate { get; set; }
        




    }

