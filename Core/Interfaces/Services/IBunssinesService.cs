using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Entities;

namespace Core.Interfaces
{
    public interface IBusinessService
    {
        Task<IEnumerable<Business>> GetAllBusinessesAsync();
        Task<IEnumerable<Business>> GetFilteredBusinessesAsync(string name, string address, string phone, string email);
       
    }
}
