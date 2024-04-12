namespace Core.Requests
{
    public class FilterAccountModel
    {
        public string Number { get; set; }
        public string Type { get; set; } 
        public int CurrencyId { get; set; }
        public int CustomerId { get; set; }
    }
}
