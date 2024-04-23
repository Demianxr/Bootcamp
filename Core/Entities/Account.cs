using Core.Constants;
using Core.Entities;

public class Account
{
    public int Id { get; set; }
    public string Holder { get; set; }
    public string Number { get; set; }
    public decimal OperationalLimit { get; set; } = 100000m;
    public AccountType AccountType { get; set; } = AccountType.Current;
    public decimal Balance { get; set; }
    public AccountStatus AccountStatus { get; set; } = AccountStatus.Active;
    public DateTime OpeningDate { get; set; }
    public int CurrencyId { get; set; }
    public Currency Currency { get; set; }
    public int CustomerId { get; set; }
    public Customer Customer { get; set; }
    public SavingAccount? SavingAccount { get; set; }
    public CurrentAccount? CurrentAccount { get; set; }
    public virtual ICollection<Movement> Movements { get; set; } = new List<Movement>();
    public virtual ICollection<Withdrawal> Withdrawals { get; set; } = new List<Withdrawal>();

    public Account()
    {
        OpeningDate = DateTime.Now;
    }

    public Account(string holder, string number, AccountType accountType, int currencyId, int customerId)
    {
        ValidateHolder(holder);
        ValidateNumber(number);
        Holder = holder;
        Number = number;
        AccountType = accountType;
        CurrencyId = currencyId;
        CustomerId = customerId;
        OpeningDate = DateTime.Now;
    }

    public void SetCustomer(Customer customer)
    {
        if (customer == null)
        {
            throw new ArgumentNullException(nameof(customer));
        }
        Customer = customer;
    }

    public void SetCurrency(Currency currency)
    {
        if (currency == null)
        {
            throw new ArgumentNullException(nameof(currency));
        }
        Currency = currency;
    }

    private void ValidateHolder(string holder)
    {
        if (string.IsNullOrEmpty(holder))
        {
            throw new ArgumentNullException(nameof(holder));
        }
    }

    private void ValidateNumber(string number)
    {
        if (string.IsNullOrEmpty(number))
        {
            throw new ArgumentNullException(nameof(number));
        }
    }

    // Método para depositar dinero en la cuenta
    public void Deposit(decimal amount)
    {
        if (amount <= 0)
        {
            throw new ArgumentException("El monto a depositar debe ser mayor a cero.", nameof(amount));
        }
        Balance += amount;
    }

    // Método para retirar dinero de la cuenta
    public void Withdraw(decimal amount)
    {
        if (amount <= 0)
        {
            throw new ArgumentException("El monto a retirar debe ser mayor a cero.", nameof(amount));
        }
        if (Balance < amount)
        {
            throw new InvalidOperationException("No hay suficiente saldo en la cuenta para realizar la operación.");
        }
        Balance -= amount;
    }
}
