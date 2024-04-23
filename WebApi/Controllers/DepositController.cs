using Core.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace BankAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DepositController : ControllerBase
    {
        private readonly IDepositService _service;

        public DepositController(IDepositService service)
        {
            _service = service;
        }

        [HttpGet("{accountId}")]
        public async Task<ActionResult<Deposit>> GetDeposit(string accountId)
        {
            var deposit = await _service.GetDepositAsync(accountId);
            if (deposit == null)
            {
                return NotFound();
            }
            return deposit;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Deposit>>> GetDeposits([FromQuery] FilterDepositModel filterModel)
        {
            var deposits = await _service.GetDepositsAsync(filterModel);
            return Ok(deposits);
        }

        [HttpPost]
        public async Task<ActionResult<Deposit>> CreateDeposit(CreateDepositModel createModel)
        {
            var deposit = await _service.CreateDepositAsync(createModel);
            return CreatedAtAction(nameof(GetDeposit), new { accountId = deposit.AccountId }, deposit);
        }

        [HttpPut("{accountId}")]
        public async Task<ActionResult> UpdateDeposit(string accountId, UpdateDepositModel updateModel)
        {
            try
            {
                await _service.UpdateDepositAsync(accountId, updateModel);
            }
            catch (KeyNotFoundException)
            {
                return NotFound();
            }
            return NoContent();
        }

        [HttpDelete("{accountId}")]
        public async Task<ActionResult> DeleteDeposit(string accountId)
        {
            try
            {
                await _service.DeleteDepositAsync(accountId);
            }
            catch (KeyNotFoundException)
            {
                return NotFound();
            }
            return NoContent();
        }
    }
}
