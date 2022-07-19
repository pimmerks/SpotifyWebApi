namespace SpotifyWebApi.NewModels
{
    using Newtonsoft.Json;

    /// <summary>
    /// </summary>
    public class Image
    {
        /// <summary>
        ///     The source URL of the image.
        /// </summary>
        /// <value>The source URL of the image. </value>
        [JsonProperty(PropertyName = "url")]
        public string Url { get; set; }

        /// <summary>
        ///     The image height in pixels.
        /// </summary>
        /// <value>The image height in pixels. </value>
        [JsonProperty(PropertyName = "height")]
        public int? Height { get; set; }

        /// <summary>
        ///     The image width in pixels.
        /// </summary>
        /// <value>The image width in pixels. </value>
        [JsonProperty(PropertyName = "width")]
        public int? Width { get; set; }
    }
}
