using Core.Interfaces.Repositories;
using Core.Models;
using Core.Requests;

namespace Infrastructure.Services;

public interface ICustomerService
{
    Task<List<CustomerDTO>> GetFiltered(FilterCustomersModel filter);
    Task<customerDTO> Add(CreateCustomerModel model);
    Task<customerDTO> GetById(int id);
    Task<customerDTO> Update(CreateCustomerModel model);
    Task<bool> Delete(int id);
    Task<List<CustomerDTO>> GetAll();
}