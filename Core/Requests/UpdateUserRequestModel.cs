namespace Core.Requests
{
    public class UpdateUserRequestModel
    {
        public int Id { get; set; }
        public string ProductType { get; set; }
        public decimal Amount { get; set; }
        public string Currency { get; set; }
    }
}
