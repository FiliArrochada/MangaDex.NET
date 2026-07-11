using System.Threading.Tasks;
using MangaDex.Model;
using Refit;

namespace MangaDex.Api
{
    public interface IForumsApi
    {
        [Post("/forums/thread")]
        [Headers("Content-Type: application/json")]
        Task<ForumsThreadResponse> ForumsThreadCreate([Body] ForumsThreadCreateRequest forumsThreadCreateRequest = null);
    }
}