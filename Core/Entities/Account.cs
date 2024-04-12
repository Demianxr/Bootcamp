using Core.Constants;

namespace Core.Entities;

public class Account
{
    public int Id { get; set; }
    public string Type { get; set; }
    public string Holder { get; set; } = string.Empty;
    public string Number { get; set; } = string.Empty;
    public decimal Balance { get; set; }


    public AccountType AccountType { get; set; } = AccountType.Current;
    public AccountStatus AccountStatus { get; set; } = AccountStatus.Active;
    

    public int CurrencyId { get; set; }
    public int CustomerId { get; set; }

    public Currency Currency { get; set; } = null!;
    public Customer Customer { get; set; } = null!;

    public SavingAccount SavingAccount { get; set; }
    public CurrentAccount CurrentAccount { get; set; }
    public virtual ICollection<Movement> Movements { get; set; } = new List<Movement>();

    public bool IsDeleted { get; set; }

}