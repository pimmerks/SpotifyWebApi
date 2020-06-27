namespace Spotify.WebApi.Model.Objects.Playback
{
    using System;
    using System.Text.Json.Serialization;
    using Spotify.WebApi.Model.Objects.Tracks;

    /// <summary>
    /// The play history.
    /// </summary>
    public class PlayHistory
    {
        /// <summary>
        /// The context the track was played from.
        /// </summary>
        [JsonPropertyName("context")]
        public Context Context { get; set; }

        /// <summary>
        /// The date and time the track was played.
        /// </summary>
        [JsonPropertyName("played_at")]
        public DateTime PlayedAt { get; set; }

        /// <summary>
        /// The track the user listened to.
        /// </summary>
        [JsonPropertyName("track")]
        public SimpleTrack Track { get; set; }
    }
}
