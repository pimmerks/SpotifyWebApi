namespace SpotifyWebApi.NewModels
{
    using System;
    using Newtonsoft.Json;

    /// <summary>
    /// </summary>
    public class SavedEpisode
    {
        /// <summary>
        ///     The date and time the episode was saved. Timestamps are returned in ISO 8601 format as Coordinated Universal Time
        ///     (UTC) with a zero offset: YYYY-MM-DDTHH:MM:SSZ.
        /// </summary>
        /// <value>
        ///     The date and time the episode was saved. Timestamps are returned in ISO 8601 format as Coordinated Universal
        ///     Time (UTC) with a zero offset: YYYY-MM-DDTHH:MM:SSZ.
        /// </value>
        [JsonProperty(PropertyName = "added_at")]
        public DateTime? AddedAt { get; set; }

        /// <summary>
        ///     Information about the episode.
        /// </summary>
        /// <value>Information about the episode.</value>
        [JsonProperty(PropertyName = "episode")]
        public Episode Episode { get; set; }
    }
}
