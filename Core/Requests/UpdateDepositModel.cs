namespace Core.Requests
{
    public class UpdateDepositModel
    {
        public decimal? Amount { get; set; }

        public bool IsValid(decimal operationalLimit)
        {
            if (Amount.HasValue && Amount <= 0)
            {
                Console.WriteLine("El monto debe ser mayor que cero.");
                return false;
            }

            if (Amount.HasValue && Amount > operationalLimit)
            {
                Console.WriteLine("El monto sobrepasa el límite operacional.");
                return false;
            }

            return true;
        }
    }
}