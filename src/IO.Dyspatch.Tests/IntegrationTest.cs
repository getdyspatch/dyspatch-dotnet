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
            Configuration config = new Configuration();
            config.ApiKey.Add(
                "Authorization",
                Environment.GetEnvironmentVariable("DYSPATCH_API_KEY")
            );
            config.ApiKeyPrefix.Add("Authorization", "Bearer");

            drafts = new DraftsApi(config);
            templates = new TemplatesApi(config);
        }


        [Fact]
        public void GetTemplates()
        {
            var accept = "application/vnd.dyspatch.2019.10+json";
            templates.GetTemplates(accept, "");
        }

        [Fact]
        public void GetDrafts()
        {
            var accept = "application/vnd.dyspatch.2019.10+json";
            drafts.GetDrafts(accept, "");
        }
    }
}
