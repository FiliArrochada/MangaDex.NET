# CLAUDE.md

This file provides guidance to Claude Code (claude.ai/code) when working with code in this repository.

## What this is

A hand-maintained C# client library for the MangaDex REST API (`https://api.mangadex.org`).
The client is a set of **Refit** interfaces serialized with **System.Text.Json**. It is a typed
proxy over the live API and is kept in sync with the MangaDex OpenAPI spec (`api/openapi.yaml`)
**manually** — there is no code generator in this repo. When the spec changes, edits are applied
directly to the interface and model source. Current: API 5.13.1, SDK 0.1.0.

## Commands

```bash
# Build / test (from repo root)
dotnet build MangaDex.sln
dotnet test  MangaDex.sln

# Run a single test class or method (xUnit)
dotnet test --filter "FullyQualifiedName~RefitMangaApiTests"
dotnet test --filter "FullyQualifiedName~RefitMangaApiTests.BearerHandler_Attaches_Authorization"

# Check whether the vendored spec has drifted from MangaDex's upstream spec.
# This is a .NET 10 file-based app (needs the .NET 10 SDK; the library itself targets net8.0).
dotnet run scripts/check-spec-version.cs -- --diff
```

Both projects target **net8.0**. Tests use **xUnit**.

## Layout

- `src/MangaDex/` — the library (`MangaDex` assembly, root namespace `MangaDex`).
  - `Api/I*Api.cs` — Refit interfaces, one per API tag (`IMangaApi`, `IChapterApi`, `IAuthApi`, …),
    all in namespace **`MangaDex.Api`**.
  - `Model/*.cs` — DTOs (~145 files). See "Model conventions" below.
  - `Client/` — serialization infrastructure: `SerializerOptions` (`.Default` compact,
    `.Indented` pretty), `StringEnumMemberConverter` (maps enums via `[EnumMember]` values),
    `OpenAPIDateConverter`.
- `src/MangaDex.Test/` — xUnit tests: per-model tests under `Model/`, and the Refit
  vertical-slice tests under `Refit/`.
- `api/openapi.yaml` — the source-of-truth spec this client mirrors.
- `scripts/check-spec-version.cs` — upstream drift checker.

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

## Testing note

The test suite never hits the network — `api.mangadex.org`'s edge requires TLS 1.3, which the
Windows 10 schannel stack (used by `HttpClient`) does not provide, so live calls fail on that OS.
Refit tests use a `CapturingHandler` that records the outgoing request and returns canned JSON, so
they assert URL/query/body construction and response parsing without a real call.
