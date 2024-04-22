using Core.Interfaces.Services;
using Core.Models;
using Core.Requests;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]
public class DepositController : ControllerBase
{
    private readonly IDepositService _service;

    public DepositController(IDepositService service)
    {
        _service = service;
    }

    [HttpGet("{accountId}/{bankId}")]
    public async Task<ActionResult<DepositDTO>> GetDeposit(int accountId, int bankId)
    {
        var deposit = await _service.GetDepositAsync(accountId, bankId);

        if (deposit == null)
        {
            return NotFound();
        }

        return deposit;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<DepositDTO>>> GetDeposits([FromQuery] FilterDepositModel filter)
    {
        var deposits = await _service.GetDepositsAsync(filter);
        return Ok(deposits);
    }

    [HttpPost]
    public async Task<ActionResult<DepositDTO>> CreateDeposit(CreateDepositModel createModel)
    {
        var deposit = await _service.CreateDepositAsync(createModel);

        if (deposit == null)
        {
            return BadRequest("El monto del depósito no es válido.");
        }

        return CreatedAtAction(nameof(GetDeposit), new { accountId = deposit.AccountId, bankId = deposit.BankId }, deposit);
    }

    [HttpPut("{accountId}/{bankId}")]
    public async Task<ActionResult<DepositDTO>> UpdateDeposit(int accountId, int bankId, UpdateDepositModel updateModel)
    {
        var deposit = await _service.UpdateDepositAsync(accountId, bankId, updateModel);

        if (deposit == null)
        {
            return NotFound();
        }

        return deposit;
    }

    [HttpDelete("{accountId}/{bankId}")]
    public async Task<IActionResult> DeleteDeposit(int accountId, int bankId)
    {
        var result = await _service.DeleteDepositAsync(accountId, bankId);

        if (!result)
        {
            return NotFound();
        }

        return NoContent();
    }
}

