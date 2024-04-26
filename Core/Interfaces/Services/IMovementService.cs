using Core.Models;
using Core.Request;
using Core.Requests;

namespace Core.Interfaces.Services;

public interface IMovementService
{
    Task<MovementDTO> Add(CreateMovementModel model);
    Task<List<MovementDTO>> GetAll();
}