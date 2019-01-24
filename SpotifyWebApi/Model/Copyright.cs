namespace Spotify.Model
{
    using Newtonsoft.Json;

    /// <summary>
    /// Class Copyright.
    /// </summary>
    public class Copyright
    {
        /// <summary>
        /// Gets or sets the text.
        /// </summary>
        [JsonProperty("text")]
        public string Text { get; set; }

        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
