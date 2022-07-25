namespace SpotifyWebApi.Models
{
    using System.Text.Json.Serialization;

    /// <summary>
    /// </summary>
    public class Episode : EpisodeBase
    {
        /// <summary>
        ///     Gets or Sets Show
        /// </summary>
        [JsonPropertyName("show")]
        public SimplifiedShow Show { get; set; }
    }
}
