using Core.Entities;

namespace Core.Models
{
    public class DepositDTO
    {
        public int AccountId { get; set; }
        public int BankId { get; set; }
        public decimal Amount { get; set; }
        public DateTime TransactionDate { get; set; }

        public DepositDTO(Deposit deposit)
        {
            AccountId = deposit.AccountId;
            BankId = deposit.BankId;
            Amount = deposit.Amount;
            TransactionDate = deposit.TransactionDate;
        }
    }
}