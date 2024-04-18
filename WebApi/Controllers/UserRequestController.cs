using Core.Interfaces.Services;
using Core.Requests;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    public class UserRequestController : ControllerBase
    {
        private readonly IUserRequestService _userRequestService;

        public UserRequestController(IUserRequestService userRequestService)
        {
            _userRequestService = userRequestService;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var userRequest = await _userRequestService.GetRequestByIdAsync(id);
            if (userRequest == null)
            {
                return NotFound();
            }
            return Ok(userRequest);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateUserRequestModel requestModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var createdUserRequest = await _userRequestService.CreateUserRequestAsync(requestModel);
            return CreatedAtAction(nameof(Get), new { id = createdUserRequest.Id }, createdUserRequest);
        }
        

        
        }
    }

