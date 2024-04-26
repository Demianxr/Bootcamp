using Core.Entities;
using Core.Interfaces.Repositories;
using Core.Models;
using Core.Request;
using Infrastructure.Contexts;
using Mapster;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories;

public class RequestRepository : IRequestRepository
{
    private readonly BootcampContext _context;

    public RequestRepository(BootcampContext context)
    {
        _context = context;
    }

    public async Task<UserRequestDTO> Add(CreateRequestModel model)
    {

        var userRequestToCreate = model.Adapt<Request>();

        _context.Requests.Add(userRequestToCreate);

        await _context.SaveChangesAsync();


        var query = await _context.Requests
         .Include(a => a.Currency)
         .Include(a => a.Product)
         .Include(a => a.Customer)
         .ThenInclude(a => a.Bank)
         .SingleOrDefaultAsync(r => r.Id == userRequestToCreate.Id);

        var userRequestDTO = userRequestToCreate.Adapt<UserRequestDTO>();

        return userRequestDTO;
    }

    public async Task<List<UserRequestDTO>> GetAll()
    {

        var query = _context.Requests
                  .Include(a => a.Currency)
                  .Include(a => a.Customer)
                  .ThenInclude(a => a.Bank)
                  .Include(a => a.Product)
                  .AsQueryable();

        var result = await query.ToListAsync();

        var userRequests = await _context.Requests.ToListAsync();

        var userRequestsDTO = userRequests.Adapt<List<UserRequestDTO>>();

        return userRequestsDTO;
    }

    public async Task<(bool customerExists, bool currencyExists)> VerifyCustomerAndCurrencyExist(int customerId, int currencyId)
    {
        var customerExists = await _context.Customers.AnyAsync(c => c.Id == customerId);
        var currencyExists = await _context.Currency.AnyAsync(c => c.Id == currencyId);

        return (customerExists, currencyExists);
    }

    public async Task<bool> VerifyProductExists(int productId)
    {
        var productExists = await _context.Products.AnyAsync(c => c.Id == productId);
        return (productExists);

    }
}