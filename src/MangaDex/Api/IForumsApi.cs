using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Refit;
using MangaDex.Model;

namespace MangaDex.Api
{
    public interface IForumsApi
    {
        [Post("/forums/thread")] [Headers("Content-Type: application/json")]
        Task<ForumsThreadResponse> ForumsThreadCreate([Body] ForumsThreadCreateRequest forumsThreadCreateRequest = null);

    }
}