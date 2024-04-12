using Core.Interfaces.Services;
using Core.Models;
using Core.Request;
using Core.Requests;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IAccountService _accountService;

        public AccountController(IAccountService accountService)
        {
            _accountService = accountService;
        }

        [HttpPost]
        public async Task<ActionResult<AccountDTO>> Add(CreateAccountModel model)
        {
            var accountDTO = await _accountService.Add(model);

            if (accountDTO is null)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Failed to create account");
            }

            return Ok(accountDTO);
        }



        [HttpGet("filter")]
        public async Task<ActionResult<List<AccountDTO>>> GetFiltered([FromQuery] FilterAccountModel filter)
        {
            var accounts = await _accountService.GetFiltered(filter);

            return Ok(accounts);
        }

        [HttpPut("update")]
        public async Task<ActionResult<AccountDTO>> Update(UpdateAccountModel model)
        {
            var accountDTO = await _accountService.Update(model);

            if (accountDTO is null)
            {
                return NotFound("Account not found");
            }

            return Ok(accountDTO);
        }
    }
}
