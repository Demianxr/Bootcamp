namespace Core.Requests
{
    public class FilterTransactionModel
    {
        public int? AccountId { get; set; } 
        public DateTime? FromDate { get; set; } 
        public DateTime? ToDate { get; set; } 

        
    }
}