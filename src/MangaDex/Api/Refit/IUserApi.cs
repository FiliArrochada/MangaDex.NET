// GENERATED Refit scaffold for UserApi — prototype, not wired into the build (needs Refit).
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Refit;
using MangaDex.Model;

namespace MangaDex.Api.Refit
{
    public interface IUserApi
    {
        [Delete("/user/{id}")]
        Task<Response> DeleteUserId(Guid id);

        [Get("/user")]
        Task<UserList> GetUser(int? limit = null, int? offset = null, [Query(CollectionFormat.Multi), AliasAs("ids[]")] List<Guid> ids = null, string username = null, [Query] IDictionary<string, string> order = null /* deepObject */);

        [Get("/user/{id}")]
        Task<UserResponse> GetUserId(Guid id);

        [Get("/user/me")]
        Task<UserResponse> GetUserMe();

        [Post("/user/delete/{code}")]
        Task<Response> PostUserDeleteCode(Guid code);

    }
}