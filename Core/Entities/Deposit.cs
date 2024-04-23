 public class Deposit
    {
        public string AccountId { get; set; }
        public string BankId { get; set; }
        public decimal Amount { get; set; }
        public DateTime TransactionDate { get; set; }

        public Deposit(string accountId, string bankId, decimal amount)
        {
            if (string.IsNullOrEmpty(accountId) || string.IsNullOrEmpty(bankId) || amount <= 0)
            {
                throw new ArgumentException("Invalid arguments");
            }

            AccountId = accountId;
            BankId = bankId;
            Amount = amount;
            TransactionDate = DateTime.Now;
        }

        
        public bool ValidateAmount(decimal operationalLimit)
        {
            if (Amount > operationalLimit)
            {
                return false;
            }
            return true;
        }


        public void UpdateBalance(Account account)
        {
            if (account == null)
            {
                throw new ArgumentNullException(nameof(account));
            }

            if (account.Balance + Amount > 100000)
            {
                throw new InvalidOperationException("Operational limit exceeded");
            }

            account.Balance += Amount;
        }
    }

