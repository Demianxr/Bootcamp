namespace Core.Requests
{
    public class CreateTransactionModel
    {
        public TransactionType Type { get; set; } 
        public int AccountId { get; set; }
        public decimal Amount { get; set; }
        public string Description { get; set; }

       
    }

    public class TransactionType
    {
    }
}