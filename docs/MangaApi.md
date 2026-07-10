# MangaDex.Api.MangaApi

All URIs are relative to *https://api.mangadex.org*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CommitMangaDraft**](MangaApi.md#commitmangadraft) | **POST** /manga/draft/{id}/commit | Submit a Manga Draft |
| [**DeleteMangaId**](MangaApi.md#deletemangaid) | **DELETE** /manga/{id} | Delete Manga |
| [**DeleteMangaIdFollow**](MangaApi.md#deletemangaidfollow) | **DELETE** /manga/{id}/follow | Unfollow Manga |
| [**DeleteMangaRelationId**](MangaApi.md#deletemangarelationid) | **DELETE** /manga/{mangaId}/relation/{id} | Delete Manga relation |
| [**GetMangaAggregate**](MangaApi.md#getmangaaggregate) | **GET** /manga/{id}/aggregate | Get Manga volumes &amp; chapters |
| [**GetMangaDrafts**](MangaApi.md#getmangadrafts) | **GET** /manga/draft | Get a list of Manga Drafts |
| [**GetMangaId**](MangaApi.md#getmangaid) | **GET** /manga/{id} | Get Manga |
| [**GetMangaIdDraft**](MangaApi.md#getmangaiddraft) | **GET** /manga/draft/{id} | Get a specific Manga Draft |
| [**GetMangaIdFeed**](MangaApi.md#getmangaidfeed) | **GET** /manga/{id}/feed | Manga feed |
| [**GetMangaIdStatus**](MangaApi.md#getmangaidstatus) | **GET** /manga/{id}/status | Get a Manga reading status |
| [**GetMangaRandom**](MangaApi.md#getmangarandom) | **GET** /manga/random | Get a random Manga |
| [**GetMangaRelation**](MangaApi.md#getmangarelation) | **GET** /manga/{mangaId}/relation | Manga relation list |
| [**GetMangaStatus**](MangaApi.md#getmangastatus) | **GET** /manga/status | Get all Manga reading status for logged User |
| [**GetMangaTag**](MangaApi.md#getmangatag) | **GET** /manga/tag | Tag list |
| [**GetSearchManga**](MangaApi.md#getsearchmanga) | **GET** /manga | Manga list |
| [**PostManga**](MangaApi.md#postmanga) | **POST** /manga | Create Manga |
| [**PostMangaIdFollow**](MangaApi.md#postmangaidfollow) | **POST** /manga/{id}/follow | Follow Manga |
| [**PostMangaIdStatus**](MangaApi.md#postmangaidstatus) | **POST** /manga/{id}/status | Update Manga reading status |
| [**PostMangaRelation**](MangaApi.md#postmangarelation) | **POST** /manga/{mangaId}/relation | Create Manga relation |
| [**PutMangaId**](MangaApi.md#putmangaid) | **PUT** /manga/{id} | Update Manga |

<a id="commitmangadraft"></a>
# **CommitMangaDraft**
> MangaResponse CommitMangaDraft (Guid id, CommitMangaDraftRequest commitMangaDraftRequest = null)

Submit a Manga Draft

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaDex.Api;
using MangaDex.Client;
using MangaDex.Model;

namespace Example
{
    public class CommitMangaDraftExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangadex.org";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new MangaApi(config);
            var id = "id_example";  // Guid | 
            var commitMangaDraftRequest = new CommitMangaDraftRequest(); // CommitMangaDraftRequest | A Manga Draft that is to be submitted must have at least one cover in the original language, must be in the \"draft\" state and must be passed the correct version in the request body. (optional) 

            try
            {
                // Submit a Manga Draft
                MangaResponse result = apiInstance.CommitMangaDraft(id, commitMangaDraftRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MangaApi.CommitMangaDraft: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CommitMangaDraftWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Submit a Manga Draft
    ApiResponse<MangaResponse> response = apiInstance.CommitMangaDraftWithHttpInfo(id, commitMangaDraftRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MangaApi.CommitMangaDraftWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** |  |  |
| **commitMangaDraftRequest** | [**CommitMangaDraftRequest**](CommitMangaDraftRequest.md) | A Manga Draft that is to be submitted must have at least one cover in the original language, must be in the \&quot;draft\&quot; state and must be passed the correct version in the request body. | [optional]  |

### Return type

[**MangaResponse**](MangaResponse.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | OK |  -  |
| **400** | BadRequest |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deletemangaid"></a>
# **DeleteMangaId**
> Response DeleteMangaId (Guid id)

Delete Manga

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaDex.Api;
using MangaDex.Client;
using MangaDex.Model;

namespace Example
{
    public class DeleteMangaIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangadex.org";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new MangaApi(config);
            var id = "id_example";  // Guid | Manga ID

            try
            {
                // Delete Manga
                Response result = apiInstance.DeleteMangaId(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MangaApi.DeleteMangaId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteMangaIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete Manga
    ApiResponse<Response> response = apiInstance.DeleteMangaIdWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MangaApi.DeleteMangaIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | Manga ID |  |

### Return type

[**Response**](Response.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Manga has been deleted. |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deletemangaidfollow"></a>
# **DeleteMangaIdFollow**
> Response DeleteMangaIdFollow (Guid id)

Unfollow Manga

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaDex.Api;
using MangaDex.Client;
using MangaDex.Model;

namespace Example
{
    public class DeleteMangaIdFollowExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangadex.org";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new MangaApi(config);
            var id = "id_example";  // Guid | 

            try
            {
                // Unfollow Manga
                Response result = apiInstance.DeleteMangaIdFollow(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MangaApi.DeleteMangaIdFollow: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteMangaIdFollowWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Unfollow Manga
    ApiResponse<Response> response = apiInstance.DeleteMangaIdFollowWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MangaApi.DeleteMangaIdFollowWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** |  |  |

### Return type

[**Response**](Response.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deletemangarelationid"></a>
# **DeleteMangaRelationId**
> Response DeleteMangaRelationId (Guid mangaId, Guid id)

Delete Manga relation

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaDex.Api;
using MangaDex.Client;
using MangaDex.Model;

namespace Example
{
    public class DeleteMangaRelationIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangadex.org";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new MangaApi(config);
            var mangaId = "mangaId_example";  // Guid | 
            var id = "id_example";  // Guid | 

            try
            {
                // Delete Manga relation
                Response result = apiInstance.DeleteMangaRelationId(mangaId, id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MangaApi.DeleteMangaRelationId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteMangaRelationIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete Manga relation
    ApiResponse<Response> response = apiInstance.DeleteMangaRelationIdWithHttpInfo(mangaId, id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MangaApi.DeleteMangaRelationIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **mangaId** | **Guid** |  |  |
| **id** | **Guid** |  |  |

### Return type

[**Response**](Response.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Manga relation has been deleted. |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getmangaaggregate"></a>
# **GetMangaAggregate**
> GetMangaAggregate200Response GetMangaAggregate (Guid id, List<string> translatedLanguage = null, List<Guid> groups = null)

Get Manga volumes & chapters

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaDex.Api;
using MangaDex.Client;
using MangaDex.Model;

namespace Example
{
    public class GetMangaAggregateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangadex.org";
            var apiInstance = new MangaApi(config);
            var id = "id_example";  // Guid | Manga ID
            var translatedLanguage = new List<string>(); // List<string> |  (optional) 
            var groups = new List<Guid>(); // List<Guid> |  (optional) 

            try
            {
                // Get Manga volumes & chapters
                GetMangaAggregate200Response result = apiInstance.GetMangaAggregate(id, translatedLanguage, groups);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MangaApi.GetMangaAggregate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetMangaAggregateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Manga volumes & chapters
    ApiResponse<GetMangaAggregate200Response> response = apiInstance.GetMangaAggregateWithHttpInfo(id, translatedLanguage, groups);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MangaApi.GetMangaAggregateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | Manga ID |  |
| **translatedLanguage** | [**List&lt;string&gt;**](string.md) |  | [optional]  |
| **groups** | [**List&lt;Guid&gt;**](Guid.md) |  | [optional]  |

### Return type

[**GetMangaAggregate200Response**](GetMangaAggregate200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getmangadrafts"></a>
# **GetMangaDrafts**
> MangaResponse GetMangaDrafts (int? limit = null, int? offset = null, string state = null, GetMangaDraftsOrderParameter order = null, List<string> includes = null)

Get a list of Manga Drafts

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaDex.Api;
using MangaDex.Client;
using MangaDex.Model;

namespace Example
{
    public class GetMangaDraftsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangadex.org";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new MangaApi(config);
            var limit = 10;  // int? |  (optional)  (default to 10)
            var offset = 56;  // int? |  (optional) 
            var state = "draft";  // string |  (optional) 
            var order = new GetMangaDraftsOrderParameter(); // GetMangaDraftsOrderParameter |  (optional) 
            var includes = new List<string>(); // List<string> |  (optional) 

            try
            {
                // Get a list of Manga Drafts
                MangaResponse result = apiInstance.GetMangaDrafts(limit, offset, state, order, includes);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MangaApi.GetMangaDrafts: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetMangaDraftsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get a list of Manga Drafts
    ApiResponse<MangaResponse> response = apiInstance.GetMangaDraftsWithHttpInfo(limit, offset, state, order, includes);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MangaApi.GetMangaDraftsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **limit** | **int?** |  | [optional] [default to 10] |
| **offset** | **int?** |  | [optional]  |
| **state** | **string** |  | [optional]  |
| **order** | [**GetMangaDraftsOrderParameter**](GetMangaDraftsOrderParameter.md) |  | [optional]  |
| **includes** | [**List&lt;string&gt;**](string.md) |  | [optional]  |

### Return type

[**MangaResponse**](MangaResponse.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getmangaid"></a>
# **GetMangaId**
> MangaResponse GetMangaId (Guid id, List<string> includes = null)

Get Manga

Get Manga.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaDex.Api;
using MangaDex.Client;
using MangaDex.Model;

namespace Example
{
    public class GetMangaIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangadex.org";
            var apiInstance = new MangaApi(config);
            var id = "id_example";  // Guid | Manga ID
            var includes = new List<string>(); // List<string> |  (optional) 

            try
            {
                // Get Manga
                MangaResponse result = apiInstance.GetMangaId(id, includes);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MangaApi.GetMangaId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetMangaIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Manga
    ApiResponse<MangaResponse> response = apiInstance.GetMangaIdWithHttpInfo(id, includes);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MangaApi.GetMangaIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | Manga ID |  |
| **includes** | [**List&lt;string&gt;**](string.md) |  | [optional]  |

### Return type

[**MangaResponse**](MangaResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **403** | Forbidden |  -  |
| **404** | Manga no content |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getmangaiddraft"></a>
# **GetMangaIdDraft**
> MangaResponse GetMangaIdDraft (Guid id, List<string> includes = null)

Get a specific Manga Draft

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaDex.Api;
using MangaDex.Client;
using MangaDex.Model;

namespace Example
{
    public class GetMangaIdDraftExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangadex.org";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new MangaApi(config);
            var id = "id_example";  // Guid | 
            var includes = new List<string>(); // List<string> |  (optional) 

            try
            {
                // Get a specific Manga Draft
                MangaResponse result = apiInstance.GetMangaIdDraft(id, includes);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MangaApi.GetMangaIdDraft: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetMangaIdDraftWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get a specific Manga Draft
    ApiResponse<MangaResponse> response = apiInstance.GetMangaIdDraftWithHttpInfo(id, includes);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MangaApi.GetMangaIdDraftWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** |  |  |
| **includes** | [**List&lt;string&gt;**](string.md) |  | [optional]  |

### Return type

[**MangaResponse**](MangaResponse.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getmangaidfeed"></a>
# **GetMangaIdFeed**
> ChapterList GetMangaIdFeed (Guid id, int? limit = null, int? offset = null, List<string> translatedLanguage = null, List<string> originalLanguage = null, List<string> excludedOriginalLanguage = null, List<string> contentRating = null, List<Guid> excludedGroups = null, List<Guid> excludedUploaders = null, string includeFutureUpdates = null, string createdAtSince = null, string updatedAtSince = null, string publishAtSince = null, GetChapterOrderParameter order = null, List<string> includes = null, int? includeEmptyPages = null, int? includeFuturePublishAt = null, int? includeExternalUrl = null)

Manga feed

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaDex.Api;
using MangaDex.Client;
using MangaDex.Model;

namespace Example
{
    public class GetMangaIdFeedExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangadex.org";
            var apiInstance = new MangaApi(config);
            var id = "id_example";  // Guid | Manga ID
            var limit = 100;  // int? |  (optional)  (default to 100)
            var offset = 56;  // int? |  (optional) 
            var translatedLanguage = new List<string>(); // List<string> |  (optional) 
            var originalLanguage = new List<string>(); // List<string> |  (optional) 
            var excludedOriginalLanguage = new List<string>(); // List<string> |  (optional) 
            var contentRating = new List<string>(); // List<string> |  (optional) 
            var excludedGroups = new List<Guid>(); // List<Guid> |  (optional) 
            var excludedUploaders = new List<Guid>(); // List<Guid> |  (optional) 
            var includeFutureUpdates = "0";  // string |  (optional)  (default to 1)
            var createdAtSince = "createdAtSince_example";  // string |  (optional) 
            var updatedAtSince = "updatedAtSince_example";  // string |  (optional) 
            var publishAtSince = "publishAtSince_example";  // string |  (optional) 
            var order = new GetChapterOrderParameter(); // GetChapterOrderParameter |  (optional) 
            var includes = new List<string>(); // List<string> |  (optional) 
            var includeEmptyPages = 0;  // int? |  (optional) 
            var includeFuturePublishAt = 0;  // int? |  (optional) 
            var includeExternalUrl = 0;  // int? |  (optional) 

            try
            {
                // Manga feed
                ChapterList result = apiInstance.GetMangaIdFeed(id, limit, offset, translatedLanguage, originalLanguage, excludedOriginalLanguage, contentRating, excludedGroups, excludedUploaders, includeFutureUpdates, createdAtSince, updatedAtSince, publishAtSince, order, includes, includeEmptyPages, includeFuturePublishAt, includeExternalUrl);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MangaApi.GetMangaIdFeed: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetMangaIdFeedWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Manga feed
    ApiResponse<ChapterList> response = apiInstance.GetMangaIdFeedWithHttpInfo(id, limit, offset, translatedLanguage, originalLanguage, excludedOriginalLanguage, contentRating, excludedGroups, excludedUploaders, includeFutureUpdates, createdAtSince, updatedAtSince, publishAtSince, order, includes, includeEmptyPages, includeFuturePublishAt, includeExternalUrl);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MangaApi.GetMangaIdFeedWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | Manga ID |  |
| **limit** | **int?** |  | [optional] [default to 100] |
| **offset** | **int?** |  | [optional]  |
| **translatedLanguage** | [**List&lt;string&gt;**](string.md) |  | [optional]  |
| **originalLanguage** | [**List&lt;string&gt;**](string.md) |  | [optional]  |
| **excludedOriginalLanguage** | [**List&lt;string&gt;**](string.md) |  | [optional]  |
| **contentRating** | [**List&lt;string&gt;**](string.md) |  | [optional]  |
| **excludedGroups** | [**List&lt;Guid&gt;**](Guid.md) |  | [optional]  |
| **excludedUploaders** | [**List&lt;Guid&gt;**](Guid.md) |  | [optional]  |
| **includeFutureUpdates** | **string** |  | [optional] [default to 1] |
| **createdAtSince** | **string** |  | [optional]  |
| **updatedAtSince** | **string** |  | [optional]  |
| **publishAtSince** | **string** |  | [optional]  |
| **order** | [**GetChapterOrderParameter**](GetChapterOrderParameter.md) |  | [optional]  |
| **includes** | [**List&lt;string&gt;**](string.md) |  | [optional]  |
| **includeEmptyPages** | **int?** |  | [optional]  |
| **includeFuturePublishAt** | **int?** |  | [optional]  |
| **includeExternalUrl** | **int?** |  | [optional]  |

### Return type

[**ChapterList**](ChapterList.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getmangaidstatus"></a>
# **GetMangaIdStatus**
> GetMangaIdStatus200Response GetMangaIdStatus (Guid id)

Get a Manga reading status

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaDex.Api;
using MangaDex.Client;
using MangaDex.Model;

namespace Example
{
    public class GetMangaIdStatusExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangadex.org";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new MangaApi(config);
            var id = "id_example";  // Guid | 

            try
            {
                // Get a Manga reading status
                GetMangaIdStatus200Response result = apiInstance.GetMangaIdStatus(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MangaApi.GetMangaIdStatus: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetMangaIdStatusWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get a Manga reading status
    ApiResponse<GetMangaIdStatus200Response> response = apiInstance.GetMangaIdStatusWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MangaApi.GetMangaIdStatusWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** |  |  |

### Return type

[**GetMangaIdStatus200Response**](GetMangaIdStatus200Response.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getmangarandom"></a>
# **GetMangaRandom**
> MangaResponse GetMangaRandom (List<string> includes = null, List<string> contentRating = null, List<Guid> includedTags = null, string includedTagsMode = null, List<Guid> excludedTags = null, string excludedTagsMode = null)

Get a random Manga

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaDex.Api;
using MangaDex.Client;
using MangaDex.Model;

namespace Example
{
    public class GetMangaRandomExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangadex.org";
            var apiInstance = new MangaApi(config);
            var includes = new List<string>(); // List<string> |  (optional) 
            var contentRating = new List<string>(); // List<string> |  (optional) 
            var includedTags = new List<Guid>(); // List<Guid> |  (optional) 
            var includedTagsMode = "AND";  // string |  (optional)  (default to AND)
            var excludedTags = new List<Guid>(); // List<Guid> |  (optional) 
            var excludedTagsMode = "AND";  // string |  (optional)  (default to OR)

            try
            {
                // Get a random Manga
                MangaResponse result = apiInstance.GetMangaRandom(includes, contentRating, includedTags, includedTagsMode, excludedTags, excludedTagsMode);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MangaApi.GetMangaRandom: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetMangaRandomWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get a random Manga
    ApiResponse<MangaResponse> response = apiInstance.GetMangaRandomWithHttpInfo(includes, contentRating, includedTags, includedTagsMode, excludedTags, excludedTagsMode);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MangaApi.GetMangaRandomWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **includes** | [**List&lt;string&gt;**](string.md) |  | [optional]  |
| **contentRating** | [**List&lt;string&gt;**](string.md) |  | [optional]  |
| **includedTags** | [**List&lt;Guid&gt;**](Guid.md) |  | [optional]  |
| **includedTagsMode** | **string** |  | [optional] [default to AND] |
| **excludedTags** | [**List&lt;Guid&gt;**](Guid.md) |  | [optional]  |
| **excludedTagsMode** | **string** |  | [optional] [default to OR] |

### Return type

[**MangaResponse**](MangaResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getmangarelation"></a>
# **GetMangaRelation**
> MangaRelationList GetMangaRelation (Guid mangaId, List<string> includes = null)

Manga relation list

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaDex.Api;
using MangaDex.Client;
using MangaDex.Model;

namespace Example
{
    public class GetMangaRelationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangadex.org";
            var apiInstance = new MangaApi(config);
            var mangaId = "mangaId_example";  // Guid | 
            var includes = new List<string>(); // List<string> |  (optional) 

            try
            {
                // Manga relation list
                MangaRelationList result = apiInstance.GetMangaRelation(mangaId, includes);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MangaApi.GetMangaRelation: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetMangaRelationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Manga relation list
    ApiResponse<MangaRelationList> response = apiInstance.GetMangaRelationWithHttpInfo(mangaId, includes);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MangaApi.GetMangaRelationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **mangaId** | **Guid** |  |  |
| **includes** | [**List&lt;string&gt;**](string.md) |  | [optional]  |

### Return type

[**MangaRelationList**](MangaRelationList.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Manga relation list |  -  |
| **400** | Bad Request |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getmangastatus"></a>
# **GetMangaStatus**
> GetMangaStatus200Response GetMangaStatus (string status = null)

Get all Manga reading status for logged User

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaDex.Api;
using MangaDex.Client;
using MangaDex.Model;

namespace Example
{
    public class GetMangaStatusExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangadex.org";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new MangaApi(config);
            var status = "reading";  // string | Used to filter the list by given status (optional) 

            try
            {
                // Get all Manga reading status for logged User
                GetMangaStatus200Response result = apiInstance.GetMangaStatus(status);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MangaApi.GetMangaStatus: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetMangaStatusWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get all Manga reading status for logged User
    ApiResponse<GetMangaStatus200Response> response = apiInstance.GetMangaStatusWithHttpInfo(status);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MangaApi.GetMangaStatusWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **status** | **string** | Used to filter the list by given status | [optional]  |

### Return type

[**GetMangaStatus200Response**](GetMangaStatus200Response.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getmangatag"></a>
# **GetMangaTag**
> TagResponse GetMangaTag ()

Tag list

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaDex.Api;
using MangaDex.Client;
using MangaDex.Model;

namespace Example
{
    public class GetMangaTagExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangadex.org";
            var apiInstance = new MangaApi(config);

            try
            {
                // Tag list
                TagResponse result = apiInstance.GetMangaTag();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MangaApi.GetMangaTag: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetMangaTagWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Tag list
    ApiResponse<TagResponse> response = apiInstance.GetMangaTagWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MangaApi.GetMangaTagWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**TagResponse**](TagResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getsearchmanga"></a>
# **GetSearchManga**
> MangaList GetSearchManga (int? limit = null, int? offset = null, string title = null, Guid? authorOrArtist = null, List<Guid> authors = null, List<Guid> artists = null, GetSearchMangaYearParameter year = null, List<Guid> includedTags = null, string includedTagsMode = null, List<Guid> excludedTags = null, string excludedTagsMode = null, List<string> status = null, List<string> originalLanguage = null, List<string> excludedOriginalLanguage = null, List<string> availableTranslatedLanguage = null, List<string> publicationDemographic = null, List<Guid> ids = null, List<string> contentRating = null, string createdAtSince = null, string updatedAtSince = null, GetSearchMangaOrderParameter order = null, List<string> includes = null, string hasAvailableChapters = null, Guid? group = null)

Manga list

Search a list of Manga.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaDex.Api;
using MangaDex.Client;
using MangaDex.Model;

namespace Example
{
    public class GetSearchMangaExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangadex.org";
            var apiInstance = new MangaApi(config);
            var limit = 10;  // int? |  (optional)  (default to 10)
            var offset = 56;  // int? |  (optional) 
            var title = "title_example";  // string |  (optional) 
            var authorOrArtist = "authorOrArtist_example";  // Guid? |  (optional) 
            var authors = new List<Guid>(); // List<Guid> |  (optional) 
            var artists = new List<Guid>(); // List<Guid> |  (optional) 
            var year = new GetSearchMangaYearParameter(); // GetSearchMangaYearParameter | Year of release or none (optional) 
            var includedTags = new List<Guid>(); // List<Guid> |  (optional) 
            var includedTagsMode = "AND";  // string |  (optional)  (default to AND)
            var excludedTags = new List<Guid>(); // List<Guid> |  (optional) 
            var excludedTagsMode = "AND";  // string |  (optional)  (default to OR)
            var status = new List<string>(); // List<string> |  (optional) 
            var originalLanguage = new List<string>(); // List<string> |  (optional) 
            var excludedOriginalLanguage = new List<string>(); // List<string> |  (optional) 
            var availableTranslatedLanguage = new List<string>(); // List<string> |  (optional) 
            var publicationDemographic = new List<string>(); // List<string> |  (optional) 
            var ids = new List<Guid>(); // List<Guid> | Manga ids (limited to 100 per request) (optional) 
            var contentRating = new List<string>(); // List<string> |  (optional) 
            var createdAtSince = "createdAtSince_example";  // string |  (optional) 
            var updatedAtSince = "updatedAtSince_example";  // string |  (optional) 
            var order = new GetSearchMangaOrderParameter(); // GetSearchMangaOrderParameter |  (optional) 
            var includes = new List<string>(); // List<string> |  (optional) 
            var hasAvailableChapters = "0";  // string |  (optional) 
            var group = "group_example";  // Guid? |  (optional) 

            try
            {
                // Manga list
                MangaList result = apiInstance.GetSearchManga(limit, offset, title, authorOrArtist, authors, artists, year, includedTags, includedTagsMode, excludedTags, excludedTagsMode, status, originalLanguage, excludedOriginalLanguage, availableTranslatedLanguage, publicationDemographic, ids, contentRating, createdAtSince, updatedAtSince, order, includes, hasAvailableChapters, group);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MangaApi.GetSearchManga: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetSearchMangaWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Manga list
    ApiResponse<MangaList> response = apiInstance.GetSearchMangaWithHttpInfo(limit, offset, title, authorOrArtist, authors, artists, year, includedTags, includedTagsMode, excludedTags, excludedTagsMode, status, originalLanguage, excludedOriginalLanguage, availableTranslatedLanguage, publicationDemographic, ids, contentRating, createdAtSince, updatedAtSince, order, includes, hasAvailableChapters, group);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MangaApi.GetSearchMangaWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **limit** | **int?** |  | [optional] [default to 10] |
| **offset** | **int?** |  | [optional]  |
| **title** | **string** |  | [optional]  |
| **authorOrArtist** | **Guid?** |  | [optional]  |
| **authors** | [**List&lt;Guid&gt;**](Guid.md) |  | [optional]  |
| **artists** | [**List&lt;Guid&gt;**](Guid.md) |  | [optional]  |
| **year** | [**GetSearchMangaYearParameter**](GetSearchMangaYearParameter.md) | Year of release or none | [optional]  |
| **includedTags** | [**List&lt;Guid&gt;**](Guid.md) |  | [optional]  |
| **includedTagsMode** | **string** |  | [optional] [default to AND] |
| **excludedTags** | [**List&lt;Guid&gt;**](Guid.md) |  | [optional]  |
| **excludedTagsMode** | **string** |  | [optional] [default to OR] |
| **status** | [**List&lt;string&gt;**](string.md) |  | [optional]  |
| **originalLanguage** | [**List&lt;string&gt;**](string.md) |  | [optional]  |
| **excludedOriginalLanguage** | [**List&lt;string&gt;**](string.md) |  | [optional]  |
| **availableTranslatedLanguage** | [**List&lt;string&gt;**](string.md) |  | [optional]  |
| **publicationDemographic** | [**List&lt;string&gt;**](string.md) |  | [optional]  |
| **ids** | [**List&lt;Guid&gt;**](Guid.md) | Manga ids (limited to 100 per request) | [optional]  |
| **contentRating** | [**List&lt;string&gt;**](string.md) |  | [optional]  |
| **createdAtSince** | **string** |  | [optional]  |
| **updatedAtSince** | **string** |  | [optional]  |
| **order** | [**GetSearchMangaOrderParameter**](GetSearchMangaOrderParameter.md) |  | [optional]  |
| **includes** | [**List&lt;string&gt;**](string.md) |  | [optional]  |
| **hasAvailableChapters** | **string** |  | [optional]  |
| **group** | **Guid?** |  | [optional]  |

### Return type

[**MangaList**](MangaList.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Manga list |  -  |
| **400** | Bad Request |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="postmanga"></a>
# **PostManga**
> MangaResponse PostManga (string contentType, MangaCreate mangaCreate = null)

Create Manga

Create a new Manga.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaDex.Api;
using MangaDex.Client;
using MangaDex.Model;

namespace Example
{
    public class PostMangaExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangadex.org";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new MangaApi(config);
            var contentType = "\"application/json\"";  // string |  (default to "application/json")
            var mangaCreate = new MangaCreate(); // MangaCreate | The size of the body is limited to 64KB. (optional) 

            try
            {
                // Create Manga
                MangaResponse result = apiInstance.PostManga(contentType, mangaCreate);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MangaApi.PostManga: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostMangaWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create Manga
    ApiResponse<MangaResponse> response = apiInstance.PostMangaWithHttpInfo(contentType, mangaCreate);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MangaApi.PostMangaWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **contentType** | **string** |  | [default to &quot;application/json&quot;] |
| **mangaCreate** | [**MangaCreate**](MangaCreate.md) | The size of the body is limited to 64KB. | [optional]  |

### Return type

[**MangaResponse**](MangaResponse.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Manga Created |  -  |
| **400** | Bad Request |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="postmangaidfollow"></a>
# **PostMangaIdFollow**
> Response PostMangaIdFollow (Guid id)

Follow Manga

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaDex.Api;
using MangaDex.Client;
using MangaDex.Model;

namespace Example
{
    public class PostMangaIdFollowExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangadex.org";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new MangaApi(config);
            var id = "id_example";  // Guid | 

            try
            {
                // Follow Manga
                Response result = apiInstance.PostMangaIdFollow(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MangaApi.PostMangaIdFollow: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostMangaIdFollowWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Follow Manga
    ApiResponse<Response> response = apiInstance.PostMangaIdFollowWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MangaApi.PostMangaIdFollowWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** |  |  |

### Return type

[**Response**](Response.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="postmangaidstatus"></a>
# **PostMangaIdStatus**
> Response PostMangaIdStatus (Guid id, string contentType, UpdateMangaStatus updateMangaStatus = null)

Update Manga reading status

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaDex.Api;
using MangaDex.Client;
using MangaDex.Model;

namespace Example
{
    public class PostMangaIdStatusExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangadex.org";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new MangaApi(config);
            var id = "id_example";  // Guid | 
            var contentType = "\"application/json\"";  // string |  (default to "application/json")
            var updateMangaStatus = new UpdateMangaStatus(); // UpdateMangaStatus | Using a `null` value in `status` field will remove the Manga reading status. The size of the body is limited to 2KB. (optional) 

            try
            {
                // Update Manga reading status
                Response result = apiInstance.PostMangaIdStatus(id, contentType, updateMangaStatus);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MangaApi.PostMangaIdStatus: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostMangaIdStatusWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update Manga reading status
    ApiResponse<Response> response = apiInstance.PostMangaIdStatusWithHttpInfo(id, contentType, updateMangaStatus);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MangaApi.PostMangaIdStatusWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** |  |  |
| **contentType** | **string** |  | [default to &quot;application/json&quot;] |
| **updateMangaStatus** | [**UpdateMangaStatus**](UpdateMangaStatus.md) | Using a &#x60;null&#x60; value in &#x60;status&#x60; field will remove the Manga reading status. The size of the body is limited to 2KB. | [optional]  |

### Return type

[**Response**](Response.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="postmangarelation"></a>
# **PostMangaRelation**
> MangaRelationResponse PostMangaRelation (Guid mangaId, string contentType, MangaRelationCreate mangaRelationCreate = null)

Create Manga relation

Create a new Manga relation.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaDex.Api;
using MangaDex.Client;
using MangaDex.Model;

namespace Example
{
    public class PostMangaRelationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangadex.org";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new MangaApi(config);
            var mangaId = "mangaId_example";  // Guid | 
            var contentType = "\"application/json\"";  // string |  (default to "application/json")
            var mangaRelationCreate = new MangaRelationCreate(); // MangaRelationCreate | The size of the body is limited to 8KB. (optional) 

            try
            {
                // Create Manga relation
                MangaRelationResponse result = apiInstance.PostMangaRelation(mangaId, contentType, mangaRelationCreate);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MangaApi.PostMangaRelation: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostMangaRelationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create Manga relation
    ApiResponse<MangaRelationResponse> response = apiInstance.PostMangaRelationWithHttpInfo(mangaId, contentType, mangaRelationCreate);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MangaApi.PostMangaRelationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **mangaId** | **Guid** |  |  |
| **contentType** | **string** |  | [default to &quot;application/json&quot;] |
| **mangaRelationCreate** | [**MangaRelationCreate**](MangaRelationCreate.md) | The size of the body is limited to 8KB. | [optional]  |

### Return type

[**MangaRelationResponse**](MangaRelationResponse.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Manga relation created |  -  |
| **400** | Bad Request |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="putmangaid"></a>
# **PutMangaId**
> MangaResponse PutMangaId (Guid id, string contentType, PutMangaIdRequest putMangaIdRequest = null)

Update Manga

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaDex.Api;
using MangaDex.Client;
using MangaDex.Model;

namespace Example
{
    public class PutMangaIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangadex.org";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new MangaApi(config);
            var id = "id_example";  // Guid | Manga ID
            var contentType = "\"application/json\"";  // string |  (default to "application/json")
            var putMangaIdRequest = new PutMangaIdRequest(); // PutMangaIdRequest | The size of the body is limited to 64KB. (optional) 

            try
            {
                // Update Manga
                MangaResponse result = apiInstance.PutMangaId(id, contentType, putMangaIdRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MangaApi.PutMangaId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PutMangaIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update Manga
    ApiResponse<MangaResponse> response = apiInstance.PutMangaIdWithHttpInfo(id, contentType, putMangaIdRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MangaApi.PutMangaIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | Manga ID |  |
| **contentType** | **string** |  | [default to &quot;application/json&quot;] |
| **putMangaIdRequest** | [**PutMangaIdRequest**](PutMangaIdRequest.md) | The size of the body is limited to 64KB. | [optional]  |

### Return type

[**MangaResponse**](MangaResponse.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

