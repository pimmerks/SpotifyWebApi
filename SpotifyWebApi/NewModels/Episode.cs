namespace SpotifyWebApi.NewModels
{
    using Newtonsoft.Json;

    /// <summary>
    /// </summary>
    public class Episode : EpisodeBase
    {
        /// <summary>
        ///     Gets or Sets Show
        /// </summary>
        [JsonProperty(PropertyName = "show")]
        public SimplifiedShow Show { get; set; }
    }
}
