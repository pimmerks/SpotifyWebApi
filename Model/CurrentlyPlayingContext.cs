namespace SpotifyWebApi.Model
{
    using System;
    using System.Globalization;
    using Newtonsoft.Json;

    /// <summary>
    /// The <see cref="CurrentlyPlayingContext" />.
    /// </summary>
    public class CurrentlyPlayingContext
    {
        /// <summary>
        /// Gets or sets the device that is currently active.
        /// </summary>
        [JsonProperty("device")]
        public Device Device { get; set; }

        /// <summary>
        /// Gets or sets the repeat state: off, track, context.
        /// </summary>
        [JsonProperty("repeat_state")]
        public string RepeatState { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether shuffle is on or off
        /// </summary>
        [JsonProperty("shuffle_state")]
        public bool ShuffleState { get; set; }

        /// <summary>
        /// Gets or sets the context.
        /// </summary>
        [JsonProperty("context")]
        public Context Context { get; set; }

        /// <summary>
        /// Gets or sets the Unix Millisecond Timestamp when data was fetched
        /// </summary>
        [JsonProperty("timestamp")]
        public long TimestampMs { get; set; }

        /// <summary>
        /// Gets the <see cref="DateTime"/> object of the <see cref="TimestampMs"/>
        /// </summary>
        public DateTime Timestamp => DateTimeOffset.FromUnixTimeMilliseconds(this.TimestampMs).LocalDateTime;

        /// <summary>
        /// Gets or sets the progress into the currently playing track. Can be null.
        /// </summary>
        [JsonProperty("progress_ms")]
        public int? ProgressMs { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether if something is currently playing.
        /// </summary>
        [JsonProperty("is_playing")]
        public bool IsPlaying { get; set; }

        /// <summary>
        /// Gets or sets the currently playing track. Can be null.
        /// </summary>
        [JsonProperty("item")]
        public FullTrack Item { get; set; }
    }
}
