namespace Core.Entities;

public class Bank
{
    public object costumer;

    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Phone { get; set; } = string.Empty;
    public string Mail { get; set; } = string.Empty;
    public string Address { get; set; } = string.Empty;
    public virtual ICollection<Customer> Customers { get; set; } = new List<Customer>();
    public string Balance { get; set; }
    public string Number { get; set; }
    public string Customer { get; set; }
}
