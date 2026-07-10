# MangaDex.Api.ReadMarkerApi

All URIs are relative to *https://api.mangadex.org*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetMangaChapterReadmarkers**](ReadMarkerApi.md#getmangachapterreadmarkers) | **GET** /manga/{id}/read | Manga read markers |
| [**GetMangaChapterReadmarkers2**](ReadMarkerApi.md#getmangachapterreadmarkers2) | **GET** /manga/read | Manga read markers |
| [**GetReadingHistory**](ReadMarkerApi.md#getreadinghistory) | **GET** /user/history | Get users reading history |
| [**PostMangaChapterReadmarkers**](ReadMarkerApi.md#postmangachapterreadmarkers) | **POST** /manga/{id}/read | Manga read markers batch |

<a id="getmangachapterreadmarkers"></a>
# **GetMangaChapterReadmarkers**
> GetMangaChapterReadmarkers200Response GetMangaChapterReadmarkers (Guid id)

Manga read markers

A list of chapter ids that are marked as read for the specified manga

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaDex.Api;
using MangaDex.Client;
using MangaDex.Model;

namespace Example
{
    public class GetMangaChapterReadmarkersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangadex.org";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ReadMarkerApi(config);
            var id = "id_example";  // Guid | 

            try
            {
                // Manga read markers
                GetMangaChapterReadmarkers200Response result = apiInstance.GetMangaChapterReadmarkers(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ReadMarkerApi.GetMangaChapterReadmarkers: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetMangaChapterReadmarkersWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Manga read markers
    ApiResponse<GetMangaChapterReadmarkers200Response> response = apiInstance.GetMangaChapterReadmarkersWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ReadMarkerApi.GetMangaChapterReadmarkersWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** |  |  |

### Return type

[**GetMangaChapterReadmarkers200Response**](GetMangaChapterReadmarkers200Response.md)

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

<a id="getmangachapterreadmarkers2"></a>
# **GetMangaChapterReadmarkers2**
> GetMangaChapterReadmarkers2200Response GetMangaChapterReadmarkers2 (List<Guid> ids, bool? grouped = null)

Manga read markers

A list of chapter ids that are marked as read for the given manga ids

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaDex.Api;
using MangaDex.Client;
using MangaDex.Model;

namespace Example
{
    public class GetMangaChapterReadmarkers2Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangadex.org";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ReadMarkerApi(config);
            var ids = new List<Guid>(); // List<Guid> | Manga ids
            var grouped = true;  // bool? | Group results by manga ids (optional) 

            try
            {
                // Manga read markers
                GetMangaChapterReadmarkers2200Response result = apiInstance.GetMangaChapterReadmarkers2(ids, grouped);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ReadMarkerApi.GetMangaChapterReadmarkers2: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetMangaChapterReadmarkers2WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Manga read markers
    ApiResponse<GetMangaChapterReadmarkers2200Response> response = apiInstance.GetMangaChapterReadmarkers2WithHttpInfo(ids, grouped);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ReadMarkerApi.GetMangaChapterReadmarkers2WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **ids** | [**List&lt;Guid&gt;**](Guid.md) | Manga ids |  |
| **grouped** | **bool?** | Group results by manga ids | [optional]  |

### Return type

[**GetMangaChapterReadmarkers2200Response**](GetMangaChapterReadmarkers2200Response.md)

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

<a id="getreadinghistory"></a>
# **GetReadingHistory**
> GetReadingHistory200Response GetReadingHistory ()

Get users reading history

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaDex.Api;
using MangaDex.Client;
using MangaDex.Model;

namespace Example
{
    public class GetReadingHistoryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangadex.org";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ReadMarkerApi(config);

            try
            {
                // Get users reading history
                GetReadingHistory200Response result = apiInstance.GetReadingHistory();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ReadMarkerApi.GetReadingHistory: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetReadingHistoryWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get users reading history
    ApiResponse<GetReadingHistory200Response> response = apiInstance.GetReadingHistoryWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ReadMarkerApi.GetReadingHistoryWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**GetReadingHistory200Response**](GetReadingHistory200Response.md)

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
| **404** | Manga no content |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="postmangachapterreadmarkers"></a>
# **PostMangaChapterReadmarkers**
> FollowListId200Response PostMangaChapterReadmarkers (Guid id, bool? updateHistory = null, ChapterReadMarkerBatch chapterReadMarkerBatch = null)

Manga read markers batch

Send a lot of chapter ids for one manga to mark as read and/or unread

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaDex.Api;
using MangaDex.Client;
using MangaDex.Model;

namespace Example
{
    public class PostMangaChapterReadmarkersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangadex.org";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ReadMarkerApi(config);
            var id = "id_example";  // Guid | 
            var updateHistory = true;  // bool? | Adding this will cause the chapter to be stored in the user's reading history (optional) 
            var chapterReadMarkerBatch = new ChapterReadMarkerBatch(); // ChapterReadMarkerBatch | The size of the body is limited to 10KB. (optional) 

            try
            {
                // Manga read markers batch
                FollowListId200Response result = apiInstance.PostMangaChapterReadmarkers(id, updateHistory, chapterReadMarkerBatch);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ReadMarkerApi.PostMangaChapterReadmarkers: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostMangaChapterReadmarkersWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Manga read markers batch
    ApiResponse<FollowListId200Response> response = apiInstance.PostMangaChapterReadmarkersWithHttpInfo(id, updateHistory, chapterReadMarkerBatch);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ReadMarkerApi.PostMangaChapterReadmarkersWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** |  |  |
| **updateHistory** | **bool?** | Adding this will cause the chapter to be stored in the user&#39;s reading history | [optional]  |
| **chapterReadMarkerBatch** | [**ChapterReadMarkerBatch**](ChapterReadMarkerBatch.md) | The size of the body is limited to 10KB. | [optional]  |

### Return type

[**FollowListId200Response**](FollowListId200Response.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

