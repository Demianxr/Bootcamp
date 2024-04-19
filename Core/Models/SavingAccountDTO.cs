namespace Core.Models;

public class SavingAccountDTO
{
    public int Id { get; set; }
    public string SavingType { get; set; }
    public string HolderName { get; set; }
    public int AccountId { get; set; }
    public string Currency { get; set; }
    public decimal DesiredAmount { get; set; }
    public int PreferredTerm { get; set; }
    public string Brand { get; set; }
    public DateTime ApplicationDate { get; set; }
    public DateTime ApprovalDate { get; set; }
}