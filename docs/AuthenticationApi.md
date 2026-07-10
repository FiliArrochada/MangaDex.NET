# MangaDex.Api.AuthenticationApi

All URIs are relative to *https://api.mangadex.org*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetAuthCheck**](AuthenticationApi.md#getauthcheck) | **GET** /auth/check | Check the set of permissions associated with the current token |
| [**PostAuthLogin**](AuthenticationApi.md#postauthlogin) | **POST** /auth/login | Login |
| [**PostAuthLogout**](AuthenticationApi.md#postauthlogout) | **POST** /auth/logout | Logout |
| [**PostAuthRefresh**](AuthenticationApi.md#postauthrefresh) | **POST** /auth/refresh | Refresh token |

<a id="getauthcheck"></a>
# **GetAuthCheck**
> CheckResponse GetAuthCheck ()

Check the set of permissions associated with the current token

The returned list of permissions is computed depending on the generic role permissions that the token user has, their personal overrides, and the OpenID scopes of the token (we do not offer granular token permissions yet) 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaDex.Api;
using MangaDex.Client;
using MangaDex.Model;

namespace Example
{
    public class GetAuthCheckExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangadex.org";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AuthenticationApi(config);

            try
            {
                // Check the set of permissions associated with the current token
                CheckResponse result = apiInstance.GetAuthCheck();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthenticationApi.GetAuthCheck: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAuthCheckWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Check the set of permissions associated with the current token
    ApiResponse<CheckResponse> response = apiInstance.GetAuthCheckWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AuthenticationApi.GetAuthCheckWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**CheckResponse**](CheckResponse.md)

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

<a id="postauthlogin"></a>
# **PostAuthLogin**
> LoginResponse PostAuthLogin (string contentType, Login login = null)

Login

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaDex.Api;
using MangaDex.Client;
using MangaDex.Model;

namespace Example
{
    public class PostAuthLoginExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangadex.org";
            var apiInstance = new AuthenticationApi(config);
            var contentType = "\"application/json\"";  // string |  (default to "application/json")
            var login = new Login(); // Login | The size of the body is limited to 2KB. (optional) 

            try
            {
                // Login
                LoginResponse result = apiInstance.PostAuthLogin(contentType, login);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthenticationApi.PostAuthLogin: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostAuthLoginWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Login
    ApiResponse<LoginResponse> response = apiInstance.PostAuthLoginWithHttpInfo(contentType, login);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AuthenticationApi.PostAuthLoginWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **contentType** | **string** |  | [default to &quot;application/json&quot;] |
| **login** | [**Login**](Login.md) | The size of the body is limited to 2KB. | [optional]  |

### Return type

[**LoginResponse**](LoginResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="postauthlogout"></a>
# **PostAuthLogout**
> LogoutResponse PostAuthLogout ()

Logout

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaDex.Api;
using MangaDex.Client;
using MangaDex.Model;

namespace Example
{
    public class PostAuthLogoutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangadex.org";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AuthenticationApi(config);

            try
            {
                // Logout
                LogoutResponse result = apiInstance.PostAuthLogout();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthenticationApi.PostAuthLogout: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostAuthLogoutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Logout
    ApiResponse<LogoutResponse> response = apiInstance.PostAuthLogoutWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AuthenticationApi.PostAuthLogoutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**LogoutResponse**](LogoutResponse.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **503** | Service Unavailable |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="postauthrefresh"></a>
# **PostAuthRefresh**
> RefreshResponse PostAuthRefresh (string contentType, RefreshToken refreshToken = null)

Refresh token

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaDex.Api;
using MangaDex.Client;
using MangaDex.Model;

namespace Example
{
    public class PostAuthRefreshExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangadex.org";
            var apiInstance = new AuthenticationApi(config);
            var contentType = "\"application/json\"";  // string |  (default to "application/json")
            var refreshToken = new RefreshToken(); // RefreshToken | The size of the body is limited to 2KB. (optional) 

            try
            {
                // Refresh token
                RefreshResponse result = apiInstance.PostAuthRefresh(contentType, refreshToken);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthenticationApi.PostAuthRefresh: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostAuthRefreshWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Refresh token
    ApiResponse<RefreshResponse> response = apiInstance.PostAuthRefreshWithHttpInfo(contentType, refreshToken);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AuthenticationApi.PostAuthRefreshWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **contentType** | **string** |  | [default to &quot;application/json&quot;] |
| **refreshToken** | [**RefreshToken**](RefreshToken.md) | The size of the body is limited to 2KB. | [optional]  |

### Return type

[**RefreshResponse**](RefreshResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

