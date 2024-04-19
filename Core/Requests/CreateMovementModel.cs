namespace Core.Requests
{
    public class CreateMovementModel
    {
        public string Destination { get; set; }
        public decimal Amount { get; set; }
        public int AccountId { get; set; }
    }
}
