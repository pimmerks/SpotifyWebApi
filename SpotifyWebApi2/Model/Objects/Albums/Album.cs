namespace Spotify.WebApi.Model.Objects.Albums
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using Spotify.WebApi.Model.Objects.Artists;
    using Spotify.WebApi.Model.Objects.Tracks;

    /// <summary>
    /// An album.
    /// </summary>
    public class Album
    {
        /// <summary>
        /// The type of the album: album, single, or compilation.
        /// </summary>
        [JsonPropertyName("album_type")]
        public string AlbumType { get; set; }

        /// <summary>
        /// The artists of the album. Each artist object includes a link in href to more detailed information about the artist.
        /// </summary>
        [JsonPropertyName("artists")]
        public List<SimpleArtist> Artists { get; set; }

        /// <summary>
        /// The markets in which the album is available: ISO 3166-1 alpha-2 country codes. Note that an album is considered available in a market when at least 1 of its tracks is available in that market.
        /// </summary>
        [JsonPropertyName("available_markets")]
        public List<string> AvailableMarkets { get; set; }

        /// <summary>
        /// The copyright statements of the album.
        /// </summary>
        [JsonPropertyName("copyrights")]
        public List<Copyright> Copyrights { get; set; }

        /// <summary>
        /// Known external IDs for the album.
        /// </summary>
        [JsonPropertyName("external_ids")]
        public ExternalId ExternalIds { get; set; }

        /// <summary>
        /// Known external URLs for this album.
        /// </summary>
        [JsonPropertyName("external_urls")]
        public ExternalUrl ExternalUrls { get; set; }

        /// <summary>
        /// A list of the genres used to classify the album. For example: “Prog Rock” , “Post-Grunge”. (If not yet classified, the array is empty.)
        /// </summary>
        [JsonPropertyName("genres")]
        public List<string> Genres { get; set; }

        /// <summary>
        /// A link to the Web API endpoint providing full details of the album.
        /// </summary>
        [JsonPropertyName("href")]
        public string Href { get; set; }

        /// <summary>
        /// The Spotify ID for the album.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// The cover art for the album in various sizes, widest first.
        /// </summary>
        [JsonPropertyName("images")]
        public List<Image> Images { get; set; }

        /// <summary>
        /// The label for the album.
        /// </summary>
        [JsonPropertyName("label")]
        public string Label { get; set; }

        /// <summary>
        /// The name of the album. In case of an album takedown, the value may be an empty string.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// The popularity of the album. The value will be between 0 and 100, with 100 being the most popular. The popularity is calculated from the popularity of the album’s individual tracks.
        /// </summary>
        [JsonPropertyName("popularity")]
        public int Popularity { get; set; }

        /// <summary>
        /// The date the album was first released, for example “1981-12-15”. Depending on the precision, it might be shown as “1981” or “1981-12”.
        /// </summary>
        [JsonPropertyName("release_date")]
        public DateTime ReleaseDate { get; set; }

        /// <summary>
        /// The precision with which release_date value is known: “year” , “month” , or “day”.
        /// </summary>
        [JsonPropertyName("release_date_precision")]
        public string ReleaseDatePrecision { get; set; }

        /// <summary>
        /// The tracks of the album.
        /// </summary>
        [JsonPropertyName("tracks")]
        public Paging<SimpleTrack> Tracks { get; set; }

        /// <summary>
        /// The object type: “album”
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        /// The Spotify URI for the album.
        /// </summary>
        [JsonPropertyName("uri")]
        public SpotifyUri Uri { get; set; }
    }
}
