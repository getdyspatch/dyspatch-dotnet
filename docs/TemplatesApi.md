# IO.Dyspatch.Api.TemplatesApi

All URIs are relative to *https://api.dyspatch.io*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetTemplateById**](TemplatesApi.md#gettemplatebyid) | **GET** /templates/{templateId} | Get Template by ID
[**GetTemplates**](TemplatesApi.md#gettemplates) | **GET** /templates | List Templates


<a name="gettemplatebyid"></a>
# **GetTemplateById**
> TemplateRead GetTemplateById (string templateId, string targetLanguage, string accept)

Get Template by ID

Gets a template object with the matching ID. If the template has published content the \"compiled\" field will contain the template .

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using IO.Dyspatch.Api;
using IO.Dyspatch.Client;
using IO.Dyspatch.Model;

namespace Example
{
    public class GetTemplateByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.dyspatch.io";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TemplatesApi(config);
            var templateId = templateId_example;  // string | A template ID
            var targetLanguage = targetLanguage_example;  // string | The type of templating language to compile as. Should only be used for visual templates.
            var accept = accept_example;  // string | A version of the API that should be used for the request. For example, to use version \"2020.04\", set the value to \"application/vnd.dyspatch.2020.04+json\"

            try
            {
                // Get Template by ID
                TemplateRead result = apiInstance.GetTemplateById(templateId, targetLanguage, accept);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TemplatesApi.GetTemplateById: " + e.Message );
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
 **templateId** | **string**| A template ID | 
 **targetLanguage** | **string**| The type of templating language to compile as. Should only be used for visual templates. | 
 **accept** | **string**| A version of the API that should be used for the request. For example, to use version \&quot;2020.04\&quot;, set the value to \&quot;application/vnd.dyspatch.2020.04+json\&quot; | 

### Return type

[**TemplateRead**](TemplateRead.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.dyspatch.2020.04+json, */*

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A template object with the requested ID. If the template has no published content the \&quot;compiled\&quot; field will be *null*. |  * X-RateLimit-Remaining - The number of requests left for the current time window <br>  |
| **400** | Invalid request |  * X-RateLimit-Remaining - The number of requests left for the time window. <br>  |
| **401** | Unauthenticated |  * X-RateLimit-Remaining - The number of requests left for the time window. <br>  |
| **403** | Unauthorized |  * X-RateLimit-Remaining - The number of requests left for the time window. <br>  |
| **404** | Resource not found |  * X-RateLimit-Remaining - The number of requests left for the time window. <br>  |
| **429** | Rate limit exceeded |  * X-RateLimit-Remaining - The number of requests left for the time window. <br>  |
| **500** | Server error |  * X-RateLimit-Remaining - The number of requests left for the time window. <br>  |
| **0** | Server error |  * X-RateLimit-Remaining - The number of requests left for the time window. <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettemplates"></a>
# **GetTemplates**
> TemplatesRead GetTemplates (string accept, string cursor = null)

List Templates

Gets a list of Template Metadata objects for all templates. Up to 25 results returned before results are paginated.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using IO.Dyspatch.Api;
using IO.Dyspatch.Client;
using IO.Dyspatch.Model;

namespace Example
{
    public class GetTemplatesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.dyspatch.io";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TemplatesApi(config);
            var accept = accept_example;  // string | A version of the API that should be used for the request. For example, to use version \"2020.04\", set the value to \"application/vnd.dyspatch.2020.04+json\"
            var cursor = cursor_example;  // string | A cursor value used to retrieve a specific page from a paginated result set. (optional) 

            try
            {
                // List Templates
                TemplatesRead result = apiInstance.GetTemplates(accept, cursor);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TemplatesApi.GetTemplates: " + e.Message );
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
 **accept** | **string**| A version of the API that should be used for the request. For example, to use version \&quot;2020.04\&quot;, set the value to \&quot;application/vnd.dyspatch.2020.04+json\&quot; | 
 **cursor** | **string**| A cursor value used to retrieve a specific page from a paginated result set. | [optional] 

### Return type

[**TemplatesRead**](TemplatesRead.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.dyspatch.2020.04+json, */*

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A list of templates |  * X-RateLimit-Remaining - The number of requests left for the time window. <br>  |
| **400** | Invalid request |  * X-RateLimit-Remaining - The number of requests left for the time window. <br>  |
| **401** | Unauthenticated |  * X-RateLimit-Remaining - The number of requests left for the time window. <br>  |
| **403** | Unauthorized |  * X-RateLimit-Remaining - The number of requests left for the time window. <br>  |
| **429** | Rate limit exceeded |  * X-RateLimit-Remaining - The number of requests left for the time window. <br>  |
| **500** | Server error |  * X-RateLimit-Remaining - The number of requests left for the time window. <br>  |
| **0** | Server error |  * X-RateLimit-Remaining - The number of requests left for the time window. <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

