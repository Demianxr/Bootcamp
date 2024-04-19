namespace Core.Entities
{
    public class UserRequest
    {
        
        public int Id { get; set; }
        public string User { get; set; }
        public string ProductType { get; set; }
        public decimal Amount { get; set; }
        public string Currency { get; set; }
        public DateTime RequestDate { get; set; }
        public DateTime? ApprovalDate { get; set; }

        public void RegisterRequest(string productType, decimal amount, string currency)
        {
            
            this.ProductType = productType;
            this.Amount = amount;
            this.Currency = currency;
            this.RequestDate = DateTime.Now;
        }

        public void ApproveRequest()
        {
         
            this.ApprovalDate = DateTime.Now;
        }
    }
}
