# MangaDex.Api.CaptchaApi

All URIs are relative to *https://api.mangadex.org*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**PostCaptchaSolve**](CaptchaApi.md#postcaptchasolve) | **POST** /captcha/solve | Solve Captcha |

<a id="postcaptchasolve"></a>
# **PostCaptchaSolve**
> PostCaptchaSolve200Response PostCaptchaSolve (string contentType, PostCaptchaSolveRequest postCaptchaSolveRequest = null)

Solve Captcha

Captchas can be solved explicitly through this endpoint, another way is to add a `X-Captcha-Result` header to any request. The same logic will verify the captcha and is probably more convenient because it takes one less request.  Authentication is optional. Captchas are tracked for both the client ip and for the user id, if you are logged in you want to send your session token but that is not required.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaDex.Api;
using MangaDex.Client;
using MangaDex.Model;

namespace Example
{
    public class PostCaptchaSolveExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangadex.org";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new CaptchaApi(config);
            var contentType = "\"application/json\"";  // string |  (default to "application/json")
            var postCaptchaSolveRequest = new PostCaptchaSolveRequest(); // PostCaptchaSolveRequest |  (optional) 

            try
            {
                // Solve Captcha
                PostCaptchaSolve200Response result = apiInstance.PostCaptchaSolve(contentType, postCaptchaSolveRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CaptchaApi.PostCaptchaSolve: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostCaptchaSolveWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Solve Captcha
    ApiResponse<PostCaptchaSolve200Response> response = apiInstance.PostCaptchaSolveWithHttpInfo(contentType, postCaptchaSolveRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CaptchaApi.PostCaptchaSolveWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **contentType** | **string** |  | [default to &quot;application/json&quot;] |
| **postCaptchaSolveRequest** | [**PostCaptchaSolveRequest**](PostCaptchaSolveRequest.md) |  | [optional]  |

### Return type

[**PostCaptchaSolve200Response**](PostCaptchaSolve200Response.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK: Captcha has been solved |  -  |
| **400** | Bad Request: Captcha challenge result was wrong, the Captcha Verification service was down or other, refer to the error message and the errorCode inside the error context |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

