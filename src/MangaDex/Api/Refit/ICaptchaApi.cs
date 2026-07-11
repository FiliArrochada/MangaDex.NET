// GENERATED Refit scaffold for CaptchaApi — prototype, not wired into the build (needs Refit).
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Refit;
using MangaDex.Model;

namespace MangaDex.Api.Refit
{
    public interface ICaptchaApi
    {
        [Post("/captcha/solve")] [Headers("Content-Type: application/json")]
        Task<PostCaptchaSolve200Response> PostCaptchaSolve([Body] PostCaptchaSolveRequest postCaptchaSolveRequest = null);

    }
}