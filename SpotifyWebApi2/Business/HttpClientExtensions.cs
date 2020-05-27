namespace Spotify.WebApi.Business
{
    using System.Net.Http;
    using System.Net.Http.Headers;
    using Spotify.WebApi.Model.Authentication;

    /// <summary>
    /// Extension methods for the <see cref="HttpClient"/>.
    /// </summary>
    internal static class HttpClientExtensions
    {
        /// <summary>
        /// Adds the authorization header of a <see cref="Token"/> to this http client.
        /// </summary>
        /// <param name="client">The <see cref="HttpClient"/> to add this token to.</param>
        /// <param name="token">The token to add.</param>
        public static void AddToken(this HttpClient client, Token token)
        {
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(
                token.Type, token.AccessToken);
        }
    }
}
