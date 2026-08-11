/*
 * Fixture tests: deserialization of a realistic Author payload shaped after the
 * MangaDex API envelope ({ result, response, data: { id, type, attributes,
 * relationships } }), built from the api/openapi-<version>.yaml Author schemas.
 * Exercises the envelope wrapper, Guid ids, the "author" [EnumMember] type tag,
 * the localized-string biography dictionary, and the relationships array.
 */

using System;
using System.Text.Json;
using MangaDex.Client;
using MangaDex.Model;
using Xunit;

namespace MangaDex.Test.Fixtures
{
    public class AuthorsFixtureTests
    {
        private const string AuthorResponseJson = """
        {
          "result": "ok",
          "response": "entity",
          "data": {
            "id": "f0e6e3c4-6d5a-4b3a-9c8e-1a2b3c4d5e6f",
            "type": "author",
            "attributes": {
              "name": "MIURA Kentarou",
              "imageUrl": null,
              "biography": {
                "en": "Author of Berserk.",
                "ja": "ベルセルクの作者。"
              },
              "twitter": null,
              "pixiv": "https://www.pixiv.net/users/1",
              "website": "https://example.com",
              "version": 3,
              "createdAt": "2021-04-19T21:45:59+00:00",
              "updatedAt": "2023-01-01T00:00:00+00:00"
            },
            "relationships": [
              { "id": "aa6c76f7-5f5f-46b6-a800-911145f81b9b", "type": "manga" }
            ]
          }
        }
        """;

        [Fact]
        public void AuthorResponse_Deserializes_Entity_Envelope()
        {
            var response = JsonSerializer.Deserialize<AuthorResponse>(AuthorResponseJson, SerializerOptions.Default);

            Assert.NotNull(response);
            Assert.Equal("ok", response.Result);
            Assert.Equal("entity", response.Response);

            var author = response.Data;
            Assert.Equal(Guid.Parse("f0e6e3c4-6d5a-4b3a-9c8e-1a2b3c4d5e6f"), author.Id);
            Assert.Equal(Author.TypeEnum.Author, author.Type);   // "author" via [EnumMember]

            // attributes, including the localized biography dictionary
            Assert.Equal("MIURA Kentarou", author.Attributes.Name);
            Assert.Equal("Author of Berserk.", author.Attributes.Biography["en"]);
            Assert.Equal("https://www.pixiv.net/users/1", author.Attributes.Pixiv);
            Assert.Equal(3, author.Attributes.VarVersion);       // [JsonPropertyName("version")]
            Assert.Equal("2021-04-19T21:45:59+00:00", author.Attributes.CreatedAt);

            // relationships array
            var relationship = Assert.Single(author.Relationships);
            Assert.Equal(Guid.Parse("aa6c76f7-5f5f-46b6-a800-911145f81b9b"), relationship.Id);
            Assert.Equal("manga", relationship.Type);
        }
    }
}
