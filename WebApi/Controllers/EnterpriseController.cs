using Core.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace Enterprise.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EnterpriseController : ControllerBase
    {
        private readonly IEnterpriseService _enterpriseService;

        public EnterpriseController(IEnterpriseService enterpriseService)
        {
            _enterpriseService = enterpriseService;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetEnterpriseById(int id)
        {
            var enterprise = await _enterpriseService.GetEnterpriseById(id);
            if (enterprise == null)
            {
                return NotFound(); // Retornar un código 404 si no se encuentra la empresa
            }
            return Ok(enterprise);
        }

        [HttpPost]
        public async Task<IActionResult> CreateEnterprise([FromBody] CreateEnterpriseRequest request)
        {
            var createdEnterprise = await _enterpriseService.CreateEnterprise(request);
            return CreatedAtAction(nameof(GetEnterpriseById), new { id = createdEnterprise.Id }, createdEnterprise);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateEnterprise(int id, [FromBody] UpdateEnterpriseRequest request)
        {
            var updatedEnterprise = await _enterpriseService.UpdateEnterprise(id, request);
            if (updatedEnterprise == null)
            {
                return NotFound(); // Retornar un código 404 si no se encuentra la empresa
            }
            return Ok(updatedEnterprise);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEnterprise(int id)
        {
            var isDeleted = await _enterpriseService.DeleteEnterprise(id);
            if (!isDeleted)
            {
                return NotFound(); // Retornar un código 404 si no se encuentra la empresa
            }
            return NoContent(); // Retornar un código 204 para indicar que la empresa fue eliminada con éxito
        }
    }
}
