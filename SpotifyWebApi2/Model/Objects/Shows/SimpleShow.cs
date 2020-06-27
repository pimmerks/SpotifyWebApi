namespace Spotify.WebApi.Model.Objects.Shows
{
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using Spotify.WebApi.Model.Objects.Albums;

    /// <summary>
    /// A simplified show.
    /// </summary>
    public class SimpleShow
    {
        /// <summary>
        /// A list of the countries in which the show can be played, identified by their ISO 3166-1 alpha-2 code.
        /// </summary>
        [JsonPropertyName("available_markets")]
        public List<string> AvailableMarkets { get; set; }

        /// <summary>
        /// The copyright statements of the show.
        /// </summary>
        [JsonPropertyName("copyrights")]
        public List<Copyright> Copyrights { get; set; }

        /// <summary>
        /// A description of the show.
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// Whether or not the show has explicit content (true = yes it does; false = no it does not OR unknown).
        /// </summary>
        [JsonPropertyName("explicit")]
        public bool Explicit { get; set; }

        /// <summary>
        /// External URLs for this show.
        /// </summary>
        [JsonPropertyName("external_urls")]
        public ExternalUrl ExternalUrls { get; set; }

        /// <summary>
        /// A link to the Web API endpoint providing full details of the show.
        /// </summary>
        [JsonPropertyName("href")]
        public string Href { get; set; }

        /// <summary>
        /// The Spotify ID for the show.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// The cover art for the show in various sizes, widest first.
        /// </summary>
        [JsonPropertyName("images")]
        public List<Image> Images { get; set; }

        /// <summary>
        /// True if all of the show’s episodes are hosted outside of Spotify’s CDN. This field might be null in some cases.
        /// </summary>
        [JsonPropertyName("is_externally_hosted")]
        public bool IsExternallyHosted { get; set; }

        /// <summary>
        /// A list of the languages used in the show, identified by their ISO 639 code.
        /// </summary>
        [JsonPropertyName("languages")]
        public List<string> Languages { get; set; }

        /// <summary>
        /// The media type of the show.
        /// </summary>
        [JsonPropertyName("media_type")]
        public string MediaType { get; set; }

        /// <summary>
        /// The name of the episode.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// The publisher of the show.
        /// </summary>
        [JsonPropertyName("publisher")]
        public string Publisher { get; set; }

        /// <summary>
        /// The object type: “show”.
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        /// The Spotify URI for the show.
        /// </summary>
        [JsonPropertyName("uri")]
        public string Uri { get; set; }
    }
}
