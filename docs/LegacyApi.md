# MangaDex.Api.LegacyApi

All URIs are relative to *https://api.mangadex.org*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**PostLegacyMapping**](LegacyApi.md#postlegacymapping) | **POST** /legacy/mapping | Legacy ID mapping |

<a id="postlegacymapping"></a>
# **PostLegacyMapping**
> MappingIdResponse PostLegacyMapping (string contentType, MappingIdBody mappingIdBody = null)

Legacy ID mapping

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaDex.Api;
using MangaDex.Client;
using MangaDex.Model;

namespace Example
{
    public class PostLegacyMappingExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangadex.org";
            var apiInstance = new LegacyApi(config);
            var contentType = "\"application/json\"";  // string |  (default to "application/json")
            var mappingIdBody = new MappingIdBody(); // MappingIdBody | The size of the body is limited to 10KB. (optional) 

            try
            {
                // Legacy ID mapping
                MappingIdResponse result = apiInstance.PostLegacyMapping(contentType, mappingIdBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LegacyApi.PostLegacyMapping: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostLegacyMappingWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Legacy ID mapping
    ApiResponse<MappingIdResponse> response = apiInstance.PostLegacyMappingWithHttpInfo(contentType, mappingIdBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LegacyApi.PostLegacyMappingWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **contentType** | **string** |  | [default to &quot;application/json&quot;] |
| **mappingIdBody** | [**MappingIdBody**](MappingIdBody.md) | The size of the body is limited to 10KB. | [optional]  |

### Return type

[**MappingIdResponse**](MappingIdResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | This response will give you an array of mappings of resource identifiers ; the &#x60;data.attributes.newId&#x60; field corresponds to the new UUID. |  -  |
| **400** | Bad Request |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

