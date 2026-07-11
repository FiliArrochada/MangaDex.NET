// GENERATED Refit scaffold for AtHomeApi — prototype, not wired into the build (needs Refit).
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Refit;
using MangaDex.Model;

namespace MangaDex.Api.Refit
{
    public interface IAtHomeApi
    {
        [Get("/at-home/server/{chapterId}")]
        Task<GetAtHomeServerChapterId200Response> GetAtHomeServerChapterId(Guid chapterId, bool? forcePort443 = null);

    }
}