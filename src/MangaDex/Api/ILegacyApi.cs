using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Refit;
using MangaDex.Model;

namespace MangaDex.Api
{
    public interface ILegacyApi
    {
        [Post("/legacy/mapping")] [Headers("Content-Type: application/json")]
        Task<MappingIdResponse> PostLegacyMapping([Body] MappingIdBody mappingIdBody = null);

    }
}