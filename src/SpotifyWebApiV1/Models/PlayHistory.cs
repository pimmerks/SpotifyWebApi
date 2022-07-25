namespace SpotifyWebApi.Models
{
    using System;
    using System.Text.Json.Serialization;

    /// <summary>
    /// </summary>
    public class PlayHistory
    {
        /// <summary>
        ///     The track the user listened to.
        /// </summary>
        /// <value>The track the user listened to.</value>
        [JsonPropertyName("track")]
        public SimplifiedTrack Track { get; set; }

        /// <summary>
        ///     The date and time the track was played.
        /// </summary>
        /// <value>The date and time the track was played.</value>
        [JsonPropertyName("played_at")]
        public DateTime? PlayedAt { get; set; }

        /// <summary>
        ///     The context the track was played from.
        /// </summary>
        /// <value>The context the track was played from.</value>
        [JsonPropertyName("context")]
        public Context Context { get; set; }
    }
}
