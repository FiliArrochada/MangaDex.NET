// GENERATED Refit scaffold for AuthenticationApi — prototype, not wired into the build (needs Refit).
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Refit;
using MangaDex.Model;

namespace MangaDex.Api.Refit
{
    public interface IAuthenticationApi
    {
        [Get("/auth/check")]
        Task<CheckResponse> GetAuthCheck();

        [Post("/auth/login")] [Headers("Content-Type: application/json")]
        Task<LoginResponse> PostAuthLogin([Body] Login login = null);

        [Post("/auth/logout")]
        Task<LogoutResponse> PostAuthLogout();

        [Post("/auth/refresh")] [Headers("Content-Type: application/json")]
        Task<RefreshResponse> PostAuthRefresh([Body] RefreshToken refreshToken = null);

    }
}