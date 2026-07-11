// GENERATED Refit scaffold for ForumsApi — prototype, not wired into the build (needs Refit).
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Refit;
using MangaDex.Model;

namespace MangaDex.Api.Refit
{
    public interface IForumsApi
    {
        [Post("/forums/thread")] [Headers("Content-Type: application/json")]
        Task<ForumsThreadResponse> ForumsThreadCreate([Body] ForumsThreadCreateRequest forumsThreadCreateRequest = null);

    }
}