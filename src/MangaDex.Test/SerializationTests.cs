/*
 * Serialization tests validating the migration from Newtonsoft.Json to System.Text.Json.
 *
 * These exercise the behaviours most at risk in the migration:
 *   - enum values serialized/parsed via their [EnumMember] value (StringEnumMemberConverter)
 *   - explicit [JsonPropertyName] mapping, including renamed properties (VarVersion -> "version")
 *   - EmitDefaultValue=false -> omit default; EmitDefaultValue=true -> always emit
 *   - oneOf/anyOf models (custom converters + FromJson/ToJson) and their disambiguation
 *   - collections and dictionaries
 */

using System;
using System.Collections.Generic;
using System.Text.Json;
using MangaDex.Client;
using MangaDex.Model;
using Xunit;

namespace MangaDex.Test
{
    public class SerializationTests
    {
        private static readonly JsonSerializerOptions Options = SerializerOptions.Default;

        // ---------- Enums (EnumMember values) ----------

        [Fact]
        public void Enum_Serializes_Using_EnumMember_Value()
        {
            var cover = new Cover(id: Guid.NewGuid(), type: Cover.TypeEnum.CoverArt);
            var json = JsonSerializer.Serialize(cover, Options);
            Assert.Contains("\"type\":\"cover_art\"", json);
            Assert.DoesNotContain("\"type\":1", json); // not the numeric underlying value
        }

        [Fact]
        public void Enum_Deserializes_From_EnumMember_Value()
        {
            var id = Guid.NewGuid();
            var json = $"{{\"id\":\"{id}\",\"type\":\"cover_art\"}}";
            var cover = JsonSerializer.Deserialize<Cover>(json, Options);
            Assert.Equal(Cover.TypeEnum.CoverArt, cover.Type);
            Assert.Equal(id, cover.Id);
        }

        [Fact]
        public void Enum_With_Underscore_Value_RoundTrips()
        {
            var report = new PostReportRequest(category: PostReportRequest.CategoryEnum.ScanlationGroup);
            var json = JsonSerializer.Serialize(report, Options);
            Assert.Contains("\"category\":\"scanlation_group\"", json);

            var back = JsonSerializer.Deserialize<PostReportRequest>(json, Options);
            Assert.Equal(PostReportRequest.CategoryEnum.ScanlationGroup, back.Category);
        }

        // ---------- Property naming ----------

        [Fact]
        public void PropertyNames_Use_DataMember_Names_Including_Renamed_Property()
        {
            var attrs = new MangaAttributes(
                originalLanguage: "ja",
                availableTranslatedLanguages: new List<string> { "en", "fr" },
                status: MangaAttributes.StatusEnum.Ongoing,
                varVersion: 3);

            var json = JsonSerializer.Serialize(attrs, Options);

            Assert.Contains("\"originalLanguage\":\"ja\"", json);
            Assert.Contains("\"version\":3", json);            // VarVersion property -> "version" key
            Assert.Contains("\"status\":\"ongoing\"", json);   // enum via EnumMember
            Assert.Contains("\"availableTranslatedLanguages\":[\"en\",\"fr\"]", json);
        }

        [Fact]
        public void RenamedProperty_Deserializes_From_Json_Key()
        {
            var json = "{\"originalLanguage\":\"ko\",\"version\":7}";
            var attrs = JsonSerializer.Deserialize<MangaAttributes>(json, Options);
            Assert.Equal("ko", attrs.OriginalLanguage);
            Assert.Equal(7, attrs.VarVersion);
        }

        // ---------- Null / default handling ----------

        [Fact]
        public void EmitDefaultValueFalse_Omits_Null_While_True_Emits_Null()
        {
            // Only originalLanguage set; everything else default/null.
            var attrs = new MangaAttributes(originalLanguage: "en");
            var json = JsonSerializer.Serialize(attrs, Options);

            // title: EmitDefaultValue = false, and is null -> omitted
            Assert.DoesNotContain("\"title\"", json);
            // lastVolume: EmitDefaultValue = true, and is null -> emitted as null
            Assert.Contains("\"lastVolume\":null", json);
            // isLocked: EmitDefaultValue = true bool default -> emitted as false
            Assert.Contains("\"isLocked\":false", json);
        }

