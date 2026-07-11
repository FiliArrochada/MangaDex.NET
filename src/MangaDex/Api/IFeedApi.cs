using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MangaDex.Model;
using Refit;

namespace MangaDex.Api
{
    public interface IFeedApi
    {
        [Get("/list/{id}/feed")]
        Task<ChapterList> GetListIdFeed(Guid id, int? limit = null, int? offset = null, [Query(CollectionFormat.Multi), AliasAs("translatedLanguage[]")] List<string> translatedLanguage = null, [Query(CollectionFormat.Multi), AliasAs("originalLanguage[]")] List<string> originalLanguage = null, [Query(CollectionFormat.Multi), AliasAs("excludedOriginalLanguage[]")] List<string> excludedOriginalLanguage = null, [Query(CollectionFormat.Multi), AliasAs("contentRating[]")] List<string> contentRating = null, [Query(CollectionFormat.Multi), AliasAs("excludedGroups[]")] List<Guid> excludedGroups = null, [Query(CollectionFormat.Multi), AliasAs("excludedUploaders[]")] List<Guid> excludedUploaders = null, string includeFutureUpdates = null, string createdAtSince = null, string updatedAtSince = null, string publishAtSince = null, [Query] IDictionary<string, string> order = null /* deepObject */, [Query(CollectionFormat.Multi), AliasAs("includes[]")] List<string> includes = null, int? includeEmptyPages = null, int? includeFuturePublishAt = null, int? includeExternalUrl = null);

        [Get("/user/follows/manga/feed")]
        Task<ChapterList> GetUserFollowsMangaFeed(int? limit = null, int? offset = null, [Query(CollectionFormat.Multi), AliasAs("translatedLanguage[]")] List<string> translatedLanguage = null, [Query(CollectionFormat.Multi), AliasAs("originalLanguage[]")] List<string> originalLanguage = null, [Query(CollectionFormat.Multi), AliasAs("excludedOriginalLanguage[]")] List<string> excludedOriginalLanguage = null, [Query(CollectionFormat.Multi), AliasAs("contentRating[]")] List<string> contentRating = null, [Query(CollectionFormat.Multi), AliasAs("excludedGroups[]")] List<Guid> excludedGroups = null, [Query(CollectionFormat.Multi), AliasAs("excludedUploaders[]")] List<Guid> excludedUploaders = null, string includeFutureUpdates = null, string createdAtSince = null, string updatedAtSince = null, string publishAtSince = null, [Query] IDictionary<string, string> order = null /* deepObject */, [Query(CollectionFormat.Multi), AliasAs("includes[]")] List<string> includes = null, int? includeEmptyPages = null, int? includeFuturePublishAt = null, int? includeExternalUrl = null);
    }
}