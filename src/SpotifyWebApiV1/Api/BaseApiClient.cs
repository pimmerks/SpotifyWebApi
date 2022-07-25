namespace SpotifyWebApi.Api
{
    using System.Net.Http;
    using SpotifyWebApi.Models.Auth;

    public abstract class BaseApiClient
    {
        protected BaseApiClient(HttpClient httpClient, Token accessToken, Uri? baseUri = null)
        {
            this.AccessToken = accessToken;
            this.HttpClient = httpClient;

            if (baseUri != null)
            {
                this.HttpClient.BaseAddress = baseUri;
            }
        }

        protected Token AccessToken { get; }

        protected HttpClient HttpClient { get; }
    }
}
