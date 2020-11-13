/* 
 * Dyspatch API
 *
 * # Introduction  The Dyspatch API is based on the REST paradigm, and features resource based URLs with standard HTTP response codes to indicate errors. We use standard HTTP authentication and request verbs, and all responses are JSON formatted. See our [Implementation Guide](https://docs.dyspatch.io/development/implementing_dyspatch/) for more details on how to implement Dyspatch.  ## API Client Libraries Dyspatch provides API Clients for popular languages and web frameworks.  - [Java](https://github.com/getdyspatch/dyspatch-java) - [Javascript](https://github.com/getdyspatch/dyspatch-javascript) - [Python](https://github.com/getdyspatch/dyspatch-python) - [C#](https://github.com/getdyspatch/dyspatch-dotnet) - [Go](https://github.com/getdyspatch/dyspatch-golang) - [Ruby](https://github.com/getdyspatch/dyspatch-ruby) 
 *
 * The version of the OpenAPI document: 2020.11
 * Contact: support@dyspatch.io
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Mime;
using IO.Dyspatch.Client;
using IO.Dyspatch.Model;

namespace IO.Dyspatch.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ILocalizationsApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Get Draft Localization Object by ID
        /// </summary>
        /// <remarks>
        /// Returns a specific localization object of the matching draft with a matching localization ID
        /// </remarks>
        /// <exception cref="IO.Dyspatch.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="draftId">A draft ID</param>
        /// <param name="localizationId">A localization ID</param>
        /// <param name="targetLanguage">The type of templating language to compile as. Should only be used for visual templates.</param>
        /// <param name="accept">A version of the API that should be used for the request. For example, to use version \&quot;2020.11\&quot;, set the value to \&quot;application/vnd.dyspatch.2020.11+json\&quot;</param>
        /// <returns>LocalizationRead</returns>
        LocalizationRead GetDraftLocalizationById (string draftId, string localizationId, string targetLanguage, string accept);

        /// <summary>
        /// Get Draft Localization Object by ID
        /// </summary>
        /// <remarks>
        /// Returns a specific localization object of the matching draft with a matching localization ID
        /// </remarks>
        /// <exception cref="IO.Dyspatch.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="draftId">A draft ID</param>
        /// <param name="localizationId">A localization ID</param>
        /// <param name="targetLanguage">The type of templating language to compile as. Should only be used for visual templates.</param>
        /// <param name="accept">A version of the API that should be used for the request. For example, to use version \&quot;2020.11\&quot;, set the value to \&quot;application/vnd.dyspatch.2020.11+json\&quot;</param>
        /// <returns>ApiResponse of LocalizationRead</returns>
        ApiResponse<LocalizationRead> GetDraftLocalizationByIdWithHttpInfo (string draftId, string localizationId, string targetLanguage, string accept);
        /// <summary>
        /// Get Localization Object by ID
        /// </summary>
        /// <remarks>
        /// Returns the published content associated with the localization of the matching ID
        /// </remarks>
        /// <exception cref="IO.Dyspatch.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="localizationId">A localization ID</param>
        /// <param name="targetLanguage">The type of templating language to compile as. Should only be used for visual templates.</param>
        /// <param name="accept">A version of the API that should be used for the request. For example, to use version \&quot;2020.11\&quot;, set the value to \&quot;application/vnd.dyspatch.2020.11+json\&quot;</param>
        /// <returns>LocalizationRead</returns>
        LocalizationRead GetPublishedLocalizationById (string localizationId, string targetLanguage, string accept);

        /// <summary>
        /// Get Localization Object by ID
        /// </summary>
        /// <remarks>
        /// Returns the published content associated with the localization of the matching ID
        /// </remarks>
        /// <exception cref="IO.Dyspatch.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="localizationId">A localization ID</param>
        /// <param name="targetLanguage">The type of templating language to compile as. Should only be used for visual templates.</param>
        /// <param name="accept">A version of the API that should be used for the request. For example, to use version \&quot;2020.11\&quot;, set the value to \&quot;application/vnd.dyspatch.2020.11+json\&quot;</param>
        /// <returns>ApiResponse of LocalizationRead</returns>
        ApiResponse<LocalizationRead> GetPublishedLocalizationByIdWithHttpInfo (string localizationId, string targetLanguage, string accept);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ILocalizationsApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Get Draft Localization Object by ID
        /// </summary>
        /// <remarks>
        /// Returns a specific localization object of the matching draft with a matching localization ID
        /// </remarks>
        /// <exception cref="IO.Dyspatch.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="draftId">A draft ID</param>
        /// <param name="localizationId">A localization ID</param>
        /// <param name="targetLanguage">The type of templating language to compile as. Should only be used for visual templates.</param>
        /// <param name="accept">A version of the API that should be used for the request. For example, to use version \&quot;2020.11\&quot;, set the value to \&quot;application/vnd.dyspatch.2020.11+json\&quot;</param>
        /// <returns>Task of LocalizationRead</returns>
        System.Threading.Tasks.Task<LocalizationRead> GetDraftLocalizationByIdAsync (string draftId, string localizationId, string targetLanguage, string accept);

        /// <summary>
        /// Get Draft Localization Object by ID
        /// </summary>
        /// <remarks>
        /// Returns a specific localization object of the matching draft with a matching localization ID
        /// </remarks>
        /// <exception cref="IO.Dyspatch.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="draftId">A draft ID</param>
        /// <param name="localizationId">A localization ID</param>
        /// <param name="targetLanguage">The type of templating language to compile as. Should only be used for visual templates.</param>
        /// <param name="accept">A version of the API that should be used for the request. For example, to use version \&quot;2020.11\&quot;, set the value to \&quot;application/vnd.dyspatch.2020.11+json\&quot;</param>
        /// <returns>Task of ApiResponse (LocalizationRead)</returns>
        System.Threading.Tasks.Task<ApiResponse<LocalizationRead>> GetDraftLocalizationByIdAsyncWithHttpInfo (string draftId, string localizationId, string targetLanguage, string accept);
        /// <summary>
        /// Get Localization Object by ID
        /// </summary>
        /// <remarks>
        /// Returns the published content associated with the localization of the matching ID
        /// </remarks>
        /// <exception cref="IO.Dyspatch.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="localizationId">A localization ID</param>
        /// <param name="targetLanguage">The type of templating language to compile as. Should only be used for visual templates.</param>
        /// <param name="accept">A version of the API that should be used for the request. For example, to use version \&quot;2020.11\&quot;, set the value to \&quot;application/vnd.dyspatch.2020.11+json\&quot;</param>
        /// <returns>Task of LocalizationRead</returns>
        System.Threading.Tasks.Task<LocalizationRead> GetPublishedLocalizationByIdAsync (string localizationId, string targetLanguage, string accept);

        /// <summary>
        /// Get Localization Object by ID
        /// </summary>
        /// <remarks>
        /// Returns the published content associated with the localization of the matching ID
        /// </remarks>
        /// <exception cref="IO.Dyspatch.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="localizationId">A localization ID</param>
        /// <param name="targetLanguage">The type of templating language to compile as. Should only be used for visual templates.</param>
        /// <param name="accept">A version of the API that should be used for the request. For example, to use version \&quot;2020.11\&quot;, set the value to \&quot;application/vnd.dyspatch.2020.11+json\&quot;</param>
        /// <returns>Task of ApiResponse (LocalizationRead)</returns>
        System.Threading.Tasks.Task<ApiResponse<LocalizationRead>> GetPublishedLocalizationByIdAsyncWithHttpInfo (string localizationId, string targetLanguage, string accept);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ILocalizationsApi : ILocalizationsApiSync, ILocalizationsApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class LocalizationsApi : ILocalizationsApi
    {
        private IO.Dyspatch.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="LocalizationsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public LocalizationsApi() : this((string) null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LocalizationsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public LocalizationsApi(String basePath)
        {
            this.Configuration = IO.Dyspatch.Client.Configuration.MergeConfigurations(
                IO.Dyspatch.Client.GlobalConfiguration.Instance,
                new IO.Dyspatch.Client.Configuration { BasePath = basePath }
            );
            this.Client = new IO.Dyspatch.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new IO.Dyspatch.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = IO.Dyspatch.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LocalizationsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public LocalizationsApi(IO.Dyspatch.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = IO.Dyspatch.Client.Configuration.MergeConfigurations(
                IO.Dyspatch.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.Client = new IO.Dyspatch.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new IO.Dyspatch.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = IO.Dyspatch.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LocalizationsApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public LocalizationsApi(IO.Dyspatch.Client.ISynchronousClient client,IO.Dyspatch.Client.IAsynchronousClient asyncClient, IO.Dyspatch.Client.IReadableConfiguration configuration)
        {
            if(client == null) throw new ArgumentNullException("client");
            if(asyncClient == null) throw new ArgumentNullException("asyncClient");
            if(configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = IO.Dyspatch.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public IO.Dyspatch.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public IO.Dyspatch.Client.ISynchronousClient Client { get; set; }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.BasePath;
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public IO.Dyspatch.Client.IReadableConfiguration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public IO.Dyspatch.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Get Draft Localization Object by ID Returns a specific localization object of the matching draft with a matching localization ID
        /// </summary>
        /// <exception cref="IO.Dyspatch.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="draftId">A draft ID</param>
        /// <param name="localizationId">A localization ID</param>
        /// <param name="targetLanguage">The type of templating language to compile as. Should only be used for visual templates.</param>
        /// <param name="accept">A version of the API that should be used for the request. For example, to use version \&quot;2020.11\&quot;, set the value to \&quot;application/vnd.dyspatch.2020.11+json\&quot;</param>
        /// <returns>LocalizationRead</returns>
        public LocalizationRead GetDraftLocalizationById (string draftId, string localizationId, string targetLanguage, string accept)
        {
             IO.Dyspatch.Client.ApiResponse<LocalizationRead> localVarResponse = GetDraftLocalizationByIdWithHttpInfo(draftId, localizationId, targetLanguage, accept);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get Draft Localization Object by ID Returns a specific localization object of the matching draft with a matching localization ID
        /// </summary>
        /// <exception cref="IO.Dyspatch.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="draftId">A draft ID</param>
        /// <param name="localizationId">A localization ID</param>
        /// <param name="targetLanguage">The type of templating language to compile as. Should only be used for visual templates.</param>
        /// <param name="accept">A version of the API that should be used for the request. For example, to use version \&quot;2020.11\&quot;, set the value to \&quot;application/vnd.dyspatch.2020.11+json\&quot;</param>
        /// <returns>ApiResponse of LocalizationRead</returns>
        public IO.Dyspatch.Client.ApiResponse< LocalizationRead > GetDraftLocalizationByIdWithHttpInfo (string draftId, string localizationId, string targetLanguage, string accept)
        {
            // verify the required parameter 'draftId' is set
            if (draftId == null)
                throw new IO.Dyspatch.Client.ApiException(400, "Missing required parameter 'draftId' when calling LocalizationsApi->GetDraftLocalizationById");

            // verify the required parameter 'localizationId' is set
            if (localizationId == null)
                throw new IO.Dyspatch.Client.ApiException(400, "Missing required parameter 'localizationId' when calling LocalizationsApi->GetDraftLocalizationById");

            // verify the required parameter 'targetLanguage' is set
            if (targetLanguage == null)
                throw new IO.Dyspatch.Client.ApiException(400, "Missing required parameter 'targetLanguage' when calling LocalizationsApi->GetDraftLocalizationById");

            // verify the required parameter 'accept' is set
            if (accept == null)
                throw new IO.Dyspatch.Client.ApiException(400, "Missing required parameter 'accept' when calling LocalizationsApi->GetDraftLocalizationById");

            IO.Dyspatch.Client.RequestOptions localVarRequestOptions = new IO.Dyspatch.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/vnd.dyspatch.2020.11+json",
                "*/*"
            };

            var localVarContentType = IO.Dyspatch.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = IO.Dyspatch.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("draftId", IO.Dyspatch.Client.ClientUtils.ParameterToString(draftId)); // path parameter
            localVarRequestOptions.PathParameters.Add("localizationId", IO.Dyspatch.Client.ClientUtils.ParameterToString(localizationId)); // path parameter
            localVarRequestOptions.QueryParameters.Add(IO.Dyspatch.Client.ClientUtils.ParameterToMultiMap("", "targetLanguage", targetLanguage));
            localVarRequestOptions.HeaderParameters.Add("Accept", IO.Dyspatch.Client.ClientUtils.ParameterToString(accept)); // header parameter

            // authentication (Bearer) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get< LocalizationRead >("/localizations/{localizationId}/drafts/{draftId}", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetDraftLocalizationById", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get Draft Localization Object by ID Returns a specific localization object of the matching draft with a matching localization ID
        /// </summary>
        /// <exception cref="IO.Dyspatch.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="draftId">A draft ID</param>
        /// <param name="localizationId">A localization ID</param>
        /// <param name="targetLanguage">The type of templating language to compile as. Should only be used for visual templates.</param>
        /// <param name="accept">A version of the API that should be used for the request. For example, to use version \&quot;2020.11\&quot;, set the value to \&quot;application/vnd.dyspatch.2020.11+json\&quot;</param>
        /// <returns>Task of LocalizationRead</returns>
        public async System.Threading.Tasks.Task<LocalizationRead> GetDraftLocalizationByIdAsync (string draftId, string localizationId, string targetLanguage, string accept)
        {
             IO.Dyspatch.Client.ApiResponse<LocalizationRead> localVarResponse = await GetDraftLocalizationByIdAsyncWithHttpInfo(draftId, localizationId, targetLanguage, accept);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get Draft Localization Object by ID Returns a specific localization object of the matching draft with a matching localization ID
        /// </summary>
        /// <exception cref="IO.Dyspatch.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="draftId">A draft ID</param>
        /// <param name="localizationId">A localization ID</param>
        /// <param name="targetLanguage">The type of templating language to compile as. Should only be used for visual templates.</param>
        /// <param name="accept">A version of the API that should be used for the request. For example, to use version \&quot;2020.11\&quot;, set the value to \&quot;application/vnd.dyspatch.2020.11+json\&quot;</param>
        /// <returns>Task of ApiResponse (LocalizationRead)</returns>
        public async System.Threading.Tasks.Task<IO.Dyspatch.Client.ApiResponse<LocalizationRead>> GetDraftLocalizationByIdAsyncWithHttpInfo (string draftId, string localizationId, string targetLanguage, string accept)
        {
            // verify the required parameter 'draftId' is set
            if (draftId == null)
                throw new IO.Dyspatch.Client.ApiException(400, "Missing required parameter 'draftId' when calling LocalizationsApi->GetDraftLocalizationById");

            // verify the required parameter 'localizationId' is set
            if (localizationId == null)
                throw new IO.Dyspatch.Client.ApiException(400, "Missing required parameter 'localizationId' when calling LocalizationsApi->GetDraftLocalizationById");

            // verify the required parameter 'targetLanguage' is set
            if (targetLanguage == null)
                throw new IO.Dyspatch.Client.ApiException(400, "Missing required parameter 'targetLanguage' when calling LocalizationsApi->GetDraftLocalizationById");

            // verify the required parameter 'accept' is set
            if (accept == null)
                throw new IO.Dyspatch.Client.ApiException(400, "Missing required parameter 'accept' when calling LocalizationsApi->GetDraftLocalizationById");


            IO.Dyspatch.Client.RequestOptions localVarRequestOptions = new IO.Dyspatch.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/vnd.dyspatch.2020.11+json",
                "*/*"
            };
            
            foreach (var _contentType in _contentTypes)
                localVarRequestOptions.HeaderParameters.Add("Content-Type", _contentType);
            
            foreach (var _accept in _accepts)
                localVarRequestOptions.HeaderParameters.Add("Accept", _accept);
            
            localVarRequestOptions.PathParameters.Add("draftId", IO.Dyspatch.Client.ClientUtils.ParameterToString(draftId)); // path parameter
            localVarRequestOptions.PathParameters.Add("localizationId", IO.Dyspatch.Client.ClientUtils.ParameterToString(localizationId)); // path parameter
            localVarRequestOptions.QueryParameters.Add(IO.Dyspatch.Client.ClientUtils.ParameterToMultiMap("", "targetLanguage", targetLanguage));
            localVarRequestOptions.HeaderParameters.Add("Accept", IO.Dyspatch.Client.ClientUtils.ParameterToString(accept)); // header parameter

            // authentication (Bearer) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<LocalizationRead>("/localizations/{localizationId}/drafts/{draftId}", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetDraftLocalizationById", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get Localization Object by ID Returns the published content associated with the localization of the matching ID
        /// </summary>
        /// <exception cref="IO.Dyspatch.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="localizationId">A localization ID</param>
        /// <param name="targetLanguage">The type of templating language to compile as. Should only be used for visual templates.</param>
        /// <param name="accept">A version of the API that should be used for the request. For example, to use version \&quot;2020.11\&quot;, set the value to \&quot;application/vnd.dyspatch.2020.11+json\&quot;</param>
        /// <returns>LocalizationRead</returns>
        public LocalizationRead GetPublishedLocalizationById (string localizationId, string targetLanguage, string accept)
        {
             IO.Dyspatch.Client.ApiResponse<LocalizationRead> localVarResponse = GetPublishedLocalizationByIdWithHttpInfo(localizationId, targetLanguage, accept);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get Localization Object by ID Returns the published content associated with the localization of the matching ID
        /// </summary>
        /// <exception cref="IO.Dyspatch.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="localizationId">A localization ID</param>
        /// <param name="targetLanguage">The type of templating language to compile as. Should only be used for visual templates.</param>
        /// <param name="accept">A version of the API that should be used for the request. For example, to use version \&quot;2020.11\&quot;, set the value to \&quot;application/vnd.dyspatch.2020.11+json\&quot;</param>
        /// <returns>ApiResponse of LocalizationRead</returns>
        public IO.Dyspatch.Client.ApiResponse< LocalizationRead > GetPublishedLocalizationByIdWithHttpInfo (string localizationId, string targetLanguage, string accept)
        {
            // verify the required parameter 'localizationId' is set
            if (localizationId == null)
                throw new IO.Dyspatch.Client.ApiException(400, "Missing required parameter 'localizationId' when calling LocalizationsApi->GetPublishedLocalizationById");

            // verify the required parameter 'targetLanguage' is set
            if (targetLanguage == null)
                throw new IO.Dyspatch.Client.ApiException(400, "Missing required parameter 'targetLanguage' when calling LocalizationsApi->GetPublishedLocalizationById");

            // verify the required parameter 'accept' is set
            if (accept == null)
                throw new IO.Dyspatch.Client.ApiException(400, "Missing required parameter 'accept' when calling LocalizationsApi->GetPublishedLocalizationById");

            IO.Dyspatch.Client.RequestOptions localVarRequestOptions = new IO.Dyspatch.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/vnd.dyspatch.2020.11+json",
                "*/*"
            };

            var localVarContentType = IO.Dyspatch.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = IO.Dyspatch.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("localizationId", IO.Dyspatch.Client.ClientUtils.ParameterToString(localizationId)); // path parameter
            localVarRequestOptions.QueryParameters.Add(IO.Dyspatch.Client.ClientUtils.ParameterToMultiMap("", "targetLanguage", targetLanguage));
            localVarRequestOptions.HeaderParameters.Add("Accept", IO.Dyspatch.Client.ClientUtils.ParameterToString(accept)); // header parameter

            // authentication (Bearer) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get< LocalizationRead >("/localizations/{localizationId}", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetPublishedLocalizationById", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get Localization Object by ID Returns the published content associated with the localization of the matching ID
        /// </summary>
        /// <exception cref="IO.Dyspatch.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="localizationId">A localization ID</param>
        /// <param name="targetLanguage">The type of templating language to compile as. Should only be used for visual templates.</param>
        /// <param name="accept">A version of the API that should be used for the request. For example, to use version \&quot;2020.11\&quot;, set the value to \&quot;application/vnd.dyspatch.2020.11+json\&quot;</param>
        /// <returns>Task of LocalizationRead</returns>
        public async System.Threading.Tasks.Task<LocalizationRead> GetPublishedLocalizationByIdAsync (string localizationId, string targetLanguage, string accept)
        {
             IO.Dyspatch.Client.ApiResponse<LocalizationRead> localVarResponse = await GetPublishedLocalizationByIdAsyncWithHttpInfo(localizationId, targetLanguage, accept);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get Localization Object by ID Returns the published content associated with the localization of the matching ID
        /// </summary>
        /// <exception cref="IO.Dyspatch.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="localizationId">A localization ID</param>
        /// <param name="targetLanguage">The type of templating language to compile as. Should only be used for visual templates.</param>
        /// <param name="accept">A version of the API that should be used for the request. For example, to use version \&quot;2020.11\&quot;, set the value to \&quot;application/vnd.dyspatch.2020.11+json\&quot;</param>
        /// <returns>Task of ApiResponse (LocalizationRead)</returns>
        public async System.Threading.Tasks.Task<IO.Dyspatch.Client.ApiResponse<LocalizationRead>> GetPublishedLocalizationByIdAsyncWithHttpInfo (string localizationId, string targetLanguage, string accept)
        {
            // verify the required parameter 'localizationId' is set
            if (localizationId == null)
                throw new IO.Dyspatch.Client.ApiException(400, "Missing required parameter 'localizationId' when calling LocalizationsApi->GetPublishedLocalizationById");

            // verify the required parameter 'targetLanguage' is set
            if (targetLanguage == null)
                throw new IO.Dyspatch.Client.ApiException(400, "Missing required parameter 'targetLanguage' when calling LocalizationsApi->GetPublishedLocalizationById");

            // verify the required parameter 'accept' is set
            if (accept == null)
                throw new IO.Dyspatch.Client.ApiException(400, "Missing required parameter 'accept' when calling LocalizationsApi->GetPublishedLocalizationById");


            IO.Dyspatch.Client.RequestOptions localVarRequestOptions = new IO.Dyspatch.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/vnd.dyspatch.2020.11+json",
                "*/*"
            };
            
            foreach (var _contentType in _contentTypes)
                localVarRequestOptions.HeaderParameters.Add("Content-Type", _contentType);
            
            foreach (var _accept in _accepts)
                localVarRequestOptions.HeaderParameters.Add("Accept", _accept);
            
            localVarRequestOptions.PathParameters.Add("localizationId", IO.Dyspatch.Client.ClientUtils.ParameterToString(localizationId)); // path parameter
            localVarRequestOptions.QueryParameters.Add(IO.Dyspatch.Client.ClientUtils.ParameterToMultiMap("", "targetLanguage", targetLanguage));
            localVarRequestOptions.HeaderParameters.Add("Accept", IO.Dyspatch.Client.ClientUtils.ParameterToString(accept)); // header parameter

            // authentication (Bearer) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<LocalizationRead>("/localizations/{localizationId}", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetPublishedLocalizationById", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

    }
}
