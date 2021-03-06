# IO.Dyspatch.Model.DraftRead
template draft metadata included latest draft revision
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | An opaque, unique identifier for a draft | [optional] 
**Template** | **string** | An opaque, unique identifier for a template | [optional] 
**Name** | **string** | The name of a draft | [optional] 
**Url** | **string** | The API url for a specific draft | [optional] 
**Compiled** | [**CompiledRead**](CompiledRead.md) |  | [optional] 
**CreatedAt** | **DateTimeOffset** | The time of initial creation | [optional] 
**UpdatedAt** | **DateTimeOffset** | The time of last update | [optional] 
**Localizations** | [**List&lt;LocalizationMetaRead&gt;**](LocalizationMetaRead.md) | A list of the Template&#39;s available localizations | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

