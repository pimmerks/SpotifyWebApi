namespace Spotify.Model
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Uri;

    /// <summary>
    /// The <see cref="SimpleArtist" /> class.
    /// </summary>
    public class SimpleArtist
    {
        /// <summary>
        /// Gets or sets the external urls.
        /// </summary>
        [JsonProperty("external_urls")]
        public Dictionary<string, string> ExternalUrls { get; set; }

        /// <summary>
        /// Gets or sets the href.
        /// </summary>
        [JsonProperty("href")]
        public string Href { get; set; }

        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets the URI.
        /// </summary>
        [JsonProperty("uri")]
        public SpotifyUri Uri { get; set; }
    }
}
