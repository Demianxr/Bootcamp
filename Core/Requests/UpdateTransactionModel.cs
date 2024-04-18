namespace Core.Requests
{
    public class UpdateTransactionModel
    {
        public int Id { get; set; }
        public decimal? Amount { get; set; }
        public string Description { get; set; }

    }
}