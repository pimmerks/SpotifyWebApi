namespace SpotifyWebApi.NewModels
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

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
        [JsonProperty(PropertyName = "artists")]
        public List<Artist> Artists { get; set; }

        /// <summary>
        ///     The tracks of the album.
        /// </summary>
        /// <value>The tracks of the album. </value>
        [JsonProperty(PropertyName = "tracks")]
        public object Tracks { get; set; }
    }
}
