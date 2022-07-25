namespace SpotifyWebApi.Models
{
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    /// <summary>
    /// </summary>
    public class AlbumBase
    {
        /// <summary>
        ///     The type of the album.
        /// </summary>
        /// <value>The type of the album. </value>
        [JsonPropertyName("album_type")]
        public string AlbumType { get; set; }

        /// <summary>
        ///     The number of tracks in the album.
        /// </summary>
        /// <value>The number of tracks in the album.</value>
        [JsonPropertyName("total_tracks")]
        public int? TotalTracks { get; set; }

        /// <summary>
        ///     The markets in which the album is available: [ISO 3166-1 alpha-2 country
        ///     codes](http://en.wikipedia.org/wiki/ISO_3166-1_alpha-2). _**NOTE**: an album is considered available in a market
        ///     when at least 1 of its tracks is available in that market._
        /// </summary>
        /// <value>
        ///     The markets in which the album is available: [ISO 3166-1 alpha-2 country
        ///     codes](http://en.wikipedia.org/wiki/ISO_3166-1_alpha-2). _**NOTE**: an album is considered available in a market
        ///     when at least 1 of its tracks is available in that market._
        /// </value>
        [JsonPropertyName("available_markets")]
        public List<string> AvailableMarkets { get; set; }

        /// <summary>
        ///     Known external URLs for this album.
        /// </summary>
        /// <value>Known external URLs for this album. </value>
        [JsonPropertyName("external_urls")]
        public ExternalUrl ExternalUrls { get; set; }

        /// <summary>
        ///     A link to the Web API endpoint providing full details of the album.
        /// </summary>
        /// <value>A link to the Web API endpoint providing full details of the album. </value>
        [JsonPropertyName("href")]
        public string Href { get; set; }

        /// <summary>
        ///     The [Spotify ID](/documentation/web-api/#spotify-uris-and-ids) for the album.
        /// </summary>
        /// <value>The [Spotify ID](/documentation/web-api/#spotify-uris-and-ids) for the album. </value>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        ///     The cover art for the album in various sizes, widest first.
        /// </summary>
        /// <value>The cover art for the album in various sizes, widest first. </value>
        [JsonPropertyName("images")]
        public List<Image> Images { get; set; }

        /// <summary>
        ///     The name of the album. In case of an album takedown, the value may be an empty string.
        /// </summary>
        /// <value>The name of the album. In case of an album takedown, the value may be an empty string. </value>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        ///     The date the album was first released.
        /// </summary>
        /// <value>The date the album was first released. </value>
        [JsonPropertyName("release_date")]
        public string ReleaseDate { get; set; }

        /// <summary>
        ///     The precision with which `release_date` value is known.
        /// </summary>
        /// <value>The precision with which `release_date` value is known. </value>
        [JsonPropertyName("release_date_precision")]
        public string ReleaseDatePrecision { get; set; }

        /// <summary>
        ///     Included in the response when a content restriction is applied.
        /// </summary>
        /// <value>Included in the response when a content restriction is applied. </value>
        [JsonPropertyName("restrictions")]
        public AlbumRestriction Restrictions { get; set; }

        /// <summary>
        ///     The object type.
        /// </summary>
        /// <value>The object type. </value>
        [JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        ///     The [Spotify URI](/documentation/web-api/#spotify-uris-and-ids) for the album.
        /// </summary>
        /// <value>The [Spotify URI](/documentation/web-api/#spotify-uris-and-ids) for the album. </value>
        [JsonPropertyName("uri")]
        public string Uri { get; set; }
    }
}
