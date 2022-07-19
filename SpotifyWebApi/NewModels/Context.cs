namespace SpotifyWebApi.NewModels
{
    using Newtonsoft.Json;

    /// <summary>
    /// </summary>
    public class Context
    {
        /// <summary>
        ///     The object type, e.g. \"artist\", \"playlist\", \"album\", \"show\".
        /// </summary>
        /// <value>The object type, e.g. \"artist\", \"playlist\", \"album\", \"show\". </value>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        ///     A link to the Web API endpoint providing full details of the track.
        /// </summary>
        /// <value>A link to the Web API endpoint providing full details of the track.</value>
        [JsonProperty(PropertyName = "href")]
        public string Href { get; set; }

        /// <summary>
        ///     External URLs for this context.
        /// </summary>
        /// <value>External URLs for this context.</value>
        [JsonProperty(PropertyName = "external_urls")]
        public ExternalUrl ExternalUrls { get; set; }

        /// <summary>
        ///     The [Spotify URI](/documentation/web-api/#spotify-uris-and-ids) for the context.
        /// </summary>
        /// <value>The [Spotify URI](/documentation/web-api/#spotify-uris-and-ids) for the context. </value>
        [JsonProperty(PropertyName = "uri")]
        public string Uri { get; set; }
    }
}
