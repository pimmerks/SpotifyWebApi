namespace Spotify.Api.Album
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Model;
    using Model.Uri;

    /// <summary>
    /// The album api.
    /// </summary>
    public interface IAlbumApi
    {
        /// <summary>
        /// Get Spotify catalog information for a single album.
        /// </summary>
        /// <param name="albumUri">The <see cref="SpotifyUri"/> for the album</param>
        /// <param name="market">Optional. An ISO 3166-1 alpha-2 country code. Provide this parameter if you want to apply Track Relinking.</param>
        /// <returns>The retrieved <see cref="FullAlbum"/>.</returns>
        Task<FullAlbum> GetAlbum(SpotifyUri albumUri, string market = "");

        /// <summary>
        /// Get Spotify catalog information for multiple albums identified by their Spotify URIs.
        /// </summary>
        /// <param name="albumUris">A list of the Spotify URIs for the albums. Maximum: 20 IDs.</param>
        /// <param name="market">Optional. An ISO 3166-1 alpha-2 country code. Provide this parameter if you want to apply Track Relinking.</param>
        /// <returns>The retrieved <see cref="FullAlbum"/>s.</returns>
        Task<IList<FullAlbum>> GetAlbums(IList<SpotifyUri> albumUris, string market = "");

        /// <summary>
        /// Get Spotify catalog information about an album’s tracks. Optional parameters can be used to limit the number of tracks returned.
        /// </summary>
        /// <param name="albumUri">The <see cref="SpotifyUri"/> for the album</param>
        /// <param name="market">Optional. An ISO 3166-1 alpha-2 country code. Provide this parameter if you want to apply Track Relinking.</param>
        /// <returns>The retrieved tracks.</returns>
        Task<IList<SimpleTrack>> GetAlbumTracks(SpotifyUri albumUri, string market = "");
    }
}