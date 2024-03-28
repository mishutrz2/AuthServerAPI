using TeamPickerAPI.Models;

namespace TeamPickerAPI.Services
{
    public interface IAuthService
    {
        Task<LoginResponse> Login(LoginUser user);
        Task<LoginResponse> RefreshToken(RefreshTokenModel model);
        Task<bool> RegisterUser(RegisterUser user);
    }
}
