/*
 * Fixture tests: deserialization of a realistic ScanlationGroup payload shaped after
 * the MangaDex API envelope, built from the api/openapi-<version>.yaml ScanlationGroup
 * schemas. Exercises the enum result field ("ok"), the "scanlation_group" type tag,
 * altNames as a list of localized-string dictionaries, focusedLanguage arrays and the
 * group boolean flags.
 */

using System;
using System.Text.Json;
using MangaDex.Client;
using MangaDex.Model;
using Xunit;

namespace MangaDex.Test.Fixtures
{
    public class GroupsFixtureTests
    {
        private const string GroupResponseJson = """
        {
          "result": "ok",
          "response": "entity",
          "data": {
            "id": "790c2f4e-1713-4826-9d3c-e91be1ba28f2",
            "type": "scanlation_group",
            "attributes": {
              "name": "Evil Genius",
              "altNames": [
                { "en": "EG Scans" }
              ],
              "website": "https://example.org",
              "ircServer": null,
              "ircChannel": null,
              "discord": "abc123",
              "contactEmail": "contact@example.org",
              "description": "We scanlate seinen manga.",
              "twitter": null,
              "mangaUpdates": "https://www.mangaupdates.com/group/xyz/evil-genius",
              "focusedLanguage": [ "en" ],
              "locked": false,
              "official": false,
              "verified": true,
              "inactive": false,
              "exLicensed": false,
              "publishDelay": "P4D",
              "version": 2,
              "createdAt": "2021-04-19T21:45:59+00:00",
              "updatedAt": "2023-01-01T00:00:00+00:00"
            },
            "relationships": [
              { "id": "b0e957ca-1c74-49b6-a06f-4145bd70e80b", "type": "leader" }
            ]
          }
        }
        """;

        [Fact]
        public void ScanlationGroupResponse_Deserializes_Entity_Envelope()
        {
            var response = JsonSerializer.Deserialize<ScanlationGroupResponse>(GroupResponseJson, SerializerOptions.Default);

            Assert.NotNull(response);
            Assert.Equal(ScanlationGroupResponse.ResultEnum.Ok, response.Result);   // enum "ok"
            Assert.Equal("entity", response.Response);

            var group = response.Data;
            Assert.Equal(Guid.Parse("790c2f4e-1713-4826-9d3c-e91be1ba28f2"), group.Id);
            Assert.Equal(ScanlationGroup.TypeEnum.ScanlationGroup, group.Type);     // "scanlation_group"

            // attributes
            Assert.Equal("Evil Genius", group.Attributes.Name);
            var altName = Assert.Single(group.Attributes.AltNames);
            Assert.Equal("EG Scans", altName["en"]);
            Assert.Equal(new[] { "en" }, group.Attributes.FocusedLanguage);
            Assert.True(group.Attributes.Verified);
            Assert.False(group.Attributes.Locked);
            Assert.Equal("P4D", group.Attributes.PublishDelay);
            Assert.Equal(2, group.Attributes.VarVersion);

            // relationships array
            var relationship = Assert.Single(group.Relationships);
            Assert.Equal("leader", relationship.Type);
        }
    }
}
