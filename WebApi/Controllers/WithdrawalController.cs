using Core.Models;
using Core.Requests;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WithdrawalController : ControllerBase
    {
        private readonly IWithdrawalService _withdrawalService;

        public WithdrawalController(IWithdrawalService withdrawalService)
        {
            _withdrawalService = withdrawalService;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetWithdrawalById(int id)
        {
            var withdrawal = await _withdrawalService.GetWithdrawalByIdAsync(id);
            if (withdrawal == null)
            {
                return NotFound();
            }
            return Ok(withdrawal);
        }

        [HttpGet("account/{accountId}")]
        public async Task<IActionResult> GetWithdrawalsByAccountId(int accountId)
        {
            var withdrawals = await _withdrawalService.GetWithdrawalsByAccountIdAsync(accountId);
            return Ok(withdrawals);
        }

        [HttpPost]
        public async Task<IActionResult> AddWithdrawal([FromBody] CreateWithdrawalModel model)
        {
            var withdrawal = new WithdrawalDTO(model.AccountId, model.BankId, model.Amount);
            await _withdrawalService.AddWithdrawalAsync(withdrawal);
            return CreatedAtAction(nameof(GetWithdrawalById), new { id = withdrawal.Id }, withdrawal);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateWithdrawal(int id, [FromBody] UpdateWithdrawalModel model)
        {
            var withdrawal = new WithdrawalDTO(model.AccountId, model.BankId, model.Amount) { Id = id };
            await _withdrawalService.UpdateWithdrawalAsync(withdrawal);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteWithdrawal(int id)
        {
            await _withdrawalService.DeleteWithdrawalAsync(id);
            return NoContent();
        }
    }
}
