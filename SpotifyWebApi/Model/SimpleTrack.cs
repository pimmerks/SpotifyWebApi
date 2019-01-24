namespace Spotify.Model
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Uri;

    /// <summary>
    /// The <see cref="SimpleTrack" /> class.
    /// </summary>
    public class SimpleTrack
    {
        /// <summary>
        /// Gets or sets the artists.
        /// </summary>
        [JsonProperty("artists")]
        public List<SimpleArtist> Artists { get; set; }

        /// <summary>
        /// Gets or sets the available markets.
        /// </summary>
        [JsonProperty("available_markets")]
        public List<string> AvailableMarkets { get; set; }

        /// <summary>
        /// Gets or sets the disc number.
        /// </summary>
        [JsonProperty("disc_number")]
        public int DiscNumber { get; set; }

        /// <summary>
        /// Gets or sets the duration ms.
        /// </summary>
        [JsonProperty("duration_ms")]
        public int DurationMs { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="SimpleTrack"/> is explicit.
        /// </summary>
        [JsonProperty("explicit")]
        public bool Explicit { get; set; }

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
        /// Gets or sets the preview URL.
        /// </summary>
        [JsonProperty("preview_url")]
        public string PreviewUrl { get; set; }

        /// <summary>
        /// Gets or sets the track number.
        /// </summary>
        [JsonProperty("track_number")]
        public int TrackNumber { get; set; }

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
