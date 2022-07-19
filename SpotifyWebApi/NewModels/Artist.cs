namespace SpotifyWebApi.NewModels
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    /// <summary>
    /// </summary>
    public class Artist
    {
        /// <summary>
        ///     Known external URLs for this artist.
        /// </summary>
        /// <value>Known external URLs for this artist. </value>
        [JsonProperty(PropertyName = "external_urls")]
        public ExternalUrl ExternalUrls { get; set; }

        /// <summary>
        ///     Information about the followers of the artist.
        /// </summary>
        /// <value>Information about the followers of the artist. </value>
        [JsonProperty(PropertyName = "followers")]
        public Followers Followers { get; set; }

        /// <summary>
        ///     A list of the genres the artist is associated with. If not yet classified, the array is empty.
        /// </summary>
        /// <value>A list of the genres the artist is associated with. If not yet classified, the array is empty. </value>
        [JsonProperty(PropertyName = "genres")]
        public List<string> Genres { get; set; }

        /// <summary>
        ///     A link to the Web API endpoint providing full details of the artist.
        /// </summary>
        /// <value>A link to the Web API endpoint providing full details of the artist. </value>
        [JsonProperty(PropertyName = "href")]
        public string Href { get; set; }

        /// <summary>
        ///     The [Spotify ID](/documentation/web-api/#spotify-uris-and-ids) for the artist.
        /// </summary>
        /// <value>The [Spotify ID](/documentation/web-api/#spotify-uris-and-ids) for the artist. </value>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        ///     Images of the artist in various sizes, widest first.
        /// </summary>
        /// <value>Images of the artist in various sizes, widest first. </value>
        [JsonProperty(PropertyName = "images")]
        public List<Image> Images { get; set; }

        /// <summary>
        ///     The name of the artist.
        /// </summary>
        /// <value>The name of the artist. </value>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        ///     The popularity of the artist. The value will be between 0 and 100, with 100 being the most popular. The artist's
        ///     popularity is calculated from the popularity of all the artist's tracks.
        /// </summary>
        /// <value>
        ///     The popularity of the artist. The value will be between 0 and 100, with 100 being the most popular. The artist's
        ///     popularity is calculated from the popularity of all the artist's tracks.
        /// </value>
        [JsonProperty(PropertyName = "popularity")]
        public int? Popularity { get; set; }

        /// <summary>
        ///     The object type.
        /// </summary>
        /// <value>The object type. </value>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        ///     The [Spotify URI](/documentation/web-api/#spotify-uris-and-ids) for the artist.
        /// </summary>
        /// <value>The [Spotify URI](/documentation/web-api/#spotify-uris-and-ids) for the artist. </value>
        [JsonProperty(PropertyName = "uri")]
        public string Uri { get; set; }
    }
}
