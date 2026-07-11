using System;
using System.Threading.Tasks;
using MangaDex.Model;
using Refit;

namespace MangaDex.Api
{
    public interface IAtHomeApi
    {
        [Get("/at-home/server/{chapterId}")]
        Task<GetAtHomeServerChapterId200Response> GetAtHomeServerChapterId(Guid chapterId, bool? forcePort443 = null);
    }
}