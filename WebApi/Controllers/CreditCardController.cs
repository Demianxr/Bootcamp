using Core.Interfaces.Services;
using Core.Requests;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CreditCardController : ControllerBase
    {
        private readonly ICreditCardService _creditCardService;

        public CreditCardController(ICreditCardService creditCardService)
        {
            _creditCardService = creditCardService;
        }

        [HttpGet("filtered")]
        public async Task<IActionResult> GetFiltered([FromQuery] FilterCreditCardModel filter)
        {
            var creditCards = await _creditCardService.GetFiltered(filter);
            return Ok(creditCards);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateCreditCardModel request)
        {
            return Ok(await _creditCardService.Add(request));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById([FromRoute] int id)
        {
            var creditCard = await _creditCardService.GetById(id);
            return Ok(creditCard);
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] UpdateCreditCardModel request)
        {
            return Ok(await _creditCardService.Update(request));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            return Ok(await _creditCardService.Delete(id));
        }

        [HttpGet("all")]
        public async Task<IActionResult> GetAll()
        {
            var creditCards = await _creditCardService.GetAll();
            return Ok(creditCards);
        }
    }
}
