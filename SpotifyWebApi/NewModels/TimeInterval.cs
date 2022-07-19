namespace SpotifyWebApi.NewModels
{
    using Newtonsoft.Json;

    /// <summary>
    /// </summary>
    public class TimeInterval
    {
        /// <summary>
        ///     The starting point (in seconds) of the time interval.
        /// </summary>
        /// <value>The starting point (in seconds) of the time interval.</value>
        [JsonProperty(PropertyName = "start")]
        public decimal? Start { get; set; }

        /// <summary>
        ///     The duration (in seconds) of the time interval.
        /// </summary>
        /// <value>The duration (in seconds) of the time interval.</value>
        [JsonProperty(PropertyName = "duration")]
        public decimal? Duration { get; set; }

        /// <summary>
        ///     The confidence, from 0.0 to 1.0, of the reliability of the interval.
        /// </summary>
        /// <value>The confidence, from 0.0 to 1.0, of the reliability of the interval.</value>
        [JsonProperty(PropertyName = "confidence")]
        public decimal? Confidence { get; set; }
    }
}
