using System.Threading.Tasks;
using MangaDex.Model;
using Refit;

namespace MangaDex.Api
{
    public interface IAuthenticationApi
    {
        [Get("/auth/check")]
        Task<CheckResponse> GetAuthCheck();

        [Post("/auth/login")]
        [Headers("Content-Type: application/json")]
        Task<LoginResponse> PostAuthLogin([Body] Login login = null);

        [Post("/auth/logout")]
        Task<LogoutResponse> PostAuthLogout();

        [Post("/auth/refresh")]
        [Headers("Content-Type: application/json")]
        Task<RefreshResponse> PostAuthRefresh([Body] RefreshToken refreshToken = null);
    }
}