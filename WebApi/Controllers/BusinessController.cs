using Core.Entities;
using Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Promotion.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BusinessController : ControllerBase
    {
        private readonly IBusinessService _businessService;

        public BusinessController(IBusinessService businessService)
        {
            _businessService = businessService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Business>>> GetAllBusinesses()
        {
            var businesses = await _businessService.GetAllBusinessesAsync();
            return Ok(businesses);
        }

        [HttpGet("filter")]
        public async Task<ActionResult<IEnumerable<Business>>> GetFilteredBusinesses(string name, string address, string phone, string email)
        {
            var filteredBusinesses = await _businessService.GetFilteredBusinessesAsync(name, address, phone, email);
            return Ok(filteredBusinesses);
        }

    }
}
