namespace SpotifyWebApi.Models
{
    using System.Text.Json.Serialization;

    /// <summary>
    /// </summary>
    public class PlaylistsplaylistIdtracksTracks
    {
        /// <summary>
        ///     Spotify URI
        /// </summary>
        /// <value>Spotify URI</value>
        [JsonPropertyName("uri")]
        public string Uri { get; set; }
    }
}
