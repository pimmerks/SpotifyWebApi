namespace Spotify.WebApi
{
    using System.Net.Http;
    using Spotify.WebApi.Apis.Album;
    using Spotify.WebApi.Business;
    using Spotify.WebApi.Model.Authentication;

    /// <summary>
    /// The main Spotify web Api class.
    /// </summary>
    public class SpotifyWebApi : SpotifyBaseClient, ISpotifyWebApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SpotifyWebApi"/> class without token.
        /// </summary>
        /// <param name="httpClient">A <see cref="HttpClient"/> that will not be disposed.</param>
        public SpotifyWebApi(HttpClient httpClient)
            : this(null, httpClient)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SpotifyWebApi"/> class.
        /// </summary>
        /// <param name="token">A <see cref="Token"/>.</param>
        /// <param name="httpClient">A <see cref="HttpClient"/> that will not be disposed.</param>
        public SpotifyWebApi(Token token, HttpClient httpClient)
            : base(httpClient, token, new Serializer())
        {
        }

        /// <inheritdoc/>
        public IAlbumApi Album => new AlbumApi(this.Token, this.client, this.serializer);
    }
}
