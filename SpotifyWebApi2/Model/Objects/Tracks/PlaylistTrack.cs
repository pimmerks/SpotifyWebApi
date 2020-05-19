namespace Spotify.WebApi.Model.Objects.Tracks
{
    using System;
    using System.Text.Json.Serialization;
    using Episodes;
    using Users;

    public class PlaylistTrack
    {
        /// <summary>
        /// The date and time the track or episode was added. Note that some very old playlists may return null in this field.
        /// </summary>
        [JsonPropertyName("added_at")]
        public DateTime AddedAt { get; private set; }

        /// <summary>
        /// The Spotify user who added the track or episode. Note that some very old playlists may return null in this field.
        /// </summary>
        [JsonPropertyName("added_by")]
        public PublicUser AddedBy { get; private set; }

        /// <summary>
        /// Whether this track or episode is a local file or not.
        /// </summary>
        [JsonPropertyName("is_local")]
        public bool IsLocal { get; private set; }

        /// <summary>
        /// Information about the track or episode.
        /// </summary>
        [JsonPropertyName("track")]
        public PlayableBase Track { get; private set; }
    }
}
