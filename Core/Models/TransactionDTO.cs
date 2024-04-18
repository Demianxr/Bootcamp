namespace Core.Models
{
    public class TransactionDTO
    {
        public int IdTransaction { get; set; }
        public string Type { get; set; } 
        public int AccountId { get; set; }
        public decimal Amount { get; set; }
        public string TransactionDate { get; set; } 
        public string Description { get; set; }

       }
    }

