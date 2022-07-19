namespace SpotifyWebApi.NewModels
{
    using System;
    using Newtonsoft.Json;

    /// <summary>
    /// </summary>
    public class SavedAlbum
    {
        /// <summary>
        ///     The date and time the album was saved Timestamps are returned in ISO 8601 format as Coordinated Universal Time
        ///     (UTC) with a zero offset: YYYY-MM-DDTHH:MM:SSZ. If the time is imprecise (for example, the date/time of an album
        ///     release), an additional field indicates the precision; see for example, release_date in an album object.
        /// </summary>
        /// <value>
        ///     The date and time the album was saved Timestamps are returned in ISO 8601 format as Coordinated Universal Time
        ///     (UTC) with a zero offset: YYYY-MM-DDTHH:MM:SSZ. If the time is imprecise (for example, the date/time of an album
        ///     release), an additional field indicates the precision; see for example, release_date in an album object.
        /// </value>
        [JsonProperty(PropertyName = "added_at")]
        public DateTime? AddedAt { get; set; }

        /// <summary>
        ///     Information about the album.
        /// </summary>
        /// <value>Information about the album.</value>
        [JsonProperty(PropertyName = "album")]
        public Album Album { get; set; }
    }
}
