/* 
 * Dyspatch API
 *
 * # Introduction  The Dyspatch API is based on the REST paradigm, and features resource based URLs with standard HTTP response codes to indicate errors. We use standard HTTP authentication and request verbs, and all responses are JSON formatted. See our [Implementation Guide](https://docs.dyspatch.io/development/implementing_dyspatch/) for more details on how to implement Dyspatch.  ## API Client Libraries Dyspatch provides API Clients for popular languages and web frameworks.  - [Java](https://github.com/getdyspatch/dyspatch-java) - [Javascript](https://github.com/getdyspatch/dyspatch-javascript) - [Python](https://github.com/getdyspatch/dyspatch-python) - [C#](https://github.com/getdyspatch/dyspatch-dotnet) - [Go](https://github.com/getdyspatch/dyspatch-golang) - [Ruby](https://github.com/getdyspatch/dyspatch-ruby) 
 *
 * The version of the OpenAPI document: 2020.08
 * Contact: support@dyspatch.io
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using Xunit;

using IO.Dyspatch.Client;
using IO.Dyspatch.Api;
using IO.Dyspatch.Model;

namespace IO.Dyspatch.Test
{
    /// <summary>
    ///  Class for testing LocalizationsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class LocalizationsApiTests : IDisposable
    {
        private LocalizationsApi instance;

        public LocalizationsApiTests()
        {
            instance = new LocalizationsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of LocalizationsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' LocalizationsApi
            //Assert.IsType(typeof(LocalizationsApi), instance, "instance is a LocalizationsApi");
        }

        
        /// <summary>
        /// Test GetLocalizationById
        /// </summary>
        [Fact]
        public void GetLocalizationByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string localizationId = null;
            //string targetLanguage = null;
            //string accept = null;
            //var response = instance.GetLocalizationById(localizationId, targetLanguage, accept);
            //Assert.IsType<LocalizationRead> (response, "response is LocalizationRead");
        }
        
    }

}
