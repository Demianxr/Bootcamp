namespace Core.Entities
{
    public class UserRequest
    {
        public int Id { get; set; }
        public string ProductType { get; set; }
        public decimal Amount { get; set; }
        public string Currency { get; set; }
        public DateTime RequestDate { get; set; }
        public DateTime ApprovalDate { get; set; }
        public int? CreditTerm { get; set; }
        public string CreditBrand { get; set; }

    }
}
