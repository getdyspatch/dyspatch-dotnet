# IO.Dyspatch.Api.LocalizationsApi

All URIs are relative to *https://api.dyspatch.io*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetDraftLocalizationById**](LocalizationsApi.md#getdraftlocalizationbyid) | **GET** /localizations/{localizationId}/drafts/{draftId} | Get Draft Localization Object by ID
[**GetPublishedLocalizationById**](LocalizationsApi.md#getpublishedlocalizationbyid) | **GET** /localizations/{localizationId} | Get Localization Object by ID


<a name="getdraftlocalizationbyid"></a>
# **GetDraftLocalizationById**
> LocalizationRead GetDraftLocalizationById (string draftId, string localizationId, string targetLanguage, string accept)

Get Draft Localization Object by ID

Returns a specific localization object of the matching draft with a matching localization ID

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using IO.Dyspatch.Api;
using IO.Dyspatch.Client;
using IO.Dyspatch.Model;

namespace Example
{
    public class GetDraftLocalizationByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.dyspatch.io";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new LocalizationsApi(config);
            var draftId = draftId_example;  // string | A draft ID
            var localizationId = localizationId_example;  // string | A localization ID
            var targetLanguage = targetLanguage_example;  // string | The type of templating language to compile as. Should only be used for visual templates.
            var accept = accept_example;  // string | A version of the API that should be used for the request. For example, to use version \"2020.11\", set the value to \"application/vnd.dyspatch.2020.11+json\"

            try
            {
                // Get Draft Localization Object by ID
                LocalizationRead result = apiInstance.GetDraftLocalizationById(draftId, localizationId, targetLanguage, accept);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LocalizationsApi.GetDraftLocalizationById: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **draftId** | **string**| A draft ID | 
 **localizationId** | **string**| A localization ID | 
 **targetLanguage** | **string**| The type of templating language to compile as. Should only be used for visual templates. | 
 **accept** | **string**| A version of the API that should be used for the request. For example, to use version \&quot;2020.11\&quot;, set the value to \&quot;application/vnd.dyspatch.2020.11+json\&quot; | 

### Return type

[**LocalizationRead**](LocalizationRead.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.dyspatch.2020.11+json, */*

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A localization object from the matching draft ID with the requested ID |  * X-RateLimit-Remaining - The number of requests left for the current time window <br>  |
| **400** | Invalid request |  * X-RateLimit-Remaining - The number of requests left for the time window. <br>  |
| **401** | Unauthenticated |  * X-RateLimit-Remaining - The number of requests left for the time window. <br>  |
| **403** | Unauthorized |  * X-RateLimit-Remaining - The number of requests left for the time window. <br>  |
| **404** | Resource not found |  * X-RateLimit-Remaining - The number of requests left for the time window. <br>  |
| **429** | Rate limit exceeded |  * X-RateLimit-Remaining - The number of requests left for the time window. <br>  |
| **500** | Server error |  * X-RateLimit-Remaining - The number of requests left for the time window. <br>  |
| **0** | Server error |  * X-RateLimit-Remaining - The number of requests left for the time window. <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpublishedlocalizationbyid"></a>
# **GetPublishedLocalizationById**
> LocalizationRead GetPublishedLocalizationById (string localizationId, string targetLanguage, string accept)

Get Localization Object by ID

Returns the published content associated with the localization of the matching ID

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using IO.Dyspatch.Api;
using IO.Dyspatch.Client;
using IO.Dyspatch.Model;

namespace Example
{
    public class GetPublishedLocalizationByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.dyspatch.io";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new LocalizationsApi(config);
            var localizationId = localizationId_example;  // string | A localization ID
            var targetLanguage = targetLanguage_example;  // string | The type of templating language to compile as. Should only be used for visual templates.
            var accept = accept_example;  // string | A version of the API that should be used for the request. For example, to use version \"2020.11\", set the value to \"application/vnd.dyspatch.2020.11+json\"

            try
            {
                // Get Localization Object by ID
                LocalizationRead result = apiInstance.GetPublishedLocalizationById(localizationId, targetLanguage, accept);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LocalizationsApi.GetPublishedLocalizationById: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **localizationId** | **string**| A localization ID | 
 **targetLanguage** | **string**| The type of templating language to compile as. Should only be used for visual templates. | 
 **accept** | **string**| A version of the API that should be used for the request. For example, to use version \&quot;2020.11\&quot;, set the value to \&quot;application/vnd.dyspatch.2020.11+json\&quot; | 

### Return type

[**LocalizationRead**](LocalizationRead.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.dyspatch.2020.11+json, */*

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A localization object with the requested ID |  * X-RateLimit-Remaining - The number of requests left for the current time window <br>  |
| **400** | Invalid request |  * X-RateLimit-Remaining - The number of requests left for the time window. <br>  |
| **401** | Unauthenticated |  * X-RateLimit-Remaining - The number of requests left for the time window. <br>  |
| **403** | Unauthorized |  * X-RateLimit-Remaining - The number of requests left for the time window. <br>  |
| **404** | Resource not found |  * X-RateLimit-Remaining - The number of requests left for the time window. <br>  |
| **429** | Rate limit exceeded |  * X-RateLimit-Remaining - The number of requests left for the time window. <br>  |
| **500** | Server error |  * X-RateLimit-Remaining - The number of requests left for the time window. <br>  |
| **0** | Server error |  * X-RateLimit-Remaining - The number of requests left for the time window. <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

