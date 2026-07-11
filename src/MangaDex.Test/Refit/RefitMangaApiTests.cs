/*
 * Vertical-slice tests: prove the Refit interface + glue actually build requests and parse
 * responses correctly — including the deepObject `order` serialization that was previously
 * flagged as unverified. No network (CapturingHandler intercepts).
 */

using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using MangaDex.Api.Refit;
using MangaDex.Model;
using MangaDex.Test.RefitSlice;
using Xunit;

namespace MangaDex.Test
{
    public class RefitMangaApiTests
    {
        private static (IMangaApi api, CapturingHandler cap) Build(string cannedJson, Func<string> token = null)
        {
            var cap = new CapturingHandler(cannedJson);
            HttpMessageHandler pipeline = token == null ? cap : new BearerTokenHandler(token) { InnerHandler = cap };
            var http = new HttpClient(pipeline) { BaseAddress = new Uri("https://api.mangadex.org") };
            return (MangaRefit.Create(http), cap);
        }

        [Fact]
        public async Task GetSearchManga_Builds_Arrays_And_DeepObject_Order()
        {
            var (api, cap) = Build("{\"result\":\"ok\",\"response\":\"collection\",\"data\":[],\"limit\":10,\"offset\":0,\"total\":0}");

            var result = await api.GetSearchManga(
                title: "one piece",
                contentRating: new List<string> { "safe", "suggestive" },
                order: new Dictionary<string, string> { ["order[relevance]"] = "desc" },
                includes: new List<string> { "cover_art", "author" });

            var q = Uri.UnescapeDataString(cap.LastRequest.RequestUri.Query);
            Assert.Equal(HttpMethod.Get, cap.LastRequest.Method);
            Assert.Equal("/manga", cap.LastRequest.RequestUri.AbsolutePath);
            Assert.Contains("title=one piece", q);
            Assert.Contains("contentRating[]=safe", q);         // array param, AliasAs "contentRating[]"
            Assert.Contains("contentRating[]=suggestive", q);
            Assert.Contains("includes[]=cover_art", q);
            Assert.Contains("includes[]=author", q);
            Assert.Contains("order[relevance]=desc", q);         // <-- deepObject serialization, CONFIRMED

            // response body parsed via the library's STJ options
            Assert.Equal("ok", result.Result);
            Assert.Equal(10, result.Limit);
        }

        [Fact]
        public async Task GetMangaId_Templates_Path_And_Deserializes()
        {
            var id = Guid.NewGuid();
            var (api, cap) = Build("{\"result\":\"ok\",\"response\":\"entity\"}");

            var result = await api.GetMangaId(id, includes: new List<string> { "author" });

            Assert.Equal($"/manga/{id}", cap.LastRequest.RequestUri.AbsolutePath);
            Assert.Contains("includes[]=author", Uri.UnescapeDataString(cap.LastRequest.RequestUri.Query));
            Assert.NotNull(result);
        }

        [Fact]
        public async Task BearerHandler_Attaches_Authorization()
        {
            var (api, cap) = Build("{\"result\":\"ok\"}", token: () => "tok-123");

            await api.GetMangaId(Guid.NewGuid());

            Assert.NotNull(cap.LastRequest.Headers.Authorization);
            Assert.Equal("Bearer", cap.LastRequest.Headers.Authorization.Scheme);
            Assert.Equal("tok-123", cap.LastRequest.Headers.Authorization.Parameter);
        }
    }
}
