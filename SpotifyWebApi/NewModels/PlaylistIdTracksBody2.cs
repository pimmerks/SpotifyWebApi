namespace SpotifyWebApi.NewModels
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    /// <summary>
    /// </summary>
    public class PlaylistIdTracksBody2
    {
        /// <summary>
        ///     An array of objects containing [Spotify
        ///     URIs](https://developer.spotify.com/documentation/web-api/#spotify-uris-and-ids) of the tracks or episodes to
        ///     remove. For example: `{ \"tracks\": [{ \"uri\": \"spotify:track:4iV5W9uYEdYUVa79Axb7Rh\" },{ \"uri\":
        ///     \"spotify:track:1301WleyT98MSxVHPZCA6M\" }] }`. A maximum of 100 objects can be sent at once.
        /// </summary>
        /// <value>
        ///     An array of objects containing [Spotify
        ///     URIs](https://developer.spotify.com/documentation/web-api/#spotify-uris-and-ids) of the tracks or episodes to
        ///     remove. For example: `{ \"tracks\": [{ \"uri\": \"spotify:track:4iV5W9uYEdYUVa79Axb7Rh\" },{ \"uri\":
        ///     \"spotify:track:1301WleyT98MSxVHPZCA6M\" }] }`. A maximum of 100 objects can be sent at once.
        /// </value>
        [JsonProperty(PropertyName = "tracks")]
        public List<PlaylistsplaylistIdtracksTracks> Tracks { get; set; }

        /// <summary>
        ///     The playlist's snapshot ID against which you want to make the changes. The API will validate that the specified
        ///     items exist and in the specified positions and make the changes, even if more recent changes have been made to the
        ///     playlist.
        /// </summary>
        /// <value>
        ///     The playlist's snapshot ID against which you want to make the changes. The API will validate that the specified
        ///     items exist and in the specified positions and make the changes, even if more recent changes have been made to the
        ///     playlist.
        /// </value>
        [JsonProperty(PropertyName = "snapshot_id")]
        public string SnapshotId { get; set; }
    }
}
