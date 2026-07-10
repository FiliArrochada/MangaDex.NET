# MangaDex.Api.ApiClientApi

All URIs are relative to *https://api.mangadex.org*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DeleteApiclient**](ApiClientApi.md#deleteapiclient) | **DELETE** /client/{id} | Delete Api Client |
| [**GetApiclient**](ApiClientApi.md#getapiclient) | **GET** /client/{id} | Get Api Client by ID |
| [**GetApiclientSecret**](ApiClientApi.md#getapiclientsecret) | **GET** /client/{id}/secret | Get Secret for Client by ID |
| [**GetListApiclients**](ApiClientApi.md#getlistapiclients) | **GET** /client | List own Api Clients |
| [**PostCreateApiclient**](ApiClientApi.md#postcreateapiclient) | **POST** /client | Create ApiClient |
| [**PostEditApiclient**](ApiClientApi.md#posteditapiclient) | **POST** /client/{id} | Edit ApiClient |
| [**PostRegenerateApiclientSecret**](ApiClientApi.md#postregenerateapiclientsecret) | **POST** /client/{id}/secret | Regenerate Client Secret |

<a id="deleteapiclient"></a>
# **DeleteApiclient**
> DeleteApiclient200Response DeleteApiclient (Guid id, string varVersion = null)

Delete Api Client

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaDex.Api;
using MangaDex.Client;
using MangaDex.Model;

namespace Example
{
    public class DeleteApiclientExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangadex.org";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ApiClientApi(config);
            var id = "id_example";  // Guid | ApiClient ID
            var varVersion = "varVersion_example";  // string |  (optional) 

            try
            {
                // Delete Api Client
                DeleteApiclient200Response result = apiInstance.DeleteApiclient(id, varVersion);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ApiClientApi.DeleteApiclient: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteApiclientWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete Api Client
    ApiResponse<DeleteApiclient200Response> response = apiInstance.DeleteApiclientWithHttpInfo(id, varVersion);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ApiClientApi.DeleteApiclientWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | ApiClient ID |  |
| **varVersion** | **string** |  | [optional]  |

### Return type

[**DeleteApiclient200Response**](DeleteApiclient200Response.md)

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

<a id="getapiclient"></a>
# **GetApiclient**
> ApiClientResponse GetApiclient (Guid id, List<string> includes = null)

Get Api Client by ID

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaDex.Api;
using MangaDex.Client;
using MangaDex.Model;

namespace Example
{
    public class GetApiclientExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangadex.org";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ApiClientApi(config);
            var id = "id_example";  // Guid | ApiClient ID
            var includes = new List<string>(); // List<string> |  (optional) 

            try
            {
                // Get Api Client by ID
                ApiClientResponse result = apiInstance.GetApiclient(id, includes);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ApiClientApi.GetApiclient: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetApiclientWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Api Client by ID
    ApiResponse<ApiClientResponse> response = apiInstance.GetApiclientWithHttpInfo(id, includes);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ApiClientApi.GetApiclientWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | ApiClient ID |  |
| **includes** | [**List&lt;string&gt;**](string.md) |  | [optional]  |

### Return type

[**ApiClientResponse**](ApiClientResponse.md)

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

<a id="getapiclientsecret"></a>
# **GetApiclientSecret**
> GetApiclientSecret200Response GetApiclientSecret (Guid id)

Get Secret for Client by ID

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaDex.Api;
using MangaDex.Client;
using MangaDex.Model;

namespace Example
{
    public class GetApiclientSecretExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangadex.org";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ApiClientApi(config);
            var id = "id_example";  // Guid | ApiClient ID

            try
            {
                // Get Secret for Client by ID
                GetApiclientSecret200Response result = apiInstance.GetApiclientSecret(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ApiClientApi.GetApiclientSecret: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetApiclientSecretWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Secret for Client by ID
    ApiResponse<GetApiclientSecret200Response> response = apiInstance.GetApiclientSecretWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ApiClientApi.GetApiclientSecretWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | ApiClient ID |  |

### Return type

[**GetApiclientSecret200Response**](GetApiclientSecret200Response.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **403** | Client not found, not active or user is not the owner |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getlistapiclients"></a>
# **GetListApiclients**
> ApiClientList GetListApiclients (int? limit = null, int? offset = null, string state = null, string name = null, List<string> includes = null, GetListApiclientsOrderParameter order = null)

List own Api Clients

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaDex.Api;
using MangaDex.Client;
using MangaDex.Model;

namespace Example
{
    public class GetListApiclientsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangadex.org";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ApiClientApi(config);
            var limit = 10;  // int? |  (optional)  (default to 10)
            var offset = 56;  // int? |  (optional) 
            var state = "requested";  // string |  (optional) 
            var name = "name_example";  // string |  (optional) 
            var includes = new List<string>(); // List<string> |  (optional) 
            var order = new GetListApiclientsOrderParameter(); // GetListApiclientsOrderParameter |  (optional) 

            try
            {
                // List own Api Clients
                ApiClientList result = apiInstance.GetListApiclients(limit, offset, state, name, includes, order);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ApiClientApi.GetListApiclients: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetListApiclientsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List own Api Clients
    ApiResponse<ApiClientList> response = apiInstance.GetListApiclientsWithHttpInfo(limit, offset, state, name, includes, order);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ApiClientApi.GetListApiclientsWithHttpInfo: " + e.Message);
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
| **name** | **string** |  | [optional]  |
| **includes** | [**List&lt;string&gt;**](string.md) |  | [optional]  |
| **order** | [**GetListApiclientsOrderParameter**](GetListApiclientsOrderParameter.md) |  | [optional]  |

### Return type

[**ApiClientList**](ApiClientList.md)

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

<a id="postcreateapiclient"></a>
# **PostCreateApiclient**
> ApiClientResponse PostCreateApiclient (string contentType, ApiClientCreate apiClientCreate = null)

Create ApiClient

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaDex.Api;
using MangaDex.Client;
using MangaDex.Model;

namespace Example
{
    public class PostCreateApiclientExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangadex.org";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ApiClientApi(config);
            var contentType = "\"application/json\"";  // string |  (default to "application/json")
            var apiClientCreate = new ApiClientCreate(); // ApiClientCreate |  (optional) 

            try
            {
                // Create ApiClient
                ApiClientResponse result = apiInstance.PostCreateApiclient(contentType, apiClientCreate);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ApiClientApi.PostCreateApiclient: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostCreateApiclientWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create ApiClient
    ApiResponse<ApiClientResponse> response = apiInstance.PostCreateApiclientWithHttpInfo(contentType, apiClientCreate);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ApiClientApi.PostCreateApiclientWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **contentType** | **string** |  | [default to &quot;application/json&quot;] |
| **apiClientCreate** | [**ApiClientCreate**](ApiClientCreate.md) |  | [optional]  |

### Return type

[**ApiClientResponse**](ApiClientResponse.md)

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

<a id="posteditapiclient"></a>
# **PostEditApiclient**
> ApiClientResponse PostEditApiclient (Guid id, string contentType, ApiClientEdit apiClientEdit = null)

Edit ApiClient

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaDex.Api;
using MangaDex.Client;
using MangaDex.Model;

namespace Example
{
    public class PostEditApiclientExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangadex.org";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ApiClientApi(config);
            var id = "id_example";  // Guid | ApiClient ID
            var contentType = "\"application/json\"";  // string |  (default to "application/json")
            var apiClientEdit = new ApiClientEdit(); // ApiClientEdit |  (optional) 

            try
            {
                // Edit ApiClient
                ApiClientResponse result = apiInstance.PostEditApiclient(id, contentType, apiClientEdit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ApiClientApi.PostEditApiclient: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostEditApiclientWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Edit ApiClient
    ApiResponse<ApiClientResponse> response = apiInstance.PostEditApiclientWithHttpInfo(id, contentType, apiClientEdit);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ApiClientApi.PostEditApiclientWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | ApiClient ID |  |
| **contentType** | **string** |  | [default to &quot;application/json&quot;] |
| **apiClientEdit** | [**ApiClientEdit**](ApiClientEdit.md) |  | [optional]  |

### Return type

[**ApiClientResponse**](ApiClientResponse.md)

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

<a id="postregenerateapiclientsecret"></a>
# **PostRegenerateApiclientSecret**
> GetApiclientSecret200Response PostRegenerateApiclientSecret (Guid id, string contentType, Object body = null)

Regenerate Client Secret

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaDex.Api;
using MangaDex.Client;
using MangaDex.Model;

namespace Example
{
    public class PostRegenerateApiclientSecretExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangadex.org";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ApiClientApi(config);
            var id = "id_example";  // Guid | ApiClient ID
            var contentType = "\"application/json\"";  // string |  (default to "application/json")
            var body = null;  // Object |  (optional) 

            try
            {
                // Regenerate Client Secret
                GetApiclientSecret200Response result = apiInstance.PostRegenerateApiclientSecret(id, contentType, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ApiClientApi.PostRegenerateApiclientSecret: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostRegenerateApiclientSecretWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Regenerate Client Secret
    ApiResponse<GetApiclientSecret200Response> response = apiInstance.PostRegenerateApiclientSecretWithHttpInfo(id, contentType, body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ApiClientApi.PostRegenerateApiclientSecretWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | ApiClient ID |  |
| **contentType** | **string** |  | [default to &quot;application/json&quot;] |
| **body** | **Object** |  | [optional]  |

### Return type

[**GetApiclientSecret200Response**](GetApiclientSecret200Response.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **403** | Client not found, not active or user is not the owner |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

