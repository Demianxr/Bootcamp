using Core.Entities;
using Core.Interfaces;
using Core.Requests;

namespace Core.Services
{
    public class PromotionService : IPromotionService
    {
        private readonly IPromotionRepository _promotionRepository;

        public PromotionService(IPromotionRepository promotionRepository)
        {
            _promotionRepository = promotionRepository;
        }

        public Task<int> CreatePromotionAsync(CreatePromotionModel model)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeletePromotionAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Promotion>> GetAllPromotionsAsync()
        {
            return await _promotionRepository.GetAllPromotionsAsync();
        }

        public async Task<IEnumerable<Promotion>> GetFilteredPromotionsAsync(string name, TimeSpan? durationTime, decimal? percentageOff)
        {
            return await _promotionRepository.GetFilteredPromotionsAsync(name, durationTime, percentageOff);
        }

        public Task<bool> UpdatePromotionAsync(UpdatePromotionModel model)
        {
            throw new NotImplementedException();
        }
    }
}
