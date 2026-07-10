# MangaDex.Api.AccountApi

All URIs are relative to *https://api.mangadex.org*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetAccountActivateCode**](AccountApi.md#getaccountactivatecode) | **POST** /account/activate/{code} | Activate account |
| [**GetAccountAvailable**](AccountApi.md#getaccountavailable) | **GET** /account/available | Account username available |
| [**PostAccountActivateResend**](AccountApi.md#postaccountactivateresend) | **POST** /account/activate/resend | Resend Activation code |
| [**PostAccountCreate**](AccountApi.md#postaccountcreate) | **POST** /account/create | Create Account |
| [**PostAccountRecover**](AccountApi.md#postaccountrecover) | **POST** /account/recover | Recover given Account |
| [**PostAccountRecoverCode**](AccountApi.md#postaccountrecovercode) | **POST** /account/recover/{code} | Complete Account recover |

<a id="getaccountactivatecode"></a>
# **GetAccountActivateCode**
> AccountActivateResponse GetAccountActivateCode (string code)

Activate account

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaDex.Api;
using MangaDex.Client;
using MangaDex.Model;

namespace Example
{
    public class GetAccountActivateCodeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangadex.org";
            var apiInstance = new AccountApi(config);
            var code = "code_example";  // string | 

            try
            {
                // Activate account
                AccountActivateResponse result = apiInstance.GetAccountActivateCode(code);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountApi.GetAccountActivateCode: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAccountActivateCodeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Activate account
    ApiResponse<AccountActivateResponse> response = apiInstance.GetAccountActivateCodeWithHttpInfo(code);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountApi.GetAccountActivateCodeWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **code** | **string** |  |  |

### Return type

[**AccountActivateResponse**](AccountActivateResponse.md)

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
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getaccountavailable"></a>
# **GetAccountAvailable**
> GetAccountAvailable200Response GetAccountAvailable (string username)

Account username available

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaDex.Api;
using MangaDex.Client;
using MangaDex.Model;

namespace Example
{
    public class GetAccountAvailableExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangadex.org";
            var apiInstance = new AccountApi(config);
            var username = "username_example";  // string | Username to check for avaibility

            try
            {
                // Account username available
                GetAccountAvailable200Response result = apiInstance.GetAccountAvailable(username);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountApi.GetAccountAvailable: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAccountAvailableWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Account username available
    ApiResponse<GetAccountAvailable200Response> response = apiInstance.GetAccountAvailableWithHttpInfo(username);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountApi.GetAccountAvailableWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **username** | **string** | Username to check for avaibility |  |

### Return type

[**GetAccountAvailable200Response**](GetAccountAvailable200Response.md)

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="postaccountactivateresend"></a>
# **PostAccountActivateResend**
> AccountActivateResponse PostAccountActivateResend (string contentType, SendAccountActivationCode sendAccountActivationCode = null)

Resend Activation code

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaDex.Api;
using MangaDex.Client;
using MangaDex.Model;

namespace Example
{
    public class PostAccountActivateResendExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangadex.org";
            var apiInstance = new AccountApi(config);
            var contentType = "\"application/json\"";  // string |  (default to "application/json")
            var sendAccountActivationCode = new SendAccountActivationCode(); // SendAccountActivationCode | The size of the body is limited to 1KB. (optional) 

            try
            {
                // Resend Activation code
                AccountActivateResponse result = apiInstance.PostAccountActivateResend(contentType, sendAccountActivationCode);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountApi.PostAccountActivateResend: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostAccountActivateResendWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Resend Activation code
    ApiResponse<AccountActivateResponse> response = apiInstance.PostAccountActivateResendWithHttpInfo(contentType, sendAccountActivationCode);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountApi.PostAccountActivateResendWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **contentType** | **string** |  | [default to &quot;application/json&quot;] |
| **sendAccountActivationCode** | [**SendAccountActivationCode**](SendAccountActivationCode.md) | The size of the body is limited to 1KB. | [optional]  |

### Return type

[**AccountActivateResponse**](AccountActivateResponse.md)

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="postaccountcreate"></a>
# **PostAccountCreate**
> UserResponse PostAccountCreate (string contentType, CreateAccount createAccount = null)

Create Account

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaDex.Api;
using MangaDex.Client;
using MangaDex.Model;

namespace Example
{
    public class PostAccountCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangadex.org";
            var apiInstance = new AccountApi(config);
            var contentType = "\"application/json\"";  // string |  (default to "application/json")
            var createAccount = new CreateAccount(); // CreateAccount | The size of the body is limited to 4KB. (optional) 

            try
            {
                // Create Account
                UserResponse result = apiInstance.PostAccountCreate(contentType, createAccount);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountApi.PostAccountCreate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostAccountCreateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create Account
    ApiResponse<UserResponse> response = apiInstance.PostAccountCreateWithHttpInfo(contentType, createAccount);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountApi.PostAccountCreateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **contentType** | **string** |  | [default to &quot;application/json&quot;] |
| **createAccount** | [**CreateAccount**](CreateAccount.md) | The size of the body is limited to 4KB. | [optional]  |

### Return type

[**UserResponse**](UserResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Created |  -  |
| **400** | Bad Request |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="postaccountrecover"></a>
# **PostAccountRecover**
> AccountActivateResponse PostAccountRecover (string contentType, SendAccountActivationCode sendAccountActivationCode = null)

Recover given Account

You can only request Account Recovery once per Hour for the same Email Address

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaDex.Api;
using MangaDex.Client;
using MangaDex.Model;

namespace Example
{
    public class PostAccountRecoverExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangadex.org";
            var apiInstance = new AccountApi(config);
            var contentType = "\"application/json\"";  // string |  (default to "application/json")
            var sendAccountActivationCode = new SendAccountActivationCode(); // SendAccountActivationCode | The size of the body is limited to 1KB. (optional) 

            try
            {
                // Recover given Account
                AccountActivateResponse result = apiInstance.PostAccountRecover(contentType, sendAccountActivationCode);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountApi.PostAccountRecover: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostAccountRecoverWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Recover given Account
    ApiResponse<AccountActivateResponse> response = apiInstance.PostAccountRecoverWithHttpInfo(contentType, sendAccountActivationCode);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountApi.PostAccountRecoverWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **contentType** | **string** |  | [default to &quot;application/json&quot;] |
| **sendAccountActivationCode** | [**SendAccountActivationCode**](SendAccountActivationCode.md) | The size of the body is limited to 1KB. | [optional]  |

### Return type

[**AccountActivateResponse**](AccountActivateResponse.md)

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="postaccountrecovercode"></a>
# **PostAccountRecoverCode**
> AccountActivateResponse PostAccountRecoverCode (string code, string contentType, RecoverCompleteBody recoverCompleteBody = null)

Complete Account recover

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaDex.Api;
using MangaDex.Client;
using MangaDex.Model;

namespace Example
{
    public class PostAccountRecoverCodeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangadex.org";
            var apiInstance = new AccountApi(config);
            var code = "code_example";  // string | 
            var contentType = "\"application/json\"";  // string |  (default to "application/json")
            var recoverCompleteBody = new RecoverCompleteBody(); // RecoverCompleteBody | The size of the body is limited to 2KB. (optional) 

            try
            {
                // Complete Account recover
                AccountActivateResponse result = apiInstance.PostAccountRecoverCode(code, contentType, recoverCompleteBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountApi.PostAccountRecoverCode: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostAccountRecoverCodeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Complete Account recover
    ApiResponse<AccountActivateResponse> response = apiInstance.PostAccountRecoverCodeWithHttpInfo(code, contentType, recoverCompleteBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountApi.PostAccountRecoverCodeWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **code** | **string** |  |  |
| **contentType** | **string** |  | [default to &quot;application/json&quot;] |
| **recoverCompleteBody** | [**RecoverCompleteBody**](RecoverCompleteBody.md) | The size of the body is limited to 2KB. | [optional]  |

### Return type

[**AccountActivateResponse**](AccountActivateResponse.md)

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

