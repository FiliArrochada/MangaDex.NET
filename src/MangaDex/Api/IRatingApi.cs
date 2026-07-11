using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MangaDex.Model;
using Refit;

namespace MangaDex.Api
{
    public interface IRatingApi
    {
        [Delete("/rating/{mangaId}")]
        Task<Response> DeleteRatingMangaId(Guid mangaId);

        [Get("/rating")]
        Task<GetRating200Response> GetRating([Query(CollectionFormat.Csv)] List<Guid> manga = null);

        [Post("/rating/{mangaId}")]
        [Headers("Content-Type: application/json")]
        Task<Response> PostRatingMangaId(Guid mangaId, [Body] PostRatingMangaIdRequest postRatingMangaIdRequest = null);
    }
}