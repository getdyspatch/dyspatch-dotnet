using System;
using Xunit;
using IO.Dyspatch.Api;
using IO.Dyspatch.Client;
using IO.Dyspatch.Model;

namespace IO.Dyspatch.Tests
{
    public class IntegrationTest
    {
        DraftsApi drafts;
        TemplatesApi templates;

        public IntegrationTest()
        {
            Configuration.Default.ApiKey.Add("Authorization", "TODO");
            Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            drafts = new DraftsApi(Configuration.Default);
            templates = new TemplatesApi(Configuration.Default);
        }


        [Fact]
        public void GetTemplates()
        {
        }
    }
}
