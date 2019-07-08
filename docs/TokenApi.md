# IO.Swagger.Api.TokenApi

All URIs are relative to *https://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateToken**](TokenApi.md#createtoken) | **POST** /api/Token | Creates a token once it validates the login details


<a name="createtoken"></a>
# **CreateToken**
> void CreateToken (UserLoginInfo login = null)

Creates a token once it validates the login details

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateTokenExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TokenApi();
            var login = new UserLoginInfo(); // UserLoginInfo | login details (optional) 

            try
            {
                // Creates a token once it validates the login details
                apiInstance.CreateToken(login);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TokenApi.CreateToken: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **login** | [**UserLoginInfo**](UserLoginInfo.md)| login details | [optional] 

### Return type

void (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

