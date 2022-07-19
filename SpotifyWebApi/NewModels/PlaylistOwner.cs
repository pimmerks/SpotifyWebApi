namespace SpotifyWebApi.NewModels
{
    using Newtonsoft.Json;

    /// <summary>
    /// </summary>
    public class PlaylistOwner : PlaylistUser
    {
        /// <summary>
        ///     The name displayed on the user's profile. `null` if not available.
        /// </summary>
        /// <value>The name displayed on the user's profile. `null` if not available. </value>
        [JsonProperty(PropertyName = "display_name")]
        public string DisplayName { get; set; }
    }
}
