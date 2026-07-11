// GENERATED Refit scaffold for AuthorApi — prototype, not wired into the build (needs Refit).
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Refit;
using MangaDex.Model;

namespace MangaDex.Api.Refit
{
    public interface IAuthorApi
    {
        [Delete("/author/{id}")]
        Task<Response> DeleteAuthorId(Guid id);

        [Get("/author")]
        Task<AuthorList> GetAuthor(int? limit = null, int? offset = null, [Query(CollectionFormat.Multi), AliasAs("ids[]")] List<Guid> ids = null, string name = null, [Query] IDictionary<string, string> order = null /* deepObject */, [Query(CollectionFormat.Multi), AliasAs("includes[]")] List<string> includes = null);

        [Get("/author/{id}")]
        Task<AuthorResponse> GetAuthorId(Guid id, [Query(CollectionFormat.Multi), AliasAs("includes[]")] List<string> includes = null);

        [Post("/author")] [Headers("Content-Type: application/json")]
        Task<AuthorResponse> PostAuthor([Body] AuthorCreate authorCreate = null);

        [Put("/author/{id}")] [Headers("Content-Type: application/json")]
        Task<AuthorResponse> PutAuthorId(Guid id, [Body] AuthorEdit authorEdit = null);

    }
}