// GENERATED Refit scaffold for StatisticsApi — prototype, not wired into the build (needs Refit).
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Refit;
using MangaDex.Model;

namespace MangaDex.Api
{
    public interface IStatisticsApi
    {
        [Get("/statistics/chapter/{uuid}")]
        Task<GetStatisticsChapterUuid200Response> GetStatisticsChapterUuid(Guid uuid);

        [Get("/statistics/chapter")]
        Task<GetStatisticsChapterUuid200Response> GetStatisticsChapters([Query(CollectionFormat.Csv), AliasAs("chapter[]")] List<Guid> chapter = null);

        [Get("/statistics/group/{uuid}")]
        Task<GetStatisticsChapterUuid200Response> GetStatisticsGroupUuid(Guid uuid);

        [Get("/statistics/group")]
        Task<GetStatisticsChapterUuid200Response> GetStatisticsGroups([Query(CollectionFormat.Csv), AliasAs("group[]")] List<Guid> group = null);

        [Get("/statistics/manga")]
        Task<GetStatisticsManga200Response> GetStatisticsManga([Query(CollectionFormat.Csv), AliasAs("manga[]")] List<Guid> manga = null);

        [Get("/statistics/manga/{uuid}")]
        Task<GetStatisticsMangaUuid200Response> GetStatisticsMangaUuid(Guid uuid);

    }
}