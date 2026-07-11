// GENERATED Refit scaffold for ChapterApi — prototype, not wired into the build (needs Refit).
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Refit;
using MangaDex.Model;

namespace MangaDex.Api
{
    public interface IChapterApi
    {
        [Delete("/chapter/{id}")]
        Task<Response> DeleteChapterId(Guid id);

        [Get("/chapter")]
        Task<ChapterList> GetChapter(int? limit = null, int? offset = null, [Query(CollectionFormat.Multi), AliasAs("ids[]")] List<Guid> ids = null, string title = null, [Query(CollectionFormat.Multi), AliasAs("groups[]")] List<Guid> groups = null, GetChapterUploaderParameter uploader = null, Guid? manga = null, [AliasAs("volume[]")] GetChapterVolumeParameter volume = null, GetChapterVolumeParameter chapter = null, [Query(CollectionFormat.Multi), AliasAs("translatedLanguage[]")] List<string> translatedLanguage = null, [Query(CollectionFormat.Multi), AliasAs("originalLanguage[]")] List<string> originalLanguage = null, [Query(CollectionFormat.Multi), AliasAs("excludedOriginalLanguage[]")] List<string> excludedOriginalLanguage = null, [Query(CollectionFormat.Multi), AliasAs("contentRating[]")] List<string> contentRating = null, [Query(CollectionFormat.Multi), AliasAs("excludedGroups[]")] List<Guid> excludedGroups = null, [Query(CollectionFormat.Multi), AliasAs("excludedUploaders[]")] List<Guid> excludedUploaders = null, string includeFutureUpdates = null, int? includeEmptyPages = null, int? includeFuturePublishAt = null, int? includeExternalUrl = null, string createdAtSince = null, string updatedAtSince = null, string publishAtSince = null, [Query] IDictionary<string, string> order = null /* deepObject */, [Query(CollectionFormat.Multi)] List<string> includes = null);

        [Get("/chapter/{id}")]
        Task<ChapterResponse> GetChapterId(Guid id, [Query(CollectionFormat.Multi), AliasAs("includes[]")] List<string> includes = null);

        [Put("/chapter/{id}")] [Headers("Content-Type: application/json")]
        Task<ChapterResponse> PutChapterId(Guid id, [Body] ChapterEdit chapterEdit = null);

    }
}