namespace SpotifyWebApi.NewModels
{
    using System;
    using Newtonsoft.Json;

    /// <summary>
    /// </summary>
    public class PlaylistTrack
    {
        /// <summary>
        ///     The date and time the track or episode was added. _**Note**: some very old playlists may return `null` in this
        ///     field._
        /// </summary>
        /// <value>
        ///     The date and time the track or episode was added. _**Note**: some very old playlists may return `null` in this
        ///     field._
        /// </value>
        [JsonProperty(PropertyName = "added_at")]
        public DateTime? AddedAt { get; set; }

        /// <summary>
        ///     The Spotify user who added the track or episode. _**Note**: some very old playlists may return `null` in this
        ///     field._
        /// </summary>
        /// <value>
        ///     The Spotify user who added the track or episode. _**Note**: some very old playlists may return `null` in this
        ///     field._
        /// </value>
        [JsonProperty(PropertyName = "added_by")]
        public PlaylistUser AddedBy { get; set; }

        /// <summary>
        ///     Whether this track or episode is a [local
        ///     file](https://developer.spotify.com/web-api/local-files-spotify-playlists/) or not.
        /// </summary>
        /// <value>
        ///     Whether this track or episode is a [local
        ///     file](https://developer.spotify.com/web-api/local-files-spotify-playlists/) or not.
        /// </value>
        [JsonProperty(PropertyName = "is_local")]
        public bool? IsLocal { get; set; }

        /// <summary>
        ///     Information about the track or episode.
        /// </summary>
        /// <value>Information about the track or episode.</value>
        [JsonProperty(PropertyName = "track")]
        public PlayableBase Track { get; set; }
    }
}
