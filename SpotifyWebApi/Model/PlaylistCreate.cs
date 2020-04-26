namespace SpotifyWebApi.Model
{
    using Newtonsoft.Json;

    /// <summary>
    /// The playlist create object
    /// </summary>
    public class PlaylistCreate
    {
        /// <summary>
        /// The name of the playlist
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// The playlist description.
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// The playlist visibility.
        /// </summary>
        [JsonProperty("public")]
        public bool Public { get; set; }
    }
}
