namespace Spotify.Model
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Uri;

    /// <summary>
    /// The <see cref="SimplePlaylist" /> class.
    /// </summary>
    public class SimplePlaylist
    {
        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="SimplePlaylist"/> is collaborative.
        /// </summary>
        [JsonProperty("collaborative")]
        public bool Collaborative { get; set; }

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
        /// Gets or sets the images.
        /// </summary>
        [JsonProperty("images")]
        public List<Image> Images { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the owner.
        /// </summary>
        [JsonProperty("owner")]
        public PublicUser Owner { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="SimplePlaylist"/> is public.
        /// </summary>
        [JsonProperty("public")]
        public bool? Public { get; set; }

        /// <summary>
        /// Gets or sets the snapshot identifier.
        /// </summary>
        [JsonProperty("snapshot_id")]
        public string SnapshotId { get; set; }

        // TODO: This causes error, fix this.
        // /// <summary>
        // /// Gets or sets the tracks.
        // /// </summary>
        // [JsonProperty("tracks")]
        // public List<LinkedFrom> Tracks { get; set; } = new List<LinkedFrom>();

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
