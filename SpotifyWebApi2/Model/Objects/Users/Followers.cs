namespace Spotify.WebApi.Model.Objects.Users
{
    using System.Text.Json.Serialization;

    /// <summary>
    /// The <see cref="Followers" /> class.
    /// </summary>
    public class Followers
    {
        /// <summary>
        /// Gets or sets the href.
        /// </summary>
        [JsonPropertyName("href")]
        public string Href { get; set; }

        /// <summary>
        /// Gets or sets the total.
        /// </summary>
        [JsonPropertyName("total")]
        public int Total { get; set; }
    }
}
