# MangaDex.Api.StatisticsApi

All URIs are relative to *https://api.mangadex.org*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetStatisticsChapterUuid**](StatisticsApi.md#getstatisticschapteruuid) | **GET** /statistics/chapter/{uuid} | Get statistics about given chapter |
| [**GetStatisticsChapters**](StatisticsApi.md#getstatisticschapters) | **GET** /statistics/chapter | Get statistics about given chapters |
| [**GetStatisticsGroupUuid**](StatisticsApi.md#getstatisticsgroupuuid) | **GET** /statistics/group/{uuid} | Get statistics about given scanlation group |
| [**GetStatisticsGroups**](StatisticsApi.md#getstatisticsgroups) | **GET** /statistics/group | Get statistics about given groups |
| [**GetStatisticsManga**](StatisticsApi.md#getstatisticsmanga) | **GET** /statistics/manga | Find statistics about given Manga |
| [**GetStatisticsMangaUuid**](StatisticsApi.md#getstatisticsmangauuid) | **GET** /statistics/manga/{uuid} | Get statistics about given Manga |

<a id="getstatisticschapteruuid"></a>
# **GetStatisticsChapterUuid**
> GetStatisticsChapterUuid200Response GetStatisticsChapterUuid (Guid uuid)

Get statistics about given chapter

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaDex.Api;
using MangaDex.Client;
using MangaDex.Model;

namespace Example
{
    public class GetStatisticsChapterUuidExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangadex.org";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new StatisticsApi(config);
            var uuid = "uuid_example";  // Guid | 

            try
            {
                // Get statistics about given chapter
                GetStatisticsChapterUuid200Response result = apiInstance.GetStatisticsChapterUuid(uuid);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StatisticsApi.GetStatisticsChapterUuid: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetStatisticsChapterUuidWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get statistics about given chapter
    ApiResponse<GetStatisticsChapterUuid200Response> response = apiInstance.GetStatisticsChapterUuidWithHttpInfo(uuid);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StatisticsApi.GetStatisticsChapterUuidWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **uuid** | **Guid** |  |  |

### Return type

[**GetStatisticsChapterUuid200Response**](GetStatisticsChapterUuid200Response.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Statistics |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getstatisticschapters"></a>
# **GetStatisticsChapters**
> GetStatisticsChapterUuid200Response GetStatisticsChapters (List<Guid> chapter)

Get statistics about given chapters

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaDex.Api;
using MangaDex.Client;
using MangaDex.Model;

namespace Example
{
    public class GetStatisticsChaptersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangadex.org";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new StatisticsApi(config);
            var chapter = new List<Guid>(); // List<Guid> | 

            try
            {
                // Get statistics about given chapters
                GetStatisticsChapterUuid200Response result = apiInstance.GetStatisticsChapters(chapter);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StatisticsApi.GetStatisticsChapters: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetStatisticsChaptersWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get statistics about given chapters
    ApiResponse<GetStatisticsChapterUuid200Response> response = apiInstance.GetStatisticsChaptersWithHttpInfo(chapter);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StatisticsApi.GetStatisticsChaptersWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **chapter** | [**List&lt;Guid&gt;**](Guid.md) |  |  |

### Return type

[**GetStatisticsChapterUuid200Response**](GetStatisticsChapterUuid200Response.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Statistics |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getstatisticsgroupuuid"></a>
# **GetStatisticsGroupUuid**
> GetStatisticsChapterUuid200Response GetStatisticsGroupUuid (Guid uuid)

Get statistics about given scanlation group

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaDex.Api;
using MangaDex.Client;
using MangaDex.Model;

namespace Example
{
    public class GetStatisticsGroupUuidExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangadex.org";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new StatisticsApi(config);
            var uuid = "uuid_example";  // Guid | 

            try
            {
                // Get statistics about given scanlation group
                GetStatisticsChapterUuid200Response result = apiInstance.GetStatisticsGroupUuid(uuid);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StatisticsApi.GetStatisticsGroupUuid: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetStatisticsGroupUuidWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get statistics about given scanlation group
    ApiResponse<GetStatisticsChapterUuid200Response> response = apiInstance.GetStatisticsGroupUuidWithHttpInfo(uuid);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StatisticsApi.GetStatisticsGroupUuidWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **uuid** | **Guid** |  |  |

### Return type

[**GetStatisticsChapterUuid200Response**](GetStatisticsChapterUuid200Response.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Statistics |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getstatisticsgroups"></a>
# **GetStatisticsGroups**
> GetStatisticsChapterUuid200Response GetStatisticsGroups (List<Guid> group)

Get statistics about given groups

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaDex.Api;
using MangaDex.Client;
using MangaDex.Model;

namespace Example
{
    public class GetStatisticsGroupsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangadex.org";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new StatisticsApi(config);
            var group = new List<Guid>(); // List<Guid> | 

            try
            {
                // Get statistics about given groups
                GetStatisticsChapterUuid200Response result = apiInstance.GetStatisticsGroups(group);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StatisticsApi.GetStatisticsGroups: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetStatisticsGroupsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get statistics about given groups
    ApiResponse<GetStatisticsChapterUuid200Response> response = apiInstance.GetStatisticsGroupsWithHttpInfo(group);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StatisticsApi.GetStatisticsGroupsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **group** | [**List&lt;Guid&gt;**](Guid.md) |  |  |

### Return type

[**GetStatisticsChapterUuid200Response**](GetStatisticsChapterUuid200Response.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Statistics |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getstatisticsmanga"></a>
# **GetStatisticsManga**
> GetStatisticsManga200Response GetStatisticsManga (List<Guid> manga)

Find statistics about given Manga

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaDex.Api;
using MangaDex.Client;
using MangaDex.Model;

namespace Example
{
    public class GetStatisticsMangaExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangadex.org";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new StatisticsApi(config);
            var manga = new List<Guid>(); // List<Guid> | 

            try
            {
                // Find statistics about given Manga
                GetStatisticsManga200Response result = apiInstance.GetStatisticsManga(manga);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StatisticsApi.GetStatisticsManga: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetStatisticsMangaWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Find statistics about given Manga
    ApiResponse<GetStatisticsManga200Response> response = apiInstance.GetStatisticsMangaWithHttpInfo(manga);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StatisticsApi.GetStatisticsMangaWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **manga** | [**List&lt;Guid&gt;**](Guid.md) |  |  |

### Return type

[**GetStatisticsManga200Response**](GetStatisticsManga200Response.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Statistics |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getstatisticsmangauuid"></a>
# **GetStatisticsMangaUuid**
> GetStatisticsMangaUuid200Response GetStatisticsMangaUuid (Guid uuid)

Get statistics about given Manga

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaDex.Api;
using MangaDex.Client;
using MangaDex.Model;

namespace Example
{
    public class GetStatisticsMangaUuidExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangadex.org";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new StatisticsApi(config);
            var uuid = "uuid_example";  // Guid | 

            try
            {
                // Get statistics about given Manga
                GetStatisticsMangaUuid200Response result = apiInstance.GetStatisticsMangaUuid(uuid);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StatisticsApi.GetStatisticsMangaUuid: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetStatisticsMangaUuidWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get statistics about given Manga
    ApiResponse<GetStatisticsMangaUuid200Response> response = apiInstance.GetStatisticsMangaUuidWithHttpInfo(uuid);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StatisticsApi.GetStatisticsMangaUuidWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **uuid** | **Guid** |  |  |

### Return type

[**GetStatisticsMangaUuid200Response**](GetStatisticsMangaUuid200Response.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Statistics |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

