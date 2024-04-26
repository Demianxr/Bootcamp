using Core.Interfaces.Services;
using Core.Request;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

public class ServicePaymentController : BaseApiController
{
    private readonly IServicePaymentService _service;
    public ServicePaymentController(IServicePaymentService service)
    {
        _service = service;
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] CreateServicePaymentModel request)
    {
        return Ok(await _service.Add(request));
    }

    [HttpGet("all")]
    public async Task<IActionResult> GetAll()
    {
        var payments = await _service.GetAll();
        return Ok(payments);
    }
}