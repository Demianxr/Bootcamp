namespace Core.Requests
{
    public class CreateDepositModel
    {
        public int AccountId { get; set; }
        public int BankId { get; set; }
        public decimal Amount { get; set; }

        public bool IsValid(decimal operationalLimit)
        {
            if (Amount <= 0)
            {
                Console.WriteLine("El monto debe ser mayor que cero.");
                return false;
            }

            if (Amount > operationalLimit)
            {
                Console.WriteLine("El monto sobrepasa el límite operacional.");
                return false;
            }

            return true;
        }
    }
}
    
