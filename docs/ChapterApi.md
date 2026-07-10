# MangaDex.Api.ChapterApi

All URIs are relative to *https://api.mangadex.org*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DeleteChapterId**](ChapterApi.md#deletechapterid) | **DELETE** /chapter/{id} | Delete Chapter |
| [**GetChapter**](ChapterApi.md#getchapter) | **GET** /chapter | Chapter list |
| [**GetChapterId**](ChapterApi.md#getchapterid) | **GET** /chapter/{id} | Get Chapter |
| [**PutChapterId**](ChapterApi.md#putchapterid) | **PUT** /chapter/{id} | Update Chapter |

<a id="deletechapterid"></a>
# **DeleteChapterId**
> Response DeleteChapterId (Guid id)

Delete Chapter

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaDex.Api;
using MangaDex.Client;
using MangaDex.Model;

namespace Example
{
    public class DeleteChapterIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangadex.org";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ChapterApi(config);
            var id = "id_example";  // Guid | Chapter ID

            try
            {
                // Delete Chapter
                Response result = apiInstance.DeleteChapterId(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChapterApi.DeleteChapterId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteChapterIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete Chapter
    ApiResponse<Response> response = apiInstance.DeleteChapterIdWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ChapterApi.DeleteChapterIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | Chapter ID |  |

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
| **200** | Chapter has been deleted. |  -  |
| **400** | Bad Request |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getchapter"></a>
# **GetChapter**
> ChapterList GetChapter (int? limit = null, int? offset = null, List<Guid> ids = null, string title = null, List<Guid> groups = null, GetChapterUploaderParameter uploader = null, Guid? manga = null, GetChapterVolumeParameter volume = null, GetChapterVolumeParameter chapter = null, List<string> translatedLanguage = null, List<string> originalLanguage = null, List<string> excludedOriginalLanguage = null, List<string> contentRating = null, List<Guid> excludedGroups = null, List<Guid> excludedUploaders = null, string includeFutureUpdates = null, int? includeEmptyPages = null, int? includeFuturePublishAt = null, int? includeExternalUrl = null, string createdAtSince = null, string updatedAtSince = null, string publishAtSince = null, GetChapterOrderParameter order = null, List<string> includes = null)

Chapter list

Chapter list. If you want the Chapters of a given Manga, please check the feed endpoints.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaDex.Api;
using MangaDex.Client;
using MangaDex.Model;

namespace Example
{
    public class GetChapterExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangadex.org";
            var apiInstance = new ChapterApi(config);
            var limit = 10;  // int? |  (optional)  (default to 10)
            var offset = 56;  // int? |  (optional) 
            var ids = new List<Guid>(); // List<Guid> | Chapter ids (limited to 100 per request) (optional) 
            var title = "title_example";  // string |  (optional) 
            var groups = new List<Guid>(); // List<Guid> |  (optional) 
            var uploader = new GetChapterUploaderParameter(); // GetChapterUploaderParameter |  (optional) 
            var manga = "manga_example";  // Guid? |  (optional) 
            var volume = new GetChapterVolumeParameter(); // GetChapterVolumeParameter |  (optional) 
            var chapter = new GetChapterVolumeParameter(); // GetChapterVolumeParameter |  (optional) 
            var translatedLanguage = new List<string>(); // List<string> |  (optional) 
            var originalLanguage = new List<string>(); // List<string> |  (optional) 
            var excludedOriginalLanguage = new List<string>(); // List<string> |  (optional) 
            var contentRating = new List<string>(); // List<string> |  (optional) 
            var excludedGroups = new List<Guid>(); // List<Guid> |  (optional) 
            var excludedUploaders = new List<Guid>(); // List<Guid> |  (optional) 
            var includeFutureUpdates = "0";  // string |  (optional)  (default to 1)
            var includeEmptyPages = 0;  // int? |  (optional) 
            var includeFuturePublishAt = 0;  // int? |  (optional) 
            var includeExternalUrl = 0;  // int? |  (optional) 
            var createdAtSince = "createdAtSince_example";  // string |  (optional) 
            var updatedAtSince = "updatedAtSince_example";  // string |  (optional) 
            var publishAtSince = "publishAtSince_example";  // string |  (optional) 
            var order = new GetChapterOrderParameter(); // GetChapterOrderParameter |  (optional) 
            var includes = new List<string>(); // List<string> |  (optional) 

            try
            {
                // Chapter list
                ChapterList result = apiInstance.GetChapter(limit, offset, ids, title, groups, uploader, manga, volume, chapter, translatedLanguage, originalLanguage, excludedOriginalLanguage, contentRating, excludedGroups, excludedUploaders, includeFutureUpdates, includeEmptyPages, includeFuturePublishAt, includeExternalUrl, createdAtSince, updatedAtSince, publishAtSince, order, includes);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChapterApi.GetChapter: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetChapterWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Chapter list
    ApiResponse<ChapterList> response = apiInstance.GetChapterWithHttpInfo(limit, offset, ids, title, groups, uploader, manga, volume, chapter, translatedLanguage, originalLanguage, excludedOriginalLanguage, contentRating, excludedGroups, excludedUploaders, includeFutureUpdates, includeEmptyPages, includeFuturePublishAt, includeExternalUrl, createdAtSince, updatedAtSince, publishAtSince, order, includes);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ChapterApi.GetChapterWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **limit** | **int?** |  | [optional] [default to 10] |
| **offset** | **int?** |  | [optional]  |
| **ids** | [**List&lt;Guid&gt;**](Guid.md) | Chapter ids (limited to 100 per request) | [optional]  |
| **title** | **string** |  | [optional]  |
| **groups** | [**List&lt;Guid&gt;**](Guid.md) |  | [optional]  |
| **uploader** | [**GetChapterUploaderParameter**](GetChapterUploaderParameter.md) |  | [optional]  |
| **manga** | **Guid?** |  | [optional]  |
| **volume** | [**GetChapterVolumeParameter**](GetChapterVolumeParameter.md) |  | [optional]  |
| **chapter** | [**GetChapterVolumeParameter**](GetChapterVolumeParameter.md) |  | [optional]  |
| **translatedLanguage** | [**List&lt;string&gt;**](string.md) |  | [optional]  |
| **originalLanguage** | [**List&lt;string&gt;**](string.md) |  | [optional]  |
| **excludedOriginalLanguage** | [**List&lt;string&gt;**](string.md) |  | [optional]  |
| **contentRating** | [**List&lt;string&gt;**](string.md) |  | [optional]  |
| **excludedGroups** | [**List&lt;Guid&gt;**](Guid.md) |  | [optional]  |
| **excludedUploaders** | [**List&lt;Guid&gt;**](Guid.md) |  | [optional]  |
| **includeFutureUpdates** | **string** |  | [optional] [default to 1] |
| **includeEmptyPages** | **int?** |  | [optional]  |
| **includeFuturePublishAt** | **int?** |  | [optional]  |
| **includeExternalUrl** | **int?** |  | [optional]  |
| **createdAtSince** | **string** |  | [optional]  |
| **updatedAtSince** | **string** |  | [optional]  |
| **publishAtSince** | **string** |  | [optional]  |
| **order** | [**GetChapterOrderParameter**](GetChapterOrderParameter.md) |  | [optional]  |
| **includes** | [**List&lt;string&gt;**](string.md) |  | [optional]  |

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
| **200** | Chapter list |  -  |
| **400** | Bad Request |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getchapterid"></a>
# **GetChapterId**
> ChapterResponse GetChapterId (Guid id, List<string> includes = null)

Get Chapter

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaDex.Api;
using MangaDex.Client;
using MangaDex.Model;

namespace Example
{
    public class GetChapterIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangadex.org";
            var apiInstance = new ChapterApi(config);
            var id = "id_example";  // Guid | Chapter ID
            var includes = new List<string>(); // List<string> |  (optional) 

            try
            {
                // Get Chapter
                ChapterResponse result = apiInstance.GetChapterId(id, includes);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChapterApi.GetChapterId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetChapterIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Chapter
    ApiResponse<ChapterResponse> response = apiInstance.GetChapterIdWithHttpInfo(id, includes);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ChapterApi.GetChapterIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | Chapter ID |  |
| **includes** | [**List&lt;string&gt;**](string.md) |  | [optional]  |

### Return type

[**ChapterResponse**](ChapterResponse.md)

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
| **404** | Chapter not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="putchapterid"></a>
# **PutChapterId**
> ChapterResponse PutChapterId (Guid id, string contentType, ChapterEdit chapterEdit = null)

Update Chapter

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaDex.Api;
using MangaDex.Client;
using MangaDex.Model;

namespace Example
{
    public class PutChapterIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangadex.org";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ChapterApi(config);
            var id = "id_example";  // Guid | Chapter ID
            var contentType = "\"application/json\"";  // string |  (default to "application/json")
            var chapterEdit = new ChapterEdit(); // ChapterEdit | The size of the body is limited to 32KB. (optional) 

            try
            {
                // Update Chapter
                ChapterResponse result = apiInstance.PutChapterId(id, contentType, chapterEdit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChapterApi.PutChapterId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PutChapterIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update Chapter
    ApiResponse<ChapterResponse> response = apiInstance.PutChapterIdWithHttpInfo(id, contentType, chapterEdit);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ChapterApi.PutChapterIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | Chapter ID |  |
| **contentType** | **string** |  | [default to &quot;application/json&quot;] |
| **chapterEdit** | [**ChapterEdit**](ChapterEdit.md) | The size of the body is limited to 32KB. | [optional]  |

### Return type

[**ChapterResponse**](ChapterResponse.md)

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

