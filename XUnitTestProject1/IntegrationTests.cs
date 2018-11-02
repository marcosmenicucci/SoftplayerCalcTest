using Microsoft.AspNetCore.Mvc.Testing;
using SoftplayerCalcTest;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;


namespace XUnitTestProject1
{
    public class IntegrationTests 
    {
        private readonly TestContext _testContext;
        public IntegrationTests()
        {
            _testContext = new TestContext();
        }

        [Fact]
        public async Task TestReturnsOkResponse()
        {
            var response = await _testContext.Client.GetAsync("/api/calculajuros/100/5");
            response.EnsureSuccessStatusCode();
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }

        [Fact]
        public async Task TestReturnsBadRequestResponse()
        {
            var response = await _testContext.Client.GetAsync("/api/calculajuros/100.00/5.2");
            Assert.Equal(HttpStatusCode.BadRequest, response.StatusCode);
        }

        [Fact]
        public async Task TestCorrectContentType()
        {
            var response = await _testContext.Client.GetAsync("/api/calculajuros/100/5");
            response.EnsureSuccessStatusCode();
            Assert.Equal("text/plain; charset=utf-8", response.Content.Headers.ContentType.ToString());
        }
    }
}
