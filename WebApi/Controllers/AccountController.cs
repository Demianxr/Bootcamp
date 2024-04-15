using Core.Interfaces.Services;
using Core.Models;
using Core.Request;
using Core.Requests;
using Infrastructure.Repositories;
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

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
       => Ok(await _accountService.GetById(id));

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] Core.Requests.CreateAccountRequest request)
            => Ok(await _accountService.Create(request));
    }

}
