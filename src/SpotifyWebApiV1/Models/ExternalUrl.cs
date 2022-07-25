namespace SpotifyWebApi.Models
{
    using System.Text.Json.Serialization;

    /// <summary>
    /// </summary>
    public class ExternalUrl
    {
        /// <summary>
        ///     The [Spotify URL](/documentation/web-api/#spotify-uris-and-ids) for the object.
        /// </summary>
        /// <value>The [Spotify URL](/documentation/web-api/#spotify-uris-and-ids) for the object. </value>
        [JsonPropertyName("spotify")]
        public string Spotify { get; set; }
    }
}
