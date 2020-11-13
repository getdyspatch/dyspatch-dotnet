# IO.Dyspatch.Api.DraftsApi

All URIs are relative to *https://api.dyspatch.io*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteLocalization**](DraftsApi.md#deletelocalization) | **DELETE** /drafts/{draftId}/localizations/{languageId} | Remove a localization
[**GetDraftById**](DraftsApi.md#getdraftbyid) | **GET** /drafts/{draftId} | Get Draft by ID
[**GetDraftLocalizationKeys**](DraftsApi.md#getdraftlocalizationkeys) | **GET** /drafts/{draftId}/localizationKeys | Get localization keys
[**GetDrafts**](DraftsApi.md#getdrafts) | **GET** /drafts | List Drafts
[**GetLocalizationForDraft**](DraftsApi.md#getlocalizationfordraft) | **GET** /drafts/{draftId}/localizations | Get localizations on a draft
[**SaveLocalization**](DraftsApi.md#savelocalization) | **PUT** /drafts/{draftId}/localizations/{languageId} | Create or update a localization
[**SetTranslation**](DraftsApi.md#settranslation) | **PUT** /drafts/{draftId}/localizations/{languageId}/translations | Set translations for language
[**SubmitDraftForApproval**](DraftsApi.md#submitdraftforapproval) | **POST** /drafts/{draftId}/publishRequest | Submit the draft for approval


<a name="deletelocalization"></a>
# **DeleteLocalization**
> void DeleteLocalization (string draftId, string languageId, string accept)

Remove a localization

Deletes the localization with the given language ID if it exists

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using IO.Dyspatch.Api;
using IO.Dyspatch.Client;
using IO.Dyspatch.Model;

namespace Example
{
    public class DeleteLocalizationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.dyspatch.io";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DraftsApi(config);
            var draftId = draftId_example;  // string | A draft ID
            var languageId = languageId_example;  // string | A language ID (eg: en-US)
            var accept = accept_example;  // string | A version of the API that should be used for the request. For example, to use version \"2020.11\", set the value to \"application/vnd.dyspatch.2020.11+json\"

            try
            {
                // Remove a localization
                apiInstance.DeleteLocalization(draftId, languageId, accept);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DraftsApi.DeleteLocalization: " + e.Message );
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
 **languageId** | **string**| A language ID (eg: en-US) | 
 **accept** | **string**| A version of the API that should be used for the request. For example, to use version \&quot;2020.11\&quot;, set the value to \&quot;application/vnd.dyspatch.2020.11+json\&quot; | 

### Return type

void (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful delete |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdraftbyid"></a>
# **GetDraftById**
> DraftRead GetDraftById (string draftId, string targetLanguage, string accept)

Get Draft by ID

Gets a draft object with the matching ID. The \"compiled\" field will contain the template in the default, unlocalized form.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using IO.Dyspatch.Api;
using IO.Dyspatch.Client;
using IO.Dyspatch.Model;

namespace Example
{
    public class GetDraftByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.dyspatch.io";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DraftsApi(config);
            var draftId = draftId_example;  // string | A draft ID
            var targetLanguage = targetLanguage_example;  // string | The type of templating language to compile as. Should only be used for visual templates.
            var accept = accept_example;  // string | A version of the API that should be used for the request. For example, to use version \"2020.11\", set the value to \"application/vnd.dyspatch.2020.11+json\"

            try
            {
                // Get Draft by ID
                DraftRead result = apiInstance.GetDraftById(draftId, targetLanguage, accept);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DraftsApi.GetDraftById: " + e.Message );
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
 **targetLanguage** | **string**| The type of templating language to compile as. Should only be used for visual templates. | 
 **accept** | **string**| A version of the API that should be used for the request. For example, to use version \&quot;2020.11\&quot;, set the value to \&quot;application/vnd.dyspatch.2020.11+json\&quot; | 

### Return type

[**DraftRead**](DraftRead.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.dyspatch.2020.11+json, */*

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A draft object with the requested ID. |  * X-RateLimit-Remaining - The number of requests left for the current time window <br>  |
| **400** | Invalid request |  * X-RateLimit-Remaining - The number of requests left for the time window. <br>  |
| **401** | Unauthenticated |  * X-RateLimit-Remaining - The number of requests left for the time window. <br>  |
| **403** | Unauthorized |  * X-RateLimit-Remaining - The number of requests left for the time window. <br>  |
| **404** | Resource not found |  * X-RateLimit-Remaining - The number of requests left for the time window. <br>  |
| **429** | Rate limit exceeded |  * X-RateLimit-Remaining - The number of requests left for the time window. <br>  |
| **500** | Server error |  * X-RateLimit-Remaining - The number of requests left for the time window. <br>  |
| **0** | Server error |  * X-RateLimit-Remaining - The number of requests left for the time window. <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdraftlocalizationkeys"></a>
# **GetDraftLocalizationKeys**
> List&lt;LocalizationKeyRead&gt; GetDraftLocalizationKeys (string draftId, string accept)

Get localization keys

Returns the list of values that need to be translated for the draft. Set the `Accept` header to `application/vnd.dyspatch.2020.11+json` to get a JSON object, or `text/vnd.dyspatch.2020.11+x-gettext-translation` to get the POT file.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using IO.Dyspatch.Api;
using IO.Dyspatch.Client;
using IO.Dyspatch.Model;

namespace Example
{
    public class GetDraftLocalizationKeysExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.dyspatch.io";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DraftsApi(config);
            var draftId = draftId_example;  // string | A draft ID
            var accept = accept_example;  // string | A version of the API that should be used for the request. For example, to use version \"2020.11\", set the value to \"application/vnd.dyspatch.2020.11+json\"

            try
            {
                // Get localization keys
                List<LocalizationKeyRead> result = apiInstance.GetDraftLocalizationKeys(draftId, accept);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DraftsApi.GetDraftLocalizationKeys: " + e.Message );
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
 **accept** | **string**| A version of the API that should be used for the request. For example, to use version \&quot;2020.11\&quot;, set the value to \&quot;application/vnd.dyspatch.2020.11+json\&quot; | 

### Return type

[**List&lt;LocalizationKeyRead&gt;**](LocalizationKeyRead.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.dyspatch.2020.11+json, text/vnd.dyspatch.2020.11+x-gettext-translation

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Localization keys |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdrafts"></a>
# **GetDrafts**
> DraftsRead GetDrafts (string accept, string cursor = null, string status = null)

List Drafts

Returns all drafts for your organization.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using IO.Dyspatch.Api;
using IO.Dyspatch.Client;
using IO.Dyspatch.Model;

namespace Example
{
    public class GetDraftsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.dyspatch.io";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DraftsApi(config);
            var accept = accept_example;  // string | A version of the API that should be used for the request. For example, to use version \"2020.11\", set the value to \"application/vnd.dyspatch.2020.11+json\"
            var cursor = cursor_example;  // string | A cursor value used to retrieve a specific page from a paginated result set. (optional) 
            var status = status_example;  // string | Filter the list of drafts by a particular status (optional) 

            try
            {
                // List Drafts
                DraftsRead result = apiInstance.GetDrafts(accept, cursor, status);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DraftsApi.GetDrafts: " + e.Message );
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
 **accept** | **string**| A version of the API that should be used for the request. For example, to use version \&quot;2020.11\&quot;, set the value to \&quot;application/vnd.dyspatch.2020.11+json\&quot; | 
 **cursor** | **string**| A cursor value used to retrieve a specific page from a paginated result set. | [optional] 
 **status** | **string**| Filter the list of drafts by a particular status | [optional] 

### Return type

[**DraftsRead**](DraftsRead.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.dyspatch.2020.11+json, */*

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Drafts |  * X-RateLimit-Remaining - The number of requests left for the time window. <br>  |
| **400** | Invalid request |  * X-RateLimit-Remaining - The number of requests left for the time window. <br>  |
| **401** | Unauthenticated |  * X-RateLimit-Remaining - The number of requests left for the time window. <br>  |
| **403** | Unauthorized |  * X-RateLimit-Remaining - The number of requests left for the time window. <br>  |
| **404** | Resource not found |  * X-RateLimit-Remaining - The number of requests left for the time window. <br>  |
| **429** | Rate limit exceeded |  * X-RateLimit-Remaining - The number of requests left for the time window. <br>  |
| **500** | Server error |  * X-RateLimit-Remaining - The number of requests left for the time window. <br>  |
| **0** | Server error |  * X-RateLimit-Remaining - The number of requests left for the time window. <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getlocalizationfordraft"></a>
# **GetLocalizationForDraft**
> List&lt;LocalizationMetaRead&gt; GetLocalizationForDraft (string draftId, string accept)

Get localizations on a draft

Returns localization metadata for the draft

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using IO.Dyspatch.Api;
using IO.Dyspatch.Client;
using IO.Dyspatch.Model;

namespace Example
{
    public class GetLocalizationForDraftExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.dyspatch.io";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DraftsApi(config);
            var draftId = draftId_example;  // string | A draft ID
            var accept = accept_example;  // string | A version of the API that should be used for the request. For example, to use version \"2020.11\", set the value to \"application/vnd.dyspatch.2020.11+json\"

            try
            {
                // Get localizations on a draft
                List<LocalizationMetaRead> result = apiInstance.GetLocalizationForDraft(draftId, accept);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DraftsApi.GetLocalizationForDraft: " + e.Message );
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
 **accept** | **string**| A version of the API that should be used for the request. For example, to use version \&quot;2020.11\&quot;, set the value to \&quot;application/vnd.dyspatch.2020.11+json\&quot; | 

### Return type

[**List&lt;LocalizationMetaRead&gt;**](LocalizationMetaRead.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.dyspatch.2020.11+json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A list of localizations |  * X-RateLimit-Remaining - The number of requests left for the current time window <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="savelocalization"></a>
# **SaveLocalization**
> void SaveLocalization (string draftId, string languageId, string accept, InlineObject inlineObject)

Create or update a localization

Inserts a localization or sets the name on an existing localization that already uses the languageId

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using IO.Dyspatch.Api;
using IO.Dyspatch.Client;
using IO.Dyspatch.Model;

namespace Example
{
    public class SaveLocalizationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.dyspatch.io";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DraftsApi(config);
            var draftId = draftId_example;  // string | A draft ID
            var languageId = languageId_example;  // string | A language ID (eg: en-US)
            var accept = accept_example;  // string | A version of the API that should be used for the request. For example, to use version \"2020.11\", set the value to \"application/vnd.dyspatch.2020.11+json\"
            var inlineObject = new InlineObject(); // InlineObject | 

            try
            {
                // Create or update a localization
                apiInstance.SaveLocalization(draftId, languageId, accept, inlineObject);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DraftsApi.SaveLocalization: " + e.Message );
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
 **languageId** | **string**| A language ID (eg: en-US) | 
 **accept** | **string**| A version of the API that should be used for the request. For example, to use version \&quot;2020.11\&quot;, set the value to \&quot;application/vnd.dyspatch.2020.11+json\&quot; | 
 **inlineObject** | [**InlineObject**](InlineObject.md)|  | 

### Return type

void (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful upsert |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="settranslation"></a>
# **SetTranslation**
> void SetTranslation (string draftId, string languageId, string accept, Dictionary<string, string> requestBody)

Set translations for language

Completely replaces any existing translations for the given language with those provided in request body. Variables embedded in keys or values are expected to be in the format `%(my_variable)s` and will automatically convert to the correct Dyspatch format depending on the type of template. Accepts key/value pairs in JSON format or in gettext PO file format. For JSON set `Content-Type` header to `application/json`. For gettext PO format set `Content-Type` header to `text/x-gettext-translation`.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using IO.Dyspatch.Api;
using IO.Dyspatch.Client;
using IO.Dyspatch.Model;

namespace Example
{
    public class SetTranslationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.dyspatch.io";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DraftsApi(config);
            var draftId = draftId_example;  // string | A draft ID
            var languageId = languageId_example;  // string | A language ID (eg: en-US)
            var accept = accept_example;  // string | A version of the API that should be used for the request. For example, to use version \"2020.11\", set the value to \"application/vnd.dyspatch.2020.11+json\"
            var requestBody = new Dictionary<string, string>(); // Dictionary<string, string> | 

            try
            {
                // Set translations for language
                apiInstance.SetTranslation(draftId, languageId, accept, requestBody);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DraftsApi.SetTranslation: " + e.Message );
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
 **languageId** | **string**| A language ID (eg: en-US) | 
 **accept** | **string**| A version of the API that should be used for the request. For example, to use version \&quot;2020.11\&quot;, set the value to \&quot;application/vnd.dyspatch.2020.11+json\&quot; | 
 **requestBody** | [**Dictionary&lt;string, string&gt;**](string.md)|  | 

### Return type

void (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful |  -  |
| **403** | Unauthorized |  * X-RateLimit-Remaining - The number of requests left for the time window. <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="submitdraftforapproval"></a>
# **SubmitDraftForApproval**
> void SubmitDraftForApproval (string draftId, string accept)

Submit the draft for approval

Moves the draft into submitted state.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using IO.Dyspatch.Api;
using IO.Dyspatch.Client;
using IO.Dyspatch.Model;

namespace Example
{
    public class SubmitDraftForApprovalExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.dyspatch.io";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DraftsApi(config);
            var draftId = draftId_example;  // string | A draft ID
            var accept = accept_example;  // string | A version of the API that should be used for the request. For example, to use version \"2020.11\", set the value to \"application/vnd.dyspatch.2020.11+json\"

            try
            {
                // Submit the draft for approval
                apiInstance.SubmitDraftForApproval(draftId, accept);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DraftsApi.SubmitDraftForApproval: " + e.Message );
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
 **accept** | **string**| A version of the API that should be used for the request. For example, to use version \&quot;2020.11\&quot;, set the value to \&quot;application/vnd.dyspatch.2020.11+json\&quot; | 

### Return type

void (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully submitted |  -  |
| **400** | Invalid request |  * X-RateLimit-Remaining - The number of requests left for the time window. <br>  |
| **401** | Unauthenticated |  * X-RateLimit-Remaining - The number of requests left for the time window. <br>  |
| **403** | Unauthorized |  * X-RateLimit-Remaining - The number of requests left for the time window. <br>  |
| **404** | Resource not found |  * X-RateLimit-Remaining - The number of requests left for the time window. <br>  |
| **429** | Rate limit exceeded |  * X-RateLimit-Remaining - The number of requests left for the time window. <br>  |
| **500** | Server error |  * X-RateLimit-Remaining - The number of requests left for the time window. <br>  |
| **0** | Server error |  * X-RateLimit-Remaining - The number of requests left for the time window. <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

