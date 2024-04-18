using Core.Requests;

namespace Core.Entities
{

    public class Transaction
    {
        public int IdTransaction { get; set; }
        public TransactionType Type { get; set; } 
        public int AccountId { get; set; }
        public decimal Amount { get; set; }
        public DateTime TransactionDate { get; set; }
        public string Description { get; set; }

        
    }
}

