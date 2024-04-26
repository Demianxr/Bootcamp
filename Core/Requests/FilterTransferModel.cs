namespace Core.Requests
{
    public class FilterTransferModel
    {
        public int? SourceAccountId { get; set; }
        public int? DestinationAccountId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
    }
}
