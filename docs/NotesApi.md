# IO.Swagger.Api.NotesApi

All URIs are relative to *https://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Create**](NotesApi.md#create) | **POST** /api/Notes | Create a entity
[**Delete**](NotesApi.md#delete) | **DELETE** /api/Notes/{owningEntityId}/{owningEntityType}/{id} | Deletes and Entity
[**Delete_0**](NotesApi.md#delete_0) | **DELETE** /api/Notes/{id} | Deletes and Entity
[**GetAll**](NotesApi.md#getall) | **GET** /api/Notes | Get all entities
[**GetAllEntitiesForOwner**](NotesApi.md#getallentitiesforowner) | **GET** /api/Notes/{owningEntityId}/{owningEntityType} | Get Entity by ID
[**GetAllWithoutChildren**](NotesApi.md#getallwithoutchildren) | **GET** /api/Notes/WithoutChildren | Gets all entities but not their children
[**GetById**](NotesApi.md#getbyid) | **GET** /api/Notes/{id} | Get Entity by ID
[**Import**](NotesApi.md#import) | **POST** /api/Notes/import | 
[**Patch**](NotesApi.md#patch) | **PATCH** /api/Notes/{id} | Updates an entity partially
[**Replace**](NotesApi.md#replace) | **PUT** /api/Notes/{id} | Replaces and existing Entity.  Note this is not for partial updates, for that use PATCH. This is used for replacing the entire entity.  At the moment it is not possible to replace everything on the existing generic entity with that on the new one and  sometimes we dont want to: we dont want to replace the ID property for example, but we might want to replace  collections in the orignal item with the new collections in the new item, but this is currently not possible in the  implemantation. It just replaces simple members.  ** So if you want to do it propery, override this method in the controller for the type you want to implementa replacement  routine for.


<a name="create"></a>
# **Create**
> void Create (InvestmentNote entity = null)

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

            var apiInstance = new NotesApi();
            var entity = new InvestmentNote(); // InvestmentNote | the entity to create (optional) 

            try
            {
                // Create a entity
                apiInstance.Create(entity);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NotesApi.Create: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **entity** | [**InvestmentNote**](InvestmentNote.md)| the entity to create | [optional] 

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
> void Delete (int? owningEntityId, int? owningEntityType, int? id)

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

            var apiInstance = new NotesApi();
            var owningEntityId = 56;  // int? | The id of the type you want the entity for
            var owningEntityType = 56;  // int? | The type of the owning entity
            var id = 56;  // int? | The id of the entity to delete

            try
            {
                // Deletes and Entity
                apiInstance.Delete(owningEntityId, owningEntityType, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NotesApi.Delete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **owningEntityId** | **int?**| The id of the type you want the entity for | 
 **owningEntityType** | **int?**| The type of the owning entity | 
 **id** | **int?**| The id of the entity to delete | 

### Return type

void (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="delete_0"></a>
# **Delete_0**
> void Delete_0 (int? id)

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
    public class Delete_0Example
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new NotesApi();
            var id = 56;  // int? | The id of the entity to delete

            try
            {
                // Deletes and Entity
                apiInstance.Delete_0(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NotesApi.Delete_0: " + e.Message );
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

<a name="getall"></a>
# **GetAll**
> List<InvestmentNote> GetAll ()

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

            var apiInstance = new NotesApi();

            try
            {
                // Get all entities
                List&lt;InvestmentNote&gt; result = apiInstance.GetAll();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NotesApi.GetAll: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<InvestmentNote>**](InvestmentNote.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getallentitiesforowner"></a>
# **GetAllEntitiesForOwner**
> List<InvestmentNote> GetAllEntitiesForOwner (int? owningEntityId, int? owningEntityType)

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
    public class GetAllEntitiesForOwnerExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new NotesApi();
            var owningEntityId = 56;  // int? | 
            var owningEntityType = 56;  // int? | 

            try
            {
                // Get Entity by ID
                List&lt;InvestmentNote&gt; result = apiInstance.GetAllEntitiesForOwner(owningEntityId, owningEntityType);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NotesApi.GetAllEntitiesForOwner: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **owningEntityId** | **int?**|  | 
 **owningEntityType** | **int?**|  | 

### Return type

[**List<InvestmentNote>**](InvestmentNote.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getallwithoutchildren"></a>
# **GetAllWithoutChildren**
> List<InvestmentNote> GetAllWithoutChildren ()

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

            var apiInstance = new NotesApi();

            try
            {
                // Gets all entities but not their children
                List&lt;InvestmentNote&gt; result = apiInstance.GetAllWithoutChildren();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NotesApi.GetAllWithoutChildren: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<InvestmentNote>**](InvestmentNote.md)

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

            var apiInstance = new NotesApi();
            var id = 56;  // int? | 

            try
            {
                // Get Entity by ID
                apiInstance.GetById(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NotesApi.GetById: " + e.Message );
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
> void Import (List<InvestmentNote> entities = null)



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

            var apiInstance = new NotesApi();
            var entities = new List<InvestmentNote>(); // List<InvestmentNote> |  (optional) 

            try
            {
                apiInstance.Import(entities);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NotesApi.Import: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **entities** | [**List&lt;InvestmentNote&gt;**](InvestmentNote.md)|  | [optional] 

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

            var apiInstance = new NotesApi();
            var id = 56;  // int? | Id of entity to patch
            var patchDocument = new List<Operation>(); // List<Operation> | the patched object (optional) 

            try
            {
                // Updates an entity partially
                apiInstance.Patch(id, patchDocument);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NotesApi.Patch: " + e.Message );
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
> void Replace (int? id, InvestmentNote newItem = null)

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

            var apiInstance = new NotesApi();
            var id = 56;  // int? | Id of the entity to update
            var newItem = new InvestmentNote(); // InvestmentNote | the contents of the entity to change (optional) 

            try
            {
                // Replaces and existing Entity.  Note this is not for partial updates, for that use PATCH. This is used for replacing the entire entity.  At the moment it is not possible to replace everything on the existing generic entity with that on the new one and  sometimes we dont want to: we dont want to replace the ID property for example, but we might want to replace  collections in the orignal item with the new collections in the new item, but this is currently not possible in the  implemantation. It just replaces simple members.  ** So if you want to do it propery, override this method in the controller for the type you want to implementa replacement  routine for.
                apiInstance.Replace(id, newItem);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NotesApi.Replace: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Id of the entity to update | 
 **newItem** | [**InvestmentNote**](InvestmentNote.md)| the contents of the entity to change | [optional] 

### Return type

void (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

