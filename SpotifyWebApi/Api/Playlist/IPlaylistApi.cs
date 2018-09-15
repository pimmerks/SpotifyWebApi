namespace SpotifyWebApi.Api.Playlist
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Model;
    using Model.Enum;
    using Model.Uri;

    /// <summary>
    /// The playlist api.
    /// </summary>
    public interface IPlaylistApi
    {
        /// <summary>
        /// Get a list of the playlists owned or followed by a Spotify user.
        /// </summary>
        /// <param name="user">The <see cref="SpotifyUri"/> of the user.</param>
        /// <param name="maxResults">The maximum items to retrieve.</param>
        /// <param name="offset">Optional. The index of the first playlist to return.
        /// Default: 0 (the first object).
        /// Maximum offset: 100.000. Use with limit to get the next set of playlists.</param>
        /// <returns>A list of <see cref="SimplePlaylist"/>s.</returns>
        Task<IList<SimplePlaylist>> GetUsersPlaylist(SpotifyUri user, int maxResults = 100, int offset = 0);

        /// <summary>
        /// Get a list of the playlists owned or followed by the current Spotify user.
        /// </summary>
        /// <param name="maxResults">The maximum items to retrieve.</param>
        /// <param name="offset">Optional. The index of the first playlist to return.
        /// Default: 0 (the first object).
        /// Maximum offset: 100.000. Use with limit to get the next set of playlists.</param>
        /// <returns>A list of <see cref="SimplePlaylist"/>s.</returns>
        Task<IList<SimplePlaylist>> GetMyPlaylists(int maxResults = 100, int offset = 0);

        /// <summary>
        /// Get a playlist owned by a Spotify user.
        /// </summary>
        /// <param name="playlistUri">The <see cref="SpotifyUri"/> for the playlist.</param>
        /// <param name="market">Optional. An ISO 3166-1 alpha-2 country code. Provide this parameter if you want to apply Track Relinking.</param>
        /// <returns>A <see cref="FullPlaylist"/> object.</returns>
        Task<FullPlaylist> GetPlaylist(SpotifyUri playlistUri, string market = null);

        /// <summary>
        /// Get full details of the tracks of a playlist owned by a Spotify user.
        /// </summary>
        /// <param name="playlistUri">The <see cref="SpotifyUri"/> for the playlist.</param>
        /// <param name="maxResults">Optional. The maximum results to return.</param>
        /// <param name="offset">Optional. The index of the first track to return. Default: 0 (the first object).</param>
        /// <param name="market">Optional. An ISO 3166-1 alpha-2 country code. Provide this parameter if you want to apply Track Relinking.</param>
        /// <returns>A list of <see cref="PlaylistTrack"/> objects.</returns>
        Task<IList<PlaylistTrack>> GetPlaylistTracks(
            SpotifyUri playlistUri, int maxResults = 100, int offset = 0, string market = null);

        /// <summary>
        /// Create a playlist for a Spotify user.
        /// See Remarks for <paramref name="public"/> and <paramref name="collaborative"/> parameters.
        /// </summary>
        /// <param name="user">The <see cref="SpotifyUri"/> of the user.</param>
        /// <param name="name">The name for the new playlist, for example "Your Coolest Playlist". This name does not need to be unique; a user may have several playlists with the same name.</param>
        /// <param name="public">Optional. If true the playlist will be public, if false it will be private.</param>
        /// <param name="collaborative">Optional. If true the playlist will be collaborative. Note that to create a collaborative playlist you must also set public to false.</param>
        /// <param name="description">Optional. Value for playlist description as displayed in Spotify Clients and in the Web API.</param>
        /// <returns>The created <see cref="FullPlaylist"/>.</returns>
        /// <remarks>
        /// Note: that the playlist will be empty until you add tracks.
        /// Note: To be able to create private playlists, the user must have granted the <see cref="Scope.PlaylistModifyPrivate"/> scope.
        /// Note: To create collaborative playlists you must have granted <see cref="Scope.PlaylistModifyPrivate"/> and <see cref="Scope.PlaylistModifyPublic"/> scopes.
        /// </remarks>
        Task<FullPlaylist> CreatePlaylist(
            SpotifyUri user, string name, bool @public = true, bool collaborative = false, string description = "");

        /// <summary>
        /// Add one or more tracks to a user’s playlist.
        /// </summary>
        /// <param name="playlistUri">The <see cref="SpotifyUri"/> for the playlist.</param>
        /// <param name="tracks">A list of <see cref="SpotifyUri"/>'s to add to the playlist.</param>
        /// <param name="position">Optional. The position to insert the tracks, a zero-based index.</param>
        /// <returns>Tha add tracks to playlist task.</returns>
        Task AddTracksToPlaylist(SpotifyUri playlistUri, IList<SpotifyUri> tracks, int? position = null);

        // TODO: More functions:
        // https://developer.spotify.com/web-api/remove-tracks-playlist/
        // https://developer.spotify.com/web-api/reorder-playlists-tracks/
        // https://developer.spotify.com/web-api/replace-playlists-tracks/
        // https://developer.spotify.com/web-api/change-playlist-details/
    }
}