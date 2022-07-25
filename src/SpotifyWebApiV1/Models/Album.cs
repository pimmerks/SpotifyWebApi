namespace SpotifyWebApi.Models
{
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    /// <summary>
    /// </summary>
    public class Album : AlbumBase
    {
        /// <summary>
        ///     The artists of the album. Each artist object includes a link in `href` to more detailed information about the
        ///     artist.
        /// </summary>
        /// <value>
        ///     The artists of the album. Each artist object includes a link in `href` to more detailed information about the
        ///     artist.
        /// </value>
        [JsonPropertyName("artists")]
        public List<Artist> Artists { get; set; }

        /// <summary>
        ///     The tracks of the album.
        /// </summary>
        /// <value>The tracks of the album. </value>
        [JsonPropertyName("tracks")]
        public object Tracks { get; set; }
    }
}
