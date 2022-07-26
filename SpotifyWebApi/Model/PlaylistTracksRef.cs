namespace SpotifyWebApi.Model
{
    using Newtonsoft.Json;

    /// <summary>
    /// The <see cref="PlaylistTracksRef" /> class.
    /// </summary>
    public class PlaylistTracksRef
    {
        /// <summary>
        /// A link to the Web API endpoint where full details of the playlist's tracks can be retrieved.
        /// </summary>
        [JsonProperty("href")]
        public string Href { get; set; }

        /// <summary>
        /// Number of tracks in the playlist.
        /// </summary>
        [JsonProperty("total")]
        public int? Total { get; set; }
    }
}
