public class UpdateRequestModel
{
    public string ProductType { get; set; }  // Tipo de producto

    public decimal? Amount { get; set; }  // Monto del crédito o depósito

    public string Brand { get; set; }  // Marca de la tarjeta de crédito

    public int? Term { get; set; }  // Plazo del crédito

    public string Currency { get; set; }  // Moneda

    public DateTime? RequestDate { get; set; }  // Fecha de solicitud

    public DateTime? ApprovalDate { get; set; }  // Fecha de aprobación
}
