public class FilterRequestModel
{
    public string ProductType { get; set; }  // Tipo de producto

    public decimal? MinAmount { get; set; }  // Monto mínimo del crédito o depósito

    public decimal? MaxAmount { get; set; }  // Monto máximo del crédito o depósito

    public string Brand { get; set; }  // Marca de la tarjeta de crédito

    public int? MinTerm { get; set; }  // Plazo mínimo del crédito

    public int? MaxTerm { get; set; }  // Plazo máximo del crédito

    public string Currency { get; set; }  // Moneda

    public DateTime? MinRequestDate { get; set; }  // Fecha mínima de solicitud

    public DateTime? MaxRequestDate { get; set; }  // Fecha máxima de solicitud

    public DateTime? MinApprovalDate { get; set; }  // Fecha mínima de aprobación

    public DateTime? MaxApprovalDate { get; set; }  // Fecha máxima de aprobación
}
