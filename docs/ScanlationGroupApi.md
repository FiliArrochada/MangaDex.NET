# MangaDex.Api.ScanlationGroupApi

All URIs are relative to *https://api.mangadex.org*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DeleteGroupId**](ScanlationGroupApi.md#deletegroupid) | **DELETE** /group/{id} | Delete Scanlation Group |
| [**DeleteGroupIdFollow**](ScanlationGroupApi.md#deletegroupidfollow) | **DELETE** /group/{id}/follow | Unfollow Scanlation Group |
| [**GetGroupId**](ScanlationGroupApi.md#getgroupid) | **GET** /group/{id} | Get Scanlation Group |
| [**GetSearchGroup**](ScanlationGroupApi.md#getsearchgroup) | **GET** /group | Scanlation Group list |
| [**PostGroup**](ScanlationGroupApi.md#postgroup) | **POST** /group | Create Scanlation Group |
| [**PostGroupIdFollow**](ScanlationGroupApi.md#postgroupidfollow) | **POST** /group/{id}/follow | Follow Scanlation Group |
| [**PutGroupId**](ScanlationGroupApi.md#putgroupid) | **PUT** /group/{id} | Update Scanlation Group |

<a id="deletegroupid"></a>
# **DeleteGroupId**
> Response DeleteGroupId (Guid id)

Delete Scanlation Group

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaDex.Api;
using MangaDex.Client;
using MangaDex.Model;

namespace Example
{
    public class DeleteGroupIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangadex.org";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ScanlationGroupApi(config);
            var id = "id_example";  // Guid | Scanlation Group ID

            try
            {
                // Delete Scanlation Group
                Response result = apiInstance.DeleteGroupId(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ScanlationGroupApi.DeleteGroupId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteGroupIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete Scanlation Group
    ApiResponse<Response> response = apiInstance.DeleteGroupIdWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ScanlationGroupApi.DeleteGroupIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | Scanlation Group ID |  |

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

<a id="deletegroupidfollow"></a>
# **DeleteGroupIdFollow**
> Response DeleteGroupIdFollow (Guid id)

Unfollow Scanlation Group

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaDex.Api;
using MangaDex.Client;
using MangaDex.Model;

namespace Example
{
    public class DeleteGroupIdFollowExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangadex.org";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ScanlationGroupApi(config);
            var id = "id_example";  // Guid | 

            try
            {
                // Unfollow Scanlation Group
                Response result = apiInstance.DeleteGroupIdFollow(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ScanlationGroupApi.DeleteGroupIdFollow: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteGroupIdFollowWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Unfollow Scanlation Group
    ApiResponse<Response> response = apiInstance.DeleteGroupIdFollowWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ScanlationGroupApi.DeleteGroupIdFollowWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** |  |  |

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
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getgroupid"></a>
# **GetGroupId**
> ScanlationGroupResponse GetGroupId (Guid id, List<string> includes = null)

Get Scanlation Group

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaDex.Api;
using MangaDex.Client;
using MangaDex.Model;

namespace Example
{
    public class GetGroupIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangadex.org";
            var apiInstance = new ScanlationGroupApi(config);
            var id = "id_example";  // Guid | Scanlation Group ID
            var includes = new List<string>(); // List<string> |  (optional) 

            try
            {
                // Get Scanlation Group
                ScanlationGroupResponse result = apiInstance.GetGroupId(id, includes);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ScanlationGroupApi.GetGroupId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetGroupIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Scanlation Group
    ApiResponse<ScanlationGroupResponse> response = apiInstance.GetGroupIdWithHttpInfo(id, includes);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ScanlationGroupApi.GetGroupIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | Scanlation Group ID |  |
| **includes** | [**List&lt;string&gt;**](string.md) |  | [optional]  |

### Return type

[**ScanlationGroupResponse**](ScanlationGroupResponse.md)

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
| **404** | ScanlationGroup not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getsearchgroup"></a>
# **GetSearchGroup**
> ScanlationGroupList GetSearchGroup (int? limit = null, int? offset = null, List<Guid> ids = null, string name = null, string focusedLanguage = null, List<string> includes = null, GetSearchGroupOrderParameter order = null)

Scanlation Group list

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaDex.Api;
using MangaDex.Client;
using MangaDex.Model;

namespace Example
{
    public class GetSearchGroupExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangadex.org";
            var apiInstance = new ScanlationGroupApi(config);
            var limit = 10;  // int? |  (optional)  (default to 10)
            var offset = 56;  // int? |  (optional) 
            var ids = new List<Guid>(); // List<Guid> | ScanlationGroup ids (limited to 100 per request) (optional) 
            var name = "name_example";  // string |  (optional) 
            var focusedLanguage = "focusedLanguage_example";  // string |  (optional) 
            var includes = new List<string>(); // List<string> |  (optional) 
            var order = new GetSearchGroupOrderParameter(); // GetSearchGroupOrderParameter |  (optional) 

            try
            {
                // Scanlation Group list
                ScanlationGroupList result = apiInstance.GetSearchGroup(limit, offset, ids, name, focusedLanguage, includes, order);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ScanlationGroupApi.GetSearchGroup: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetSearchGroupWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Scanlation Group list
    ApiResponse<ScanlationGroupList> response = apiInstance.GetSearchGroupWithHttpInfo(limit, offset, ids, name, focusedLanguage, includes, order);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ScanlationGroupApi.GetSearchGroupWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **limit** | **int?** |  | [optional] [default to 10] |
| **offset** | **int?** |  | [optional]  |
| **ids** | [**List&lt;Guid&gt;**](Guid.md) | ScanlationGroup ids (limited to 100 per request) | [optional]  |
| **name** | **string** |  | [optional]  |
| **focusedLanguage** | **string** |  | [optional]  |
| **includes** | [**List&lt;string&gt;**](string.md) |  | [optional]  |
| **order** | [**GetSearchGroupOrderParameter**](GetSearchGroupOrderParameter.md) |  | [optional]  |

### Return type

[**ScanlationGroupList**](ScanlationGroupList.md)

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

<a id="postgroup"></a>
# **PostGroup**
> ScanlationGroupResponse PostGroup (string contentType, CreateScanlationGroup createScanlationGroup = null)

Create Scanlation Group

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaDex.Api;
using MangaDex.Client;
using MangaDex.Model;

namespace Example
{
    public class PostGroupExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangadex.org";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ScanlationGroupApi(config);
            var contentType = "\"application/json\"";  // string |  (default to "application/json")
            var createScanlationGroup = new CreateScanlationGroup(); // CreateScanlationGroup | The size of the body is limited to 16KB. (optional) 

            try
            {
                // Create Scanlation Group
                ScanlationGroupResponse result = apiInstance.PostGroup(contentType, createScanlationGroup);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ScanlationGroupApi.PostGroup: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostGroupWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create Scanlation Group
    ApiResponse<ScanlationGroupResponse> response = apiInstance.PostGroupWithHttpInfo(contentType, createScanlationGroup);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ScanlationGroupApi.PostGroupWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **contentType** | **string** |  | [default to &quot;application/json&quot;] |
| **createScanlationGroup** | [**CreateScanlationGroup**](CreateScanlationGroup.md) | The size of the body is limited to 16KB. | [optional]  |

### Return type

[**ScanlationGroupResponse**](ScanlationGroupResponse.md)

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

<a id="postgroupidfollow"></a>
# **PostGroupIdFollow**
> Response PostGroupIdFollow (Guid id)

Follow Scanlation Group

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaDex.Api;
using MangaDex.Client;
using MangaDex.Model;

namespace Example
{
    public class PostGroupIdFollowExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangadex.org";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ScanlationGroupApi(config);
            var id = "id_example";  // Guid | 

            try
            {
                // Follow Scanlation Group
                Response result = apiInstance.PostGroupIdFollow(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ScanlationGroupApi.PostGroupIdFollow: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostGroupIdFollowWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Follow Scanlation Group
    ApiResponse<Response> response = apiInstance.PostGroupIdFollowWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ScanlationGroupApi.PostGroupIdFollowWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** |  |  |

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
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="putgroupid"></a>
# **PutGroupId**
> ScanlationGroupResponse PutGroupId (Guid id, string contentType, ScanlationGroupEdit scanlationGroupEdit = null)

Update Scanlation Group

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaDex.Api;
using MangaDex.Client;
using MangaDex.Model;

namespace Example
{
    public class PutGroupIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangadex.org";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ScanlationGroupApi(config);
            var id = "id_example";  // Guid | Scanlation Group ID
            var contentType = "\"application/json\"";  // string |  (default to "application/json")
            var scanlationGroupEdit = new ScanlationGroupEdit(); // ScanlationGroupEdit | The size of the body is limited to 8KB. (optional) 

            try
            {
                // Update Scanlation Group
                ScanlationGroupResponse result = apiInstance.PutGroupId(id, contentType, scanlationGroupEdit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ScanlationGroupApi.PutGroupId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PutGroupIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update Scanlation Group
    ApiResponse<ScanlationGroupResponse> response = apiInstance.PutGroupIdWithHttpInfo(id, contentType, scanlationGroupEdit);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ScanlationGroupApi.PutGroupIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | Scanlation Group ID |  |
| **contentType** | **string** |  | [default to &quot;application/json&quot;] |
| **scanlationGroupEdit** | [**ScanlationGroupEdit**](ScanlationGroupEdit.md) | The size of the body is limited to 8KB. | [optional]  |

### Return type

[**ScanlationGroupResponse**](ScanlationGroupResponse.md)

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

