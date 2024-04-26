
using Core.Entities;
using Core.Interfaces.Repositories;
using Core.Models;
using Core.Request;
using Infrastructure.Contexts;
using Mapster;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories;

public class ServicePaymentRepository : IServicePaymentRepository
{
    private readonly BootcampContext _context;

    public ServicePaymentRepository(BootcampContext context)
    {
        _context = context;
    }

    public async Task<ServicePaymentDTO> Add(CreateServicePaymentModel model)
    {
        var paymentToCreate = model.Adapt<ServicePayment>();

        await UpdateAccountBalance(model.AccountId, model.Amount);


        _context.ServicePayments.Add(paymentToCreate);

        var result = await _context.SaveChangesAsync();

        var query = await _context.ServicePayments
            .Include(a => a.Service)
            .Include(a => a.Account)
                .ThenInclude(a => a.Customer)
            .SingleOrDefaultAsync(r => r.Id == paymentToCreate.Id);

        var paymentDTO = query.Adapt<ServicePaymentDTO>();
        return paymentDTO;
    }

    public async Task<List<ServicePaymentDTO>> GetAll()
    {

        var query = _context.ServicePayments
             .Include(a => a.Account)
             .ThenInclude(a => a.Customer)
             .Include(a => a.Account)
             .Include(a => a.Service)
             .AsQueryable();

        //var result = await query.ToListAsync();

        var payments = await _context.ServicePayments.ToListAsync();

        var paymentsDTO = payments.Adapt<List<ServicePaymentDTO>>();

        return paymentsDTO;
    }

    public async Task UpdateAccountBalance(int accountId, decimal amount)
    {
        var account = await _context.Accounts.FirstOrDefaultAsync(a => a.Id == accountId);
        if (account != null)
        {
            account.Balance -= amount;
            await _context.SaveChangesAsync();
        }
    }

    public async Task<bool> VerifyServiceExists(int serviceId)
    {
        var serviceExists = await _context.Services.AnyAsync(c => c.Id == serviceId);
        return (serviceExists);

    }

    public async Task<bool> IsSufficientBalance(int accountId, decimal amount)
    {
        var account = await _context.Accounts.FindAsync(accountId);

        return account!.Balance >= amount;
    }

    public async Task<bool> DoesAccountExist(int accountId)
    {
        var account = await _context.Accounts.FindAsync(accountId);
        return account != null;
    }

}