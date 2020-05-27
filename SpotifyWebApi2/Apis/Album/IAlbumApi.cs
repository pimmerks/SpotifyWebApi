namespace Spotify.WebApi.Apis.Album
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Spotify.WebApi.Model;
    using Spotify.WebApi.Model.Objects;
    using Spotify.WebApi.Model.Objects.Albums;
    using Spotify.WebApi.Model.Objects.Tracks;

    /// <summary>
    /// Main interface for the Album Api.
    /// </summary>
    public interface IAlbumApi
    {
        /// <summary>
        /// Get Spotify catalog information for a single album.
        /// </summary>
        /// <param name="uri">The <see cref="SpotifyUri"/> for the album.</param>
        /// <param name="market">Optional. An ISO 3166-1 alpha-2 country code or the string from_token.
        /// Provide this parameter if you want to apply Track Relinking.</param>
        /// <returns>A <see cref="Album"/>.</returns>
        public Task<Album> GetAlbumAsync(SpotifyUri uri, string? market = null) => this.GetAlbumAsync(uri.Id, market);

        /// <summary>
        /// Get Spotify catalog information for a single album.
        /// </summary>
        /// <param name="id">The Spotify Id for the album.</param>
        /// <param name="market">Optional. An ISO 3166-1 alpha-2 country code or the string from_token.
        /// Provide this parameter if you want to apply Track Relinking.</param>
        /// <returns>A <see cref="Album"/>.</returns>
        public Task<Album> GetAlbumAsync(string id, string? market = null);

        /// <summary>
        /// Get Spotify catalog information about an album’s tracks. Optional parameters can be used to limit the
        /// number of tracks returned.
        /// </summary>
        /// <param name="uri">The <see cref="SpotifyUri"/> for the album.</param>
        /// <param name="limit">Optional. The maximum number of tracks to return. Default: 20. Minimum: 1. Maximum: 50.
        /// </param>
        /// <param name="offset">Optional. The index of the first track to return. Default: 0 (the first object).
        /// Use with limit to get the next set of tracks.</param>
        /// <param name="market">Optional. An ISO 3166-1 alpha-2 country code or the string from_token.
        /// Provide this parameter if you want to apply Track Relinking.</param>
        /// <returns>A <see cref="Paging{SimpleTrack}"/>.</returns>
        public Task<Paging<SimpleTrack>> GetAlbumsTrackAsync(
            SpotifyUri uri, int? limit = null, int? offset = null, string? market = null) =>
            this.GetAlbumsTrackAsync(uri.Id, limit, offset, market);

        /// <summary>
        /// Get Spotify catalog information about an album’s tracks. Optional parameters can be used to limit the
        /// number of tracks returned.
        /// </summary>
        /// <param name="id">The Spotify Id for the album.</param>
        /// <param name="limit">Optional. The maximum number of tracks to return. Default: 20. Minimum: 1. Maximum: 50.
        /// </param>
        /// <param name="offset">Optional. The index of the first track to return. Default: 0 (the first object).
        /// Use with limit to get the next set of tracks.</param>
        /// <param name="market">Optional. An ISO 3166-1 alpha-2 country code or the string from_token.
        /// Provide this parameter if you want to apply Track Relinking.</param>
        /// <returns>A <see cref="Paging{SimpleTrack}"/>.</returns>
        public Task<Paging<SimpleTrack>> GetAlbumsTrackAsync(
            string id, int? limit = null, int? offset = null, string? market = null);

        /// <summary>
        /// Get Spotify catalog information for multiple albums identified by their Spotify IDs.
        /// </summary>
        /// <param name="ids">Required. A list of <see cref="SpotifyUri"/> for the albums. Maximum: 20 IDs.</param>
        /// <param name="market">Optional. An ISO 3166-1 alpha-2 country code or the string from_token.
        /// Provide this parameter if you want to apply Track Relinking.</param>
        /// <returns>A list of <see cref="Album"/>s.</returns>
        public Task<List<Album>> GetAlbumsAsync(List<SpotifyUri> ids, string? market = null)
            => this.GetAlbumsAsync(ids.Select(x => x.Id).ToList(), market);

        /// <summary>
        /// Get Spotify catalog information for multiple albums identified by their Spotify IDs.
        /// </summary>
        /// <param name="ids">Required. A list of Spotify Ids for the albums. Maximum: 20 IDs.</param>
        /// <returns>A list of <see cref="Album"/>s.</returns>
        public Task<List<Album>> GetAlbumsAsync(params string[] ids)
            => this.GetAlbumsAsync(ids.ToList());

        /// <summary>
        /// Get Spotify catalog information for multiple albums identified by their Spotify IDs.
        /// </summary>
        /// <param name="ids">Required. A list oof Spotify Ids for the albums. Maximum: 20 IDs.</param>
        /// <param name="market">Optional. An ISO 3166-1 alpha-2 country code or the string from_token.
        /// Provide this parameter if you want to apply Track Relinking.</param>
        /// <returns>A list of <see cref="Album"/>s.</returns>
        public Task<List<Album>> GetAlbumsAsync(List<string> ids, string? market = null);
    }
}
