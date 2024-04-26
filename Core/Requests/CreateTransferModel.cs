namespace Core.Request
{
    public class CreateTransferModel
    {
        public int OriginAccountId { get; set; }
        public int DestinationAccountId { get; set; }
        public decimal Amount { get; set; }
    }
}
