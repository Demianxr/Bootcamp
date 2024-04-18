using Core.Constants;

namespace Core.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Amount { get; set; }
        public int Term { get; set; } // En meses para créditos
        public string Brand { get; set; } // Para tarjetas de crédito
        public decimal InitialDeposit { get; set; } // Para cuentas corrientes
        public string Currency { get; set; }
        public DateTime RequestDate { get; set; }
        public DateTime? ApprovalDate { get; set; }
    }

}
