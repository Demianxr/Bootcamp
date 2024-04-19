using Core.Interfaces.Services;
using Core.Requests;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ServicePaymentController : ControllerBase
    {
        private readonly IServicePaymentService _service;

        public ServicePaymentController(IServicePaymentService service)
        {
            _service = service;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetServicePaymentByIdAsync(int id)
        {
            var servicePayment = await _service.GetServicePaymentByIdAsync(id);
            if (servicePayment == null)
            {
                return NotFound();
            }

            return Ok(servicePayment);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllServicePaymentsAsync()
        {
            var servicePayments = await _service.GetAllServicePaymentsAsync();
            return Ok(servicePayments);
        }

        [HttpPost]
        public async Task<IActionResult> AddServicePaymentAsync([FromBody] CreateServicePaymentModel model)
        {
            var servicePayment = await _service.AddServicePaymentAsync(model);
            return CreatedAtAction(nameof(GetServicePaymentByIdAsync), new { id = servicePayment.Id }, servicePayment);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateServicePaymentAsync(int id, [FromBody] UpdateServicePaymentModel model)
        {
            if (id != model.Id)
            {
                return BadRequest();
            }

            var servicePayment = await _service.UpdateServicePaymentAsync(model);
            if (servicePayment == null)
            {
                return NotFound();
            }

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteServicePaymentAsync(int id)
        {
            await _service.DeleteServicePaymentAsync(id);
            return NoContent();
        }
    }
}

