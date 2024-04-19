namespace Core.Entities
{
    public class ServicePayment
    {

        public int Id { get; set; }
        public string DocumentNumber { get; set; }
        public decimal Amount { get; set; }
        public string Description { get; set; }
        public int DebitAccountId { get; set; }
        public DateTime PaymentDate { get; set; }


        public void MakePayment(string documentNumber, decimal amount, string description, int debitAccountId)
        {

            this.DocumentNumber = documentNumber;
            this.Amount = amount;
            this.Description = description;
            this.DebitAccountId = debitAccountId;
            this.PaymentDate = DateTime.Now;
        }
    }
}
