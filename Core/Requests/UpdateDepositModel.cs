public class UpdateDepositModel
{
    public string AccountId { get; set; }
    public string BankId { get; set; }
    public decimal Amount { get; set; }

    public bool IsValid()
    {
        // Verifica que el monto sea positivo y que los IDs de la cuenta y del banco no estén vacíos
        return Amount > 0 && !string.IsNullOrEmpty(AccountId) && !string.IsNullOrEmpty(BankId);
    }
}
