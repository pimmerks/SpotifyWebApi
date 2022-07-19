namespace SpotifyWebApi.NewModels
{
    using Newtonsoft.Json;

    /// <summary>
    /// </summary>
    public class ExplicitContentSettings
    {
        /// <summary>
        ///     When `true`, indicates that explicit content should not be played.
        /// </summary>
        /// <value>When `true`, indicates that explicit content should not be played. </value>
        [JsonProperty(PropertyName = "filter_enabled")]
        public bool? FilterEnabled { get; set; }

        /// <summary>
        ///     When `true`, indicates that the explicit content setting is locked and can't be changed by the user.
        /// </summary>
        /// <value>When `true`, indicates that the explicit content setting is locked and can't be changed by the user. </value>
        [JsonProperty(PropertyName = "filter_locked")]
        public bool? FilterLocked { get; set; }
    }
}
