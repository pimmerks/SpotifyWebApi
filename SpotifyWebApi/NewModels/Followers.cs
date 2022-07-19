namespace SpotifyWebApi.NewModels
{
    using Newtonsoft.Json;

    /// <summary>
    /// </summary>
    public class Followers
    {
        /// <summary>
        ///     This will always be set to null, as the Web API does not support it at the moment.
        /// </summary>
        /// <value>This will always be set to null, as the Web API does not support it at the moment. </value>
        [JsonProperty(PropertyName = "href")]
        public string Href { get; set; }

        /// <summary>
        ///     The total number of followers.
        /// </summary>
        /// <value>The total number of followers. </value>
        [JsonProperty(PropertyName = "total")]
        public int? Total { get; set; }
    }
}
