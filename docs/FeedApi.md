# MangaDex.Api.FeedApi

All URIs are relative to *https://api.mangadex.org*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetListIdFeed**](FeedApi.md#getlistidfeed) | **GET** /list/{id}/feed | CustomList Manga feed |
| [**GetUserFollowsMangaFeed**](FeedApi.md#getuserfollowsmangafeed) | **GET** /user/follows/manga/feed | Get logged User followed Manga feed (Chapter list) |

<a id="getlistidfeed"></a>
# **GetListIdFeed**
> ChapterList GetListIdFeed (Guid id, int? limit = null, int? offset = null, List<string> translatedLanguage = null, List<string> originalLanguage = null, List<string> excludedOriginalLanguage = null, List<string> contentRating = null, List<Guid> excludedGroups = null, List<Guid> excludedUploaders = null, string includeFutureUpdates = null, string createdAtSince = null, string updatedAtSince = null, string publishAtSince = null, GetChapterOrderParameter order = null, List<string> includes = null, int? includeEmptyPages = null, int? includeFuturePublishAt = null, int? includeExternalUrl = null)

CustomList Manga feed

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaDex.Api;
using MangaDex.Client;
using MangaDex.Model;

namespace Example
{
    public class GetListIdFeedExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangadex.org";
            var apiInstance = new FeedApi(config);
            var id = "id_example";  // Guid | 
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
                // CustomList Manga feed
                ChapterList result = apiInstance.GetListIdFeed(id, limit, offset, translatedLanguage, originalLanguage, excludedOriginalLanguage, contentRating, excludedGroups, excludedUploaders, includeFutureUpdates, createdAtSince, updatedAtSince, publishAtSince, order, includes, includeEmptyPages, includeFuturePublishAt, includeExternalUrl);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FeedApi.GetListIdFeed: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetListIdFeedWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // CustomList Manga feed
    ApiResponse<ChapterList> response = apiInstance.GetListIdFeedWithHttpInfo(id, limit, offset, translatedLanguage, originalLanguage, excludedOriginalLanguage, contentRating, excludedGroups, excludedUploaders, includeFutureUpdates, createdAtSince, updatedAtSince, publishAtSince, order, includes, includeEmptyPages, includeFuturePublishAt, includeExternalUrl);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FeedApi.GetListIdFeedWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** |  |  |
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
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getuserfollowsmangafeed"></a>
# **GetUserFollowsMangaFeed**
> ChapterList GetUserFollowsMangaFeed (int? limit = null, int? offset = null, List<string> translatedLanguage = null, List<string> originalLanguage = null, List<string> excludedOriginalLanguage = null, List<string> contentRating = null, List<Guid> excludedGroups = null, List<Guid> excludedUploaders = null, string includeFutureUpdates = null, string createdAtSince = null, string updatedAtSince = null, string publishAtSince = null, GetChapterOrderParameter order = null, List<string> includes = null, int? includeEmptyPages = null, int? includeFuturePublishAt = null, int? includeExternalUrl = null)

Get logged User followed Manga feed (Chapter list)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaDex.Api;
using MangaDex.Client;
using MangaDex.Model;

namespace Example
{
    public class GetUserFollowsMangaFeedExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangadex.org";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new FeedApi(config);
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
                // Get logged User followed Manga feed (Chapter list)
                ChapterList result = apiInstance.GetUserFollowsMangaFeed(limit, offset, translatedLanguage, originalLanguage, excludedOriginalLanguage, contentRating, excludedGroups, excludedUploaders, includeFutureUpdates, createdAtSince, updatedAtSince, publishAtSince, order, includes, includeEmptyPages, includeFuturePublishAt, includeExternalUrl);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FeedApi.GetUserFollowsMangaFeed: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetUserFollowsMangaFeedWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get logged User followed Manga feed (Chapter list)
    ApiResponse<ChapterList> response = apiInstance.GetUserFollowsMangaFeedWithHttpInfo(limit, offset, translatedLanguage, originalLanguage, excludedOriginalLanguage, contentRating, excludedGroups, excludedUploaders, includeFutureUpdates, createdAtSince, updatedAtSince, publishAtSince, order, includes, includeEmptyPages, includeFuturePublishAt, includeExternalUrl);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FeedApi.GetUserFollowsMangaFeedWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
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

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |
| **404** | User not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

