namespace SpotifyWebApi.NewModels
{
    using Newtonsoft.Json;

    /// <summary>
    /// </summary>
    public class ExternalUrl
    {
        /// <summary>
        ///     The [Spotify URL](/documentation/web-api/#spotify-uris-and-ids) for the object.
        /// </summary>
        /// <value>The [Spotify URL](/documentation/web-api/#spotify-uris-and-ids) for the object. </value>
        [JsonProperty(PropertyName = "spotify")]
        public string Spotify { get; set; }
    }
}
