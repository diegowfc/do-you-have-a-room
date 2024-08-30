using Domain.DTOs.UserDTO;

namespace Service.Services.UserServices
{
    public interface IUserService
    {
        Task<UserReadDTO> RegisterUserAsync(UserCreateDTO userCreateDTO);
    }
}
