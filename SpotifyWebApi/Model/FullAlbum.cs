namespace Spotify.Model
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Uri;

    /// <summary>
    /// The <see cref="FullAlbum" /> class.
    /// </summary>
    public class FullAlbum
    {
        /// <summary>
        /// Gets or sets the type of the album.
        /// </summary>
        [JsonProperty("album_type")]
        public string AlbumType { get; set; }

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
        /// Gets or sets the copyrights.
        /// </summary>
        [JsonProperty("copyrights")]
        public List<Copyright> Copyrights { get; set; }

        /// <summary>
        /// Gets or sets the external ids.
        /// </summary>
        [JsonProperty("external_ids")]
        public Dictionary<string, string> ExternalIds { get; set; }

        /// <summary>
        /// Gets or sets the external urls.
        /// </summary>
        [JsonProperty("external_url")]
        public Dictionary<string, string> ExternalUrls { get; set; }

        /// <summary>
        /// Gets or sets the genres.
        /// </summary>
        [JsonProperty("genres")]
        public List<string> Genres { get; set; }

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
        /// Gets or sets the label.
        /// </summary>
        [JsonProperty("label")]
        public string Label { get; set; }

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
        /// Gets or sets the release date.
        /// </summary>
        [JsonProperty("release_date")]
        public string ReleaseDate { get; set; }

        /// <summary>
        /// Gets or sets the release date precision.
        /// </summary>
        [JsonProperty("release_date_precision")]
        public string ReleaseDatePrecision { get; set; }

        /// <summary>
        /// Gets or sets the tracks.
        /// </summary>
        [JsonProperty("tracks")]
        public Paging<SimpleTrack> Tracks { get; set; }

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
