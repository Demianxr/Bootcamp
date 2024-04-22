namespace Core.Entities
{
    public class Deposit
    {
        public int AccountId { get; set; }
        public int BankId { get; set; }
        public decimal Amount { get; set; }
        public DateTime TransactionDate { get; set; }

        public Deposit(int accountId, int bankId, decimal amount)
        {
            AccountId = accountId;
            BankId = bankId;
            Amount = amount;
            TransactionDate = DateTime.Now;
        }

        public bool ValidateAmount(decimal operationalLimit)
        {
            if (Amount > operationalLimit)
            {
                Console.WriteLine("El monto sobrepasa el límite operacional.");
                return false;
            }
            return true;
        }

        public void UpdateBalance(ref decimal balance)
        {
            balance += Amount;
            Console.WriteLine($"El saldo se ha actualizado correctamente. Nuevo saldo: {balance}");
        }
    }
}

  
