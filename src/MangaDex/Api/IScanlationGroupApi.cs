// GENERATED Refit scaffold for ScanlationGroupApi — prototype, not wired into the build (needs Refit).
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Refit;
using MangaDex.Model;

namespace MangaDex.Api
{
    public interface IScanlationGroupApi
    {
        [Delete("/group/{id}")]
        Task<Response> DeleteGroupId(Guid id);

        [Delete("/group/{id}/follow")]
        Task<Response> DeleteGroupIdFollow(Guid id);

        [Get("/group/{id}")]
        Task<ScanlationGroupResponse> GetGroupId(Guid id, [Query(CollectionFormat.Multi), AliasAs("includes[]")] List<string> includes = null);

        [Get("/group")]
        Task<ScanlationGroupList> GetSearchGroup(int? limit = null, int? offset = null, [Query(CollectionFormat.Multi), AliasAs("ids[]")] List<Guid> ids = null, string name = null, string focusedLanguage = null, [Query(CollectionFormat.Multi), AliasAs("includes[]")] List<string> includes = null, [Query] IDictionary<string, string> order = null /* deepObject */);

        [Post("/group")] [Headers("Content-Type: application/json")]
        Task<ScanlationGroupResponse> PostGroup([Body] CreateScanlationGroup createScanlationGroup = null);

        [Post("/group/{id}/follow")]
        Task<Response> PostGroupIdFollow(Guid id);

        [Put("/group/{id}")] [Headers("Content-Type: application/json")]
        Task<ScanlationGroupResponse> PutGroupId(Guid id, [Body] ScanlationGroupEdit scanlationGroupEdit = null);

    }
}