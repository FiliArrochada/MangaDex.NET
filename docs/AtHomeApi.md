# MangaDex.Api.AtHomeApi

All URIs are relative to *https://api.mangadex.org*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetAtHomeServerChapterId**](AtHomeApi.md#getathomeserverchapterid) | **GET** /at-home/server/{chapterId} | Get MangaDex@Home server URL |

<a id="getathomeserverchapterid"></a>
# **GetAtHomeServerChapterId**
> GetAtHomeServerChapterId200Response GetAtHomeServerChapterId (Guid chapterId, bool? forcePort443 = null)

Get MangaDex@Home server URL

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaDex.Api;
using MangaDex.Client;
using MangaDex.Model;

namespace Example
{
    public class GetAtHomeServerChapterIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangadex.org";
            var apiInstance = new AtHomeApi(config);
            var chapterId = "chapterId_example";  // Guid | Chapter ID
            var forcePort443 = false;  // bool? | Force selecting from MangaDex@Home servers that use the standard HTTPS port 443.  While the conventional port for HTTPS traffic is 443 and servers are encouraged to use it, it is not a hard requirement as it technically isn't anything special.  However, some misbehaving school/office network will at time block traffic to non-standard ports, and setting this flag to `true` will ensure selection of a server that uses these. (optional)  (default to false)

            try
            {
                // Get MangaDex@Home server URL
                GetAtHomeServerChapterId200Response result = apiInstance.GetAtHomeServerChapterId(chapterId, forcePort443);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AtHomeApi.GetAtHomeServerChapterId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAtHomeServerChapterIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get MangaDex@Home server URL
    ApiResponse<GetAtHomeServerChapterId200Response> response = apiInstance.GetAtHomeServerChapterIdWithHttpInfo(chapterId, forcePort443);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AtHomeApi.GetAtHomeServerChapterIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **chapterId** | **Guid** | Chapter ID |  |
| **forcePort443** | **bool?** | Force selecting from MangaDex@Home servers that use the standard HTTPS port 443.  While the conventional port for HTTPS traffic is 443 and servers are encouraged to use it, it is not a hard requirement as it technically isn&#39;t anything special.  However, some misbehaving school/office network will at time block traffic to non-standard ports, and setting this flag to &#x60;true&#x60; will ensure selection of a server that uses these. | [optional] [default to false] |

### Return type

[**GetAtHomeServerChapterId200Response**](GetAtHomeServerChapterId200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

