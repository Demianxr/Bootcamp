namespace Core.Entities
{
    public class TransactionHistoryFilter
    {
        public int AccountId { get; set; } // Cuenta (obligatorio)
        public int? Year { get; set; } // Año
        public int? Month { get; set; } // Mes
        public DateTime? StartDate { get; set; } // Fecha de inicio del rango
        public DateTime? EndDate { get; set; } // Fecha de fin del rango
        public string Description { get; set; } // Descripción
    }
}
