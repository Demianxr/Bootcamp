using Core.Models;
using Core.Request;

namespace Core.Interfaces.Services;

public interface IRequestService
{
    Task<List<UserRequestDTO>> GetAll();
    Task<UserRequestDTO> Add(CreateRequestModel model);

}