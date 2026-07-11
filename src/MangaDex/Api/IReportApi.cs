// GENERATED Refit scaffold for ReportApi — prototype, not wired into the build (needs Refit).
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Refit;
using MangaDex.Model;

namespace MangaDex.Api
{
    public interface IReportApi
    {
        [Get("/report/reasons/{category}")]
        Task<GetReportReasonsByCategory200Response> GetReportReasonsByCategory(string category);

        [Get("/report")]
        Task<ReportListResponse> GetReports(int? limit = null, int? offset = null, string category = null, Guid? reasonId = null, Guid? objectId = null, string status = null, [Query] IDictionary<string, string> order = null /* deepObject */, [Query(CollectionFormat.Multi), AliasAs("includes[]")] List<string> includes = null);

        [Post("/report")] [Headers("Content-Type: application/json")]
        Task<Response> PostReport([Body] PostReportRequest postReportRequest = null);

    }
}