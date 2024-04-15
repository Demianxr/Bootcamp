using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Entities;

namespace Core.Interfaces
{
    public interface IPromotionRepository
    {
        Task<IEnumerable<Promotion>> GetAllPromotionsAsync();
        Task<IEnumerable<Promotion>> GetFilteredPromotionsAsync(string name, TimeSpan? durationTime, decimal? percentageOff);
    }
}
