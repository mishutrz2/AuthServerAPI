using AuthServerAPI.Models;

namespace AuthServerAPI.Services
{
    public interface IAuthService
    {
        Task<LoginResponse> Login(LoginUser user);
        Task<LoginResponse> RefreshToken(RefreshTokenModel model);
        Task<bool> RegisterUser(LoginUser user);
    }
}
