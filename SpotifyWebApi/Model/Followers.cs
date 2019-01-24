namespace Spotify.Model
{
    using Newtonsoft.Json;

    /// <summary>
    /// The <see cref="Followers" /> class.
    /// </summary>
    public class Followers
    {
        /// <summary>
        /// Gets or sets the href.
        /// </summary>
        [JsonProperty("href")]
        public string Href { get; set; }

        /// <summary>
        /// Gets or sets the total.
        /// </summary>
        [JsonProperty("total")]
        public int Total { get; set; }
    }
}
