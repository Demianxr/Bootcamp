using Infrastructure.Contexts;
using Microsoft.EntityFrameworkCore;

public class WithdrawalRepository : IWithdrawalRepository
{
    private readonly BootcampContext _context;

    public WithdrawalRepository(BootcampContext context)
    {
        _context = context;
    }

    public async Task<Withdrawal> CreateAsync(Withdrawal withdrawal)
    {
        _context.Withdrawals.Add(withdrawal);
        await _context.SaveChangesAsync();
        return withdrawal;
    }

    public async Task<Withdrawal> UpdateAsync(Withdrawal withdrawal)
    {
        _context.Entry(withdrawal).State = EntityState.Modified;
        await _context.SaveChangesAsync();
        return withdrawal;
    }

    public async Task DeleteAsync(int id)
    {
        var withdrawal = await _context.Withdrawals.FindAsync(id);
        if (withdrawal != null)
        {
            _context.Withdrawals.Remove(withdrawal);
            await _context.SaveChangesAsync();
        }
    }

    public async Task<Withdrawal> GetByIdAsync(int id)
    {
        return await _context.Withdrawals.FindAsync(id);
    }

    public async Task<IEnumerable<Withdrawal>> FilterAsync(FilterWithdrawalModel filterModel)
    {
        var query = _context.Withdrawals.AsQueryable();

        if (filterModel.AccountId.HasValue)
            query = query.Where(w => w.AccountId == filterModel.AccountId.Value);

        if (filterModel.BankId.HasValue)
            query = query.Where(w => w.BankId == filterModel.BankId.Value);

        if (filterModel.MinAmount.HasValue)
            query = query.Where(w => w.Amount >= filterModel.MinAmount.Value);

        if (filterModel.MaxAmount.HasValue)
            query = query.Where(w => w.Amount <= filterModel.MaxAmount.Value);

        if (filterModel.StartDate.HasValue)
            query = query.Where(w => w.TransactionDate >= filterModel.StartDate.Value);

        if (filterModel.EndDate.HasValue)
            query = query.Where(w => w.TransactionDate <= filterModel.EndDate.Value);

        return await query.ToListAsync();
    }
}
