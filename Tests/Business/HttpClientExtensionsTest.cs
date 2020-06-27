namespace Spotify.WebApi.Tests.Business
{
    using System.Net.Http;
    using Spotify.WebApi.Business;
    using Spotify.WebApi.Model.Authentication;
    using Xunit;

    public class HttpClientExtensionsTest
    {
        [Fact]
        public void HasToken_ReturnsTrueWithToken()
        {
            using var httpClient = new HttpClient();
            var token = Token.Make("access_token");
            httpClient.AddToken(token);
            Assert.Equal("access_token", httpClient.DefaultRequestHeaders.Authorization.Parameter);
        }
    }
}
