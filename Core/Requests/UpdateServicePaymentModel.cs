namespace Core.Requests
{
    public class UpdateServicePaymentModel
    {
        public int Id { get; set; }
        public string DocumentNumber { get; set; }
        public decimal Amount { get; set; }
        public string Description { get; set; }
        public int DebitAccountId { get; set; }

        public UpdateServicePaymentModel(int id, string documentNumber, decimal amount, string description, int debitAccountId)
        {
            this.Id = id;
            this.DocumentNumber = documentNumber;
            this.Amount = amount;
            this.Description = description;
            this.DebitAccountId = debitAccountId;
        }
    }
}

