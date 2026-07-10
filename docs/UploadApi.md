# MangaDex.Api.UploadApi

All URIs are relative to *https://api.mangadex.org*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AbandonUploadSession**](UploadApi.md#abandonuploadsession) | **DELETE** /upload/{uploadSessionId} | Abandon upload session |
| [**BeginEditSession**](UploadApi.md#begineditsession) | **POST** /upload/begin/{chapterId} | Start an edit chapter session |
| [**BeginUploadSession**](UploadApi.md#beginuploadsession) | **POST** /upload/begin | Start an upload session |
| [**CommitUploadSession**](UploadApi.md#commituploadsession) | **POST** /upload/{uploadSessionId}/commit | Commit the upload session and specify chapter data |
| [**DeleteUploadedSessionFile**](UploadApi.md#deleteuploadedsessionfile) | **DELETE** /upload/{uploadSessionId}/{uploadSessionFileId} | Delete an uploaded image from the Upload Session |
| [**DeleteUploadedSessionFiles**](UploadApi.md#deleteuploadedsessionfiles) | **DELETE** /upload/{uploadSessionId}/batch | Delete a set of uploaded images from the Upload Session |
| [**GetUploadSession**](UploadApi.md#getuploadsession) | **GET** /upload | Get the current User upload session |
| [**PutUploadSessionFile**](UploadApi.md#putuploadsessionfile) | **POST** /upload/{uploadSessionId} | Upload images to the upload session |

<a id="abandonuploadsession"></a>
# **AbandonUploadSession**
> Response AbandonUploadSession (Guid uploadSessionId)

Abandon upload session

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaDex.Api;
using MangaDex.Client;
using MangaDex.Model;

namespace Example
{
    public class AbandonUploadSessionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangadex.org";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UploadApi(config);
            var uploadSessionId = "uploadSessionId_example";  // Guid | 

            try
            {
                // Abandon upload session
                Response result = apiInstance.AbandonUploadSession(uploadSessionId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UploadApi.AbandonUploadSession: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AbandonUploadSessionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Abandon upload session
    ApiResponse<Response> response = apiInstance.AbandonUploadSessionWithHttpInfo(uploadSessionId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UploadApi.AbandonUploadSessionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **uploadSessionId** | **Guid** |  |  |

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="begineditsession"></a>
# **BeginEditSession**
> UploadSession BeginEditSession (Guid chapterId, string contentType, BeginEditSession beginEditSession = null)

Start an edit chapter session

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaDex.Api;
using MangaDex.Client;
using MangaDex.Model;

namespace Example
{
    public class BeginEditSessionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangadex.org";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UploadApi(config);
            var chapterId = "chapterId_example";  // Guid | 
            var contentType = "\"application/json\"";  // string |  (default to "application/json")
            var beginEditSession = new BeginEditSession(); // BeginEditSession | The size of the body is limited to 1KB. (optional) 

            try
            {
                // Start an edit chapter session
                UploadSession result = apiInstance.BeginEditSession(chapterId, contentType, beginEditSession);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UploadApi.BeginEditSession: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the BeginEditSessionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Start an edit chapter session
    ApiResponse<UploadSession> response = apiInstance.BeginEditSessionWithHttpInfo(chapterId, contentType, beginEditSession);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UploadApi.BeginEditSessionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **chapterId** | **Guid** |  |  |
| **contentType** | **string** |  | [default to &quot;application/json&quot;] |
| **beginEditSession** | [**BeginEditSession**](BeginEditSession.md) | The size of the body is limited to 1KB. | [optional]  |

### Return type

[**UploadSession**](UploadSession.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request if Chapter&#39;s Manga is unpublished |  -  |
| **401** | Unauthorized if user does not have upload permissions or has no rights to edit the chapter (needs to be uploader or group member) |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="beginuploadsession"></a>
# **BeginUploadSession**
> UploadSession BeginUploadSession (string contentType, BeginUploadSession beginUploadSession = null)

Start an upload session

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaDex.Api;
using MangaDex.Client;
using MangaDex.Model;

namespace Example
{
    public class BeginUploadSessionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangadex.org";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UploadApi(config);
            var contentType = "\"application/json\"";  // string |  (default to "application/json")
            var beginUploadSession = new BeginUploadSession(); // BeginUploadSession | The size of the body is limited to 4KB. (optional) 

            try
            {
                // Start an upload session
                UploadSession result = apiInstance.BeginUploadSession(contentType, beginUploadSession);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UploadApi.BeginUploadSession: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the BeginUploadSessionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Start an upload session
    ApiResponse<UploadSession> response = apiInstance.BeginUploadSessionWithHttpInfo(contentType, beginUploadSession);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UploadApi.BeginUploadSessionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **contentType** | **string** |  | [default to &quot;application/json&quot;] |
| **beginUploadSession** | [**BeginUploadSession**](BeginUploadSession.md) | The size of the body is limited to 4KB. | [optional]  |

### Return type

[**UploadSession**](UploadSession.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="commituploadsession"></a>
# **CommitUploadSession**
> Chapter CommitUploadSession (Guid uploadSessionId, string contentType, CommitUploadSession commitUploadSession = null)

Commit the upload session and specify chapter data

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaDex.Api;
using MangaDex.Client;
using MangaDex.Model;

namespace Example
{
    public class CommitUploadSessionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangadex.org";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UploadApi(config);
            var uploadSessionId = "uploadSessionId_example";  // Guid | 
            var contentType = "\"application/json\"";  // string |  (default to "application/json")
            var commitUploadSession = new CommitUploadSession(); // CommitUploadSession | The size of the body is limited to 4KB. (optional) 

            try
            {
                // Commit the upload session and specify chapter data
                Chapter result = apiInstance.CommitUploadSession(uploadSessionId, contentType, commitUploadSession);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UploadApi.CommitUploadSession: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CommitUploadSessionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Commit the upload session and specify chapter data
    ApiResponse<Chapter> response = apiInstance.CommitUploadSessionWithHttpInfo(uploadSessionId, contentType, commitUploadSession);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UploadApi.CommitUploadSessionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **uploadSessionId** | **Guid** |  |  |
| **contentType** | **string** |  | [default to &quot;application/json&quot;] |
| **commitUploadSession** | [**CommitUploadSession**](CommitUploadSession.md) | The size of the body is limited to 4KB. | [optional]  |

### Return type

[**Chapter**](Chapter.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deleteuploadedsessionfile"></a>
# **DeleteUploadedSessionFile**
> Response DeleteUploadedSessionFile (Guid uploadSessionId, Guid uploadSessionFileId)

Delete an uploaded image from the Upload Session

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaDex.Api;
using MangaDex.Client;
using MangaDex.Model;

namespace Example
{
    public class DeleteUploadedSessionFileExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangadex.org";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UploadApi(config);
            var uploadSessionId = "uploadSessionId_example";  // Guid | 
            var uploadSessionFileId = "uploadSessionFileId_example";  // Guid | 

            try
            {
                // Delete an uploaded image from the Upload Session
                Response result = apiInstance.DeleteUploadedSessionFile(uploadSessionId, uploadSessionFileId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UploadApi.DeleteUploadedSessionFile: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteUploadedSessionFileWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete an uploaded image from the Upload Session
    ApiResponse<Response> response = apiInstance.DeleteUploadedSessionFileWithHttpInfo(uploadSessionId, uploadSessionFileId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UploadApi.DeleteUploadedSessionFileWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **uploadSessionId** | **Guid** |  |  |
| **uploadSessionFileId** | **Guid** |  |  |

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deleteuploadedsessionfiles"></a>
# **DeleteUploadedSessionFiles**
> Response DeleteUploadedSessionFiles (Guid uploadSessionId, string contentType, List<Guid> requestBody = null)

Delete a set of uploaded images from the Upload Session

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaDex.Api;
using MangaDex.Client;
using MangaDex.Model;

namespace Example
{
    public class DeleteUploadedSessionFilesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangadex.org";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UploadApi(config);
            var uploadSessionId = "uploadSessionId_example";  // Guid | 
            var contentType = "\"application/json\"";  // string |  (default to "application/json")
            var requestBody = new List<Guid>(); // List<Guid> | The size of the body is limited to 20KB. (optional) 

            try
            {
                // Delete a set of uploaded images from the Upload Session
                Response result = apiInstance.DeleteUploadedSessionFiles(uploadSessionId, contentType, requestBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UploadApi.DeleteUploadedSessionFiles: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteUploadedSessionFilesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete a set of uploaded images from the Upload Session
    ApiResponse<Response> response = apiInstance.DeleteUploadedSessionFilesWithHttpInfo(uploadSessionId, contentType, requestBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UploadApi.DeleteUploadedSessionFilesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **uploadSessionId** | **Guid** |  |  |
| **contentType** | **string** |  | [default to &quot;application/json&quot;] |
| **requestBody** | [**List&lt;Guid&gt;**](Guid.md) | The size of the body is limited to 20KB. | [optional]  |

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
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getuploadsession"></a>
# **GetUploadSession**
> UploadSession GetUploadSession ()

Get the current User upload session

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaDex.Api;
using MangaDex.Client;
using MangaDex.Model;

namespace Example
{
    public class GetUploadSessionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangadex.org";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UploadApi(config);

            try
            {
                // Get the current User upload session
                UploadSession result = apiInstance.GetUploadSession();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UploadApi.GetUploadSession: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetUploadSessionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get the current User upload session
    ApiResponse<UploadSession> response = apiInstance.GetUploadSessionWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UploadApi.GetUploadSessionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**UploadSession**](UploadSession.md)

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

<a id="putuploadsessionfile"></a>
# **PutUploadSessionFile**
> PutUploadSessionFile200Response PutUploadSessionFile (Guid uploadSessionId, string contentType, System.IO.Stream file = null)

Upload images to the upload session

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaDex.Api;
using MangaDex.Client;
using MangaDex.Model;

namespace Example
{
    public class PutUploadSessionFileExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangadex.org";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UploadApi(config);
            var uploadSessionId = "uploadSessionId_example";  // Guid | 
            var contentType = "\"application/json\"";  // string |  (default to "application/json")
            var file = new System.IO.MemoryStream(System.IO.File.ReadAllBytes("/path/to/file.txt"));  // System.IO.Stream |  (optional) 

            try
            {
                // Upload images to the upload session
                PutUploadSessionFile200Response result = apiInstance.PutUploadSessionFile(uploadSessionId, contentType, file);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UploadApi.PutUploadSessionFile: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PutUploadSessionFileWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Upload images to the upload session
    ApiResponse<PutUploadSessionFile200Response> response = apiInstance.PutUploadSessionFileWithHttpInfo(uploadSessionId, contentType, file);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UploadApi.PutUploadSessionFileWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **uploadSessionId** | **Guid** |  |  |
| **contentType** | **string** |  | [default to &quot;application/json&quot;] |
| **file** | **System.IO.Stream****System.IO.Stream** |  | [optional]  |

### Return type

[**PutUploadSessionFile200Response**](PutUploadSessionFile200Response.md)

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

