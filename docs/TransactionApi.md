# IO.Swagger.Api.TransactionApi

All URIs are relative to *https://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Create**](TransactionApi.md#create) | **POST** /api/Transaction | Create a entity
[**Delete**](TransactionApi.md#delete) | **DELETE** /api/Transaction/{id} | Deletes and Entity
[**GenerateEntityInvestmentsGraphFor**](TransactionApi.md#generateentityinvestmentsgraphfor) | **GET** /api/Transaction/GenerateEntityInvestmentsGraphFor/{entityId} | Generically generates a series of datapoints representing for all or one of the entitiy types.  This includes the linking of it to other entity types by joining up all the resulting entities by common investments
[**GenerateSharedGraphDataForAll**](TransactionApi.md#generatesharedgraphdataforall) | **GET** /api/Transaction/GenerateSharedInvestmentsGraphDataForAll | Generically generates a series of datapoints representing for all or one of the entitiy types.  This includes the linking of it to other entity types by joining up all the resulting entities by common investments
[**GetAll**](TransactionApi.md#getall) | **GET** /api/Transaction | Get all entities
[**GetAllWithoutChildren**](TransactionApi.md#getallwithoutchildren) | **GET** /api/Transaction/WithoutChildren | Gets all entities but not their children
[**GetById**](TransactionApi.md#getbyid) | **GET** /api/Transaction/{id} | Get Entity by ID
[**Import**](TransactionApi.md#import) | **POST** /api/Transaction/import | 
[**Patch**](TransactionApi.md#patch) | **PATCH** /api/Transaction/{id} | Updates an entity partially
[**Replace**](TransactionApi.md#replace) | **PUT** /api/Transaction/{id} | Replaces and existing Entity.  Note this is not for partial updates, for that use PATCH. This is used for replacing the entire entity.  At the moment it is not possible to replace everything on the existing generic entity with that on the new one and  sometimes we dont want to: we dont want to replace the ID property for example, but we might want to replace  collections in the orignal item with the new collections in the new item, but this is currently not possible in the  implemantation. It just replaces simple members.  ** So if you want to do it propery, override this method in the controller for the type you want to implementa replacement  routine for.


<a name="create"></a>
# **Create**
> void Create (InvestmentTransaction entity = null)

Create a entity

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TransactionApi();
            var entity = new InvestmentTransaction(); // InvestmentTransaction | the entity to create (optional) 

            try
            {
                // Create a entity
                apiInstance.Create(entity);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TransactionApi.Create: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **entity** | [**InvestmentTransaction**](InvestmentTransaction.md)| the entity to create | [optional] 

### Return type

void (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="delete"></a>
# **Delete**
> void Delete (int? id)

Deletes and Entity

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TransactionApi();
            var id = 56;  // int? | The id of the entity to delete

            try
            {
                // Deletes and Entity
                apiInstance.Delete(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TransactionApi.Delete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| The id of the entity to delete | 

### Return type

void (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="generateentityinvestmentsgraphfor"></a>
# **GenerateEntityInvestmentsGraphFor**
> void GenerateEntityInvestmentsGraphFor (int? entityId)

Generically generates a series of datapoints representing for all or one of the entitiy types.  This includes the linking of it to other entity types by joining up all the resulting entities by common investments

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GenerateEntityInvestmentsGraphForExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TransactionApi();
            var entityId = 56;  // int? | 

            try
            {
                // Generically generates a series of datapoints representing for all or one of the entitiy types.  This includes the linking of it to other entity types by joining up all the resulting entities by common investments
                apiInstance.GenerateEntityInvestmentsGraphFor(entityId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TransactionApi.GenerateEntityInvestmentsGraphFor: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **entityId** | **int?**|  | 

### Return type

void (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="generatesharedgraphdataforall"></a>
# **GenerateSharedGraphDataForAll**
> void GenerateSharedGraphDataForAll ()

Generically generates a series of datapoints representing for all or one of the entitiy types.  This includes the linking of it to other entity types by joining up all the resulting entities by common investments

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GenerateSharedGraphDataForAllExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TransactionApi();

            try
            {
                // Generically generates a series of datapoints representing for all or one of the entitiy types.  This includes the linking of it to other entity types by joining up all the resulting entities by common investments
                apiInstance.GenerateSharedGraphDataForAll();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TransactionApi.GenerateSharedGraphDataForAll: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

void (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getall"></a>
# **GetAll**
> List<InvestmentTransaction> GetAll ()

Get all entities

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetAllExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TransactionApi();

            try
            {
                // Get all entities
                List&lt;InvestmentTransaction&gt; result = apiInstance.GetAll();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TransactionApi.GetAll: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<InvestmentTransaction>**](InvestmentTransaction.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getallwithoutchildren"></a>
# **GetAllWithoutChildren**
> List<InvestmentTransaction> GetAllWithoutChildren ()

Gets all entities but not their children

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetAllWithoutChildrenExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TransactionApi();

            try
            {
                // Gets all entities but not their children
                List&lt;InvestmentTransaction&gt; result = apiInstance.GetAllWithoutChildren();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TransactionApi.GetAllWithoutChildren: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<InvestmentTransaction>**](InvestmentTransaction.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getbyid"></a>
# **GetById**
> void GetById (int? id)

Get Entity by ID

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetByIdExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TransactionApi();
            var id = 56;  // int? | 

            try
            {
                // Get Entity by ID
                apiInstance.GetById(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TransactionApi.GetById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**|  | 

### Return type

void (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="import"></a>
# **Import**
> void Import (List<InvestmentTransaction> entities = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ImportExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TransactionApi();
            var entities = new List<InvestmentTransaction>(); // List<InvestmentTransaction> |  (optional) 

            try
            {
                apiInstance.Import(entities);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TransactionApi.Import: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **entities** | [**List&lt;InvestmentTransaction&gt;**](InvestmentTransaction.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="patch"></a>
# **Patch**
> void Patch (int? id, List<Operation> patchDocument = null)

Updates an entity partially

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PatchExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TransactionApi();
            var id = 56;  // int? | Id of entity to patch
            var patchDocument = new List<Operation>(); // List<Operation> | the patched object (optional) 

            try
            {
                // Updates an entity partially
                apiInstance.Patch(id, patchDocument);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TransactionApi.Patch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Id of entity to patch | 
 **patchDocument** | [**List&lt;Operation&gt;**](Operation.md)| the patched object | [optional] 

### Return type

void (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="replace"></a>
# **Replace**
> void Replace (int? id, InvestmentTransaction newItem = null)

Replaces and existing Entity.  Note this is not for partial updates, for that use PATCH. This is used for replacing the entire entity.  At the moment it is not possible to replace everything on the existing generic entity with that on the new one and  sometimes we dont want to: we dont want to replace the ID property for example, but we might want to replace  collections in the orignal item with the new collections in the new item, but this is currently not possible in the  implemantation. It just replaces simple members.  ** So if you want to do it propery, override this method in the controller for the type you want to implementa replacement  routine for.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ReplaceExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TransactionApi();
            var id = 56;  // int? | Id of the entity to update
            var newItem = new InvestmentTransaction(); // InvestmentTransaction | the contents of the entity to change (optional) 

            try
            {
                // Replaces and existing Entity.  Note this is not for partial updates, for that use PATCH. This is used for replacing the entire entity.  At the moment it is not possible to replace everything on the existing generic entity with that on the new one and  sometimes we dont want to: we dont want to replace the ID property for example, but we might want to replace  collections in the orignal item with the new collections in the new item, but this is currently not possible in the  implemantation. It just replaces simple members.  ** So if you want to do it propery, override this method in the controller for the type you want to implementa replacement  routine for.
                apiInstance.Replace(id, newItem);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TransactionApi.Replace: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Id of the entity to update | 
 **newItem** | [**InvestmentTransaction**](InvestmentTransaction.md)| the contents of the entity to change | [optional] 

### Return type

void (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

