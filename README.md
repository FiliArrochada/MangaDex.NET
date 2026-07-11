# MangaDex - the C# library for the MangaDex API

MangaDex is an ad-free manga reader offering high-quality images!

This document details our API as it is right now. It is in no way a promise to never change it, although we will endeavour to publicly notify any major change.

# Acceptable use policy

Usage of our services implies acceptance of the following:
- You **MUST** credit us
- You **MUST** credit scanlation groups if you offer the ability to read chapters
- You **CANNOT** run ads or paid services on your website and/or apps

These may change at any time for any and no reason and it is up to you check for updates from time to time.

# Security issues

If you believe you found a security issue in our API, please check our [security.txt](/security.txt) to get in touch privately.


This C# SDK was originally generated from the MangaDex OpenAPI specification by the [OpenAPI Generator](https://openapi-generator.tech) project. It has since been migrated to System.Text.Json and is now **maintained by hand** — it is no longer regenerated, so updates are applied directly to the source and kept in sync with the spec manually.

- API version: 5.13.1
- SDK version: 0.1.0
- Source specification: [api/openapi.yaml](api/openapi.yaml)

<a id="frameworks-supported"></a>
## Frameworks supported
- .NET 8.0

<a id="dependencies"></a>
## Dependencies

- [RestSharp](https://www.nuget.org/packages/RestSharp) - 114.0.0 or later
- [System.Text.Json](https://www.nuget.org/packages/System.Text.Json/) - 10.0.9 or later
- [Refit](https://www.nuget.org/packages/Refit/) - 13.1.0 or later
- [Polly](https://www.nuget.org/packages/Polly/) - 8.7.0 or later
- [System.ComponentModel.Annotations](https://www.nuget.org/packages/System.ComponentModel.Annotations) - 5.0.0 or later

The DLLs included in the package may not be the latest version. We recommend using [NuGet](https://docs.nuget.org/consume/installing-nuget) to obtain the latest version of the packages:
```
Install-Package RestSharp
Install-Package System.Text.Json
Install-Package Refit
Install-Package Polly
Install-Package System.ComponentModel.Annotations
```

<a id="installation"></a>
## Installation
Generate the DLL using your preferred tool (e.g. `dotnet build`)

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:
```csharp
using MangaDex.Api;
using MangaDex.Client;
using MangaDex.Model;
```
<a id="usage"></a>
## Usage

To use the API client with a HTTP proxy, setup a `System.Net.WebProxy`
```csharp
Configuration c = new Configuration();
System.Net.WebProxy webProxy = new System.Net.WebProxy("http://myProxyUrl:80/");
webProxy.Credentials = System.Net.CredentialCache.DefaultCredentials;
c.Proxy = webProxy;
```

<a id="getting-started"></a>
## Getting Started

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaDex.Api;
using MangaDex.Client;
using MangaDex.Model;

namespace Example
{
    public class Example
    {
        public static void Main()
        {

            Configuration config = new Configuration();
            config.BasePath = "https://api.mangadex.org";
            var apiInstance = new InfrastructureApi(config);

            try
            {
                // Ping healthcheck
                string result = apiInstance.GetPing();
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling InfrastructureApi.GetPing: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }

        }
    }
}
```

<a id="documentation-for-authorization"></a>
## Documentation for Authorization


Authentication schemes defined for the API:
<a id="Bearer"></a>
### Bearer

- **Type**: Bearer Authentication

