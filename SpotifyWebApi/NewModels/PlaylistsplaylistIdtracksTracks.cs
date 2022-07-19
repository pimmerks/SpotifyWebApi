namespace SpotifyWebApi.NewModels
{
    using Newtonsoft.Json;

    /// <summary>
    /// </summary>
    public class PlaylistsplaylistIdtracksTracks
    {
        /// <summary>
        ///     Spotify URI
        /// </summary>
        /// <value>Spotify URI</value>
        [JsonProperty(PropertyName = "uri")]
        public string Uri { get; set; }
    }
}
