# MangaDex.Api.ReportApi

All URIs are relative to *https://api.mangadex.org*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetReportReasonsByCategory**](ReportApi.md#getreportreasonsbycategory) | **GET** /report/reasons/{category} | Get a list of report reasons |
| [**GetReports**](ReportApi.md#getreports) | **GET** /report | Get a list of reports by the user |
| [**PostReport**](ReportApi.md#postreport) | **POST** /report | Create a new Report |

<a id="getreportreasonsbycategory"></a>
# **GetReportReasonsByCategory**
> GetReportReasonsByCategory200Response GetReportReasonsByCategory (string category)

Get a list of report reasons

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaDex.Api;
using MangaDex.Client;
using MangaDex.Model;

namespace Example
{
    public class GetReportReasonsByCategoryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangadex.org";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ReportApi(config);
            var category = "manga";  // string | 

            try
            {
                // Get a list of report reasons
                GetReportReasonsByCategory200Response result = apiInstance.GetReportReasonsByCategory(category);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ReportApi.GetReportReasonsByCategory: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetReportReasonsByCategoryWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get a list of report reasons
    ApiResponse<GetReportReasonsByCategory200Response> response = apiInstance.GetReportReasonsByCategoryWithHttpInfo(category);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ReportApi.GetReportReasonsByCategoryWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **category** | **string** |  |  |

### Return type

[**GetReportReasonsByCategory200Response**](GetReportReasonsByCategory200Response.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad request |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getreports"></a>
# **GetReports**
> ReportListResponse GetReports (int? limit = null, int? offset = null, string category = null, Guid? reasonId = null, Guid? objectId = null, string status = null, GetReportsOrderParameter order = null, List<string> includes = null)

Get a list of reports by the user

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaDex.Api;
using MangaDex.Client;
using MangaDex.Model;

namespace Example
{
    public class GetReportsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangadex.org";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ReportApi(config);
            var limit = 10;  // int? |  (optional)  (default to 10)
            var offset = 56;  // int? |  (optional) 
            var category = "manga";  // string |  (optional) 
            var reasonId = "reasonId_example";  // Guid? |  (optional) 
            var objectId = "objectId_example";  // Guid? |  (optional) 
            var status = "waiting";  // string |  (optional) 
            var order = new GetReportsOrderParameter(); // GetReportsOrderParameter |  (optional) 
            var includes = new List<string>(); // List<string> |  (optional) 

            try
            {
                // Get a list of reports by the user
                ReportListResponse result = apiInstance.GetReports(limit, offset, category, reasonId, objectId, status, order, includes);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ReportApi.GetReports: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetReportsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get a list of reports by the user
    ApiResponse<ReportListResponse> response = apiInstance.GetReportsWithHttpInfo(limit, offset, category, reasonId, objectId, status, order, includes);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ReportApi.GetReportsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **limit** | **int?** |  | [optional] [default to 10] |
| **offset** | **int?** |  | [optional]  |
| **category** | **string** |  | [optional]  |
| **reasonId** | **Guid?** |  | [optional]  |
| **objectId** | **Guid?** |  | [optional]  |
| **status** | **string** |  | [optional]  |
| **order** | [**GetReportsOrderParameter**](GetReportsOrderParameter.md) |  | [optional]  |
| **includes** | [**List&lt;string&gt;**](string.md) |  | [optional]  |

### Return type

[**ReportListResponse**](ReportListResponse.md)

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

<a id="postreport"></a>
# **PostReport**
> Response PostReport (string contentType, PostReportRequest postReportRequest = null)

Create a new Report

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaDex.Api;
using MangaDex.Client;
using MangaDex.Model;

namespace Example
{
    public class PostReportExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangadex.org";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ReportApi(config);
            var contentType = "\"application/json\"";  // string |  (default to "application/json")
            var postReportRequest = new PostReportRequest(); // PostReportRequest | The size of the body is limited to 8KB. (optional) 

            try
            {
                // Create a new Report
                Response result = apiInstance.PostReport(contentType, postReportRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ReportApi.PostReport: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostReportWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a new Report
    ApiResponse<Response> response = apiInstance.PostReportWithHttpInfo(contentType, postReportRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ReportApi.PostReportWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **contentType** | **string** |  | [default to &quot;application/json&quot;] |
| **postReportRequest** | [**PostReportRequest**](PostReportRequest.md) | The size of the body is limited to 8KB. | [optional]  |

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
| **201** | Created |  -  |
| **400** | Bad request |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

