using Core.Constants;
using Core.Models;

public class CreditCardDTO
{
    public int Id { get; set; }
    private string _designation;
    public string Designation
    {
        get { return _designation; }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("La designación no puede estar vacía.", nameof(value));
            }
            _designation = value;
        }
    }
    public DateTime IssueDate { get; set; }
    public DateTime ExpirationDate { get; set; }
    private string _cardNumber;
    public string CardNumber
    {
        get { return _cardNumber; }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("El número de la tarjeta no puede estar vacío.", nameof(value));
            }
            _cardNumber = value;
        }
    }
    public int Cvv { get; set; }
    public ECreditCardStatus CreditCardStatus { get; set; } = ECreditCardStatus.Enabled;
    public decimal CreditLimit { get; set; }
    public decimal AvailableCredit { get; set; }
    public decimal CurrentDebt { get; set; }
    public decimal InterestRate { get; set; }
    public CurrencyDTO Currency { get; set; }
    public CustomerDTO Customer { get; set; }

    public string MaskedCardNumber
    {
        get
        {
            if (string.IsNullOrEmpty(CardNumber))
                return string.Empty;

            var lastFourDigits = CardNumber.Length >= 4 ? CardNumber.Substring(CardNumber.Length - 4) : CardNumber;
            return "****-****-****-" + lastFourDigits;
        }
    }
}
