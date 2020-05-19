namespace Spotify.WebApi.Model.Objects.Albums
{
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using Artists;
    using Tracks;

    public class Album
    {
        /// <summary>
        /// The type of the album: album, single, or compilation.
        /// </summary>
        [JsonPropertyName("album_type")]
        public string AlbumType { get; private set; }

        /// <summary>
        /// The artists of the album. Each artist object includes a link in href to more detailed information about the artist.
        /// </summary>
        [JsonPropertyName("artists")]
        public List<Artist> Artists { get; private set; }

        /// <summary>
        /// The markets in which the album is available: ISO 3166-1 alpha-2 country codes. Note that an album is considered available in a market when at least 1 of its tracks is available in that market.
        /// </summary>
        [JsonPropertyName("available_markets")]
        public List<string> AvailableMarkets { get; private set; }

        /// <summary>
        /// The copyright statements of the album.
        /// </summary>
        [JsonPropertyName("copyrights")]
        public List<Copyright> Copyrights { get; private set; }

        /// <summary>
        /// Known external IDs for the album.
        /// </summary>
        [JsonPropertyName("external_ids")]
        public ExternalId ExternalIds { get; private set; }

        /// <summary>
        /// Known external URLs for this album.
        /// </summary>
        [JsonPropertyName("external_urls")]
        public ExternalUrl ExternalUrls { get; private set; }

        /// <summary>
        /// A list of the genres used to classify the album. For example: “Prog Rock” , “Post-Grunge”. (If not yet classified, the array is empty.)
        /// </summary>
        [JsonPropertyName("genres")]
        public List<string> Genres { get; private set; }

        /// <summary>
        /// A link to the Web API endpoint providing full details of the album.
        /// </summary>
        [JsonPropertyName("href")]
        public string Href { get; private set; }

        /// <summary>
        /// The Spotify ID for the album.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; private set; }

        /// <summary>
        /// The cover art for the album in various sizes, widest first.
        /// </summary>
        [JsonPropertyName("images")]
        public List<Image> Images { get; private set; }

        /// <summary>
        /// The label for the album.
        /// </summary>
        [JsonPropertyName("label")]
        public string Label { get; private set; }

        /// <summary>
        /// The name of the album. In case of an album takedown, the value may be an empty string.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; private set; }

        /// <summary>
        /// The popularity of the album. The value will be between 0 and 100, with 100 being the most popular. The popularity is calculated from the popularity of the album’s individual tracks.
        /// </summary>
        [JsonPropertyName("popularity")]
        public int Popularity { get; private set; }

        /// <summary>
        /// The date the album was first released, for example “1981-12-15”. Depending on the precision, it might be shown as “1981” or “1981-12”.
        /// </summary>
        [JsonPropertyName("release_date")]
        public string ReleaseDate { get; private set; }

        /// <summary>
        /// The precision with which release_date value is known: “year” , “month” , or “day”.
        /// </summary>
        [JsonPropertyName("release_date_precision")]
        public string ReleaseDatePrecision { get; private set; }

        /// <summary>
        /// The tracks of the album.
        /// </summary>
        [JsonPropertyName("tracks")]
        public List<SimpleTrack> Tracks { get; private set; }

        /// <summary>
        /// The object type: “album”
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; private set; }

        /// <summary>
        /// The Spotify URI for the album.
        /// </summary>
        [JsonPropertyName("uri")]
        public string Uri { get; private set; }
    }
}
