using Core.Entities;
using Core.Interfaces;
using Infrastructure.Contexts;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
{
    public class PromotionRepository : IPromotionRepository
    {
        private readonly BootcampContext _Context;

        public PromotionRepository(BootcampContext Context)
        {
            _Context = Context;
        }

        public async Task<IEnumerable<Promotion>> GetAllPromotionsAsync()
        {
            return await _Context.Promotion.ToListAsync();
        }

        public async Task<IEnumerable<Promotion>> GetFilteredPromotionsAsync(string name, TimeSpan? durationTime, decimal? percentageOff)
        {
            var query = _Context.Promotion.AsQueryable();

            if (!string.IsNullOrEmpty(name))
            {
                query = query.Where(p => p.Name.Contains(name));
            }
            

            if (percentageOff.HasValue)
            {
                query = query.Where(p => p.PercentageOff == percentageOff.Value);
            }

            return await query.ToListAsync();
        }

    }
}
