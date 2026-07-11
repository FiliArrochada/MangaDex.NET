// GENERATED Refit scaffold for FollowsApi — prototype, not wired into the build (needs Refit).
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Refit;
using MangaDex.Model;

namespace MangaDex.Api.Refit
{
    public interface IFollowsApi
    {
        [Get("/user/follows/group")]
        Task<ScanlationGroupList> GetUserFollowsGroup(int? limit = null, int? offset = null, [Query(CollectionFormat.Multi), AliasAs("includes[]")] List<string> includes = null);

        [Get("/user/follows/group/{id}")]
        Task<Response> GetUserFollowsGroupId(Guid id);

        [Get("/user/follows/list")]
        Task<CustomListList> GetUserFollowsList(int? limit = null, int? offset = null);

        [Get("/user/follows/list/{id}")]
        Task<Response> GetUserFollowsListId(Guid id);

        [Get("/user/follows/manga")]
        Task<MangaList> GetUserFollowsManga(int? limit = null, int? offset = null, [Query(CollectionFormat.Multi), AliasAs("includes[]")] List<string> includes = null);

        [Get("/user/follows/manga/{id}")]
        Task<Response> GetUserFollowsMangaId(Guid id);

        [Get("/user/follows/user")]
        Task<UserList> GetUserFollowsUser(int? limit = null, int? offset = null);

        [Get("/user/follows/user/{id}")]
        Task<Response> GetUserFollowsUserId(Guid id);

    }
}