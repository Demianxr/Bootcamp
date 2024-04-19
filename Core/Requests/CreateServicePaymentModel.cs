namespace Core.Requests
{
    public class CreateServicePaymentModel
    {
        public string DocumentNumber { get; set; }
        public decimal Amount { get; set; }
        public string Description { get; set; }
        public int DebitAccountId { get; set; }

        public CreateServicePaymentModel(string documentNumber, decimal amount, string description, int debitAccountId)
        {
            this.DocumentNumber = documentNumber;
            this.Amount = amount;
            this.Description = description;
            this.DebitAccountId = debitAccountId;
        }
    }
}
