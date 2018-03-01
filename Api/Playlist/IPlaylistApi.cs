namespace SpotifyWebApi.Api.Playlist
{
    using System.Collections.Generic;
    using Model;
    using Model.Uri;

    /// <summary>
    /// The playlist api.
    /// </summary>
    public interface IPlaylistApi
    {
        /// <summary>
        /// Get a list of the playlists owned or followed by the current Spotify user.
        /// </summary>
        /// <param name="maxResults">The maximum items to retrieve.</param>
        /// <param name="offset">Optional. The index of the first playlist to return.
        /// Default: 0 (the first object).
        /// Maximum offset: 100.000. Use with limit to get the next set of playlists.</param>
        /// <returns>A list of <see cref="SimplePlaylist"/>s.</returns>
        IList<SimplePlaylist> GetMyPlaylists(int maxResults = 100, int offset = 0);

        /// <summary>
        /// Get a list of the playlists owned or followed by a Spotify user.
        /// </summary>
        /// <param name="user">The <see cref="SpotifyUri"/> of the user.</param>
        /// <param name="maxResults">The maximum items to retrieve.</param>
        /// <param name="offset">Optional. The index of the first playlist to return.
        /// Default: 0 (the first object).
        /// Maximum offset: 100.000. Use with limit to get the next set of playlists.</param>
        /// <returns>A list of <see cref="SimplePlaylist"/>s.</returns>
        IList<SimplePlaylist> GetUsersPlaylist(SpotifyUri user, int maxResults = 100, int offset = 0);
    }
}