namespace SpotifyWebApi.Models
{
    using System.Text.Json.Serialization;

    /// <summary>
    /// </summary>
    public class Image
    {
        /// <summary>
        ///     The source URL of the image.
        /// </summary>
        /// <value>The source URL of the image. </value>
        [JsonPropertyName("url")]
        public string Url { get; set; }

        /// <summary>
        ///     The image height in pixels.
        /// </summary>
        /// <value>The image height in pixels. </value>
        [JsonPropertyName("height")]
        public int? Height { get; set; }

        /// <summary>
        ///     The image width in pixels.
        /// </summary>
        /// <value>The image width in pixels. </value>
        [JsonPropertyName("width")]
        public int? Width { get; set; }
    }
}
