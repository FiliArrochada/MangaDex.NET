using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Refit;
using MangaDex.Model;

namespace MangaDex.Api
{
    public interface ICustomListApi
    {
        [Delete("/list/{id}")]
        Task<Response> DeleteListId(Guid id);

        [Delete("/manga/{id}/list/{listId}")]
        Task<Response> DeleteMangaIdListListId(Guid id, Guid listId);

        [Post("/list/{id}/follow")] [Headers("Content-Type: application/json")]
        Task<FollowListId200Response> FollowListId(Guid id, [Body] Object body = null);

        [Get("/list/{id}")]
        Task<CustomListResponse> GetListId(Guid id);

        [Get("/user/{id}/list")]
        Task<CustomListList> GetUserIdList(Guid id, int? limit = null, int? offset = null);

        [Get("/user/list")]
        Task<CustomListList> GetUserList(int? limit = null, int? offset = null);

        [Post("/list")] [Headers("Content-Type: application/json")]
        Task<CustomListResponse> PostList([Body] CustomListCreate customListCreate = null);

        [Post("/manga/{id}/list/{listId}")]
        Task<Response> PostMangaIdListListId(Guid id, Guid listId);

        [Put("/list/{id}")] [Headers("Content-Type: application/json")]
        Task<CustomListResponse> PutListId(Guid id, [Body] CustomListEdit customListEdit = null);

        [Delete("/list/{id}/follow")] [Headers("Content-Type: application/json")]
        Task<FollowListId200Response> UnfollowListId(Guid id, [Body] Object body = null);

    }
}