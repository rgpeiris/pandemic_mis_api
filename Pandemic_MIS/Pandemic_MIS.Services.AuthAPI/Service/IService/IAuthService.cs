using Pandemic_MIS.Services.AuthAPI.Models;
using Pandemic_MIS.Services.AuthAPI.Models.Dto;

namespace Pandemic_MIS.Services.AuthAPI.Service.IService
{
    public interface IAuthService
    {
        Task<string> Register(RegistrationRequestDto registrationRequestDto);
        Task<IEnumerable<ApplicationUser>> GetAllUsers();
        Task<UserDto> GetByUsername(string username);
        Task<LoginResponseDto> Login(LoginRequestDto loginRequestDto);
        Task<LoginResponseDto> LoginPublic(LoginRequestDto loginRequestDto);
        Task<bool> AssignRole(string email, string roleName);
        Task<string> UpdateUser(string userId, UpdateUserRequestDto updateUserRequestDto);
    }
}
