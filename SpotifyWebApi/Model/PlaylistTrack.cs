namespace Spotify.Model
{
    using System;
    using Newtonsoft.Json;

    /// <summary>
    /// The <see cref="PlaylistTrack" /> class.
    /// </summary>
    public class PlaylistTrack
    {
        /// <summary>
        /// Gets or sets the added at.
        /// </summary>
        [JsonProperty("added_at")]
        public DateTime AddedAt { get; set; }

        /// <summary>
        /// Gets or sets the added by.
        /// </summary>
        [JsonProperty("added_by")]
        public PublicUser AddedBy { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is local.
        /// </summary>
        [JsonProperty("is_local")]
        public bool IsLocal { get; set; }

        /// <summary>
        /// Gets or sets the track.
        /// </summary>
        [JsonProperty("track")]
        public FullTrack Track { get; set; }
    }
}
