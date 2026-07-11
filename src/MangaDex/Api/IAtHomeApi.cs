using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Refit;
using MangaDex.Model;

namespace MangaDex.Api
{
    public interface IAtHomeApi
    {
        [Get("/at-home/server/{chapterId}")]
        Task<GetAtHomeServerChapterId200Response> GetAtHomeServerChapterId(Guid chapterId, bool? forcePort443 = null);

    }
}