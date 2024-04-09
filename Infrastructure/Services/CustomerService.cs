using Core.Interfaces.Repositories;
using Core.Interfaces.Services;
using Core.Models;
using Core.Request;
using Core.Requests;

namespace Infrastructure.Services;

public class CustomerService : ICustomerService
{
    public Task<CustomerDTO> Add(CreateCustomerModel model)
    {
        throw new NotImplementedException();
    }

    public Task<bool> Delete(int id)
    {
        throw new NotImplementedException();
    }

    public Task<List<CustomerDTO>> GetAll()
    {
        throw new NotImplementedException();
    }

    public Task<CustomerDTO> GetById(int id)
    {
        throw new NotImplementedException();
    }

    public Task<List<CustomerDTO>> GetFiltered(FilterCustomersModel filter)
    {
        throw new NotImplementedException();
    }

    public Task<CustomerDTO> Update(CreateCustomerModel model)
    {
        throw new NotImplementedException();
    }

    public Task<object?> Update(UpdateCustomerModel request)
    {
        throw new NotImplementedException();
    }
}