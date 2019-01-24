namespace Spotify.Model
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Uri;

    /// <summary>
    /// The <see cref="PublicUser" /> class.
    /// </summary>
    public class PublicUser
    {
        /// <summary>
        /// Gets or sets the display name.
        /// </summary>
        [JsonProperty("display_name")]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or sets the external urls.
        /// </summary>
        [JsonProperty("external_urls")]
        public Dictionary<string, string> ExternalUrls { get; set; }

        /// <summary>
        /// Gets or sets the followers.
        /// </summary>
        [JsonProperty("followers")]
        public Followers Followers { get; set; }

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
        /// Gets or sets the images.
        /// </summary>
        [JsonProperty("images")]
        public List<Image> Images { get; set; }

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
