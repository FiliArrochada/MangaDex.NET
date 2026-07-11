using System.Threading.Tasks;
using MangaDex.Model;
using Refit;

namespace MangaDex.Api
{
    public interface ICaptchaApi
    {
        [Post("/captcha/solve")]
        [Headers("Content-Type: application/json")]
        Task<PostCaptchaSolve200Response> PostCaptchaSolve([Body] PostCaptchaSolveRequest postCaptchaSolveRequest = null);
    }
}