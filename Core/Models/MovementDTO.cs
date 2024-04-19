namespace Core.Models
{
    public class MovementDTO
    {
        public int Id { get; set; }
        public string Destination { get; set; }
        public decimal Amount { get; set; }
        public DateTime? TransferredDateTime { get; set; }
        public string TransferStatus { get; set; }
        public int AccountId { get; set; }
    }
}
