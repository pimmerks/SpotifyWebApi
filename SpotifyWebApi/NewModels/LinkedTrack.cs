namespace SpotifyWebApi.NewModels
{
    using Newtonsoft.Json;

    /// <summary>
    /// </summary>
    public class LinkedTrack
    {
        /// <summary>
        ///     Known external URLs for this track.
        /// </summary>
        /// <value>Known external URLs for this track. </value>
        [JsonProperty(PropertyName = "external_urls")]
        public ExternalUrl ExternalUrls { get; set; }

        /// <summary>
        ///     A link to the Web API endpoint providing full details of the track.
        /// </summary>
        /// <value>A link to the Web API endpoint providing full details of the track. </value>
        [JsonProperty(PropertyName = "href")]
        public string Href { get; set; }

        /// <summary>
        ///     The [Spotify ID](/documentation/web-api/#spotify-uris-and-ids) for the track.
        /// </summary>
        /// <value>The [Spotify ID](/documentation/web-api/#spotify-uris-and-ids) for the track. </value>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        ///     The object type: \"track\".
        /// </summary>
        /// <value>The object type: \"track\". </value>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        ///     The [Spotify URI](/documentation/web-api/#spotify-uris-and-ids) for the track.
        /// </summary>
        /// <value>The [Spotify URI](/documentation/web-api/#spotify-uris-and-ids) for the track. </value>
        [JsonProperty(PropertyName = "uri")]
        public string Uri { get; set; }
    }
}
