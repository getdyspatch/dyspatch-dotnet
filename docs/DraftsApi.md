# IO.Dyspatch.Api.DraftsApi

All URIs are relative to *https://api.dyspatch.io*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DraftsDraftIdGet**](DraftsApi.md#draftsdraftidget) | **GET** /drafts/{draftId} | Get Draft by ID
[**DraftsDraftIdLocalizationKeysGet**](DraftsApi.md#draftsdraftidlocalizationkeysget) | **GET** /drafts/{draftId}/localizationKeys | Get Localization Keys
[**DraftsDraftIdLocalizationsGet**](DraftsApi.md#draftsdraftidlocalizationsget) | **GET** /drafts/{draftId}/localizations | Get Localizations on a Draft
[**DraftsDraftIdLocalizationsLanguageIdDelete**](DraftsApi.md#draftsdraftidlocalizationslanguageiddelete) | **DELETE** /drafts/{draftId}/localizations/{languageId} | Remove a Localization
[**DraftsDraftIdLocalizationsLanguageIdPut**](DraftsApi.md#draftsdraftidlocalizationslanguageidput) | **PUT** /drafts/{draftId}/localizations/{languageId} | Create or Update a Localization
[**DraftsDraftIdLocalizationsLanguageIdTranslationsPut**](DraftsApi.md#draftsdraftidlocalizationslanguageidtranslationsput) | **PUT** /drafts/{draftId}/localizations/{languageId}/translations | Set Translations for Language
[**DraftsDraftIdPublishRequestPost**](DraftsApi.md#draftsdraftidpublishrequestpost) | **POST** /drafts/{draftId}/publishRequest | Submit the Draft for Approval
[**DraftsGet**](DraftsApi.md#draftsget) | **GET** /drafts | List Drafts


<a name="draftsdraftidget"></a>
# **DraftsDraftIdGet**
> DraftRead DraftsDraftIdGet (string draftId, string targetLanguage)

Get Draft by ID

Gets a draft object with the matching ID. The \"compiled\" field will contain the unlocalized default template object.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Dyspatch.Api;
using IO.Dyspatch.Client;
using IO.Dyspatch.Model;

namespace Example
{
    public class DraftsDraftIdGetExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DraftsApi();
            var draftId = draftId_example;  // string | A draft ID
            var targetLanguage = targetLanguage_example;  // string | The type of templating language to compile as. Should only be used for visual templates.

            try
            {
                // Get Draft by ID
                DraftRead result = apiInstance.DraftsDraftIdGet(draftId, targetLanguage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DraftsApi.DraftsDraftIdGet: " + e.Message );
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

### Return type

[**DraftRead**](DraftRead.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.dyspatch.2019.10+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="draftsdraftidlocalizationkeysget"></a>
# **DraftsDraftIdLocalizationKeysGet**
> List<LocalizationKeyRead> DraftsDraftIdLocalizationKeysGet (string draftId, string accept = null)

Get Localization Keys

Returns the list of values that need to be translated for the draft. Set the `Accept` header to `application/vnd.dyspatch.2019.10+json` to get a JSON object, or `text/vnd.dyspatch.2019.10+x-gettext-translation` to get the POT file.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Dyspatch.Api;
using IO.Dyspatch.Client;
using IO.Dyspatch.Model;

namespace Example
{
    public class DraftsDraftIdLocalizationKeysGetExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DraftsApi();
            var draftId = draftId_example;  // string | A draft ID
            var accept = accept_example;  // string | A version of the API that should be used for the request. For example, to use version \"2019.10\", set the value to \"application/vnd.dyspatch.2019.10+json\". (optional) 

            try
            {
                // Get Localization Keys
                List&lt;LocalizationKeyRead&gt; result = apiInstance.DraftsDraftIdLocalizationKeysGet(draftId, accept);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DraftsApi.DraftsDraftIdLocalizationKeysGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **draftId** | **string**| A draft ID | 
 **accept** | **string**| A version of the API that should be used for the request. For example, to use version \&quot;2019.10\&quot;, set the value to \&quot;application/vnd.dyspatch.2019.10+json\&quot;. | [optional] 

### Return type

[**List<LocalizationKeyRead>**](LocalizationKeyRead.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.dyspatch.2019.10+json, text/vnd.dyspatch.2019.10+x-gettext-translation

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="draftsdraftidlocalizationsget"></a>
# **DraftsDraftIdLocalizationsGet**
> List<LocalizationMetaRead> DraftsDraftIdLocalizationsGet (string draftId)

Get Localizations on a Draft

Returns localization metadata object for a template draft.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Dyspatch.Api;
using IO.Dyspatch.Client;
using IO.Dyspatch.Model;

namespace Example
{
    public class DraftsDraftIdLocalizationsGetExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DraftsApi();
            var draftId = draftId_example;  // string | A draft ID

            try
            {
                // Get Localizations on a Draft
                List&lt;LocalizationMetaRead&gt; result = apiInstance.DraftsDraftIdLocalizationsGet(draftId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DraftsApi.DraftsDraftIdLocalizationsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **draftId** | **string**| A draft ID | 

### Return type

[**List<LocalizationMetaRead>**](LocalizationMetaRead.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.dyspatch.2019.10+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="draftsdraftidlocalizationslanguageiddelete"></a>
# **DraftsDraftIdLocalizationsLanguageIdDelete**
> void DraftsDraftIdLocalizationsLanguageIdDelete (string draftId, string languageId)

Remove a Localization

Deletes the localization with the given `languageId` if it exists.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Dyspatch.Api;
using IO.Dyspatch.Client;
using IO.Dyspatch.Model;

namespace Example
{
    public class DraftsDraftIdLocalizationsLanguageIdDeleteExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DraftsApi();
            var draftId = draftId_example;  // string | A draft ID
            var languageId = languageId_example;  // string | A language ID (eg: en-US)

            try
            {
                // Remove a Localization
                apiInstance.DraftsDraftIdLocalizationsLanguageIdDelete(draftId, languageId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DraftsApi.DraftsDraftIdLocalizationsLanguageIdDelete: " + e.Message );
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

### Return type

void (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.dyspatch.2019.10+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="draftsdraftidlocalizationslanguageidput"></a>
# **DraftsDraftIdLocalizationsLanguageIdPut**
> void DraftsDraftIdLocalizationsLanguageIdPut (string draftId, string languageId, Body body)

Create or Update a Localization

Inserts a localization or sets the name on an existing localization that already uses the `languageId`.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Dyspatch.Api;
using IO.Dyspatch.Client;
using IO.Dyspatch.Model;

namespace Example
{
    public class DraftsDraftIdLocalizationsLanguageIdPutExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DraftsApi();
            var draftId = draftId_example;  // string | A draft ID
            var languageId = languageId_example;  // string | A language ID (eg: en-US)
            var body = new Body(); // Body | 

            try
            {
                // Create or Update a Localization
                apiInstance.DraftsDraftIdLocalizationsLanguageIdPut(draftId, languageId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DraftsApi.DraftsDraftIdLocalizationsLanguageIdPut: " + e.Message );
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
 **body** | [**Body**](Body.md)|  | 

### Return type

void (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.dyspatch.2019.10+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="draftsdraftidlocalizationslanguageidtranslationsput"></a>
# **DraftsDraftIdLocalizationsLanguageIdTranslationsPut**
> void DraftsDraftIdLocalizationsLanguageIdTranslationsPut (string draftId, string languageId, Object body)

Set Translations for Language

Completely replaces any existing translations for the given language with those provided in request body. Variables embedded in keys or values are expected to be in the format `%(my_variable)s` and will automatically convert to the correct Dyspatch format depending on the type of template. Accepts key/value pairs in JSON format or in gettext PO file format. For JSON set `Content-Type` header to `application/json`. For gettext PO format set `Content-Type` header to `text/x-gettext-translation`.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Dyspatch.Api;
using IO.Dyspatch.Client;
using IO.Dyspatch.Model;

namespace Example
{
    public class DraftsDraftIdLocalizationsLanguageIdTranslationsPutExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DraftsApi();
            var draftId = draftId_example;  // string | A draft ID
            var languageId = languageId_example;  // string | A language ID (eg: en-US)
            var body = ;  // Object | 

            try
            {
                // Set Translations for Language
                apiInstance.DraftsDraftIdLocalizationsLanguageIdTranslationsPut(draftId, languageId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DraftsApi.DraftsDraftIdLocalizationsLanguageIdTranslationsPut: " + e.Message );
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
 **body** | **Object**|  | 

### Return type

void (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.dyspatch.2019.10+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="draftsdraftidpublishrequestpost"></a>
# **DraftsDraftIdPublishRequestPost**
> void DraftsDraftIdPublishRequestPost (string draftId)

Submit the Draft for Approval

Moves the draft into [submitted and locked state](https://docs.dyspatch.io/templates/submitting_a_template/#awaiting-approval). This will allow your email stakeholders to review the template draft and provide feedback.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Dyspatch.Api;
using IO.Dyspatch.Client;
using IO.Dyspatch.Model;

namespace Example
{
    public class DraftsDraftIdPublishRequestPostExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DraftsApi();
            var draftId = draftId_example;  // string | A draft ID

            try
            {
                // Submit the Draft for Approval
                apiInstance.DraftsDraftIdPublishRequestPost(draftId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DraftsApi.DraftsDraftIdPublishRequestPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **draftId** | **string**| A draft ID | 

### Return type

void (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.dyspatch.2019.10+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="draftsget"></a>
# **DraftsGet**
> DraftsRead DraftsGet (string cursor = null, string status = null)

List Drafts

Gets a list of all drafts for your oranization. Up to 25 results returned before results are paginated.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Dyspatch.Api;
using IO.Dyspatch.Client;
using IO.Dyspatch.Model;

namespace Example
{
    public class DraftsGetExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DraftsApi();
            var cursor = cursor_example;  // string | A cursor value used to retrieve a specific page from a paginated result set. (optional) 
            var status = status_example;  // string | Filter the list of drafts by a particular status (optional) 

            try
            {
                // List Drafts
                DraftsRead result = apiInstance.DraftsGet(cursor, status);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DraftsApi.DraftsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **cursor** | **string**| A cursor value used to retrieve a specific page from a paginated result set. | [optional] 
 **status** | **string**| Filter the list of drafts by a particular status | [optional] 

### Return type

[**DraftsRead**](DraftsRead.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.dyspatch.2019.10+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

