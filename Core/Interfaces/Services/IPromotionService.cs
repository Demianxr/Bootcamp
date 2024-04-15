using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Entities;
using Core.Requests;

namespace Core.Interfaces
{
    public interface IPromotionService
    {
        Task<IEnumerable<Promotion>> GetAllPromotionsAsync();
        Task<IEnumerable<Promotion>> GetFilteredPromotionsAsync(string name, TimeSpan? durationTime, decimal? percentageOff);
        Task<int> CreatePromotionAsync(CreatePromotionModel model);
        Task<bool> UpdatePromotionAsync(UpdatePromotionModel model);
        Task<bool> DeletePromotionAsync(int id);
    }
}
