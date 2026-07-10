# MangaDex.Api.CoverApi

All URIs are relative to *https://api.mangadex.org*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DeleteCover**](CoverApi.md#deletecover) | **DELETE** /cover/{mangaOrCoverId} | Delete Cover |
| [**EditCover**](CoverApi.md#editcover) | **PUT** /cover/{mangaOrCoverId} | Edit Cover |
| [**GetCover**](CoverApi.md#getcover) | **GET** /cover | CoverArt list |
| [**GetCoverId**](CoverApi.md#getcoverid) | **GET** /cover/{mangaOrCoverId} | Get Cover |
| [**UploadCover**](CoverApi.md#uploadcover) | **POST** /cover/{mangaOrCoverId} | Upload Cover |

<a id="deletecover"></a>
# **DeleteCover**
> Response DeleteCover (Guid mangaOrCoverId)

Delete Cover

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaDex.Api;
using MangaDex.Client;
using MangaDex.Model;

namespace Example
{
    public class DeleteCoverExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangadex.org";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new CoverApi(config);
            var mangaOrCoverId = "mangaOrCoverId_example";  // Guid | Is Manga UUID on POST

            try
            {
                // Delete Cover
                Response result = apiInstance.DeleteCover(mangaOrCoverId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CoverApi.DeleteCover: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteCoverWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete Cover
    ApiResponse<Response> response = apiInstance.DeleteCoverWithHttpInfo(mangaOrCoverId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CoverApi.DeleteCoverWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **mangaOrCoverId** | **Guid** | Is Manga UUID on POST |  |

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
| **400** | Bad Request |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="editcover"></a>
# **EditCover**
> CoverResponse EditCover (Guid mangaOrCoverId, string contentType, CoverEdit coverEdit = null)

Edit Cover

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaDex.Api;
using MangaDex.Client;
using MangaDex.Model;

namespace Example
{
    public class EditCoverExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangadex.org";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new CoverApi(config);
            var mangaOrCoverId = "mangaOrCoverId_example";  // Guid | Is Manga UUID on POST
            var contentType = "\"application/json\"";  // string |  (default to "application/json")
            var coverEdit = new CoverEdit(); // CoverEdit | The size of the body is limited to 2KB. (optional) 

            try
            {
                // Edit Cover
                CoverResponse result = apiInstance.EditCover(mangaOrCoverId, contentType, coverEdit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CoverApi.EditCover: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EditCoverWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Edit Cover
    ApiResponse<CoverResponse> response = apiInstance.EditCoverWithHttpInfo(mangaOrCoverId, contentType, coverEdit);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CoverApi.EditCoverWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **mangaOrCoverId** | **Guid** | Is Manga UUID on POST |  |
| **contentType** | **string** |  | [default to &quot;application/json&quot;] |
| **coverEdit** | [**CoverEdit**](CoverEdit.md) | The size of the body is limited to 2KB. | [optional]  |

### Return type

[**CoverResponse**](CoverResponse.md)

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getcover"></a>
# **GetCover**
> CoverList GetCover (int? limit = null, int? offset = null, List<Guid> manga = null, List<Guid> ids = null, List<Guid> uploaders = null, List<string> locales = null, GetCoverOrderParameter order = null, List<string> includes = null)

CoverArt list

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaDex.Api;
using MangaDex.Client;
using MangaDex.Model;

namespace Example
{
    public class GetCoverExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangadex.org";
            var apiInstance = new CoverApi(config);
            var limit = 10;  // int? |  (optional)  (default to 10)
            var offset = 56;  // int? |  (optional) 
            var manga = new List<Guid>(); // List<Guid> | Manga ids (limited to 100 per request) (optional) 
            var ids = new List<Guid>(); // List<Guid> | Covers ids (limited to 100 per request) (optional) 
            var uploaders = new List<Guid>(); // List<Guid> | User ids (limited to 100 per request) (optional) 
            var locales = new List<string>(); // List<string> | Locales of cover art (limited to 100 per request) (optional) 
            var order = new GetCoverOrderParameter(); // GetCoverOrderParameter |  (optional) 
            var includes = new List<string>(); // List<string> |  (optional) 

            try
            {
                // CoverArt list
                CoverList result = apiInstance.GetCover(limit, offset, manga, ids, uploaders, locales, order, includes);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CoverApi.GetCover: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetCoverWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // CoverArt list
    ApiResponse<CoverList> response = apiInstance.GetCoverWithHttpInfo(limit, offset, manga, ids, uploaders, locales, order, includes);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CoverApi.GetCoverWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **limit** | **int?** |  | [optional] [default to 10] |
| **offset** | **int?** |  | [optional]  |
| **manga** | [**List&lt;Guid&gt;**](Guid.md) | Manga ids (limited to 100 per request) | [optional]  |
| **ids** | [**List&lt;Guid&gt;**](Guid.md) | Covers ids (limited to 100 per request) | [optional]  |
| **uploaders** | [**List&lt;Guid&gt;**](Guid.md) | User ids (limited to 100 per request) | [optional]  |
| **locales** | [**List&lt;string&gt;**](string.md) | Locales of cover art (limited to 100 per request) | [optional]  |
| **order** | [**GetCoverOrderParameter**](GetCoverOrderParameter.md) |  | [optional]  |
| **includes** | [**List&lt;string&gt;**](string.md) |  | [optional]  |

### Return type

[**CoverList**](CoverList.md)

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
| **403** | Forbidden |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getcoverid"></a>
# **GetCoverId**
> CoverResponse GetCoverId (Guid mangaOrCoverId, List<string> includes = null)

Get Cover

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaDex.Api;
using MangaDex.Client;
using MangaDex.Model;

namespace Example
{
    public class GetCoverIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangadex.org";
            var apiInstance = new CoverApi(config);
            var mangaOrCoverId = "mangaOrCoverId_example";  // Guid | Is Manga UUID on POST
            var includes = new List<string>(); // List<string> |  (optional) 

            try
            {
                // Get Cover
                CoverResponse result = apiInstance.GetCoverId(mangaOrCoverId, includes);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CoverApi.GetCoverId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetCoverIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Cover
    ApiResponse<CoverResponse> response = apiInstance.GetCoverIdWithHttpInfo(mangaOrCoverId, includes);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CoverApi.GetCoverIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **mangaOrCoverId** | **Guid** | Is Manga UUID on POST |  |
| **includes** | [**List&lt;string&gt;**](string.md) |  | [optional]  |

### Return type

[**CoverResponse**](CoverResponse.md)

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
| **403** | Forbidden |  -  |
| **404** | CoverArt not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="uploadcover"></a>
# **UploadCover**
> CoverResponse UploadCover (Guid mangaOrCoverId, string contentType, System.IO.Stream file = null, string volume = null, string description = null, string locale = null)

Upload Cover

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaDex.Api;
using MangaDex.Client;
using MangaDex.Model;

namespace Example
{
    public class UploadCoverExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangadex.org";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new CoverApi(config);
            var mangaOrCoverId = "mangaOrCoverId_example";  // Guid | Is Manga UUID on POST
            var contentType = "\"multipart/form-data\"";  // string |  (default to "multipart/form-data")
            var file = new System.IO.MemoryStream(System.IO.File.ReadAllBytes("/path/to/file.txt"));  // System.IO.Stream |  (optional) 
            var volume = "volume_example";  // string |  (optional) 
            var description = "description_example";  // string |  (optional) 
            var locale = "locale_example";  // string |  (optional) 

            try
            {
                // Upload Cover
                CoverResponse result = apiInstance.UploadCover(mangaOrCoverId, contentType, file, volume, description, locale);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CoverApi.UploadCover: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UploadCoverWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Upload Cover
    ApiResponse<CoverResponse> response = apiInstance.UploadCoverWithHttpInfo(mangaOrCoverId, contentType, file, volume, description, locale);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CoverApi.UploadCoverWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **mangaOrCoverId** | **Guid** | Is Manga UUID on POST |  |
| **contentType** | **string** |  | [default to &quot;multipart/form-data&quot;] |
| **file** | **System.IO.Stream****System.IO.Stream** |  | [optional]  |
| **volume** | **string** |  | [optional]  |
| **description** | **string** |  | [optional]  |
| **locale** | **string** |  | [optional]  |

### Return type

[**CoverResponse**](CoverResponse.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

