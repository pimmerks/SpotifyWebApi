namespace SpotifyWebApi.Models
{
    using System.Text.Json.Serialization;

    /// <summary>
    /// </summary>
    public class PlaylistUser
    {
        /// <summary>
        ///     Known public external URLs for this user.
        /// </summary>
        /// <value>Known public external URLs for this user. </value>
        [JsonPropertyName("external_urls")]
        public ExternalUrl ExternalUrls { get; set; }

        /// <summary>
        ///     Information about the followers of this user.
        /// </summary>
        /// <value>Information about the followers of this user. </value>
        [JsonPropertyName("followers")]
        public Followers Followers { get; set; }

        /// <summary>
        ///     A link to the Web API endpoint for this user.
        /// </summary>
        /// <value>A link to the Web API endpoint for this user. </value>
        [JsonPropertyName("href")]
        public string Href { get; set; }

        /// <summary>
        ///     The [Spotify user ID](/documentation/web-api/#spotify-uris-and-ids) for this user.
        /// </summary>
        /// <value>The [Spotify user ID](/documentation/web-api/#spotify-uris-and-ids) for this user. </value>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        ///     The object type.
        /// </summary>
        /// <value>The object type. </value>
        [JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        ///     The [Spotify URI](/documentation/web-api/#spotify-uris-and-ids) for this user.
        /// </summary>
        /// <value>The [Spotify URI](/documentation/web-api/#spotify-uris-and-ids) for this user. </value>
        [JsonPropertyName("uri")]
        public string Uri { get; set; }
    }
}
