namespace SpotifyWebApi.NewModels
{
    using Newtonsoft.Json;

    /// <summary>
    /// </summary>
    public class ResumePoint
    {
        /// <summary>
        ///     Whether or not the episode has been fully played by the user.
        /// </summary>
        /// <value>Whether or not the episode has been fully played by the user. </value>
        [JsonProperty(PropertyName = "fully_played")]
        public bool? FullyPlayed { get; set; }

        /// <summary>
        ///     The user's most recent position in the episode in milliseconds.
        /// </summary>
        /// <value>The user's most recent position in the episode in milliseconds. </value>
        [JsonProperty(PropertyName = "resume_position_ms")]
        public int? ResumePositionMs { get; set; }
    }
}
