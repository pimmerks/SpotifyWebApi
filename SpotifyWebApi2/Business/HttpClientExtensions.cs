namespace Spotify.WebApi.Business
{
    using System;
    using System.Net.Http;
    using System.Net.Http.Headers;
    using System.Threading.Tasks;
    using Model.Authentication;

    internal static class HttpClientExtensions
    {
        public static bool HasToken(this HttpClient client)
        {
            if (client.DefaultRequestHeaders.Authorization == null)
            {
                return false;
            }

            return true;
        }
        
        /// <summary>
        /// Adds the authorization header of a <see cref="Token"/> to this http client.
        /// </summary>
        /// <param name="client">The <see cref="HttpClient"/> to add this token to.</param>
        /// <param name="token">The token to add.</param>
        public static void AddToken(this HttpClient client, Token token)
        {
            if (client.HasToken())
            {
                return;
            }

            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(
                token.Type, token.AccessToken);
        }
        
        public static async Task<T> GetAsync<T>(this HttpClient client, Uri uri)
        {
            using var response = await client.GetAsync(uri);
            
            // TODO: Maybe throw some custom errors here.
            response.EnsureSuccessStatusCode();

            var json = await response.Content.ReadAsStringAsync();

            return Serializer.Deserialize<T>(json);
        }
    }
}
