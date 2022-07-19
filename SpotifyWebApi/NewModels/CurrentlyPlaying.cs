namespace SpotifyWebApi.NewModels
{
    using Newtonsoft.Json;

    /// <summary>
    /// </summary>
    public class CurrentlyPlaying
    {
        /// <summary>
        ///     A Context Object. Can be `null`.
        /// </summary>
        /// <value>A Context Object. Can be `null`.</value>
        [JsonProperty(PropertyName = "context")]
        public Context Context { get; set; }

        /// <summary>
        ///     Unix Millisecond Timestamp when data was fetched
        /// </summary>
        /// <value>Unix Millisecond Timestamp when data was fetched</value>
        [JsonProperty(PropertyName = "timestamp")]
        public int? Timestamp { get; set; }

        /// <summary>
        ///     Progress into the currently playing track or episode. Can be `null`.
        /// </summary>
        /// <value>Progress into the currently playing track or episode. Can be `null`.</value>
        [JsonProperty(PropertyName = "progress_ms")]
        public int? ProgressMs { get; set; }

        /// <summary>
        ///     If something is currently playing, return `true`.
        /// </summary>
        /// <value>If something is currently playing, return `true`.</value>
        [JsonProperty(PropertyName = "is_playing")]
        public bool? IsPlaying { get; set; }

        /// <summary>
        ///     The currently playing track or episode. Can be `null`.
        /// </summary>
        /// <value>The currently playing track or episode. Can be `null`.</value>
        [JsonProperty(PropertyName = "item")]
        public PlayableBase Item { get; set; }

        /// <summary>
        ///     The object type of the currently playing item. Can be one of `track`, `episode`, `ad` or `unknown`.
        /// </summary>
        /// <value>The object type of the currently playing item. Can be one of `track`, `episode`, `ad` or `unknown`. </value>
        [JsonProperty(PropertyName = "currently_playing_type")]
        public string CurrentlyPlayingType { get; set; }
    }
}
