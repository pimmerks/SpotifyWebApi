namespace SpotifyWebApi.Models
{
    using System.Text.Json.Serialization;

    /// <summary>
    /// </summary>
    public class SimplifiedArtist
    {
        /// <summary>
        ///     Known external URLs for this artist.
        /// </summary>
        /// <value>Known external URLs for this artist. </value>
        [JsonPropertyName("external_urls")]
        public ExternalUrl ExternalUrls { get; set; }

        /// <summary>
        ///     A link to the Web API endpoint providing full details of the artist.
        /// </summary>
        /// <value>A link to the Web API endpoint providing full details of the artist. </value>
        [JsonPropertyName("href")]
        public string Href { get; set; }

        /// <summary>
        ///     The [Spotify ID](/documentation/web-api/#spotify-uris-and-ids) for the artist.
        /// </summary>
        /// <value>The [Spotify ID](/documentation/web-api/#spotify-uris-and-ids) for the artist. </value>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        ///     The name of the artist.
        /// </summary>
        /// <value>The name of the artist. </value>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        ///     The object type.
        /// </summary>
        /// <value>The object type. </value>
        [JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        ///     The [Spotify URI](/documentation/web-api/#spotify-uris-and-ids) for the artist.
        /// </summary>
        /// <value>The [Spotify URI](/documentation/web-api/#spotify-uris-and-ids) for the artist. </value>
        [JsonPropertyName("uri")]
        public string Uri { get; set; }
    }
}
