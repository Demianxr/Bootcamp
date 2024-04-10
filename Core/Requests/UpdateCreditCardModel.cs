using Core.Constants;
using Core.Entities;

namespace Core.Requests;
    public class UpdateCreditCardModel
    {
        public int Id { get; set; }
        public string Designation { get; set; } = string.Empty;
        public DateTime? IssueDate { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public string CardNumber { get; set; } = string.Empty;
        public int CVV { get; set; }

        public string CreditCardStatus { get; set; } = string.Empty;

        public decimal CreditLimit { get; set; }
        public decimal Availablecredit { get; set; }
        public decimal Currentdebt { get; set; }
        public decimal InterestRate { get; set; }
        public int CustomerId { get; set; }
        public int CurrencyId { get; set; }
        
    }

