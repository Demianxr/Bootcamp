
namespace Core.Entities
{
    public interface IBank
    {
        string Address { get; set; }
        ICollection<Customer> Customers { get; set; }
        int Id { get; set; }
        string Mail { get; set; }
        string Name { get; set; }
        string Phone { get; set; }
    }
}