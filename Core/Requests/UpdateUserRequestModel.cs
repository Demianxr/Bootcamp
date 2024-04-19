namespace Core.Requests
{
    public class UpdateUserRequestModel
    {
        public int Id { get; set; }
        public string ProductType { get; set; }
        public decimal Amount { get; set; }
        public string Currency { get; set; }

        public UpdateUserRequestModel(int id, string productType, decimal amount, string currency)
        {
            this.Id = id;
            this.ProductType = productType;
            this.Amount = amount;
            this.Currency = currency;
        }
    }
}
