using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MangaDex.Model;
using Refit;

namespace MangaDex.Api
{
    public interface ICoverApi
    {
        [Delete("/cover/{mangaOrCoverId}")]
        Task<Response> DeleteCover(Guid mangaOrCoverId);

        [Put("/cover/{mangaOrCoverId}")]
        [Headers("Content-Type: application/json")]
        Task<CoverResponse> EditCover(Guid mangaOrCoverId, [Body] CoverEdit coverEdit = null);

        [Get("/cover")]
        Task<CoverList> GetCover(int? limit = null, int? offset = null, [Query(CollectionFormat.Multi), AliasAs("manga[]")] List<Guid> manga = null, [Query(CollectionFormat.Multi), AliasAs("ids[]")] List<Guid> ids = null, [Query(CollectionFormat.Multi), AliasAs("uploaders[]")] List<Guid> uploaders = null, [Query(CollectionFormat.Multi), AliasAs("locales[]")] List<string> locales = null, [Query] IDictionary<string, string> order = null /* deepObject */, [Query(CollectionFormat.Multi), AliasAs("includes[]")] List<string> includes = null);

        [Get("/cover/{mangaOrCoverId}")]
        Task<CoverResponse> GetCoverId(Guid mangaOrCoverId, [Query(CollectionFormat.Multi), AliasAs("includes[]")] List<string> includes = null);

        [Post("/cover/{mangaOrCoverId}")]
        [Multipart]
        Task<CoverResponse> UploadCover(Guid mangaOrCoverId, [AliasAs("file")] StreamPart file, string volume = null, string description = null, string locale = null);
    }
}