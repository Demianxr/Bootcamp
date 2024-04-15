using Core.Entities;
using Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Promotio.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PromotionController : ControllerBase
    {
        private readonly IPromotionService _promotionService;

        public PromotionController(IPromotionService promotionService)
        {
            _promotionService = promotionService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Promotion>>> GetAllPromotions()
        {
            var promotions = await _promotionService.GetAllPromotionsAsync();
            return Ok(promotions);
        }

        [HttpGet("filter")]
        public async Task<ActionResult<IEnumerable<Promotion>>> GetFilteredPromotions(string name, TimeSpan? durationTime, decimal? percentageOff)
        {
            var filteredPromotions = await _promotionService.GetFilteredPromotionsAsync(name, durationTime, percentageOff);
            return Ok(filteredPromotions);
        }

        
    }
}
