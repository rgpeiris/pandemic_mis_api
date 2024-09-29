using Pandemic_MIS.Services.AuthAPI.Models;

namespace Pandemic_MIS.Services.AuthAPI.Service.IService
{
    public interface IJwtTokenGenerator
    {
        string GenerateToken(ApplicationUser applicationUser);
    }
}
