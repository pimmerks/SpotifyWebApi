namespace Spotify.WebApi.Apis.Album
{
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading.Tasks;
    using Spotify.WebApi.Business;
    using Spotify.WebApi.Model.Authentication;
    using Spotify.WebApi.Model.Objects;
    using Spotify.WebApi.Model.Objects.Albums;
    using Spotify.WebApi.Model.Objects.Tracks;

    /// <inheritdoc cref="IAlbumApi" />
    public class AlbumApi : SpotifyBaseClient, IAlbumApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlbumApi"/> class.
        /// </summary>
        /// <param name="token">A <see cref="Token"/>.</param>
        /// <param name="httpClient">An instance of a <see cref="HttpClient"/>.</param>
        /// <param name="serializer">The <see cref="Serializer"/>.</param>
        public AlbumApi(Token token, HttpClient httpClient, Serializer? serializer = null)
            : base(httpClient, token, serializer)
        {
        }

        /// <inheritdoc/>
        public async Task<Album> GetAlbumAsync(string id, string? market = null)
        {
            var uri = UriHelper.FromUri($"albums/{id}")
                               .AddParameter("market", market)
                               .Uri;

            return await this.GetAsync<Album>(uri);
        }

        /// <inheritdoc/>
        public async Task<Paging<SimpleTrack>> GetAlbumsTrackAsync(
            string id, int? limit = null, int? offset = null, string? market = null)
        {
            var uri = UriHelper.FromUri($"albums/{id}/tracks")
                               .AddParameter("limit", limit)
                               .AddParameter("offset", offset)
                               .AddParameter("market", market)
                               .Uri;

            return await this.GetAsync<Paging<SimpleTrack>>(uri);
        }

        /// <inheritdoc/>
        public async Task<List<Album>> GetAlbumsAsync(List<string> ids, string? market = null)
        {
            var uri = UriHelper.FromUri($"albums?ids={string.Join(',', ids)}")
                               .AddParameter("market", market)
                               .Uri;

            var albums = await this.GetAsync<MultipleAlbums>(uri);
            return albums.Albums;
        }
    }
}
