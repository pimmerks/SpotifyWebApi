namespace SpotifyWebApi.NewModels
{
    using Newtonsoft.Json;

    /// <summary>
    /// </summary>
    public class PlaylistUser
    {
        /// <summary>
        ///     Known public external URLs for this user.
        /// </summary>
        /// <value>Known public external URLs for this user. </value>
        [JsonProperty(PropertyName = "external_urls")]
        public ExternalUrl ExternalUrls { get; set; }

        /// <summary>
        ///     Information about the followers of this user.
        /// </summary>
        /// <value>Information about the followers of this user. </value>
        [JsonProperty(PropertyName = "followers")]
        public Followers Followers { get; set; }

        /// <summary>
        ///     A link to the Web API endpoint for this user.
        /// </summary>
        /// <value>A link to the Web API endpoint for this user. </value>
        [JsonProperty(PropertyName = "href")]
        public string Href { get; set; }

        /// <summary>
        ///     The [Spotify user ID](/documentation/web-api/#spotify-uris-and-ids) for this user.
        /// </summary>
        /// <value>The [Spotify user ID](/documentation/web-api/#spotify-uris-and-ids) for this user. </value>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        ///     The object type.
        /// </summary>
        /// <value>The object type. </value>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        ///     The [Spotify URI](/documentation/web-api/#spotify-uris-and-ids) for this user.
        /// </summary>
        /// <value>The [Spotify URI](/documentation/web-api/#spotify-uris-and-ids) for this user. </value>
        [JsonProperty(PropertyName = "uri")]
        public string Uri { get; set; }
    }
}
