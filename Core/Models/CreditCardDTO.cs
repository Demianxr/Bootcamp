using Core.Constants;

namespace Core.Models;
    public class CreditCardDTO
    {
        public int Id { get; set; }
        public string Designation { get; set; } = string.Empty;
        public DateTime? IssueDate { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public string CardNumber { get; set; } = string.Empty;
        public int CVV { get; set; }

        public CreditCardStatus CreditCardStatus { get; set; } = CreditCardStatus.Enabled;

        public decimal CreditLimit { get; set; }
        public decimal Availablecredit { get; set; }
        public decimal Currentdebt { get; set; }
        public decimal InterestRate { get; set; }
        public int CustomerId { get; set; }
        public int CurrencyId { get; set; }
        public CustomerDTO Customer { get; set; } = null!;
        public CurrencyDTO Currency { get; set; } = null!;
    }

