namespace SpotifyWebApi.NewModels
{
    using Newtonsoft.Json;

    /// <summary>
    /// </summary>
    public class CurrentlyPlayingContext
    {
        /// <summary>
        ///     The device that is currently active.
        /// </summary>
        /// <value>The device that is currently active. </value>
        [JsonProperty(PropertyName = "device")]
        public Device Device { get; set; }

        /// <summary>
        ///     off, track, context
        /// </summary>
        /// <value>off, track, context</value>
        [JsonProperty(PropertyName = "repeat_state")]
        public string RepeatState { get; set; }

        /// <summary>
        ///     If shuffle is on or off.
        /// </summary>
        /// <value>If shuffle is on or off.</value>
        [JsonProperty(PropertyName = "shuffle_state")]
        public string ShuffleState { get; set; }

        /// <summary>
        ///     A Context Object. Can be `null`.
        /// </summary>
        /// <value>A Context Object. Can be `null`.</value>
        [JsonProperty(PropertyName = "context")]
        public Context Context { get; set; }

        /// <summary>
        ///     Unix Millisecond Timestamp when data was fetched.
        /// </summary>
        /// <value>Unix Millisecond Timestamp when data was fetched.</value>
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

        /// <summary>
        ///     Allows to update the user interface based on which playback actions are available within the current context.
        /// </summary>
        /// <value>Allows to update the user interface based on which playback actions are available within the current context. </value>
        [JsonProperty(PropertyName = "actions")]
        public Disallows Actions { get; set; }
    }
}
