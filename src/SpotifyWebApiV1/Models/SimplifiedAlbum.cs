namespace SpotifyWebApi.Models
{
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    /// <summary>
    /// </summary>
    public class SimplifiedAlbum : AlbumBase
    {
        /// <summary>
        ///     The field is present when getting an artist's albums. Compare to album_type this field represents relationship
        ///     between the artist and the album.
        /// </summary>
        /// <value>
        ///     The field is present when getting an artist's albums. Compare to album_type this field represents relationship
        ///     between the artist and the album.
        /// </value>
        [JsonPropertyName("album_group")]
        public string AlbumGroup { get; set; }

        /// <summary>
        ///     The artists of the album. Each artist object includes a link in `href` to more detailed information about the
        ///     artist.
        /// </summary>
        /// <value>
        ///     The artists of the album. Each artist object includes a link in `href` to more detailed information about the
        ///     artist.
        /// </value>
        [JsonPropertyName("artists")]
        public List<SimplifiedArtist> Artists { get; set; }
    }
}
