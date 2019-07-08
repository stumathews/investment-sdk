# IO.Swagger.Api.CustomEntityApi

All URIs are relative to *https://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AllByType**](CustomEntityApi.md#allbytype) | **GET** /api/CustomEntity/ByType/{type} | Gets all the custom entities for a particular type
[**ByType**](CustomEntityApi.md#bytype) | **GET** /api/CustomEntity/ByType/{type}/{id} | Gets all the custom entities for a particular type
[**Create**](CustomEntityApi.md#create) | **POST** /api/CustomEntity | Create a custom entity and if there is an associated custom entity type, looks it up and asosciates it with it,  otherwise the type is set to null
[**Delete**](CustomEntityApi.md#delete) | **DELETE** /api/CustomEntity/{id} | Deletes and Entity
[**GenerateEntityInvestmentsGraphFor**](CustomEntityApi.md#generateentityinvestmentsgraphfor) | **GET** /api/CustomEntity/GenerateEntityInvestmentsGraphFor/{entityId} | Generically generates a series of datapoints representing for all or one of the entitiy types.  This includes the linking of it to other entity types by joining up all the resulting entities by common investments
[**GenerateSharedGraphDataForAll**](CustomEntityApi.md#generatesharedgraphdataforall) | **GET** /api/CustomEntity/GenerateSharedInvestmentsGraphDataForAll | Generically generates a series of datapoints representing for all or one of the entitiy types.  This includes the linking of it to other entity types by joining up all the resulting entities by common investments
[**GetAll**](CustomEntityApi.md#getall) | **GET** /api/CustomEntity | Get all entities
[**GetAllWithoutChildren**](CustomEntityApi.md#getallwithoutchildren) | **GET** /api/CustomEntity/WithoutChildren | Gets all entities but not their children
[**GetById**](CustomEntityApi.md#getbyid) | **GET** /api/CustomEntity/{id} | Get Entity by ID
[**Import**](CustomEntityApi.md#import) | **POST** /api/CustomEntity/import | 
[**Patch**](CustomEntityApi.md#patch) | **PATCH** /api/CustomEntity/{id} | Updates an entity partially
[**Replace**](CustomEntityApi.md#replace) | **PUT** /api/CustomEntity/{id} | Replaces and existing Entity.  Note this is not for partial updates, for that use PATCH. This is used for replacing the entire entity.  At the moment it is not possible to replace everything on the existing generic entity with that on the new one and  sometimes we dont want to: we dont want to replace the ID property for example, but we might want to replace  collections in the orignal item with the new collections in the new item, but this is currently not possible in the  implemantation. It just replaces simple members.  ** So if you want to do it propery, override this method in the controller for the type you want to implementa replacement  routine for.


<a name="allbytype"></a>
# **AllByType**
> List<CustomEntity> AllByType (string type)

Gets all the custom entities for a particular type

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AllByTypeExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new CustomEntityApi();
            var type = type_example;  // string | the type of entities to fetch

            try
            {
                // Gets all the custom entities for a particular type
                List&lt;CustomEntity&gt; result = apiInstance.AllByType(type);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomEntityApi.AllByType: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **type** | **string**| the type of entities to fetch | 

### Return type

[**List<CustomEntity>**](CustomEntity.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="bytype"></a>
# **ByType**
> List<CustomEntity> ByType (string type, int? id)

Gets all the custom entities for a particular type

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ByTypeExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new CustomEntityApi();
            var type = type_example;  // string | the type of entities to fetch
            var id = 56;  // int? | owning entity type

            try
            {
                // Gets all the custom entities for a particular type
                List&lt;CustomEntity&gt; result = apiInstance.ByType(type, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomEntityApi.ByType: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **type** | **string**| the type of entities to fetch | 
 **id** | **int?**| owning entity type | 

### Return type

[**List<CustomEntity>**](CustomEntity.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="create"></a>
# **Create**
> void Create (CustomEntity entity = null)

Create a custom entity and if there is an associated custom entity type, looks it up and asosciates it with it,  otherwise the type is set to null

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

            var apiInstance = new CustomEntityApi();
            var entity = new CustomEntity(); // CustomEntity | the entity to create (optional) 

            try
            {
                // Create a custom entity and if there is an associated custom entity type, looks it up and asosciates it with it,  otherwise the type is set to null
                apiInstance.Create(entity);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomEntityApi.Create: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **entity** | [**CustomEntity**](CustomEntity.md)| the entity to create | [optional] 

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

            var apiInstance = new CustomEntityApi();
            var id = 56;  // int? | The id of the entity to delete

            try
            {
                // Deletes and Entity
                apiInstance.Delete(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomEntityApi.Delete: " + e.Message );
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

            var apiInstance = new CustomEntityApi();
            var entityId = 56;  // int? | 

            try
            {
                // Generically generates a series of datapoints representing for all or one of the entitiy types.  This includes the linking of it to other entity types by joining up all the resulting entities by common investments
                apiInstance.GenerateEntityInvestmentsGraphFor(entityId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomEntityApi.GenerateEntityInvestmentsGraphFor: " + e.Message );
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

            var apiInstance = new CustomEntityApi();

            try
            {
                // Generically generates a series of datapoints representing for all or one of the entitiy types.  This includes the linking of it to other entity types by joining up all the resulting entities by common investments
                apiInstance.GenerateSharedGraphDataForAll();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomEntityApi.GenerateSharedGraphDataForAll: " + e.Message );
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
> List<CustomEntity> GetAll ()

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

            var apiInstance = new CustomEntityApi();

            try
            {
                // Get all entities
                List&lt;CustomEntity&gt; result = apiInstance.GetAll();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomEntityApi.GetAll: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<CustomEntity>**](CustomEntity.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getallwithoutchildren"></a>
# **GetAllWithoutChildren**
> List<CustomEntity> GetAllWithoutChildren ()

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

            var apiInstance = new CustomEntityApi();

            try
            {
                // Gets all entities but not their children
                List&lt;CustomEntity&gt; result = apiInstance.GetAllWithoutChildren();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomEntityApi.GetAllWithoutChildren: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<CustomEntity>**](CustomEntity.md)

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

            var apiInstance = new CustomEntityApi();
            var id = 56;  // int? | 

            try
            {
                // Get Entity by ID
                apiInstance.GetById(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomEntityApi.GetById: " + e.Message );
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
> void Import (List<CustomEntity> entities = null)



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

            var apiInstance = new CustomEntityApi();
            var entities = new List<CustomEntity>(); // List<CustomEntity> |  (optional) 

            try
            {
                apiInstance.Import(entities);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomEntityApi.Import: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **entities** | [**List&lt;CustomEntity&gt;**](CustomEntity.md)|  | [optional] 

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

            var apiInstance = new CustomEntityApi();
            var id = 56;  // int? | Id of entity to patch
            var patchDocument = new List<Operation>(); // List<Operation> | the patched object (optional) 

            try
            {
                // Updates an entity partially
                apiInstance.Patch(id, patchDocument);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomEntityApi.Patch: " + e.Message );
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
> void Replace (int? id, CustomEntity newItem = null)

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

            var apiInstance = new CustomEntityApi();
            var id = 56;  // int? | Id of the entity to update
            var newItem = new CustomEntity(); // CustomEntity | the contents of the entity to change (optional) 

            try
            {
                // Replaces and existing Entity.  Note this is not for partial updates, for that use PATCH. This is used for replacing the entire entity.  At the moment it is not possible to replace everything on the existing generic entity with that on the new one and  sometimes we dont want to: we dont want to replace the ID property for example, but we might want to replace  collections in the orignal item with the new collections in the new item, but this is currently not possible in the  implemantation. It just replaces simple members.  ** So if you want to do it propery, override this method in the controller for the type you want to implementa replacement  routine for.
                apiInstance.Replace(id, newItem);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomEntityApi.Replace: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Id of the entity to update | 
 **newItem** | [**CustomEntity**](CustomEntity.md)| the contents of the entity to change | [optional] 

### Return type

void (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

