namespace SpotifyWebApi.Model
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    /// <summary>
    /// The <see cref="FullTrack" /> class.
    /// </summary>
    public class FullTrack
    {
        /// <summary>
        /// Gets or sets the album.
        /// </summary>
        [JsonProperty("album")]
        public SimpleAlbum Album { get; set; }

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
        /// Gets or sets the explicit.
        /// </summary>
        [JsonProperty("explicit")]
        public string Explicit { get; set; }

        /// <summary>
        /// Gets or sets the external ids.
        /// </summary>
        [JsonProperty("external_ids")]
        public Dictionary<string, string> ExternalIds { get; set; }

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
        /// Gets or sets a value indicating whether this instance is playable.
        /// </summary>
        [JsonProperty("is_playable")]
        public bool IsPlayable { get; set; }

        /// <summary>
        /// Gets or sets the linked from.
        /// </summary>
        [JsonProperty("linked_from")]
        public LinkedFrom LinkedFrom { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the popularity.
        /// </summary>
        [JsonProperty("popularity")]
        public int Popularity { get; set; }

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
        public string Uri { get; set; }

        /// <summary>
        /// Returns a hash code for this instance.
        /// </summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table.</returns>
        public override int GetHashCode()
        {
            if (this.Id != null)
                return this.Id.GetHashCode();
            else
                return 0;
        }

        /// <summary>
        /// Determines whether the specified <see cref="object" /> is equal to this instance.
        /// </summary>
        /// <param name="obj">The object to compare with the current object.</param>
        /// <returns><c>true</c> if the specified <see cref="object" /> is equal to this instance; otherwise, <c>false</c>.</returns>
        public override bool Equals(object obj)
        {
            return this.Id.Equals(obj);
        }
    }
}
