using Core.Interfaces.Repositories;
using Core.Models;
using Core.Requests;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Core.Interfaces.Services
{
    public interface ICustomerService
    {
        Task<List<CustomerDTO>> GetFiltered(FilterCustomersModel filter);
    }
}