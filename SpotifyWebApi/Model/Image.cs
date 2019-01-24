namespace Spotify.Model
{
    using Newtonsoft.Json;

    /// <summary>
    /// The <see cref="Image" /> class.
    /// </summary>
    public class Image
    {
        /// <summary>
        /// Gets or sets the height.
        /// </summary>
        [JsonProperty("height")]
        public int? Height { get; set; }

        /// <summary>
        /// Gets or sets the URL.
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; }

        /// <summary>
        /// Gets or sets the width.
        /// </summary>
        [JsonProperty("width")]
        public int? Width { get; set; }
    }
}
