using Core.DTOs;
using Core.Interfaces.Repositories;
using Core.Interfaces.Services;
using Core.Models;
using Core.Requests;
using Core.ViewModels;
using Mapster;

namespace Core.Services
{
    public class PromotionService : IPromotionService
    {
        private readonly IPromotionRepository _promotionRepository;

        public PromotionService(IPromotionRepository promotionRepository)
        {
            _promotionRepository = promotionRepository;
        }
        public async Task<PromotionDTO> GetById(int id)
        {
            var promotion = await _promotionRepository.GetById(id);
            return promotion?.Adapt<PromotionDTO>();
        }

        public async Task<bool> DeletePromotionAsync(int id)
        {
            return await _promotionRepository.Delete(id);
        }

        public async Task<PromotionDTO> UpdatePromotionAsync(UpdatePromotionModel model)
        {
            var promotion = await _promotionRepository.Update(model);
            return promotion?.Adapt<PromotionDTO>();
        }

        public Task<List<AccountDTO>> GetFiltered(FilterAccountModel filter)
        {
            throw new NotImplementedException();
        }

        public Task<AccountDTO> Add(CreateAccountModel model)
        {
            throw new NotImplementedException();
        }

        public Task<AccountDTO> Update(UpdateAccountModel model)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<AccountDTO> Create(CreateAccountRequest request)
        {
            throw new NotImplementedException();
        }

        Task<AccountDTO> IPromotionService.GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task GetAllPromotions()
        {
            throw new NotImplementedException();
        }
    }
}
