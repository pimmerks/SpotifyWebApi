namespace Spotify.WebApi.Model.Objects.Albums
{
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class SimpleAlbum
    {
        /// <summary>
        /// The field is present when getting an artist’s albums. Possible values are “album”, “single”, “compilation”, “appears_on”. Compare to album_type this field represents relationship between the artist and the album.
        /// </summary>
        [JsonPropertyName("album_group")]
        public string AlbumGroup { get; set; }

        /// <summary>
        /// The type of the album: one of “album”, “single”, or “compilation”.
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
        /// Known external URLs for this album.
        /// </summary>
        [JsonPropertyName("external_urls")]
        public ExternalUrl ExternalUrls { get; set; }

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
        /// The name of the album. In case of an album takedown, the value may be an empty string.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// The object type: “album”
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        /// The Spotify URI for the album.
        /// </summary>
        [JsonPropertyName("uri")]
        public string Uri { get; set; }
    }
}
