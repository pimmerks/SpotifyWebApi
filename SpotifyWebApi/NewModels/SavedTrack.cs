namespace SpotifyWebApi.NewModels
{
    using System;
    using Newtonsoft.Json;

    /// <summary>
    /// </summary>
    public class SavedTrack
    {
        /// <summary>
        ///     The date and time the track was saved. Timestamps are returned in ISO 8601 format as Coordinated Universal Time
        ///     (UTC) with a zero offset: YYYY-MM-DDTHH:MM:SSZ. If the time is imprecise (for example, the date/time of an album
        ///     release), an additional field indicates the precision; see for example, release_date in an album object.
        /// </summary>
        /// <value>
        ///     The date and time the track was saved. Timestamps are returned in ISO 8601 format as Coordinated Universal Time
        ///     (UTC) with a zero offset: YYYY-MM-DDTHH:MM:SSZ. If the time is imprecise (for example, the date/time of an album
        ///     release), an additional field indicates the precision; see for example, release_date in an album object.
        /// </value>
        [JsonProperty(PropertyName = "added_at")]
        public DateTime? AddedAt { get; set; }

        /// <summary>
        ///     Information about the track.
        /// </summary>
        /// <value>Information about the track.</value>
        [JsonProperty(PropertyName = "track")]
        public Track Track { get; set; }
    }
}
