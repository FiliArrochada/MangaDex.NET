# MangaDex.Api.AuthorApi

All URIs are relative to *https://api.mangadex.org*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DeleteAuthorId**](AuthorApi.md#deleteauthorid) | **DELETE** /author/{id} | Delete Author |
| [**GetAuthor**](AuthorApi.md#getauthor) | **GET** /author | Author list |
| [**GetAuthorId**](AuthorApi.md#getauthorid) | **GET** /author/{id} | Get Author |
| [**PostAuthor**](AuthorApi.md#postauthor) | **POST** /author | Create Author |
| [**PutAuthorId**](AuthorApi.md#putauthorid) | **PUT** /author/{id} | Update Author |

<a id="deleteauthorid"></a>
# **DeleteAuthorId**
> Response DeleteAuthorId (Guid id)

Delete Author

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaDex.Api;
using MangaDex.Client;
using MangaDex.Model;

namespace Example
{
    public class DeleteAuthorIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangadex.org";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AuthorApi(config);
            var id = "id_example";  // Guid | Author ID

            try
            {
                // Delete Author
                Response result = apiInstance.DeleteAuthorId(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthorApi.DeleteAuthorId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteAuthorIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete Author
    ApiResponse<Response> response = apiInstance.DeleteAuthorIdWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AuthorApi.DeleteAuthorIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | Author ID |  |

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
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getauthor"></a>
# **GetAuthor**
> AuthorList GetAuthor (int? limit = null, int? offset = null, List<Guid> ids = null, string name = null, GetAuthorOrderParameter order = null, List<string> includes = null)

Author list

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaDex.Api;
using MangaDex.Client;
using MangaDex.Model;

namespace Example
{
    public class GetAuthorExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangadex.org";
            var apiInstance = new AuthorApi(config);
            var limit = 10;  // int? |  (optional)  (default to 10)
            var offset = 56;  // int? |  (optional) 
            var ids = new List<Guid>(); // List<Guid> | Author ids (limited to 100 per request) (optional) 
            var name = "name_example";  // string |  (optional) 
            var order = new GetAuthorOrderParameter(); // GetAuthorOrderParameter |  (optional) 
            var includes = new List<string>(); // List<string> |  (optional) 

            try
            {
                // Author list
                AuthorList result = apiInstance.GetAuthor(limit, offset, ids, name, order, includes);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthorApi.GetAuthor: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAuthorWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Author list
    ApiResponse<AuthorList> response = apiInstance.GetAuthorWithHttpInfo(limit, offset, ids, name, order, includes);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AuthorApi.GetAuthorWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **limit** | **int?** |  | [optional] [default to 10] |
| **offset** | **int?** |  | [optional]  |
| **ids** | [**List&lt;Guid&gt;**](Guid.md) | Author ids (limited to 100 per request) | [optional]  |
| **name** | **string** |  | [optional]  |
| **order** | [**GetAuthorOrderParameter**](GetAuthorOrderParameter.md) |  | [optional]  |
| **includes** | [**List&lt;string&gt;**](string.md) |  | [optional]  |

### Return type

[**AuthorList**](AuthorList.md)

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

<a id="getauthorid"></a>
# **GetAuthorId**
> AuthorResponse GetAuthorId (Guid id, List<string> includes = null)

Get Author

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaDex.Api;
using MangaDex.Client;
using MangaDex.Model;

namespace Example
{
    public class GetAuthorIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangadex.org";
            var apiInstance = new AuthorApi(config);
            var id = "id_example";  // Guid | Author ID
            var includes = new List<string>(); // List<string> |  (optional) 

            try
            {
                // Get Author
                AuthorResponse result = apiInstance.GetAuthorId(id, includes);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthorApi.GetAuthorId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAuthorIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Author
    ApiResponse<AuthorResponse> response = apiInstance.GetAuthorIdWithHttpInfo(id, includes);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AuthorApi.GetAuthorIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | Author ID |  |
| **includes** | [**List&lt;string&gt;**](string.md) |  | [optional]  |

### Return type

[**AuthorResponse**](AuthorResponse.md)

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
| **404** | Author no content |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="postauthor"></a>
# **PostAuthor**
> AuthorResponse PostAuthor (string contentType, AuthorCreate authorCreate = null)

Create Author

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaDex.Api;
using MangaDex.Client;
using MangaDex.Model;

namespace Example
{
    public class PostAuthorExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangadex.org";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AuthorApi(config);
            var contentType = "\"application/json\"";  // string |  (default to "application/json")
            var authorCreate = new AuthorCreate(); // AuthorCreate | The size of the body is limited to 8KB. (optional) 

            try
            {
                // Create Author
                AuthorResponse result = apiInstance.PostAuthor(contentType, authorCreate);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthorApi.PostAuthor: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostAuthorWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create Author
    ApiResponse<AuthorResponse> response = apiInstance.PostAuthorWithHttpInfo(contentType, authorCreate);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AuthorApi.PostAuthorWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **contentType** | **string** |  | [default to &quot;application/json&quot;] |
| **authorCreate** | [**AuthorCreate**](AuthorCreate.md) | The size of the body is limited to 8KB. | [optional]  |

### Return type

[**AuthorResponse**](AuthorResponse.md)

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

<a id="putauthorid"></a>
# **PutAuthorId**
> AuthorResponse PutAuthorId (Guid id, string contentType, AuthorEdit authorEdit = null)

Update Author

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaDex.Api;
using MangaDex.Client;
using MangaDex.Model;

namespace Example
{
    public class PutAuthorIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangadex.org";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AuthorApi(config);
            var id = "id_example";  // Guid | Author ID
            var contentType = "\"application/json\"";  // string |  (default to "application/json")
            var authorEdit = new AuthorEdit(); // AuthorEdit | The size of the body is limited to 8KB. (optional) 

            try
            {
                // Update Author
                AuthorResponse result = apiInstance.PutAuthorId(id, contentType, authorEdit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthorApi.PutAuthorId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PutAuthorIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update Author
    ApiResponse<AuthorResponse> response = apiInstance.PutAuthorIdWithHttpInfo(id, contentType, authorEdit);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AuthorApi.PutAuthorIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | Author ID |  |
| **contentType** | **string** |  | [default to &quot;application/json&quot;] |
| **authorEdit** | [**AuthorEdit**](AuthorEdit.md) | The size of the body is limited to 8KB. | [optional]  |

### Return type

[**AuthorResponse**](AuthorResponse.md)

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

