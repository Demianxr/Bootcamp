using Core.DTOs;
using Core.Entities;
using Core.Interfaces.Repositories;
using Core.Models;
using Core.Request;
using Core.Requests;
using Core.ViewModels;
using Infrastructure.Contexts;
using Mapster;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories;

public class PromotionRepository : IPromotionRepository
{
    private readonly BootcampContext _context;

    public PromotionRepository(BootcampContext context)
    {
        _context = context;
    }

    public async Task<PromotionDTO> Add(CreatePromotionModel model)
    {
        var promotionToCreate = model.Adapt<Promotion>();

        _context.Add(promotionToCreate);
        await _context.SaveChangesAsync();

        var promotionDTO = promotionToCreate.Adapt<PromotionDTO>();

        return promotionDTO;
    }

    public Task<bool> ProductExists(int productId)
    {
        throw new NotImplementedException();
    }


    public async Task<List<PromotionDTO>> GetAll()
    {
        var promotions = await _context.Promotion.ToListAsync();
        var promotionDTOs = promotions.Select(promotion => promotion.Adapt<PromotionDTO>()).ToList();
        return promotionDTOs;
    }



    

    public async Task<PromotionDTO> Update(UpdatePromotionModel model)
    {
        var promotion = await _context.Promotion.FindAsync(model.Id);

        if (promotion is null) throw new Exception("Promotion was not found");

        model.Adapt(promotion);

        _context.Promotion.Update(promotion);

        await _context.SaveChangesAsync();

        var promotionDTO = promotion.Adapt<PromotionDTO>();

        return promotionDTO;
    }

    public Task<List<CurrencyDTO>> GetFiltered(FilterCurrencyModel filter)
    {
        throw new NotImplementedException();
    }

    public Task<CurrencyDTO> Add(CreateCurrencyModel model)
    {
        throw new NotImplementedException();
    }

    Task<CurrencyDTO> IPromotionRepository.GetById(int id)
    {
        throw new NotImplementedException();
    }

    public Task<CurrencyDTO> Update(UpdateCurrencyModel model)
    {
        throw new NotImplementedException();
    }

    Task<List<CurrencyDTO>> IPromotionRepository.GetAll()
    {
        throw new NotImplementedException();
    }

    public Task<bool> Delete(int id)
    {
        throw new NotImplementedException();
    }
}
