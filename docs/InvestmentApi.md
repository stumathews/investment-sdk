# IO.Swagger.Api.InvestmentApi

All URIs are relative to *https://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AssociateCustomEntities**](InvestmentApi.md#associatecustomentities) | **POST** /api/Investment/AssociateCustomEntities/{id} | Associate custom entity with investments
[**AssociateFactors**](InvestmentApi.md#associatefactors) | **POST** /api/Investment/AssociateFactors/{id} | Associates factors(as checkmodels) with an investment
[**AssociateGroups**](InvestmentApi.md#associategroups) | **POST** /api/Investment/AssociateGroups/{id} | Associate a groups with an investment
[**AssociateRegions**](InvestmentApi.md#associateregions) | **POST** /api/Investment/AssociateRegions/{id} | Associate regions with an investment
[**AssociateRisks**](InvestmentApi.md#associaterisks) | **POST** /api/Investment/AssociateRisks/{id} | Associates multiple risks with an investment
[**Create**](InvestmentApi.md#create) | **POST** /api/Investment | Create a entity
[**Delete**](InvestmentApi.md#delete) | **DELETE** /api/Investment/{id} | Deletes and Entity
[**DissassociateCustomEntity**](InvestmentApi.md#dissassociatecustomentity) | **POST** /api/Investment/DissassociateCustomEntity/{customEntityId}/{investmentId} | Dissosicate a custom entity with an investment
[**DissassociateFactor**](InvestmentApi.md#dissassociatefactor) | **POST** /api/Investment/DissassociateFactor/{factorId}/{investmentId} | Dissociate a factor with an investment
[**DissassociateGroup**](InvestmentApi.md#dissassociategroup) | **POST** /api/Investment/DissassociateGroup/{groupId}/{investmentId} | Dissociate a group from a investment
[**DissassociateRegion**](InvestmentApi.md#dissassociateregion) | **POST** /api/Investment/DissassociateRegion/{regionId}/{investmentId} | Dissasociates the region from an investment
[**DissassociateRisk**](InvestmentApi.md#dissassociaterisk) | **POST** /api/Investment/DissassociateRisk/{riskId}/{investmentId} | Dissosicate a risk with an investment
[**GenerateCustomEntitiesGraph**](InvestmentApi.md#generatecustomentitiesgraph) | **GET** /api/Investment/CustomEntitiesGraph/{id} | Generates graph data all custom entities given associated with particular investment
[**GenerateEntityInvestmentsGraphFor**](InvestmentApi.md#generateentityinvestmentsgraphfor) | **GET** /api/Investment/GenerateEntityInvestmentsGraphFor/{entityId} | Generically generates a series of datapoints representing for all or one of the entitiy types.  This includes the linking of it to other entity types by joining up all the resulting entities by common investments
[**GenerateFactorsGraph**](InvestmentApi.md#generatefactorsgraph) | **GET** /api/Investment/FactorsGraph/{id} | Generates graph data with all factors associated with particular investment
[**GenerateGroupsGraph**](InvestmentApi.md#generategroupsgraph) | **GET** /api/Investment/GroupsGraph/{id} | Generates graph data with all groups associated with particular investment
[**GenerateRegionsGraph**](InvestmentApi.md#generateregionsgraph) | **GET** /api/Investment/RegionsGraph/{id} | Generates graph data with all regions associated with particular investment
[**GenerateRisksGraph**](InvestmentApi.md#generaterisksgraph) | **GET** /api/Investment/RisksGraph/{id} | Generates graph data all risks given associated with particular investment
[**GenerateSharedGraphDataForAll**](InvestmentApi.md#generatesharedgraphdataforall) | **GET** /api/Investment/GenerateSharedInvestmentsGraphDataForAll | Generically generates a series of datapoints representing for all or one of the entitiy types.  This includes the linking of it to other entity types by joining up all the resulting entities by common investments
[**GetAll**](InvestmentApi.md#getall) | **GET** /api/Investment | Get all entities
[**GetAllWithoutChildren**](InvestmentApi.md#getallwithoutchildren) | **GET** /api/Investment/WithoutChildren | Gets all entities but not their children
[**GetById**](InvestmentApi.md#getbyid) | **GET** /api/Investment/{id} | Get Entity by ID
[**Import**](InvestmentApi.md#import) | **POST** /api/Investment/import | 
[**InvestmentByFactor**](InvestmentApi.md#investmentbyfactor) | **GET** /api/Investment/ByFactor/{id} | Get investments by Factor
[**InvestmentByGroup**](InvestmentApi.md#investmentbygroup) | **GET** /api/Investment/ByGroup/{id} | Get investments by group
[**InvestmentByRegion**](InvestmentApi.md#investmentbyregion) | **GET** /api/Investment/ByRegion/{id} | Gets investments by region
[**InvestmentByRisk**](InvestmentApi.md#investmentbyrisk) | **GET** /api/Investment/ByRisk/{id} | Get investments By Risk
[**Patch**](InvestmentApi.md#patch) | **PATCH** /api/Investment/{id} | Updates an entity partially
[**Replace**](InvestmentApi.md#replace) | **PUT** /api/Investment/{id} | Replaces and existing Entity.  Note this is not for partial updates, for that use PATCH. This is used for replacing the entire entity.  At the moment it is not possible to replace everything on the existing generic entity with that on the new one and  sometimes we dont want to: we dont want to replace the ID property for example, but we might want to replace  collections in the orignal item with the new collections in the new item, but this is currently not possible in the  implemantation. It just replaces simple members.  ** So if you want to do it propery, override this method in the controller for the type you want to implementa replacement  routine for.


<a name="associatecustomentities"></a>
# **AssociateCustomEntities**
> void AssociateCustomEntities (int? id, List<int?> customEnityIds = null)

Associate custom entity with investments

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AssociateCustomEntitiesExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new InvestmentApi();
            var id = 56;  // int? | 
            var customEnityIds = ;  // List<int?> |  (optional) 

            try
            {
                // Associate custom entity with investments
                apiInstance.AssociateCustomEntities(id, customEnityIds);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvestmentApi.AssociateCustomEntities: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**|  | 
 **customEnityIds** | **List&lt;int?&gt;**|  | [optional] 

### Return type

void (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="associatefactors"></a>
# **AssociateFactors**
> void AssociateFactors (int? id, List<int?> factorIds = null)

Associates factors(as checkmodels) with an investment

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AssociateFactorsExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new InvestmentApi();
            var id = 56;  // int? | investment
            var factorIds = ;  // List<int?> |  (optional) 

            try
            {
                // Associates factors(as checkmodels) with an investment
                apiInstance.AssociateFactors(id, factorIds);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvestmentApi.AssociateFactors: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| investment | 
 **factorIds** | **List&lt;int?&gt;**|  | [optional] 

### Return type

void (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="associategroups"></a>
# **AssociateGroups**
> void AssociateGroups (int? id, List<int?> groupIDs = null)

Associate a groups with an investment

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AssociateGroupsExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new InvestmentApi();
            var id = 56;  // int? | investment
            var groupIDs = ;  // List<int?> |  (optional) 

            try
            {
                // Associate a groups with an investment
                apiInstance.AssociateGroups(id, groupIDs);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvestmentApi.AssociateGroups: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| investment | 
 **groupIDs** | **List&lt;int?&gt;**|  | [optional] 

### Return type

void (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="associateregions"></a>
# **AssociateRegions**
> void AssociateRegions (int? id, List<int?> regionIDs = null)

Associate regions with an investment

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AssociateRegionsExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new InvestmentApi();
            var id = 56;  // int? | investment
            var regionIDs = ;  // List<int?> |  (optional) 

            try
            {
                // Associate regions with an investment
                apiInstance.AssociateRegions(id, regionIDs);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvestmentApi.AssociateRegions: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| investment | 
 **regionIDs** | **List&lt;int?&gt;**|  | [optional] 

### Return type

void (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="associaterisks"></a>
# **AssociateRisks**
> void AssociateRisks (int? id, List<int?> riskIds = null)

Associates multiple risks with an investment

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AssociateRisksExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new InvestmentApi();
            var id = 56;  // int? | investment
            var riskIds = ;  // List<int?> | list of risk ids (optional) 

            try
            {
                // Associates multiple risks with an investment
                apiInstance.AssociateRisks(id, riskIds);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvestmentApi.AssociateRisks: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| investment | 
 **riskIds** | **List&lt;int?&gt;**| list of risk ids | [optional] 

### Return type

void (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="create"></a>
# **Create**
> void Create (Investment entity = null)

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

            var apiInstance = new InvestmentApi();
            var entity = new Investment(); // Investment | the entity to create (optional) 

            try
            {
                // Create a entity
                apiInstance.Create(entity);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvestmentApi.Create: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **entity** | [**Investment**](Investment.md)| the entity to create | [optional] 

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

            var apiInstance = new InvestmentApi();
            var id = 56;  // int? | The id of the entity to delete

            try
            {
                // Deletes and Entity
                apiInstance.Delete(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvestmentApi.Delete: " + e.Message );
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

<a name="dissassociatecustomentity"></a>
# **DissassociateCustomEntity**
> void DissassociateCustomEntity (int? customEntityId, int? investmentId)

Dissosicate a custom entity with an investment

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DissassociateCustomEntityExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new InvestmentApi();
            var customEntityId = 56;  // int? | custom entity to dissasociate
            var investmentId = 56;  // int? | investment to dissasociate risk from

            try
            {
                // Dissosicate a custom entity with an investment
                apiInstance.DissassociateCustomEntity(customEntityId, investmentId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvestmentApi.DissassociateCustomEntity: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **customEntityId** | **int?**| custom entity to dissasociate | 
 **investmentId** | **int?**| investment to dissasociate risk from | 

### Return type

void (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="dissassociatefactor"></a>
# **DissassociateFactor**
> void DissassociateFactor (int? factorId, int? investmentId)

Dissociate a factor with an investment

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DissassociateFactorExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new InvestmentApi();
            var factorId = 56;  // int? | factor id
            var investmentId = 56;  // int? | investment id

            try
            {
                // Dissociate a factor with an investment
                apiInstance.DissassociateFactor(factorId, investmentId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvestmentApi.DissassociateFactor: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **factorId** | **int?**| factor id | 
 **investmentId** | **int?**| investment id | 

### Return type

void (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="dissassociategroup"></a>
# **DissassociateGroup**
> void DissassociateGroup (int? groupId, int? investmentId)

Dissociate a group from a investment

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DissassociateGroupExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new InvestmentApi();
            var groupId = 56;  // int? | group to dissasoocate
            var investmentId = 56;  // int? | investment

            try
            {
                // Dissociate a group from a investment
                apiInstance.DissassociateGroup(groupId, investmentId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvestmentApi.DissassociateGroup: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **groupId** | **int?**| group to dissasoocate | 
 **investmentId** | **int?**| investment | 

### Return type

void (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="dissassociateregion"></a>
# **DissassociateRegion**
> void DissassociateRegion (int? regionId, int? investmentId)

Dissasociates the region from an investment

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DissassociateRegionExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new InvestmentApi();
            var regionId = 56;  // int? | region to dissasociate
            var investmentId = 56;  // int? | the investment

            try
            {
                // Dissasociates the region from an investment
                apiInstance.DissassociateRegion(regionId, investmentId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvestmentApi.DissassociateRegion: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **regionId** | **int?**| region to dissasociate | 
 **investmentId** | **int?**| the investment | 

### Return type

void (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="dissassociaterisk"></a>
# **DissassociateRisk**
> void DissassociateRisk (int? riskId, int? investmentId)

Dissosicate a risk with an investment

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DissassociateRiskExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new InvestmentApi();
            var riskId = 56;  // int? | risk to dissasociate
            var investmentId = 56;  // int? | investment to dissasociate risk from

            try
            {
                // Dissosicate a risk with an investment
                apiInstance.DissassociateRisk(riskId, investmentId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvestmentApi.DissassociateRisk: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **riskId** | **int?**| risk to dissasociate | 
 **investmentId** | **int?**| investment to dissasociate risk from | 

### Return type

void (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="generatecustomentitiesgraph"></a>
# **GenerateCustomEntitiesGraph**
> void GenerateCustomEntitiesGraph (int? id)

Generates graph data all custom entities given associated with particular investment

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GenerateCustomEntitiesGraphExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new InvestmentApi();
            var id = 56;  // int? | 

            try
            {
                // Generates graph data all custom entities given associated with particular investment
                apiInstance.GenerateCustomEntitiesGraph(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvestmentApi.GenerateCustomEntitiesGraph: " + e.Message );
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

            var apiInstance = new InvestmentApi();
            var entityId = 56;  // int? | 

            try
            {
                // Generically generates a series of datapoints representing for all or one of the entitiy types.  This includes the linking of it to other entity types by joining up all the resulting entities by common investments
                apiInstance.GenerateEntityInvestmentsGraphFor(entityId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvestmentApi.GenerateEntityInvestmentsGraphFor: " + e.Message );
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

<a name="generatefactorsgraph"></a>
# **GenerateFactorsGraph**
> void GenerateFactorsGraph (int? id)

Generates graph data with all factors associated with particular investment

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GenerateFactorsGraphExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new InvestmentApi();
            var id = 56;  // int? | Investment Id

            try
            {
                // Generates graph data with all factors associated with particular investment
                apiInstance.GenerateFactorsGraph(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvestmentApi.GenerateFactorsGraph: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Investment Id | 

### Return type

void (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="generategroupsgraph"></a>
# **GenerateGroupsGraph**
> void GenerateGroupsGraph (int? id)

Generates graph data with all groups associated with particular investment

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GenerateGroupsGraphExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new InvestmentApi();
            var id = 56;  // int? | investment ID

            try
            {
                // Generates graph data with all groups associated with particular investment
                apiInstance.GenerateGroupsGraph(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvestmentApi.GenerateGroupsGraph: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| investment ID | 

### Return type

void (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="generateregionsgraph"></a>
# **GenerateRegionsGraph**
> void GenerateRegionsGraph (int? id)

Generates graph data with all regions associated with particular investment

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GenerateRegionsGraphExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new InvestmentApi();
            var id = 56;  // int? | investment id

            try
            {
                // Generates graph data with all regions associated with particular investment
                apiInstance.GenerateRegionsGraph(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvestmentApi.GenerateRegionsGraph: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| investment id | 

### Return type

void (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="generaterisksgraph"></a>
# **GenerateRisksGraph**
> void GenerateRisksGraph (int? id)

Generates graph data all risks given associated with particular investment

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GenerateRisksGraphExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new InvestmentApi();
            var id = 56;  // int? | The investment Id

            try
            {
                // Generates graph data all risks given associated with particular investment
                apiInstance.GenerateRisksGraph(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvestmentApi.GenerateRisksGraph: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| The investment Id | 

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

            var apiInstance = new InvestmentApi();

            try
            {
                // Generically generates a series of datapoints representing for all or one of the entitiy types.  This includes the linking of it to other entity types by joining up all the resulting entities by common investments
                apiInstance.GenerateSharedGraphDataForAll();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvestmentApi.GenerateSharedGraphDataForAll: " + e.Message );
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
> List<Investment> GetAll ()

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

            var apiInstance = new InvestmentApi();

            try
            {
                // Get all entities
                List&lt;Investment&gt; result = apiInstance.GetAll();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvestmentApi.GetAll: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<Investment>**](Investment.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getallwithoutchildren"></a>
# **GetAllWithoutChildren**
> List<Investment> GetAllWithoutChildren ()

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

            var apiInstance = new InvestmentApi();

            try
            {
                // Gets all entities but not their children
                List&lt;Investment&gt; result = apiInstance.GetAllWithoutChildren();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvestmentApi.GetAllWithoutChildren: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<Investment>**](Investment.md)

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

            var apiInstance = new InvestmentApi();
            var id = 56;  // int? | 

            try
            {
                // Get Entity by ID
                apiInstance.GetById(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvestmentApi.GetById: " + e.Message );
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
> void Import (List<Investment> entities = null)



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

            var apiInstance = new InvestmentApi();
            var entities = new List<Investment>(); // List<Investment> |  (optional) 

            try
            {
                apiInstance.Import(entities);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvestmentApi.Import: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **entities** | [**List&lt;Investment&gt;**](Investment.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="investmentbyfactor"></a>
# **InvestmentByFactor**
> void InvestmentByFactor (int? id)

Get investments by Factor

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class InvestmentByFactorExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new InvestmentApi();
            var id = 56;  // int? | Factor Id

            try
            {
                // Get investments by Factor
                apiInstance.InvestmentByFactor(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvestmentApi.InvestmentByFactor: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Factor Id | 

### Return type

void (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="investmentbygroup"></a>
# **InvestmentByGroup**
> void InvestmentByGroup (int? id)

Get investments by group

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class InvestmentByGroupExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new InvestmentApi();
            var id = 56;  // int? | group id

            try
            {
                // Get investments by group
                apiInstance.InvestmentByGroup(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvestmentApi.InvestmentByGroup: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| group id | 

### Return type

void (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="investmentbyregion"></a>
# **InvestmentByRegion**
> void InvestmentByRegion (int? id)

Gets investments by region

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class InvestmentByRegionExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new InvestmentApi();
            var id = 56;  // int? | region id

            try
            {
                // Gets investments by region
                apiInstance.InvestmentByRegion(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvestmentApi.InvestmentByRegion: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| region id | 

### Return type

void (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="investmentbyrisk"></a>
# **InvestmentByRisk**
> void InvestmentByRisk (int? id)

Get investments By Risk

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class InvestmentByRiskExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new InvestmentApi();
            var id = 56;  // int? | Risk ID

            try
            {
                // Get investments By Risk
                apiInstance.InvestmentByRisk(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvestmentApi.InvestmentByRisk: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Risk ID | 

### Return type

void (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
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

            var apiInstance = new InvestmentApi();
            var id = 56;  // int? | Id of entity to patch
            var patchDocument = new List<Operation>(); // List<Operation> | the patched object (optional) 

            try
            {
                // Updates an entity partially
                apiInstance.Patch(id, patchDocument);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvestmentApi.Patch: " + e.Message );
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
> void Replace (int? id, Investment newItem = null)

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

            var apiInstance = new InvestmentApi();
            var id = 56;  // int? | Id of the entity to update
            var newItem = new Investment(); // Investment | the contents of the entity to change (optional) 

            try
            {
                // Replaces and existing Entity.  Note this is not for partial updates, for that use PATCH. This is used for replacing the entire entity.  At the moment it is not possible to replace everything on the existing generic entity with that on the new one and  sometimes we dont want to: we dont want to replace the ID property for example, but we might want to replace  collections in the orignal item with the new collections in the new item, but this is currently not possible in the  implemantation. It just replaces simple members.  ** So if you want to do it propery, override this method in the controller for the type you want to implementa replacement  routine for.
                apiInstance.Replace(id, newItem);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvestmentApi.Replace: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Id of the entity to update | 
 **newItem** | [**Investment**](Investment.md)| the contents of the entity to change | [optional] 

### Return type

void (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

