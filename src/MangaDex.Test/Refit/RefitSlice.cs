/*
 * Runtime glue for the Refit vertical slice (test project only).
 *
 * Shows what productionizing Refit needs, reusing pieces already in the library:
 *   - RefitSettings with SystemTextJsonContentSerializer(SerializerOptions.Default)  <- existing STJ options
 *   - a Bearer DelegatingHandler (replaces the per-method token wiring in the old ApiClient)
 * Plus a CapturingHandler so tests can assert the exact outgoing request without a live call
 * (a live call can't run here: api.mangadex.org requires TLS 1.3, unavailable on this OS).
 */

using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MangaDex.Api.Refit;
using MangaDex.Client;
using Refit;

namespace MangaDex.Test.RefitSlice
{
    /// <summary>Builds a Refit client for one API using the library's existing STJ options.</summary>
    public static class MangaRefit
    {
        public static readonly RefitSettings Settings =
            new RefitSettings(new SystemTextJsonContentSerializer(SerializerOptions.Default));

        public static IMangaApi Create(HttpClient http) => RestService.For<IMangaApi>(http, Settings);
    }

    /// <summary>Injects `Authorization: Bearer &lt;token&gt;` when a token is available.</summary>
    public sealed class BearerTokenHandler : DelegatingHandler
    {
        private readonly Func<string> _token;
        public BearerTokenHandler(Func<string> token) { _token = token; }

        protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken ct)
        {
            var t = _token();
            if (!string.IsNullOrEmpty(t))
                request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", t);
            return base.SendAsync(request, ct);
        }
    }

    /// <summary>Test double: records the outgoing request and returns a canned JSON response.</summary>
    public sealed class CapturingHandler : HttpMessageHandler
    {
        private readonly string _json;
        public HttpRequestMessage LastRequest { get; private set; }
        public CapturingHandler(string json) { _json = json; }

        protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken ct)
        {
            LastRequest = request;
            return Task.FromResult(new HttpResponseMessage(HttpStatusCode.OK)
            {
                Content = new StringContent(_json, Encoding.UTF8, "application/json"),
            });
        }
    }
}
