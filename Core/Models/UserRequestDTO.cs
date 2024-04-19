namespace Core.Models
{
    public class UserRequestDTO
    {
      
        public string ProductType { get; set; }
        public decimal Amount { get; set; }
        public string Currency { get; set; }

        
        public UserRequestDTO(string productType, decimal amount, string currency)
        {
            this.ProductType = productType;
            this.Amount = amount;
            this.Currency = currency;
        }
    }

}

