# MangaDex.Api.ForumsApi

All URIs are relative to *https://api.mangadex.org*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ForumsThreadCreate**](ForumsApi.md#forumsthreadcreate) | **POST** /forums/thread | Create forums thread |

<a id="forumsthreadcreate"></a>
# **ForumsThreadCreate**
> ForumsThreadResponse ForumsThreadCreate (ForumsThreadCreateRequest forumsThreadCreateRequest = null)

Create forums thread

Creates a thread in the forums for the given resource, which backs the comments functionality. A thread is only created if it doesn't exist yet; otherwise the preexisting thread is returned. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaDex.Api;
using MangaDex.Client;
using MangaDex.Model;

namespace Example
{
    public class ForumsThreadCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangadex.org";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ForumsApi(config);
            var forumsThreadCreateRequest = new ForumsThreadCreateRequest(); // ForumsThreadCreateRequest |  (optional) 

            try
            {
                // Create forums thread
                ForumsThreadResponse result = apiInstance.ForumsThreadCreate(forumsThreadCreateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ForumsApi.ForumsThreadCreate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ForumsThreadCreateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create forums thread
    ApiResponse<ForumsThreadResponse> response = apiInstance.ForumsThreadCreateWithHttpInfo(forumsThreadCreateRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ForumsApi.ForumsThreadCreateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **forumsThreadCreateRequest** | [**ForumsThreadCreateRequest**](ForumsThreadCreateRequest.md) |  | [optional]  |

### Return type

[**ForumsThreadResponse**](ForumsThreadResponse.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **403** | Forbidden |  -  |
| **404** | If the resource for which the thread creation was requested does not exist |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

