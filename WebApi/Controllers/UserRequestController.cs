using Core.Interfaces.Services;
using Core.Requests;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserRequestController : ControllerBase
    {
        private readonly IUserRequestService _service;

        public UserRequestController(IUserRequestService service)
        {
            _service = service;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetUserRequestByIdAsync(int id)
        {
            var userRequest = await _service.GetUserRequestByIdAsync(id);
            if (userRequest == null)
            {
                return NotFound();
            }

            return Ok(userRequest);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllUserRequestsAsync()
        {
            var userRequests = await _service.GetAllUserRequestsAsync();
            return Ok(userRequests);
        }

        [HttpPost]
        public async Task<IActionResult> AddUserRequestAsync([FromBody] CreateUserRequestModel model)
        {
            var userRequest = await _service.AddUserRequestAsync(model);
            return CreatedAtAction(nameof(GetUserRequestByIdAsync), new { id = userRequest.Id }, userRequest);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateUserRequestAsync(int id, [FromBody] UpdateUserRequestModel model)
        {
            if (id != model.Id)
            {
                return BadRequest();
            }

            var userRequest = await _service.UpdateUserRequestAsync(model);
            if (userRequest == null)
            {
                return NotFound();
            }

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUserRequestAsync(int id)
        {
            await _service.DeleteUserRequestAsync(id);
            return NoContent();
        }
    }
}


