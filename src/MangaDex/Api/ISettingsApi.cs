// GENERATED Refit scaffold for SettingsApi — prototype, not wired into the build (needs Refit).
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Refit;
using MangaDex.Model;

namespace MangaDex.Api
{
    public interface ISettingsApi
    {
        [Get("/settings")]
        Task<GetSettings200Response> GetSettings();

        [Get("/settings/template")]
        Task<Object> GetSettingsTemplate();

        [Get("/settings/template/{version}")]
        Task<Object> GetSettingsTemplateVersion(Guid version);

        [Post("/settings")] [Headers("Content-Type: application/json")]
        Task<PostSettings200Response> PostSettings([Body] PostSettingsRequest postSettingsRequest = null);

        [Post("/settings/template")] [Headers("Content-Type: application/json")]
        Task<Object> PostSettingsTemplate([Body] Object body = null);

    }
}