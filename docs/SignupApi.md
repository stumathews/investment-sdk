# IO.Swagger.Api.SignupApi

All URIs are relative to *https://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Signup**](SignupApi.md#signup) | **POST** /api/Signup | Creates a new user


<a name="signup"></a>
# **Signup**
> void Signup (SignupDetails signupDetails = null)

Creates a new user

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SignupExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SignupApi();
            var signupDetails = new SignupDetails(); // SignupDetails |  (optional) 

            try
            {
                // Creates a new user
                apiInstance.Signup(signupDetails);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SignupApi.Signup: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **signupDetails** | [**SignupDetails**](SignupDetails.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

