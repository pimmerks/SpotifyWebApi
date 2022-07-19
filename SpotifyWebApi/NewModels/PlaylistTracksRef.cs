namespace SpotifyWebApi.NewModels
{
    using Newtonsoft.Json;

    /// <summary>
    /// </summary>
    public class PlaylistTracksRef
    {
        /// <summary>
        ///     A link to the Web API endpoint where full details of the playlist's tracks can be retrieved.
        /// </summary>
        /// <value>A link to the Web API endpoint where full details of the playlist's tracks can be retrieved. </value>
        [JsonProperty(PropertyName = "href")]
        public string Href { get; set; }

        /// <summary>
        ///     Number of tracks in the playlist.
        /// </summary>
        /// <value>Number of tracks in the playlist. </value>
        [JsonProperty(PropertyName = "total")]
        public int? Total { get; set; }
    }
}
