using Core.Interfaces.Repositories;
using Core.Models;
using Core.Request;
using Core.Requests;

namespace Infrastructure.Services;

public interface ICustomerService
{
    Task<List<CustomerDTO>> GetFiltered(FilterCustomersModel filter);
    Task<CustomerDTO> Add(CreateCustomerModel model);
    Task<CustomerDTO> GetById(int id);
    Task<CustomerDTO> Update(CreateCustomerModel model);
    Task<bool> Delete(int id);
    Task<List<CustomerDTO>> GetAll();
    Task<object?> Update(UpdateCustomerModel request);
}