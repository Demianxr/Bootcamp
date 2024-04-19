namespace Core.Entities
{
    public class Withdrawal
    {
        public int Id { get; set; }
        public int AccountId { get; set; }
        public int BankId { get; set; }
        public decimal Amount { get; set; }
        public DateTime OperationDate { get; set; }

        public Withdrawal(int accountId, int bankId, decimal amount)
        {
            AccountId = accountId;
            BankId = bankId;
            Amount = amount;
            OperationDate = DateTime.Now;
        }
    }
}
