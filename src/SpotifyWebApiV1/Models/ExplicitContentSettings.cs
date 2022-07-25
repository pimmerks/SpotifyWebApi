namespace SpotifyWebApi.Models
{
    using System.Text.Json.Serialization;

    /// <summary>
    /// </summary>
    public class ExplicitContentSettings
    {
        /// <summary>
        ///     When `true`, indicates that explicit content should not be played.
        /// </summary>
        /// <value>When `true`, indicates that explicit content should not be played. </value>
        [JsonPropertyName("filter_enabled")]
        public bool? FilterEnabled { get; set; }

        /// <summary>
        ///     When `true`, indicates that the explicit content setting is locked and can't be changed by the user.
        /// </summary>
        /// <value>When `true`, indicates that the explicit content setting is locked and can't be changed by the user. </value>
        [JsonPropertyName("filter_locked")]
        public bool? FilterLocked { get; set; }
    }
}