        // ---------- Collections round-trip ----------

        [Fact]
        public void ListOfString_RoundTrips()
        {
            var attrs = new MangaAttributes(availableTranslatedLanguages: new List<string> { "en", "es", "ja" });
            var back = JsonSerializer.Deserialize<MangaAttributes>(JsonSerializer.Serialize(attrs, Options), Options);
            Assert.Equal(new List<string> { "en", "es", "ja" }, back.AvailableTranslatedLanguages);
        }

        // ---------- oneOf: Guid vs List<Guid> ----------

        [Fact]
        public void OneOf_Guid_RoundTrips()
        {
            var g = Guid.NewGuid();
            var p = new GetChapterUploaderParameter(g);
            var json = p.ToJson();
            Assert.Equal($"\"{g}\"", json);

            var back = GetChapterUploaderParameter.FromJson(json);
            Assert.Equal(g, back.GetGuid());
        }

        [Fact]
        public void OneOf_ListGuid_RoundTrips()
        {
            var list = new List<Guid> { Guid.NewGuid(), Guid.NewGuid() };
            var p = new GetChapterUploaderParameter(list);
            var back = GetChapterUploaderParameter.FromJson(p.ToJson());
            Assert.Equal(list, back.GetListUuid());
        }

        // ---------- oneOf: int vs string disambiguation ----------

        [Fact]
        public void OneOf_Year_Number_Parses_As_Int()
        {
            var p = GetSearchMangaYearParameter.FromJson("2020");
            Assert.Equal(2020, p.GetInt());
        }

        [Fact]
        public void OneOf_Year_QuotedValue_Parses_As_String()
        {
            var p = GetSearchMangaYearParameter.FromJson("\"any\"");
            Assert.Equal("any", p.GetString());
        }

        // ---------- oneOf: List vs Dictionary ----------

        [Fact]
        public void OneOf_ReadMarkers_Dictionary_RoundTrips()
        {
            var dict = new Dictionary<string, List<Guid>>
            {
                ["chapter-1"] = new List<Guid> { Guid.NewGuid(), Guid.NewGuid() }
            };
            var p = new GetMangaChapterReadmarkers2200ResponseData(dict);
            var back = GetMangaChapterReadmarkers2200ResponseData.FromJson(p.ToJson());
            Assert.Equal(dict, back.GetDictionary());
        }

        [Fact]
        public void OneOf_ReadMarkers_List_RoundTrips()
        {
            var list = new List<Guid> { Guid.NewGuid() };
            var p = new GetMangaChapterReadmarkers2200ResponseData(list);
            var back = GetMangaChapterReadmarkers2200ResponseData.FromJson(p.ToJson());
            Assert.Equal(list, back.GetListUuid());
        }

        // ---------- Realistic nested payload ----------

        [Fact]
        public void Deserializes_Realistic_Cover_Payload()
        {
            var id = Guid.NewGuid();
            var json = $@"{{
                ""id"": ""{id}"",
                ""type"": ""cover_art"",
                ""attributes"": {{
                    ""fileName"": ""cover.jpg"",
                    ""volume"": ""1"",
                    ""version"": 1
                }},
                ""relationships"": [
                    {{ ""id"": ""{Guid.NewGuid()}"", ""type"": ""manga"" }}
                ]
            }}";

            var cover = JsonSerializer.Deserialize<Cover>(json, Options);

