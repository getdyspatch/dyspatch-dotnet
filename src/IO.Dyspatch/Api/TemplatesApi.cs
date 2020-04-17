/* 
 * Dyspatch API
 *
 * # Introduction  The Dyspatch API is based on the REST paradigm, and features resource based URLs with standard HTTP response codes to indicate errors. We use standard HTTP authentication and request verbs, and all responses are JSON formatted. See our [Implementation Guide](https://docs.dyspatch.io/development/implementing_dyspatch/) for more details on how to implement Dyspatch.  ## API Client Libraries Dyspatch provides API Clients for popular languages and web frameworks.  - [Java](https://github.com/getdyspatch/dyspatch-java) - [Javascript](https://github.com/getdyspatch/dyspatch-javascript) - [Python](https://github.com/getdyspatch/dyspatch-python) - [C#](https://github.com/getdyspatch/dyspatch-dotnet) - [Go](https://github.com/getdyspatch/dyspatch-golang) - [Ruby](https://github.com/getdyspatch/dyspatch-ruby) 
 *
 * The version of the OpenAPI document: 2020.04
 * Contact: support@dyspatch.io
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp.Portable;
using IO.Dyspatch.Client;
using IO.Dyspatch.Model;

namespace IO.Dyspatch.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ITemplatesApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Get Template by ID
        /// </summary>
        /// <remarks>
        /// Gets a template object with the matching ID. If the template has published content the \&quot;compiled\&quot; field will contain the template .
        /// </remarks>
        /// <exception cref="IO.Dyspatch.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="templateId">A template ID</param>
        /// <param name="targetLanguage">The type of templating language to compile as. Should only be used for visual templates.</param>
        /// <param name="accept">A version of the API that should be used for the request. For example, to use version \&quot;2020.04\&quot;, set the value to \&quot;application/vnd.dyspatch.2020.04+json\&quot;</param>
        /// <returns>TemplateRead</returns>
        TemplateRead GetTemplateById (string templateId, string targetLanguage, string accept);

        /// <summary>
        /// Get Template by ID
        /// </summary>
        /// <remarks>
        /// Gets a template object with the matching ID. If the template has published content the \&quot;compiled\&quot; field will contain the template .
        /// </remarks>
        /// <exception cref="IO.Dyspatch.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="templateId">A template ID</param>
        /// <param name="targetLanguage">The type of templating language to compile as. Should only be used for visual templates.</param>
        /// <param name="accept">A version of the API that should be used for the request. For example, to use version \&quot;2020.04\&quot;, set the value to \&quot;application/vnd.dyspatch.2020.04+json\&quot;</param>
        /// <returns>ApiResponse of TemplateRead</returns>
        ApiResponse<TemplateRead> GetTemplateByIdWithHttpInfo (string templateId, string targetLanguage, string accept);
        /// <summary>
        /// List Templates
        /// </summary>
        /// <remarks>
        /// Gets a list of Template Metadata objects for all templates. Up to 25 results returned before results are paginated.
        /// </remarks>
        /// <exception cref="IO.Dyspatch.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accept">A version of the API that should be used for the request. For example, to use version \&quot;2020.04\&quot;, set the value to \&quot;application/vnd.dyspatch.2020.04+json\&quot;</param>
        /// <param name="cursor">A cursor value used to retrieve a specific page from a paginated result set. (optional)</param>
        /// <returns>TemplatesRead</returns>
        TemplatesRead GetTemplates (string accept, string cursor = default(string));

        /// <summary>
        /// List Templates
        /// </summary>
        /// <remarks>
        /// Gets a list of Template Metadata objects for all templates. Up to 25 results returned before results are paginated.
        /// </remarks>
        /// <exception cref="IO.Dyspatch.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accept">A version of the API that should be used for the request. For example, to use version \&quot;2020.04\&quot;, set the value to \&quot;application/vnd.dyspatch.2020.04+json\&quot;</param>
        /// <param name="cursor">A cursor value used to retrieve a specific page from a paginated result set. (optional)</param>
        /// <returns>ApiResponse of TemplatesRead</returns>
        ApiResponse<TemplatesRead> GetTemplatesWithHttpInfo (string accept, string cursor = default(string));
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Get Template by ID
        /// </summary>
        /// <remarks>
        /// Gets a template object with the matching ID. If the template has published content the \&quot;compiled\&quot; field will contain the template .
        /// </remarks>
        /// <exception cref="IO.Dyspatch.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="templateId">A template ID</param>
        /// <param name="targetLanguage">The type of templating language to compile as. Should only be used for visual templates.</param>
        /// <param name="accept">A version of the API that should be used for the request. For example, to use version \&quot;2020.04\&quot;, set the value to \&quot;application/vnd.dyspatch.2020.04+json\&quot;</param>
        /// <returns>Task of TemplateRead</returns>
        System.Threading.Tasks.Task<TemplateRead> GetTemplateByIdAsync (string templateId, string targetLanguage, string accept);

        /// <summary>
        /// Get Template by ID
        /// </summary>
        /// <remarks>
        /// Gets a template object with the matching ID. If the template has published content the \&quot;compiled\&quot; field will contain the template .
        /// </remarks>
        /// <exception cref="IO.Dyspatch.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="templateId">A template ID</param>
        /// <param name="targetLanguage">The type of templating language to compile as. Should only be used for visual templates.</param>
        /// <param name="accept">A version of the API that should be used for the request. For example, to use version \&quot;2020.04\&quot;, set the value to \&quot;application/vnd.dyspatch.2020.04+json\&quot;</param>
        /// <returns>Task of ApiResponse (TemplateRead)</returns>
        System.Threading.Tasks.Task<ApiResponse<TemplateRead>> GetTemplateByIdAsyncWithHttpInfo (string templateId, string targetLanguage, string accept);
        /// <summary>
        /// List Templates
        /// </summary>
        /// <remarks>
        /// Gets a list of Template Metadata objects for all templates. Up to 25 results returned before results are paginated.
        /// </remarks>
        /// <exception cref="IO.Dyspatch.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accept">A version of the API that should be used for the request. For example, to use version \&quot;2020.04\&quot;, set the value to \&quot;application/vnd.dyspatch.2020.04+json\&quot;</param>
        /// <param name="cursor">A cursor value used to retrieve a specific page from a paginated result set. (optional)</param>
        /// <returns>Task of TemplatesRead</returns>
        System.Threading.Tasks.Task<TemplatesRead> GetTemplatesAsync (string accept, string cursor = default(string));

        /// <summary>
        /// List Templates
        /// </summary>
        /// <remarks>
        /// Gets a list of Template Metadata objects for all templates. Up to 25 results returned before results are paginated.
        /// </remarks>
        /// <exception cref="IO.Dyspatch.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accept">A version of the API that should be used for the request. For example, to use version \&quot;2020.04\&quot;, set the value to \&quot;application/vnd.dyspatch.2020.04+json\&quot;</param>
        /// <param name="cursor">A cursor value used to retrieve a specific page from a paginated result set. (optional)</param>
        /// <returns>Task of ApiResponse (TemplatesRead)</returns>
        System.Threading.Tasks.Task<ApiResponse<TemplatesRead>> GetTemplatesAsyncWithHttpInfo (string accept, string cursor = default(string));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class TemplatesApi : ITemplatesApi
    {
        private IO.Dyspatch.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="TemplatesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public TemplatesApi(String basePath)
        {
            this.Configuration = new IO.Dyspatch.Client.Configuration { BasePath = basePath };

            ExceptionFactory = IO.Dyspatch.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TemplatesApi"/> class
        /// </summary>
        /// <returns></returns>
        public TemplatesApi()
        {
            this.Configuration = IO.Dyspatch.Client.Configuration.Default;

            ExceptionFactory = IO.Dyspatch.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TemplatesApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public TemplatesApi(IO.Dyspatch.Client.Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = IO.Dyspatch.Client.Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = IO.Dyspatch.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public IO.Dyspatch.Client.Configuration Configuration {get; set;}

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
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public IDictionary<String, String> DefaultHeader()
        {
            return new ReadOnlyDictionary<string, string>(this.Configuration.DefaultHeader);
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        /// Get Template by ID Gets a template object with the matching ID. If the template has published content the \&quot;compiled\&quot; field will contain the template .
        /// </summary>
        /// <exception cref="IO.Dyspatch.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="templateId">A template ID</param>
        /// <param name="targetLanguage">The type of templating language to compile as. Should only be used for visual templates.</param>
        /// <param name="accept">A version of the API that should be used for the request. For example, to use version \&quot;2020.04\&quot;, set the value to \&quot;application/vnd.dyspatch.2020.04+json\&quot;</param>
        /// <returns>TemplateRead</returns>
        public TemplateRead GetTemplateById (string templateId, string targetLanguage, string accept)
        {
             ApiResponse<TemplateRead> localVarResponse = GetTemplateByIdWithHttpInfo(templateId, targetLanguage, accept);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get Template by ID Gets a template object with the matching ID. If the template has published content the \&quot;compiled\&quot; field will contain the template .
        /// </summary>
        /// <exception cref="IO.Dyspatch.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="templateId">A template ID</param>
        /// <param name="targetLanguage">The type of templating language to compile as. Should only be used for visual templates.</param>
        /// <param name="accept">A version of the API that should be used for the request. For example, to use version \&quot;2020.04\&quot;, set the value to \&quot;application/vnd.dyspatch.2020.04+json\&quot;</param>
        /// <returns>ApiResponse of TemplateRead</returns>
        public ApiResponse<TemplateRead> GetTemplateByIdWithHttpInfo (string templateId, string targetLanguage, string accept)
        {
            // verify the required parameter 'templateId' is set
            if (templateId == null)
                throw new ApiException(400, "Missing required parameter 'templateId' when calling TemplatesApi->GetTemplateById");
            // verify the required parameter 'targetLanguage' is set
            if (targetLanguage == null)
                throw new ApiException(400, "Missing required parameter 'targetLanguage' when calling TemplatesApi->GetTemplateById");
            // verify the required parameter 'accept' is set
            if (accept == null)
                throw new ApiException(400, "Missing required parameter 'accept' when calling TemplatesApi->GetTemplateById");

            var localVarPath = "./templates/{templateId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/vnd.dyspatch.2020.04+json",
                "*/*"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (templateId != null) localVarPathParams.Add("templateId", this.Configuration.ApiClient.ParameterToString(templateId)); // path parameter
            if (targetLanguage != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "targetLanguage", targetLanguage)); // query parameter
            if (accept != null) localVarHeaderParams.Add("Accept", this.Configuration.ApiClient.ParameterToString(accept)); // header parameter

            // authentication (Bearer) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = this.Configuration.GetApiKeyWithPrefix("Authorization");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetTemplateById", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<TemplateRead>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (TemplateRead) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(TemplateRead)));
        }

        /// <summary>
        /// Get Template by ID Gets a template object with the matching ID. If the template has published content the \&quot;compiled\&quot; field will contain the template .
        /// </summary>
        /// <exception cref="IO.Dyspatch.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="templateId">A template ID</param>
        /// <param name="targetLanguage">The type of templating language to compile as. Should only be used for visual templates.</param>
        /// <param name="accept">A version of the API that should be used for the request. For example, to use version \&quot;2020.04\&quot;, set the value to \&quot;application/vnd.dyspatch.2020.04+json\&quot;</param>
        /// <returns>Task of TemplateRead</returns>
        public async System.Threading.Tasks.Task<TemplateRead> GetTemplateByIdAsync (string templateId, string targetLanguage, string accept)
        {
             ApiResponse<TemplateRead> localVarResponse = await GetTemplateByIdAsyncWithHttpInfo(templateId, targetLanguage, accept);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get Template by ID Gets a template object with the matching ID. If the template has published content the \&quot;compiled\&quot; field will contain the template .
        /// </summary>
        /// <exception cref="IO.Dyspatch.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="templateId">A template ID</param>
        /// <param name="targetLanguage">The type of templating language to compile as. Should only be used for visual templates.</param>
        /// <param name="accept">A version of the API that should be used for the request. For example, to use version \&quot;2020.04\&quot;, set the value to \&quot;application/vnd.dyspatch.2020.04+json\&quot;</param>
        /// <returns>Task of ApiResponse (TemplateRead)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TemplateRead>> GetTemplateByIdAsyncWithHttpInfo (string templateId, string targetLanguage, string accept)
        {
            // verify the required parameter 'templateId' is set
            if (templateId == null)
                throw new ApiException(400, "Missing required parameter 'templateId' when calling TemplatesApi->GetTemplateById");
            // verify the required parameter 'targetLanguage' is set
            if (targetLanguage == null)
                throw new ApiException(400, "Missing required parameter 'targetLanguage' when calling TemplatesApi->GetTemplateById");
            // verify the required parameter 'accept' is set
            if (accept == null)
                throw new ApiException(400, "Missing required parameter 'accept' when calling TemplatesApi->GetTemplateById");

            var localVarPath = "./templates/{templateId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/vnd.dyspatch.2020.04+json",
                "*/*"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (templateId != null) localVarPathParams.Add("templateId", this.Configuration.ApiClient.ParameterToString(templateId)); // path parameter
            if (targetLanguage != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "targetLanguage", targetLanguage)); // query parameter
            if (accept != null) localVarHeaderParams.Add("Accept", this.Configuration.ApiClient.ParameterToString(accept)); // header parameter

            // authentication (Bearer) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = this.Configuration.GetApiKeyWithPrefix("Authorization");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetTemplateById", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<TemplateRead>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (TemplateRead) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(TemplateRead)));
        }

        /// <summary>
        /// List Templates Gets a list of Template Metadata objects for all templates. Up to 25 results returned before results are paginated.
        /// </summary>
        /// <exception cref="IO.Dyspatch.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accept">A version of the API that should be used for the request. For example, to use version \&quot;2020.04\&quot;, set the value to \&quot;application/vnd.dyspatch.2020.04+json\&quot;</param>
        /// <param name="cursor">A cursor value used to retrieve a specific page from a paginated result set. (optional)</param>
        /// <returns>TemplatesRead</returns>
        public TemplatesRead GetTemplates (string accept, string cursor = default(string))
        {
             ApiResponse<TemplatesRead> localVarResponse = GetTemplatesWithHttpInfo(accept, cursor);
             return localVarResponse.Data;
        }

        /// <summary>
        /// List Templates Gets a list of Template Metadata objects for all templates. Up to 25 results returned before results are paginated.
        /// </summary>
        /// <exception cref="IO.Dyspatch.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accept">A version of the API that should be used for the request. For example, to use version \&quot;2020.04\&quot;, set the value to \&quot;application/vnd.dyspatch.2020.04+json\&quot;</param>
        /// <param name="cursor">A cursor value used to retrieve a specific page from a paginated result set. (optional)</param>
        /// <returns>ApiResponse of TemplatesRead</returns>
        public ApiResponse<TemplatesRead> GetTemplatesWithHttpInfo (string accept, string cursor = default(string))
        {
            // verify the required parameter 'accept' is set
            if (accept == null)
                throw new ApiException(400, "Missing required parameter 'accept' when calling TemplatesApi->GetTemplates");

            var localVarPath = "./templates";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/vnd.dyspatch.2020.04+json",
                "*/*"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (cursor != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "cursor", cursor)); // query parameter
            if (accept != null) localVarHeaderParams.Add("Accept", this.Configuration.ApiClient.ParameterToString(accept)); // header parameter

            // authentication (Bearer) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = this.Configuration.GetApiKeyWithPrefix("Authorization");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetTemplates", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<TemplatesRead>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (TemplatesRead) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(TemplatesRead)));
        }

        /// <summary>
        /// List Templates Gets a list of Template Metadata objects for all templates. Up to 25 results returned before results are paginated.
        /// </summary>
        /// <exception cref="IO.Dyspatch.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accept">A version of the API that should be used for the request. For example, to use version \&quot;2020.04\&quot;, set the value to \&quot;application/vnd.dyspatch.2020.04+json\&quot;</param>
        /// <param name="cursor">A cursor value used to retrieve a specific page from a paginated result set. (optional)</param>
        /// <returns>Task of TemplatesRead</returns>
        public async System.Threading.Tasks.Task<TemplatesRead> GetTemplatesAsync (string accept, string cursor = default(string))
        {
             ApiResponse<TemplatesRead> localVarResponse = await GetTemplatesAsyncWithHttpInfo(accept, cursor);
             return localVarResponse.Data;

        }

        /// <summary>
        /// List Templates Gets a list of Template Metadata objects for all templates. Up to 25 results returned before results are paginated.
        /// </summary>
        /// <exception cref="IO.Dyspatch.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accept">A version of the API that should be used for the request. For example, to use version \&quot;2020.04\&quot;, set the value to \&quot;application/vnd.dyspatch.2020.04+json\&quot;</param>
        /// <param name="cursor">A cursor value used to retrieve a specific page from a paginated result set. (optional)</param>
        /// <returns>Task of ApiResponse (TemplatesRead)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TemplatesRead>> GetTemplatesAsyncWithHttpInfo (string accept, string cursor = default(string))
        {
            // verify the required parameter 'accept' is set
            if (accept == null)
                throw new ApiException(400, "Missing required parameter 'accept' when calling TemplatesApi->GetTemplates");

            var localVarPath = "./templates";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/vnd.dyspatch.2020.04+json",
                "*/*"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (cursor != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "cursor", cursor)); // query parameter
            if (accept != null) localVarHeaderParams.Add("Accept", this.Configuration.ApiClient.ParameterToString(accept)); // header parameter

            // authentication (Bearer) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = this.Configuration.GetApiKeyWithPrefix("Authorization");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetTemplates", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<TemplatesRead>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (TemplatesRead) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(TemplatesRead)));
        }

    }
}
