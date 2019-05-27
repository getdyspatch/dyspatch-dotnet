# IO.Dyspatch.Api.TemplatesApi

All URIs are relative to *https://api.dyspatch.io*

Method | HTTP request | Description
------------- | ------------- | -------------
[**TemplatesGet**](TemplatesApi.md#templatesget) | **GET** /templates | List Templates
[**TemplatesTemplateIdGet**](TemplatesApi.md#templatestemplateidget) | **GET** /templates/{templateId} | Get Template by ID


<a name="templatesget"></a>
# **TemplatesGet**
> TemplatesRead TemplatesGet (string cursor = null, string accept = null)

List Templates

Gets a list of Template Metadata objects for all templates. Up to 25 results returned before results are paginated.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Dyspatch.Api;
using IO.Dyspatch.Client;
using IO.Dyspatch.Model;

namespace Example
{
    public class TemplatesGetExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TemplatesApi();
            var cursor = cursor_example;  // string | A cursor value used to retrieve a specific page from a paginated result set. (optional) 
            var accept = accept_example;  // string | A version of the API that should be used for the request. For example, to use version \"2019.03\", set the value to \"application/vnd.dyspatch.2019.03+json\" (optional) 

            try
            {
                // List Templates
                TemplatesRead result = apiInstance.TemplatesGet(cursor, accept);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TemplatesApi.TemplatesGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **cursor** | **string**| A cursor value used to retrieve a specific page from a paginated result set. | [optional] 
 **accept** | **string**| A version of the API that should be used for the request. For example, to use version \&quot;2019.03\&quot;, set the value to \&quot;application/vnd.dyspatch.2019.03+json\&quot; | [optional] 

### Return type

[**TemplatesRead**](TemplatesRead.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.dyspatch.2019.03+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="templatestemplateidget"></a>
# **TemplatesTemplateIdGet**
> TemplateRead TemplatesTemplateIdGet (string templateId, string targetLanguage = null, string accept = null)

Get Template by ID

Gets a template object with the matching ID. If the template has published content the \"compiled\" field will contain the template .

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Dyspatch.Api;
using IO.Dyspatch.Client;
using IO.Dyspatch.Model;

namespace Example
{
    public class TemplatesTemplateIdGetExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TemplatesApi();
            var templateId = templateId_example;  // string | A template ID
            var targetLanguage = targetLanguage_example;  // string | The type of templating language to compile as. Should only be used for visual templates. (optional) 
            var accept = accept_example;  // string | A version of the API that should be used for the request. For example, to use version \"2019.03\", set the value to \"application/vnd.dyspatch.2019.03+json\" (optional) 

            try
            {
                // Get Template by ID
                TemplateRead result = apiInstance.TemplatesTemplateIdGet(templateId, targetLanguage, accept);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TemplatesApi.TemplatesTemplateIdGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **templateId** | **string**| A template ID | 
 **targetLanguage** | **string**| The type of templating language to compile as. Should only be used for visual templates. | [optional] 
 **accept** | **string**| A version of the API that should be used for the request. For example, to use version \&quot;2019.03\&quot;, set the value to \&quot;application/vnd.dyspatch.2019.03+json\&quot; | [optional] 

### Return type

[**TemplateRead**](TemplateRead.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.dyspatch.2019.03+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

