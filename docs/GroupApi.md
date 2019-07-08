# IO.Swagger.Api.GroupApi

All URIs are relative to *https://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Create**](GroupApi.md#create) | **POST** /api/Group | Create a entity
[**Delete**](GroupApi.md#delete) | **DELETE** /api/Group/{id} | Deletes and Entity
[**GenerateEntityInvestmentsGraphFor**](GroupApi.md#generateentityinvestmentsgraphfor) | **GET** /api/Group/GenerateEntityInvestmentsGraphFor/{entityId} | Generically generates a series of datapoints representing for all or one of the entitiy types.  This includes the linking of it to other entity types by joining up all the resulting entities by common investments
[**GenerateSharedGraphDataForAll**](GroupApi.md#generatesharedgraphdataforall) | **GET** /api/Group/GenerateSharedInvestmentsGraphDataForAll | Generically generates a series of datapoints representing for all or one of the entitiy types.  This includes the linking of it to other entity types by joining up all the resulting entities by common investments
[**GetAll**](GroupApi.md#getall) | **GET** /api/Group | Get all entities
[**GetAllWithoutChildren**](GroupApi.md#getallwithoutchildren) | **GET** /api/Group/WithoutChildren | Gets all entities but not their children
[**GetById**](GroupApi.md#getbyid) | **GET** /api/Group/{id} | Get Entity by ID
[**Import**](GroupApi.md#import) | **POST** /api/Group/import | 
[**Patch**](GroupApi.md#patch) | **PATCH** /api/Group/{id} | Updates an entity partially
[**Replace**](GroupApi.md#replace) | **PUT** /api/Group/{id} | Replaces and existing Entity.  Note this is not for partial updates, for that use PATCH. This is used for replacing the entire entity.  At the moment it is not possible to replace everything on the existing generic entity with that on the new one and  sometimes we dont want to: we dont want to replace the ID property for example, but we might want to replace  collections in the orignal item with the new collections in the new item, but this is currently not possible in the  implemantation. It just replaces simple members.  ** So if you want to do it propery, override this method in the controller for the type you want to implementa replacement  routine for.


<a name="create"></a>
# **Create**
> void Create (InvestmentGroup entity = null)

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

            var apiInstance = new GroupApi();
            var entity = new InvestmentGroup(); // InvestmentGroup | the entity to create (optional) 

            try
            {
                // Create a entity
                apiInstance.Create(entity);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupApi.Create: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **entity** | [**InvestmentGroup**](InvestmentGroup.md)| the entity to create | [optional] 

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

            var apiInstance = new GroupApi();
            var id = 56;  // int? | The id of the entity to delete

            try
            {
                // Deletes and Entity
                apiInstance.Delete(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupApi.Delete: " + e.Message );
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

            var apiInstance = new GroupApi();
            var entityId = 56;  // int? | 

            try
            {
                // Generically generates a series of datapoints representing for all or one of the entitiy types.  This includes the linking of it to other entity types by joining up all the resulting entities by common investments
                apiInstance.GenerateEntityInvestmentsGraphFor(entityId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupApi.GenerateEntityInvestmentsGraphFor: " + e.Message );
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

            var apiInstance = new GroupApi();

            try
            {
                // Generically generates a series of datapoints representing for all or one of the entitiy types.  This includes the linking of it to other entity types by joining up all the resulting entities by common investments
                apiInstance.GenerateSharedGraphDataForAll();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupApi.GenerateSharedGraphDataForAll: " + e.Message );
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
> List<InvestmentGroup> GetAll ()

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

            var apiInstance = new GroupApi();

            try
            {
                // Get all entities
                List&lt;InvestmentGroup&gt; result = apiInstance.GetAll();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupApi.GetAll: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<InvestmentGroup>**](InvestmentGroup.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getallwithoutchildren"></a>
# **GetAllWithoutChildren**
> List<InvestmentGroup> GetAllWithoutChildren ()

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

            var apiInstance = new GroupApi();

            try
            {
                // Gets all entities but not their children
                List&lt;InvestmentGroup&gt; result = apiInstance.GetAllWithoutChildren();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupApi.GetAllWithoutChildren: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<InvestmentGroup>**](InvestmentGroup.md)

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

            var apiInstance = new GroupApi();
            var id = 56;  // int? | 

            try
            {
                // Get Entity by ID
                apiInstance.GetById(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupApi.GetById: " + e.Message );
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
> void Import (List<InvestmentGroup> entities = null)



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

            var apiInstance = new GroupApi();
            var entities = new List<InvestmentGroup>(); // List<InvestmentGroup> |  (optional) 

            try
            {
                apiInstance.Import(entities);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupApi.Import: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **entities** | [**List&lt;InvestmentGroup&gt;**](InvestmentGroup.md)|  | [optional] 

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

            var apiInstance = new GroupApi();
            var id = 56;  // int? | Id of entity to patch
            var patchDocument = new List<Operation>(); // List<Operation> | the patched object (optional) 

            try
            {
                // Updates an entity partially
                apiInstance.Patch(id, patchDocument);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupApi.Patch: " + e.Message );
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
> void Replace (int? id, InvestmentGroup newItem = null)

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

            var apiInstance = new GroupApi();
            var id = 56;  // int? | Id of the entity to update
            var newItem = new InvestmentGroup(); // InvestmentGroup | the contents of the entity to change (optional) 

            try
            {
                // Replaces and existing Entity.  Note this is not for partial updates, for that use PATCH. This is used for replacing the entire entity.  At the moment it is not possible to replace everything on the existing generic entity with that on the new one and  sometimes we dont want to: we dont want to replace the ID property for example, but we might want to replace  collections in the orignal item with the new collections in the new item, but this is currently not possible in the  implemantation. It just replaces simple members.  ** So if you want to do it propery, override this method in the controller for the type you want to implementa replacement  routine for.
                apiInstance.Replace(id, newItem);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupApi.Replace: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Id of the entity to update | 
 **newItem** | [**InvestmentGroup**](InvestmentGroup.md)| the contents of the entity to change | [optional] 

### Return type

void (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

