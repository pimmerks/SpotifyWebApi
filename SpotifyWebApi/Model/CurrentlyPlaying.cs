namespace SpotifyWebApi.Model
{
    using Newtonsoft.Json;

    /// <summary>
    /// The <see cref="CurrentlyPlaying"/>.
    /// </summary>
    public class CurrentlyPlaying
    {
        /// <summary>
        /// Gets or sets a Context Object. Can be null.
        /// </summary>
        [JsonProperty("Context")]
        public Context Context { get; set; }

        /// <summary>
        /// Gets or sets unix Millisecond Timestamp when data was fetched
        /// </summary>
        [JsonProperty("timestamp")]
        public long Timestamp { get; set; }

        /// <summary>
        /// Gets or sets progress into the currently playing track. Can be null.
        /// </summary>
        [JsonProperty("progress_ms")]
        public int ProgressMs { get; set; }

        /// <summary>
        /// Gets or sets if something is currently playing.
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
