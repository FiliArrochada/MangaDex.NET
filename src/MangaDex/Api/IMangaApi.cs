using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MangaDex.Model;
using Refit;

namespace MangaDex.Api
{
    public interface IMangaApi
    {
        [Post("/manga/draft/{id}/commit")]
        [Headers("Content-Type: application/json")]
        Task<MangaResponse> CommitMangaDraft(Guid id, [Body] CommitMangaDraftRequest commitMangaDraftRequest = null);

        [Delete("/manga/{id}")]
        Task<Response> DeleteMangaId(Guid id);

        [Delete("/manga/{id}/follow")]
        Task<Response> DeleteMangaIdFollow(Guid id);

        [Delete("/manga/{mangaId}/relation/{id}")]
        Task<Response> DeleteMangaRelationId(Guid mangaId, Guid id);

        [Get("/manga/{id}/aggregate")]
        Task<GetMangaAggregate200Response> GetMangaAggregate(Guid id, [Query(CollectionFormat.Multi), AliasAs("translatedLanguage[]")] List<string> translatedLanguage = null, [Query(CollectionFormat.Multi), AliasAs("groups[]")] List<Guid> groups = null);

        [Get("/manga/draft")]
        Task<MangaResponse> GetMangaDrafts(int? limit = null, int? offset = null, string state = null, [Query] IDictionary<string, string> order = null /* deepObject */, [Query(CollectionFormat.Multi), AliasAs("includes[]")] List<string> includes = null);

        [Get("/manga/{id}")]
        Task<MangaResponse> GetMangaId(Guid id, [Query(CollectionFormat.Multi), AliasAs("includes[]")] List<string> includes = null);

        [Get("/manga/draft/{id}")]
        Task<MangaResponse> GetMangaIdDraft(Guid id, [Query(CollectionFormat.Multi), AliasAs("includes[]")] List<string> includes = null);

        [Get("/manga/{id}/feed")]
        Task<ChapterList> GetMangaIdFeed(Guid id, int? limit = null, int? offset = null, [Query(CollectionFormat.Multi), AliasAs("translatedLanguage[]")] List<string> translatedLanguage = null, [Query(CollectionFormat.Multi), AliasAs("originalLanguage[]")] List<string> originalLanguage = null, [Query(CollectionFormat.Multi), AliasAs("excludedOriginalLanguage[]")] List<string> excludedOriginalLanguage = null, [Query(CollectionFormat.Multi), AliasAs("contentRating[]")] List<string> contentRating = null, [Query(CollectionFormat.Multi), AliasAs("excludedGroups[]")] List<Guid> excludedGroups = null, [Query(CollectionFormat.Multi), AliasAs("excludedUploaders[]")] List<Guid> excludedUploaders = null, string includeFutureUpdates = null, string createdAtSince = null, string updatedAtSince = null, string publishAtSince = null, [Query] IDictionary<string, string> order = null /* deepObject */, [Query(CollectionFormat.Multi), AliasAs("includes[]")] List<string> includes = null, int? includeEmptyPages = null, int? includeFuturePublishAt = null, int? includeExternalUrl = null);

        [Get("/manga/{id}/status")]
        Task<GetMangaIdStatus200Response> GetMangaIdStatus(Guid id);

        [Get("/manga/random")]
        Task<MangaResponse> GetMangaRandom([Query(CollectionFormat.Multi), AliasAs("includes[]")] List<string> includes = null, [Query(CollectionFormat.Multi), AliasAs("contentRating[]")] List<string> contentRating = null, [Query(CollectionFormat.Multi), AliasAs("includedTags[]")] List<Guid> includedTags = null, string includedTagsMode = null, [Query(CollectionFormat.Multi), AliasAs("excludedTags[]")] List<Guid> excludedTags = null, string excludedTagsMode = null);

        [Get("/manga/{mangaId}/relation")]
        Task<MangaRelationList> GetMangaRelation(Guid mangaId, [Query(CollectionFormat.Multi), AliasAs("includes[]")] List<string> includes = null);

        [Get("/manga/{id}/recommendation")]
        Task<MangaRecommendationList> GetMangaIdRecommendation(Guid id, [Query(CollectionFormat.Multi), AliasAs("includes[]")] List<string> includes = null, [Query] IDictionary<string, string> order = null /* deepObject */, [Query(CollectionFormat.Multi), AliasAs("contentRating[]")] List<string> contentRating = null);

        [Get("/manga/status")]
        Task<GetMangaStatus200Response> GetMangaStatus(string status = null);

        [Get("/manga/tag")]
        Task<TagResponse> GetMangaTag();

        [Get("/manga")]
        Task<MangaList> GetSearchManga(int? limit = null, int? offset = null, string title = null, Guid? authorOrArtist = null, [Query(CollectionFormat.Multi), AliasAs("authors[]")] List<Guid> authors = null, [Query(CollectionFormat.Multi), AliasAs("artists[]")] List<Guid> artists = null, GetSearchMangaYearParameter year = null, [Query(CollectionFormat.Multi), AliasAs("includedTags[]")] List<Guid> includedTags = null, string includedTagsMode = null, [Query(CollectionFormat.Multi), AliasAs("excludedTags[]")] List<Guid> excludedTags = null, string excludedTagsMode = null, [Query(CollectionFormat.Multi), AliasAs("status[]")] List<string> status = null, [Query(CollectionFormat.Multi), AliasAs("originalLanguage[]")] List<string> originalLanguage = null, [Query(CollectionFormat.Multi), AliasAs("excludedOriginalLanguage[]")] List<string> excludedOriginalLanguage = null, [Query(CollectionFormat.Multi), AliasAs("availableTranslatedLanguage[]")] List<string> availableTranslatedLanguage = null, [Query(CollectionFormat.Multi), AliasAs("publicationDemographic[]")] List<string> publicationDemographic = null, [Query(CollectionFormat.Multi), AliasAs("ids[]")] List<Guid> ids = null, [Query(CollectionFormat.Multi), AliasAs("contentRating[]")] List<string> contentRating = null, string createdAtSince = null, string updatedAtSince = null, [Query] IDictionary<string, string> order = null /* deepObject */, [Query(CollectionFormat.Multi), AliasAs("includes[]")] List<string> includes = null, string hasAvailableChapters = null, Guid? group = null);

        [Post("/manga")]
        [Headers("Content-Type: application/json")]
        Task<MangaResponse> PostManga([Body] MangaCreate mangaCreate = null);

        [Post("/manga/{id}/follow")]
        Task<Response> PostMangaIdFollow(Guid id);

        [Post("/manga/{id}/status")]
        [Headers("Content-Type: application/json")]
        Task<Response> PostMangaIdStatus(Guid id, [Body] UpdateMangaStatus updateMangaStatus = null);

        [Post("/manga/{mangaId}/relation")]
        [Headers("Content-Type: application/json")]
        Task<MangaRelationResponse> PostMangaRelation(Guid mangaId, [Body] MangaRelationCreate mangaRelationCreate = null);

        [Put("/manga/{id}")]
        [Headers("Content-Type: application/json")]
        Task<MangaResponse> PutMangaId(Guid id, [Body] PutMangaIdRequest putMangaIdRequest = null);
    }
}