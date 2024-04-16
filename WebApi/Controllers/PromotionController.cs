using Core.DTOs;
using Core.Interfaces.Services;
using Core.Models;
using Core.Requests;
using Core.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PromotionController : ControllerBase
    {
        private readonly IPromotionService _promotionService;

        public PromotionController(IPromotionService promotionService)
        {
            _promotionService = promotionService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllPromotions()
        {
            var promotions = await _promotionService.GetAllPromotions();
            return Ok(promotions);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetPromotionById(int id)
        {
            var promotion = await _promotionService.GetById(id);
            if (promotion == null)
                return NotFound();

            return Ok(promotion);
        }

        [HttpPost]
        public async Task<IActionResult> CreatePromotion([FromBody] CreateAccountRequest request)
        {
            var createdPromotion = await _promotionService.Create(request);
            return CreatedAtAction(nameof(GetPromotionById), new { id = createdPromotion.Id }, createdPromotion);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdatePromotion(int id, [FromBody] UpdatePromotionModel model)
        {
            if (model == null || model.Id != id)
                return BadRequest("Invalid promotion data.");

            var updatedPromotion = await _promotionService.Update(model);
            return Ok(updatedPromotion);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePromotion(int id)
        {
            var isDeleted = await _promotionService.Delete(id);
            if (!isDeleted)
                return NotFound();

            return NoContent();
        }
    }
}
