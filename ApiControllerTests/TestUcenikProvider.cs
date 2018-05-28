using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using DomUcenikaSvilajnac;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;

namespace ApiControllerTests
{
    public class TestUcenikProvider :IDisposable
    {
        private TestServer server;
        public HttpClient Client { get; private set; }
        public TestUcenikProvider()
        {
             server = new TestServer(new WebHostBuilder().UseStartup<Startup>());
             Client = server.CreateClient();
        }

        public void Dispose()
        {
            server?.Dispose();
            Client?.Dispose();          
        }
    }
}
