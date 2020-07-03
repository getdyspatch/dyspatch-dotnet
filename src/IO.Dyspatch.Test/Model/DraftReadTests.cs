/* 
 * Dyspatch API
 *
 * # Introduction  The Dyspatch API is based on the REST paradigm, and features resource based URLs with standard HTTP response codes to indicate errors. We use standard HTTP authentication and request verbs, and all responses are JSON formatted. See our [Implementation Guide](https://docs.dyspatch.io/development/implementing_dyspatch/) for more details on how to implement Dyspatch.  ## API Client Libraries Dyspatch provides API Clients for popular languages and web frameworks.  - [Java](https://github.com/getdyspatch/dyspatch-java) - [Javascript](https://github.com/getdyspatch/dyspatch-javascript) - [Python](https://github.com/getdyspatch/dyspatch-python) - [C#](https://github.com/getdyspatch/dyspatch-dotnet) - [Go](https://github.com/getdyspatch/dyspatch-golang) - [Ruby](https://github.com/getdyspatch/dyspatch-ruby) 
 *
 * The version of the OpenAPI document: 2020.04
 * Contact: support@dyspatch.io
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using Xunit;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using IO.Dyspatch.Api;
using IO.Dyspatch.Model;
using IO.Dyspatch.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace IO.Dyspatch.Test
{
    /// <summary>
    ///  Class for testing DraftRead
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class DraftReadTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for DraftRead
        //private DraftRead instance;

        public DraftReadTests()
        {
            // TODO uncomment below to create an instance of DraftRead
            //instance = new DraftRead();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of DraftRead
        /// </summary>
        [Fact]
        public void DraftReadInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" DraftRead
            //Assert.IsInstanceOfType<DraftRead> (instance, "variable 'instance' is a DraftRead");
        }


        /// <summary>
        /// Test the property 'Id'
        /// </summary>
        [Fact]
        public void IdTest()
        {
            // TODO unit test for the property 'Id'
        }
        /// <summary>
        /// Test the property 'Template'
        /// </summary>
        [Fact]
        public void TemplateTest()
        {
            // TODO unit test for the property 'Template'
        }
        /// <summary>
        /// Test the property 'Name'
        /// </summary>
        [Fact]
        public void NameTest()
        {
            // TODO unit test for the property 'Name'
        }
        /// <summary>
        /// Test the property 'Url'
        /// </summary>
        [Fact]
        public void UrlTest()
        {
            // TODO unit test for the property 'Url'
        }
        /// <summary>
        /// Test the property 'Compiled'
        /// </summary>
        [Fact]
        public void CompiledTest()
        {
            // TODO unit test for the property 'Compiled'
        }
        /// <summary>
        /// Test the property 'CreatedAt'
        /// </summary>
        [Fact]
        public void CreatedAtTest()
        {
            // TODO unit test for the property 'CreatedAt'
        }
        /// <summary>
        /// Test the property 'UpdatedAt'
        /// </summary>
        [Fact]
        public void UpdatedAtTest()
        {
            // TODO unit test for the property 'UpdatedAt'
        }
        /// <summary>
        /// Test the property 'Localizations'
        /// </summary>
        [Fact]
        public void LocalizationsTest()
        {
            // TODO unit test for the property 'Localizations'
        }

    }

}
