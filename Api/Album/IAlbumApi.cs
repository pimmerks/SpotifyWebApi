namespace SpotifyWebApi.Api.Album
{
    using System.Collections.Generic;
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
        FullAlbum GetAlbum(SpotifyUri albumUri, string market = "");

        /// <summary>
        /// Get Spotify catalog information for multiple albums identified by their Spotify URIs.
        /// </summary>
        /// <param name="albumUris">A list of the Spotify URIs for the albums. Maximum: 20 IDs.</param>
        /// <param name="market">Optional. An ISO 3166-1 alpha-2 country code. Provide this parameter if you want to apply Track Relinking.</param>
        /// <returns>The retrieved <see cref="FullAlbum"/>s.</returns>
        IList<FullAlbum> GetAlbums(IList<SpotifyUri> albumUris, string market = "");

        /// <summary>
        /// Get Spotify catalog information about an album’s tracks. Optional parameters can be used to limit the number of tracks returned.
        /// </summary>
        /// <param name="albumUri">The <see cref="SpotifyUri"/> for the album</param>
        /// <param name="limit">Optional. The maximum number of tracks to return. Default: 20. Minimum: 1. Maximum: 50. </param>
        /// <param name="offset">Optional. The index of the first track to return. Default: 0 (the first object). Use with limit to get the next set of tracks. </param>
        /// <param name="market">Optional. An ISO 3166-1 alpha-2 country code. Provide this parameter if you want to apply Track Relinking.</param>
        /// <returns>The retrieved tracks.</returns>
        Paging<SimpleTrack> GetAlbumTracks(SpotifyUri albumUri, int limit = 20, int offset = 0, string market = "");
    }
}