namespace SpotifyWebApi.Api.Artist
{
    using System.Collections.Generic;
    using Model;
    using Model.Enum;
    using Model.Uri;

    /// <summary>
    /// The artist api.
    /// </summary>
    public interface IArtistApi
    {
        /// <summary>
        /// Get Spotify catalog information for a single artist identified by their unique Spotify Uri.
        /// </summary>
        /// <param name="artistUri">The <see cref="SpotifyUri"/> for the artist.</param>
        /// <returns>The retrieved Artist.</returns>
        FullArtist GetArtist(SpotifyUri artistUri);

        /// <summary>
        /// Get Spotify catalog information for several artists based on their Spotify Uris.
        /// </summary>
        /// <param name="artistUris">A list of the <see cref="SpotifyUri"/> for the artists. Maximum: 50 IDs.</param>
        /// <returns>The retrieved artists.</returns>
        IList<FullArtist> GetArtists(IList<SpotifyUri> artistUris);

        /// <summary>
        /// Get Spotify catalog information about an artist’s albums. Optional parameters can be specified in the parameters to filter the response.
        /// </summary>
        /// <param name="artistUri">The <see cref="SpotifyUri"/> for the artist.</param>
        /// <param name="albumTypes">Optional. A list of <see cref="AlbumType"/>s that will be used to filter the response. If not supplied, all album types will be returned.
        /// Note multiple types can be selected like so: 'AlbumType.Album | AlbumType.AppearsOn'.</param>
        /// <param name="market">Optional. An ISO 3166-1 alpha-2 country code. Provide this parameter if you want to apply Track Relinking.</param>
        /// <param name="limit">Optional. The number of album objects to return. Default: 20. Minimum: 1. Maximum: 50.</param>
        /// <param name="offset">Optional. The index of the first album to return. Default: 0 (i.e., the first album).</param>
        /// <returns>The artists albums.</returns>
        Paging<SimpleAlbum> GetArtistAlbums(
            SpotifyUri artistUri,
            AlbumType albumTypes = AlbumType.Album | AlbumType.AppearsOn | AlbumType.Compilation | AlbumType.Single,
            string market = "",
            int limit = 20,
            int offset = 0);

        /// <summary>
        /// Get Spotify catalog information about an artist’s top tracks by country.
        /// </summary>
        /// <param name="artistUri">The <see cref="SpotifyUri"/> for the artist.</param>
        /// <param name="market">An ISO 3166-1 alpha-2 country code. Provide this parameter if you want to apply Track Relinking.</param>
        /// <returns>The artists top track by country.</returns>
        IList<FullTrack> GetArtistsTopTracks(SpotifyUri artistUri, string market);

        /// <summary>
        /// Get Spotify catalog information about artists similar to a given artist. Similarity is based on analysis of the Spotify community’s listening history.
        /// </summary>
        /// <param name="artistUri">The <see cref="SpotifyUri"/> for the artist.</param>
        /// <returns>The related artists for the specified <paramref name="artistUri"/>.</returns>
        IList<FullArtist> GetArtistsRelatedArtists(SpotifyUri artistUri);
    }
}