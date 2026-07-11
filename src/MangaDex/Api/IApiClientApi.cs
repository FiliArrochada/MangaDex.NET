// GENERATED Refit scaffold for ApiClientApi — prototype, not wired into the build (needs Refit).
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Refit;
using MangaDex.Model;

namespace MangaDex.Api
{
    public interface IApiClientApi
    {
        [Delete("/client/{id}")]
        Task<DeleteApiclient200Response> DeleteApiclient(Guid id, [AliasAs("version")] string varVersion = null);

        [Get("/client/{id}")]
        Task<ApiClientResponse> GetApiclient(Guid id, [Query(CollectionFormat.Multi), AliasAs("includes[]")] List<string> includes = null);

        [Get("/client/{id}/secret")]
        Task<GetApiclientSecret200Response> GetApiclientSecret(Guid id);

        [Get("/client")]
        Task<ApiClientList> GetListApiclients(int? limit = null, int? offset = null, string state = null, string name = null, [Query(CollectionFormat.Multi), AliasAs("includes[]")] List<string> includes = null, [Query] IDictionary<string, string> order = null /* deepObject */);

        [Post("/client")] [Headers("Content-Type: application/json")]
        Task<ApiClientResponse> PostCreateApiclient([Body] ApiClientCreate apiClientCreate = null);

        [Post("/client/{id}")] [Headers("Content-Type: application/json")]
        Task<ApiClientResponse> PostEditApiclient(Guid id, [Body] ApiClientEdit apiClientEdit = null);

        [Post("/client/{id}/secret")] [Headers("Content-Type: application/json")]
        Task<GetApiclientSecret200Response> PostRegenerateApiclientSecret(Guid id, [Body] Object body = null);

    }
}