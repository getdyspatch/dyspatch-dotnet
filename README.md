# IO.Dyspatch - the C# library for the Dyspatch API

# Introduction
The Dyspatch API is based on the REST paradigm and features resource based URLs
with standard HTTP response codes to indicate errors.

We use standard HTTP
authentication and request verbs and all responses are JSON formatted. See our
[Implementation
Guide](https://docs.dyspatch.io/development/implementing_dyspatch/) for more
details on how to implement Dyspatch.

This C# SDK is automatically generated by the [Swagger Codegen](https://github.com/swagger-api/swagger-codegen) project:

- API version: 2019.10
- SDK version: 3.0.0
- Build package: io.swagger.codegen.languages.CSharpClientCodegen
    For more information, please visit [https://docs.dyspatch.io](https://docs.dyspatch.io)

<a name="frameworks-supported"></a>
## Frameworks supported
- .NET Core >=1.0
- .NET Framework >=4.6
- Mono/Xamarin >=vNext
- UWP >=10.0

<a name="dependencies"></a>
## Dependencies
- FubarCoder.RestSharp.Portable.Core >=4.0.7
- FubarCoder.RestSharp.Portable.HttpClient >=4.0.7
- Newtonsoft.Json >=10.0.3

<a name="installation"></a>
## Installation
Generate the DLL using your preferred tool

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:
```csharp
using IO.Dyspatch.Api;
using IO.Dyspatch.Client;
using IO.Dyspatch.Model;
```
<a name="getting-started"></a>
## Getting Started

```csharp
using System;
using System.Diagnostics;
using IO.Dyspatch.Api;
using IO.Dyspatch.Client;
using IO.Dyspatch.Model;

namespace Example
{
    public class Example
    {
        public void main()
        {

            // Configure API key authorization: Bearer
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

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

<a name="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to *https://api.dyspatch.io*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*DraftsApi* | [**DraftsDraftIdGet**](docs/DraftsApi.md#draftsdraftidget) | **GET** /drafts/{draftId} | Get Draft by ID
*DraftsApi* | [**DraftsDraftIdLocalizationKeysGet**](docs/DraftsApi.md#draftsdraftidlocalizationkeysget) | **GET** /drafts/{draftId}/localizationKeys | Get Localization Keys
*DraftsApi* | [**DraftsDraftIdLocalizationsGet**](docs/DraftsApi.md#draftsdraftidlocalizationsget) | **GET** /drafts/{draftId}/localizations | Get Localizations on a Draft
*DraftsApi* | [**DraftsDraftIdLocalizationsLanguageIdDelete**](docs/DraftsApi.md#draftsdraftidlocalizationslanguageiddelete) | **DELETE** /drafts/{draftId}/localizations/{languageId} | Remove a Localization
*DraftsApi* | [**DraftsDraftIdLocalizationsLanguageIdPut**](docs/DraftsApi.md#draftsdraftidlocalizationslanguageidput) | **PUT** /drafts/{draftId}/localizations/{languageId} | Create or Update a Localization
*DraftsApi* | [**DraftsDraftIdLocalizationsLanguageIdTranslationsPut**](docs/DraftsApi.md#draftsdraftidlocalizationslanguageidtranslationsput) | **PUT** /drafts/{draftId}/localizations/{languageId}/translations | Set Translations for Language
*DraftsApi* | [**DraftsDraftIdPublishRequestPost**](docs/DraftsApi.md#draftsdraftidpublishrequestpost) | **POST** /drafts/{draftId}/publishRequest | Submit the Draft for Approval
*DraftsApi* | [**DraftsGet**](docs/DraftsApi.md#draftsget) | **GET** /drafts | List Drafts
*LocalizationsApi* | [**LocalizationsLocalizationIdGet**](docs/LocalizationsApi.md#localizationslocalizationidget) | **GET** /localizations/{localizationId} | Get Localization Object by ID
*TemplatesApi* | [**TemplatesGet**](docs/TemplatesApi.md#templatesget) | **GET** /templates | List Templates
*TemplatesApi* | [**TemplatesTemplateIdGet**](docs/TemplatesApi.md#templatestemplateidget) | **GET** /templates/{templateId} | Get Template by ID


<a name="documentation-for-models"></a>
## Documentation for Models

 - [Model.APIError](docs/APIError.md)
 - [Model.Body](docs/Body.md)
 - [Model.CompiledRead](docs/CompiledRead.md)
 - [Model.CreatedAt](docs/CreatedAt.md)
 - [Model.Cursor](docs/Cursor.md)
 - [Model.DraftDescription](docs/DraftDescription.md)
 - [Model.DraftId](docs/DraftId.md)
 - [Model.DraftMetaRead](docs/DraftMetaRead.md)
 - [Model.DraftName](docs/DraftName.md)
 - [Model.DraftRead](docs/DraftRead.md)
 - [Model.DraftUrl](docs/DraftUrl.md)
 - [Model.DraftsRead](docs/DraftsRead.md)
 - [Model.LanguageId](docs/LanguageId.md)
 - [Model.LocalizationId](docs/LocalizationId.md)
 - [Model.LocalizationKeyRead](docs/LocalizationKeyRead.md)
 - [Model.LocalizationMetaRead](docs/LocalizationMetaRead.md)
 - [Model.LocalizationName](docs/LocalizationName.md)
 - [Model.LocalizationRead](docs/LocalizationRead.md)
 - [Model.LocalizationUrl](docs/LocalizationUrl.md)
 - [Model.TemplateDescription](docs/TemplateDescription.md)
 - [Model.TemplateId](docs/TemplateId.md)
 - [Model.TemplateMetaRead](docs/TemplateMetaRead.md)
 - [Model.TemplateName](docs/TemplateName.md)
 - [Model.TemplateRead](docs/TemplateRead.md)
 - [Model.TemplateUrl](docs/TemplateUrl.md)
 - [Model.TemplatesRead](docs/TemplatesRead.md)
 - [Model.UpdatedAt](docs/UpdatedAt.md)


<a name="documentation-for-authorization"></a>
## Documentation for Authorization

<a name="Bearer"></a>
### Bearer

- **Type**: API key
- **API key parameter name**: Authorization
- **Location**: HTTP header
