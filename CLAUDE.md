# CLAUDE.md

This file provides guidance to Claude Code (claude.ai/code) when working with code in this repository.

## What this is

A hand-maintained C# client library for the MangaDex REST API (`https://api.mangadex.org`).
The client is a set of **Refit** interfaces serialized with **System.Text.Json**. It is a typed
proxy over the live API and is kept in sync with the MangaDex OpenAPI spec
(`api/openapi-<version>.yaml`, highest version = current) **manually** — there is no code
generator in this repo. When the spec changes, edits are applied
directly to the interface and model source.

## Commands

```bash
# Build / test (from repo root)
dotnet build MangaDex.sln
dotnet test  MangaDex.sln

# Run a single test class or method (xUnit)
dotnet test --filter "FullyQualifiedName~RefitMangaApiTests"
dotnet test --filter "FullyQualifiedName~RefitMangaApiTests.BearerHandler_Attaches_Authorization"

# Check whether the vendored spec has drifted from MangaDex's upstream spec.
# This is a .NET 10 file-based app (the library itself targets net10.0/net48).
dotnet run scripts/check-spec-version.cs -- --diff
```

Both projects multi-target **net10.0;net48** (`dotnet test` runs the suite on both). Tests use
**xUnit v3** (`xunit.v3` — the test project builds as an executable). Dependency updates are
automated via Renovate (`renovate.json`).

## Layout

- `src/MangaDex/` — the library (`MangaDex` assembly, root namespace `MangaDex`).
  - `Api/I*Api.cs` — Refit interfaces, one per API tag (`IMangaApi`, `IChapterApi`, `IAuthApi`, …),
    all in namespace **`MangaDex.Api`**.
  - `Model/*.cs` — DTOs (~145 files). See "Model conventions" below.
  - `Client/` — serialization infrastructure: `SerializerOptions` (`.Default` compact,
    `.Indented` pretty), `StringEnumMemberConverter` (maps enums via `[EnumMember]` values),
    `OpenAPIDateConverter`.
- `src/MangaDex.Test/` — xUnit tests: `SerializationTests.cs` (targeted STJ-migration behaviors:
  enums, property naming, EmitDefaultValue, oneOf/anyOf, collections), the Refit vertical-slice
  tests under `Refit/`, `Fixtures/` (realistic hand-built payloads in the MangaDex
  `{ result, response, data: { id, type, attributes, relationships } }` envelope —
  `AuthorsFixtureTests` with the localized biography dictionary, `GroupsFixtureTests` with
  altNames/focusedLanguage and the enum `result` field), and `Model/AllModelsRoundTripTests.cs` —
  a reflection-driven theory that
  serialize→deserialize→serialize round-trips every constructible DTO and round-trips every enum
  member through its `[EnumMember]` value (with a coverage-floor assertion; the abstract oneOf
  wrappers and `*JsonConverter` helpers are excluded). It replaced the ~139 generated per-model
  stub files, which asserted nothing.
- `api/openapi-<version>.yaml` — the specs this client mirrors, one file per API version kept
  as history; the highest-versioned file is the current source of truth. When the API updates,
  add a new file alongside the old ones (don't overwrite).
- `scripts/check-spec-version.cs` — upstream drift checker (compares the latest local spec).
  `.github/workflows/spec-drift.yml` runs it weekly and opens/closes a `spec-drift` issue.

## How the client is meant to be used

There is no generated `Configuration`/`ApiClient` wrapper — consumers build Refit clients
themselves. The one required piece from this library is the shared STJ options:

```csharp
var settings = new RefitSettings(new SystemTextJsonContentSerializer(SerializerOptions.Default));
var http = new HttpClient { BaseAddress = new Uri("https://api.mangadex.org") };
var manga = RestService.For<IMangaApi>(http, settings);
```

Auth (bearer token) and proxying are configured on the `HttpClient`/`HttpClientHandler` or via a
`DelegatingHandler` — not baked into the interfaces. `RefitSlice.cs` in the test project shows the
production glue pattern (`BearerTokenHandler`).

Since Refit 14 the reflection request builder lives in the separate `Refit.Reflection` package.
The deepObject dictionary params (`IMangaApi.GetSearchManga`, `IChapterApi.GetChapter`) can't be
source-generated (RF006, suppressed via NoWarn), so the library references `Refit.Reflection`
directly to keep `RestService.For<T>` working for consumers. Keep it version-locked to `Refit`.

## Refit interface conventions (important when editing/adding endpoints)

The interfaces encode MangaDex's non-trivial query-string shapes. Match these exactly:

- **Array params** → `[Query(CollectionFormat.Multi), AliasAs("name[]")] List<T> name = null`,
  producing `name[]=a&name[]=b` (the `[]` suffix is part of the alias, on purpose).
- **`order` deepObject params** → `[Query] IDictionary<string, string> order = null /* deepObject */`.
  Callers pass keys already in `order[field]` form (e.g. `{ ["order[relevance]"] = "desc" }`),
  which Refit emits as `order[relevance]=desc`. These serialization shapes are what the
  `Refit/` slice tests exist to lock down — keep those tests passing when touching query params.
- **Request bodies** → `[Body]` plus `[Headers("Content-Type: application/json")]`.

## Model conventions

Models are `partial` classes carrying **both** `System.Text.Json` (`[JsonPropertyName]`,
`[JsonIgnore]`) and `System.Runtime.Serialization` (`[DataContract]`/`[DataMember]`) attributes;
STJ is what actually drives (de)serialization here. Each model hand-rolls `ToJson()` (uses
`SerializerOptions.Indented`), `ToString()`, value-based `Equals`/`GetHashCode`, and an
`IValidatableObject.Validate`. When adding or changing a model, keep this full shape consistent
with the surrounding files rather than trimming it.

**net48 ctor gotcha**: an optional ctor parameter declared `DateTime x = default(DateTime)` breaks
`ParameterInfo` reflection on .NET Framework (`FormatException` in `MdConstant.GetValue`), which STJ
hits while building the type's metadata (`Guid`/plain-struct defaults are fine — only `DateTime`
emits the problematic constant). Use a nullable parameter (`DateTime? x = default(DateTime?)`) with
`?? default(DateTime)` in the body, **and** give the model a `[JsonConstructor] protected Xxx() { }`
— otherwise modern STJ rejects the parameterized ctor because the param type no longer matches the
property type. See `GetSettings200Response` for the pattern.

## Testing note

The test suite never hits the network — `api.mangadex.org`'s edge requires TLS 1.3, which the
Windows schannel stack (used by `HttpClient`) does not provide on older Windows versions, so live
calls fail there.
Refit tests use a `CapturingHandler` that records the outgoing request and returns canned JSON, so
they assert URL/query/body construction and response parsing without a real call.
