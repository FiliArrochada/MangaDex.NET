# MangaDex.Api.CustomListApi

All URIs are relative to *https://api.mangadex.org*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DeleteListId**](CustomListApi.md#deletelistid) | **DELETE** /list/{id} | Delete CustomList |
| [**DeleteMangaIdListListId**](CustomListApi.md#deletemangaidlistlistid) | **DELETE** /manga/{id}/list/{listId} | Remove Manga in CustomList |
| [**FollowListId**](CustomListApi.md#followlistid) | **POST** /list/{id}/follow | Follow CustomList |
| [**GetListId**](CustomListApi.md#getlistid) | **GET** /list/{id} | Get CustomList |
| [**GetUserIdList**](CustomListApi.md#getuseridlist) | **GET** /user/{id}/list | Get User&#39;s CustomList list |
| [**GetUserList**](CustomListApi.md#getuserlist) | **GET** /user/list | Get logged User CustomList list |
| [**PostList**](CustomListApi.md#postlist) | **POST** /list | Create CustomList |
| [**PostMangaIdListListId**](CustomListApi.md#postmangaidlistlistid) | **POST** /manga/{id}/list/{listId} | Add Manga in CustomList |
| [**PutListId**](CustomListApi.md#putlistid) | **PUT** /list/{id} | Update CustomList |
| [**UnfollowListId**](CustomListApi.md#unfollowlistid) | **DELETE** /list/{id}/follow | Unfollow CustomList |

<a id="deletelistid"></a>
# **DeleteListId**
> Response DeleteListId (Guid id)

Delete CustomList

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaDex.Api;
using MangaDex.Client;
using MangaDex.Model;

namespace Example
{
    public class DeleteListIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangadex.org";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new CustomListApi(config);
            var id = "id_example";  // Guid | CustomList ID

            try
            {
                // Delete CustomList
                Response result = apiInstance.DeleteListId(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CustomListApi.DeleteListId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteListIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete CustomList
    ApiResponse<Response> response = apiInstance.DeleteListIdWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CustomListApi.DeleteListIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | CustomList ID |  |

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

<a id="deletemangaidlistlistid"></a>
# **DeleteMangaIdListListId**
> Response DeleteMangaIdListListId (Guid id, Guid listId)

Remove Manga in CustomList

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaDex.Api;
using MangaDex.Client;
using MangaDex.Model;

namespace Example
{
    public class DeleteMangaIdListListIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangadex.org";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new CustomListApi(config);
            var id = "id_example";  // Guid | Manga ID
            var listId = "listId_example";  // Guid | CustomList ID

            try
            {
                // Remove Manga in CustomList
                Response result = apiInstance.DeleteMangaIdListListId(id, listId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CustomListApi.DeleteMangaIdListListId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteMangaIdListListIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Remove Manga in CustomList
    ApiResponse<Response> response = apiInstance.DeleteMangaIdListListIdWithHttpInfo(id, listId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CustomListApi.DeleteMangaIdListListIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | Manga ID |  |
| **listId** | **Guid** | CustomList ID |  |

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

<a id="followlistid"></a>
# **FollowListId**
> FollowListId200Response FollowListId (Guid id, string contentType, Object body = null)

Follow CustomList

The request body is empty

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaDex.Api;
using MangaDex.Client;
using MangaDex.Model;

namespace Example
{
    public class FollowListIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangadex.org";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new CustomListApi(config);
            var id = "id_example";  // Guid | CustomList ID
            var contentType = "\"application/json\"";  // string |  (default to "application/json")
            var body = null;  // Object |  (optional) 

            try
            {
                // Follow CustomList
                FollowListId200Response result = apiInstance.FollowListId(id, contentType, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CustomListApi.FollowListId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the FollowListIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Follow CustomList
    ApiResponse<FollowListId200Response> response = apiInstance.FollowListIdWithHttpInfo(id, contentType, body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CustomListApi.FollowListIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | CustomList ID |  |
| **contentType** | **string** |  | [default to &quot;application/json&quot;] |
| **body** | **Object** |  | [optional]  |

### Return type

[**FollowListId200Response**](FollowListId200Response.md)

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

<a id="getlistid"></a>
# **GetListId**
> CustomListResponse GetListId (Guid id)

Get CustomList

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaDex.Api;
using MangaDex.Client;
using MangaDex.Model;

namespace Example
{
    public class GetListIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangadex.org";
            var apiInstance = new CustomListApi(config);
            var id = "id_example";  // Guid | CustomList ID

            try
            {
                // Get CustomList
                CustomListResponse result = apiInstance.GetListId(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CustomListApi.GetListId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetListIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get CustomList
    ApiResponse<CustomListResponse> response = apiInstance.GetListIdWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CustomListApi.GetListIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | CustomList ID |  |

### Return type

[**CustomListResponse**](CustomListResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **404** | CustomList not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getuseridlist"></a>
# **GetUserIdList**
> CustomListList GetUserIdList (Guid id, int? limit = null, int? offset = null)

Get User's CustomList list

This will list only public CustomList

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaDex.Api;
using MangaDex.Client;
using MangaDex.Model;

namespace Example
{
    public class GetUserIdListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangadex.org";
            var apiInstance = new CustomListApi(config);
            var id = "id_example";  // Guid | User ID
            var limit = 10;  // int? |  (optional)  (default to 10)
            var offset = 56;  // int? |  (optional) 

            try
            {
                // Get User's CustomList list
                CustomListList result = apiInstance.GetUserIdList(id, limit, offset);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CustomListApi.GetUserIdList: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetUserIdListWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get User's CustomList list
    ApiResponse<CustomListList> response = apiInstance.GetUserIdListWithHttpInfo(id, limit, offset);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CustomListApi.GetUserIdListWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | User ID |  |
| **limit** | **int?** |  | [optional] [default to 10] |
| **offset** | **int?** |  | [optional]  |

### Return type

[**CustomListList**](CustomListList.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getuserlist"></a>
# **GetUserList**
> CustomListList GetUserList (int? limit = null, int? offset = null)

Get logged User CustomList list

This will list public and private CustomList

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaDex.Api;
using MangaDex.Client;
using MangaDex.Model;

namespace Example
{
    public class GetUserListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangadex.org";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new CustomListApi(config);
            var limit = 10;  // int? |  (optional)  (default to 10)
            var offset = 56;  // int? |  (optional) 

            try
            {
                // Get logged User CustomList list
                CustomListList result = apiInstance.GetUserList(limit, offset);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CustomListApi.GetUserList: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetUserListWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get logged User CustomList list
    ApiResponse<CustomListList> response = apiInstance.GetUserListWithHttpInfo(limit, offset);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CustomListApi.GetUserListWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **limit** | **int?** |  | [optional] [default to 10] |
| **offset** | **int?** |  | [optional]  |

### Return type

[**CustomListList**](CustomListList.md)

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

<a id="postlist"></a>
# **PostList**
> CustomListResponse PostList (string contentType, CustomListCreate customListCreate = null)

Create CustomList

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaDex.Api;
using MangaDex.Client;
using MangaDex.Model;

namespace Example
{
    public class PostListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangadex.org";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new CustomListApi(config);
            var contentType = "\"application/json\"";  // string |  (default to "application/json")
            var customListCreate = new CustomListCreate(); // CustomListCreate | The size of the body is limited to 8KB. (optional) 

            try
            {
                // Create CustomList
                CustomListResponse result = apiInstance.PostList(contentType, customListCreate);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CustomListApi.PostList: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostListWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create CustomList
    ApiResponse<CustomListResponse> response = apiInstance.PostListWithHttpInfo(contentType, customListCreate);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CustomListApi.PostListWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **contentType** | **string** |  | [default to &quot;application/json&quot;] |
| **customListCreate** | [**CustomListCreate**](CustomListCreate.md) | The size of the body is limited to 8KB. | [optional]  |

### Return type

[**CustomListResponse**](CustomListResponse.md)

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
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="postmangaidlistlistid"></a>
# **PostMangaIdListListId**
> Response PostMangaIdListListId (Guid id, Guid listId)

Add Manga in CustomList

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaDex.Api;
using MangaDex.Client;
using MangaDex.Model;

namespace Example
{
    public class PostMangaIdListListIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangadex.org";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new CustomListApi(config);
            var id = "id_example";  // Guid | Manga ID
            var listId = "listId_example";  // Guid | CustomList ID

            try
            {
                // Add Manga in CustomList
                Response result = apiInstance.PostMangaIdListListId(id, listId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CustomListApi.PostMangaIdListListId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostMangaIdListListIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Add Manga in CustomList
    ApiResponse<Response> response = apiInstance.PostMangaIdListListIdWithHttpInfo(id, listId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CustomListApi.PostMangaIdListListIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | Manga ID |  |
| **listId** | **Guid** | CustomList ID |  |

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

<a id="putlistid"></a>
# **PutListId**
> CustomListResponse PutListId (Guid id, string contentType, CustomListEdit customListEdit = null)

Update CustomList

The size of the body is limited to 8KB.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaDex.Api;
using MangaDex.Client;
using MangaDex.Model;

namespace Example
{
    public class PutListIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangadex.org";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new CustomListApi(config);
            var id = "id_example";  // Guid | CustomList ID
            var contentType = "\"application/json\"";  // string |  (default to "application/json")
            var customListEdit = new CustomListEdit(); // CustomListEdit |  (optional) 

            try
            {
                // Update CustomList
                CustomListResponse result = apiInstance.PutListId(id, contentType, customListEdit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CustomListApi.PutListId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PutListIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update CustomList
    ApiResponse<CustomListResponse> response = apiInstance.PutListIdWithHttpInfo(id, contentType, customListEdit);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CustomListApi.PutListIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | CustomList ID |  |
| **contentType** | **string** |  | [default to &quot;application/json&quot;] |
| **customListEdit** | [**CustomListEdit**](CustomListEdit.md) |  | [optional]  |

### Return type

[**CustomListResponse**](CustomListResponse.md)

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

<a id="unfollowlistid"></a>
# **UnfollowListId**
> FollowListId200Response UnfollowListId (Guid id, Object body = null)

Unfollow CustomList

The request body is empty

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaDex.Api;
using MangaDex.Client;
using MangaDex.Model;

namespace Example
{
    public class UnfollowListIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangadex.org";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new CustomListApi(config);
            var id = "id_example";  // Guid | CustomList ID
            var body = null;  // Object |  (optional) 

            try
            {
                // Unfollow CustomList
                FollowListId200Response result = apiInstance.UnfollowListId(id, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CustomListApi.UnfollowListId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UnfollowListIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Unfollow CustomList
    ApiResponse<FollowListId200Response> response = apiInstance.UnfollowListIdWithHttpInfo(id, body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CustomListApi.UnfollowListIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | CustomList ID |  |
| **body** | **Object** |  | [optional]  |

### Return type

[**FollowListId200Response**](FollowListId200Response.md)

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
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

