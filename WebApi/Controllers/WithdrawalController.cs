using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]
public class WithdrawalController : ControllerBase
{
    private readonly IWithdrawalService _withdrawalService;

    public WithdrawalController(IWithdrawalService withdrawalService)
    {
        _withdrawalService = withdrawalService;
    }

    [HttpPost]
    public async Task<IActionResult> CreateWithdrawal([FromBody] CreateWithdrawalModel model)
    {
        var withdrawal = await _withdrawalService.CreateWithdrawalAsync(model);
        return CreatedAtAction(nameof(GetWithdrawal), new { id = withdrawal.AccountId }, withdrawal);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateWithdrawal(int id, [FromBody] UpdateWithdrawalModel model)
    {
        await _withdrawalService.UpdateWithdrawalAsync(id, model);
        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteWithdrawal(int id)
    {
        await _withdrawalService.DeleteWithdrawalAsync(id);
        return NoContent();
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetWithdrawal(int id)
    {
        var withdrawal = await _withdrawalService.GetWithdrawalAsync(id);
        if (withdrawal == null)
            return NotFound();

        return Ok(withdrawal);
    }

    [HttpGet]
    public async Task<IActionResult> FilterWithdrawals([FromQuery] FilterWithdrawalModel filterModel)
    {
        var withdrawals = await _withdrawalService.FilterWithdrawalsAsync(filterModel);
        return Ok(withdrawals);
    }
}
