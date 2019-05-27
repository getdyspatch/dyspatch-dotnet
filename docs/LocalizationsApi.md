# IO.Dyspatch.Api.LocalizationsApi

All URIs are relative to *https://api.dyspatch.io*

Method | HTTP request | Description
------------- | ------------- | -------------
[**LocalizationsLocalizationIdGet**](LocalizationsApi.md#localizationslocalizationidget) | **GET** /localizations/{localizationId} | Get Localization Object by ID


<a name="localizationslocalizationidget"></a>
# **LocalizationsLocalizationIdGet**
> LocalizationRead LocalizationsLocalizationIdGet (string localizationId, string targetLanguage = null, string accept = null)

Get Localization Object by ID

Returns a specific localization object with a matching ID

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Dyspatch.Api;
using IO.Dyspatch.Client;
using IO.Dyspatch.Model;

namespace Example
{
    public class LocalizationsLocalizationIdGetExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new LocalizationsApi();
            var localizationId = localizationId_example;  // string | A localization ID
            var targetLanguage = targetLanguage_example;  // string | The type of templating language to compile as. Should only be used for visual templates. (optional) 
            var accept = accept_example;  // string | A version of the API that should be used for the request. For example, to use version \"2019.03\", set the value to \"application/vnd.dyspatch.2019.03+json\" (optional) 

            try
            {
                // Get Localization Object by ID
                LocalizationRead result = apiInstance.LocalizationsLocalizationIdGet(localizationId, targetLanguage, accept);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LocalizationsApi.LocalizationsLocalizationIdGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **localizationId** | **string**| A localization ID | 
 **targetLanguage** | **string**| The type of templating language to compile as. Should only be used for visual templates. | [optional] 
 **accept** | **string**| A version of the API that should be used for the request. For example, to use version \&quot;2019.03\&quot;, set the value to \&quot;application/vnd.dyspatch.2019.03+json\&quot; | [optional] 

### Return type

[**LocalizationRead**](LocalizationRead.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.dyspatch.2019.03+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

