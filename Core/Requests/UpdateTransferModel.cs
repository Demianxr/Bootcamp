namespace Core.Request
{
    public class UpdateTransferModel
    {
        public int Id { get; set; }
        public int? OriginAccountId { get; set; }
        public int? DestinationAccountId { get; set; }
        public decimal? Amount { get; set; }
    }
}