            Assert.Equal(id, cover.Id);
            Assert.Equal(Cover.TypeEnum.CoverArt, cover.Type);
            Assert.NotNull(cover.Attributes);
            Assert.Equal("cover.jpg", cover.Attributes.FileName);
            Assert.Single(cover.Relationships);
            Assert.Equal("manga", cover.Relationships[0].Type);
        }

        // ---------- 5.13.1 reconciliation ----------

        [Fact]
        public void RequiredBody_Serializes_With_CamelCase_Names()
        {
            // Regression: required ([DataMember IsRequired=true]) props must carry [JsonPropertyName].
            var manga = Guid.NewGuid();
            var groups = new List<Guid> { Guid.NewGuid() };
            var body = new BeginUploadSession(groups: groups, manga: manga);
            var json = JsonSerializer.Serialize(body, Options);
            Assert.Contains("\"manga\":", json);
            Assert.Contains("\"groups\":", json);
            Assert.DoesNotContain("\"Manga\":", json); // not PascalCase
            Assert.DoesNotContain("\"Groups\":", json);

            var back = JsonSerializer.Deserialize<BeginUploadSession>(json, Options);
            Assert.Equal(manga, back.Manga);
            Assert.Equal(groups, back.Groups);
        }

        [Fact]
        public void MangaAttributes_OfficialLinks_RoundTrips()
        {
            var attrs = new MangaAttributes(officialLinks: new Dictionary<string, string> { ["mal"] = "https://myanimelist.net/manga/1" });
            var json = JsonSerializer.Serialize(attrs, Options);
            Assert.Contains("\"officialLinks\":", json);
            var back = JsonSerializer.Deserialize<MangaAttributes>(json, Options);
            Assert.Equal("https://myanimelist.net/manga/1", back.OfficialLinks["mal"]);
        }

        [Fact]
        public void New_MangaRecommendation_Model_RoundTrips()
        {
            var rec = new MangaRecommendation(id: Guid.NewGuid(), type: MangaRecommendation.TypeEnum.MangaRecommendation);
            var json = JsonSerializer.Serialize(rec, Options);
            Assert.Contains("\"type\":\"manga_recommendation\"", json);

            var list = new MangaRecommendationList(data: new List<MangaRecommendation> { rec }, total: 1);
            var listJson = JsonSerializer.Serialize(list, Options);
            var back = JsonSerializer.Deserialize<MangaRecommendationList>(listJson, Options);
            Assert.Single(back.Data);
            Assert.Equal(MangaRecommendation.TypeEnum.MangaRecommendation, back.Data[0].Type);
        }

        [Fact]
        public void ApiClientAttributes_State_Enum_RoundTrips()
        {
            var attrs = new ApiClientAttributes(externalClientId: "ext-1", isActive: true, state: ApiClientAttributes.StateEnum.Autoapproved);
            var json = JsonSerializer.Serialize(attrs, Options);
            Assert.Contains("\"state\":\"autoapproved\"", json);
            Assert.Contains("\"externalClientId\":\"ext-1\"", json);
            Assert.Contains("\"isActive\":true", json);
            Assert.DoesNotContain("clientId", json); // removed upstream (only externalClientId now)

            var back = JsonSerializer.Deserialize<ApiClientAttributes>(json, Options);
            Assert.Equal(ApiClientAttributes.StateEnum.Autoapproved, back.State);
        }

        // ---------- New 5.13.1 endpoints' models ----------

        [Fact]
        public void UploadCheckApprovalRequest_Serializes()
        {
            var manga = Guid.NewGuid();
            var req = new UploadCheckApprovalRequiredRequest(manga: manga, locale: "en");
            var json = JsonSerializer.Serialize(req, Options);
            Assert.Contains($"\"manga\":\"{manga}\"", json);
            Assert.Contains("\"locale\":\"en\"", json);
        }

        [Fact]
        public void UploadCheckApproval200Response_Deserializes()
        {
            var json = "{\"result\":\"ok\",\"requiresApproval\":true}";
            var resp = JsonSerializer.Deserialize<UploadCheckApprovalRequired200Response>(json, Options);
            Assert.Equal("ok", resp.Result);
            Assert.True(resp.RequiresApproval);
        }

        [Fact]
        public void RecommendationOrderParameter_Serializes_Score()
        {
            var order = new GetMangaIdRecommendationOrderParameter(score: GetMangaIdRecommendationOrderParameter.ScoreEnum.Desc);
            var json = JsonSerializer.Serialize(order, Options);
            Assert.Contains("\"score\":\"desc\"", json);
        }

        // ---------- ClientUtils.Serialize helper ----------

        [Fact]
        public void ClientUtils_Serialize_Uses_SystemTextJson()
        {
            var attrs = new MangaAttributes(originalLanguage: "en");
            var json = ClientUtils.Serialize(attrs);
            Assert.NotNull(json);
            Assert.Contains("\"originalLanguage\":\"en\"", json);
            Assert.Null(ClientUtils.Serialize(null));
        }
    }
}
