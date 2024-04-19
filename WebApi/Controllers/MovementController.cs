using Core.Interfaces.Services;
using Core.Requests;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MovementController : ControllerBase
    {
        private readonly IMovementService _movementService;

        public MovementController(IMovementService movementService)
        {
            _movementService = movementService;
        }

        [HttpGet]
        public async Task<IActionResult> GetMovements([FromQuery] FilterMovementModel filter)
        {
            var movements = await _movementService.GetMovementsAsync(filter);
            return Ok(movements);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetMovementById(int id)
        {
            var movement = await _movementService.GetMovementByIdAsync(id);
            return Ok(movement);
        }

        [HttpPost]
        public async Task<IActionResult> CreateMovement([FromBody] CreateMovementModel movement)
        {
            await _movementService.CreateMovementAsync(movement);
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> UpdateMovement([FromBody] UpdateMovementModel movement)
        {
            await _movementService.UpdateMovementAsync(movement);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMovement(int id)
        {
            await _movementService.DeleteMovementAsync(id);
            return Ok();
        }
    }
}
