namespace Core.Models
{
    public class UserRequestDTO
    {
        public int Id { get; set; }
        public string ProductType { get; set; }
        public decimal Amount { get; set; }
        public string Currency { get; set; }
        public DateTime RequestDate { get; set; }
        public DateTime ApprovalDate { get; set; }
    }
}

