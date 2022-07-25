namespace SpotifyWebApi.Models
{
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    /// <summary>
    /// </summary>
    public class ShowBase
    {
        /// <summary>
        ///     A list of the countries in which the show can be played, identified by their [ISO 3166-1
        ///     alpha-2](http://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) code.
        /// </summary>
        /// <value>
        ///     A list of the countries in which the show can be played, identified by their [ISO 3166-1
        ///     alpha-2](http://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) code.
        /// </value>
        [JsonPropertyName("available_markets")]
        public List<string> AvailableMarkets { get; set; }

        /// <summary>
        ///     The copyright statements of the show.
        /// </summary>
        /// <value>The copyright statements of the show. </value>
        [JsonPropertyName("copyrights")]
        public List<Copyright> Copyrights { get; set; }

        /// <summary>
        ///     A description of the show. HTML tags are stripped away from this field, use `html_description` field in case HTML
        ///     tags are needed.
        /// </summary>
        /// <value>
        ///     A description of the show. HTML tags are stripped away from this field, use `html_description` field in case
        ///     HTML tags are needed.
        /// </value>
        [JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        ///     A description of the show. This field may contain HTML tags.
        /// </summary>
        /// <value>A description of the show. This field may contain HTML tags. </value>
        [JsonPropertyName("html_description")]
        public string HtmlDescription { get; set; }

        /// <summary>
        ///     Whether or not the show has explicit content (true = yes it does; false = no it does not OR unknown).
        /// </summary>
        /// <value>Whether or not the show has explicit content (true = yes it does; false = no it does not OR unknown). </value>
        [JsonPropertyName("explicit")]
        public bool? _Explicit { get; set; }

        /// <summary>
        ///     External URLs for this show.
        /// </summary>
        /// <value>External URLs for this show. </value>
        [JsonPropertyName("external_urls")]
        public ExternalUrl ExternalUrls { get; set; }

        /// <summary>
        ///     A link to the Web API endpoint providing full details of the show.
        /// </summary>
        /// <value>A link to the Web API endpoint providing full details of the show. </value>
        [JsonPropertyName("href")]
        public string Href { get; set; }

        /// <summary>
        ///     The [Spotify ID](/documentation/web-api/#spotify-uris-and-ids) for the show.
        /// </summary>
        /// <value>The [Spotify ID](/documentation/web-api/#spotify-uris-and-ids) for the show. </value>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        ///     The cover art for the show in various sizes, widest first.
        /// </summary>
        /// <value>The cover art for the show in various sizes, widest first. </value>
        [JsonPropertyName("images")]
        public List<Image> Images { get; set; }

        /// <summary>
        ///     True if all of the shows episodes are hosted outside of Spotify's CDN. This field might be `null` in some cases.
        /// </summary>
        /// <value>True if all of the shows episodes are hosted outside of Spotify's CDN. This field might be `null` in some cases. </value>
        [JsonPropertyName("is_externally_hosted")]
        public bool? IsExternallyHosted { get; set; }

        /// <summary>
        ///     A list of the languages used in the show, identified by their [ISO 639](https://en.wikipedia.org/wiki/ISO_639)
        ///     code.
        /// </summary>
        /// <value>
        ///     A list of the languages used in the show, identified by their [ISO 639](https://en.wikipedia.org/wiki/ISO_639)
        ///     code.
        /// </value>
        [JsonPropertyName("languages")]
        public List<string> Languages { get; set; }

        /// <summary>
        ///     The media type of the show.
        /// </summary>
        /// <value>The media type of the show. </value>
        [JsonPropertyName("media_type")]
        public string MediaType { get; set; }

        /// <summary>
        ///     The name of the episode.
        /// </summary>
        /// <value>The name of the episode. </value>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        ///     The publisher of the show.
        /// </summary>
        /// <value>The publisher of the show. </value>
        [JsonPropertyName("publisher")]
        public string Publisher { get; set; }

        /// <summary>
        ///     The object type.
        /// </summary>
        /// <value>The object type. </value>
        [JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        ///     The [Spotify URI](/documentation/web-api/#spotify-uris-and-ids) for the show.
        /// </summary>
        /// <value>The [Spotify URI](/documentation/web-api/#spotify-uris-and-ids) for the show. </value>
        [JsonPropertyName("uri")]
        public string Uri { get; set; }
    }
}
