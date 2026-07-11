// GENERATED Refit scaffold for ReadMarkerApi — prototype, not wired into the build (needs Refit).
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Refit;
using MangaDex.Model;

namespace MangaDex.Api.Refit
{
    public interface IReadMarkerApi
    {
        [Get("/manga/{id}/read")]
        Task<GetMangaChapterReadmarkers200Response> GetMangaChapterReadmarkers(Guid id);

        [Get("/manga/read")]
        Task<GetMangaChapterReadmarkers2200Response> GetMangaChapterReadmarkers2([Query(CollectionFormat.Multi), AliasAs("ids[]")] List<Guid> ids = null, bool? grouped = null);

        [Get("/user/history")]
        Task<GetReadingHistory200Response> GetReadingHistory();

        [Post("/manga/{id}/read")] [Headers("Content-Type: application/json")]
        Task<FollowListId200Response> PostMangaChapterReadmarkers(Guid id, bool? updateHistory = null, [Body] ChapterReadMarkerBatch chapterReadMarkerBatch = null);

    }
}