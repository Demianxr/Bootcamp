namespace Core.Requests
{
    public class UpdateMovementModel
    {
        public int Id { get; set; }
        public string Destination { get; set; }
        public decimal Amount { get; set; }
        public int AccountId { get; set; }
    }
}
