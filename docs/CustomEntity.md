# IO.Swagger.Model.CustomEntity
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CustomEntityType** | [**CustomEntityType**](CustomEntityType.md) | Type that this entity belongs to | [optional] 
**OwningCustomEntity** | [**CustomEntity**](CustomEntity.md) | The refered owning custom entity, if entity type &#x3D; custom | [optional] 
**Associations** | [**List&lt;CustomEntity&gt;**](CustomEntity.md) | Entities that relate to this entity | [optional] 
**OwningEntityId** | **int?** | This allows this custom entity to be owned by a non-custom entity | [optional] 
**OwningEntityType** | **int?** | This allows this custom entity to be owned by a non-custom entity | [optional] 
**Investments** | [**List&lt;CustomEntityInvestment&gt;**](CustomEntityInvestment.md) | We have investments | [optional] 
**InvestmentIds** | **List&lt;int?&gt;** | Convienient way to expose investments ids so we can get them generically using IHaveInvestments | [optional] 
**Id** | **int?** | The identifier of the entity | [optional] 
**Name** | **string** | The name of the entity | [optional] 
**Description** | **string** | The description of the entity | [optional] 
**CreatedTime** | **DateTime?** | When the entity was created | [optional] 
**LastModifiedTime** | **DateTime?** | When the entity was last modified | [optional] 
**Points** | **long?** | Generic points for this entity | [optional] 
**IsFlagged** | **bool?** | Generic true/false marker for entity | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

