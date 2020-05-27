namespace Spotify.WebApi.Business
{
    using System;
    using System.Net.Http;
    using System.Threading.Tasks;
    using Spotify.WebApi.Model.Authentication;

    /// <summary>
    /// Spotify base client.
    /// </summary>
    public abstract class SpotifyBaseClient
    {
        protected readonly HttpClient client;
        protected readonly Serializer serializer;

        /// <summary>
        /// Gets the token.
        /// </summary>
        public Token Token { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="SpotifyBaseClient"/> class.
        /// </summary>
        /// <param name="client">An instance of a <see cref="HttpClient"/>.</param>
        /// <param name="token">A <see cref="Token"/>.</param>
        /// <param name="serializer">The <see cref="Serializer"/>.</param>
        protected SpotifyBaseClient(HttpClient client, Token? token = null, Serializer? serializer = null)
        {
            this.client = client;
            this.serializer = serializer ?? new Serializer();

            if (token != null)
            {
                this.UpdateToken(token);
            }
        }

        /// <summary>
        /// Updates a token.
        /// </summary>
        /// <param name="newToken">The new token.</param>
        public void UpdateToken(Token newToken)
        {
            this.Token = newToken;
            this.client.AddToken(this.Token);
        }
        
        /// <summary>
        /// Send a GET request to the specified uri.
        /// </summary>
        /// <param name="uri">The uri.</param>
        /// <typeparam name="T">The expected return type.</typeparam>
        /// <returns>An object of <see cref="T"/>.</returns>
        protected async Task<T> GetAsync<T>(Uri uri)
        {
            using var response = await this.client.GetAsync(uri);

            // TODO: Maybe throw some custom errors here.
            response.EnsureSuccessStatusCode();

            var json = await response.Content.ReadAsStringAsync();

            return this.serializer.Deserialize<T>(json);
        }
    }
}
