namespace SpotifyWebApi.Models
{
    using System.Text.Json.Serialization;

    /// <summary>
    /// </summary>
    public class Disallows
    {
        /// <summary>
        ///     Interrupting playback. Optional field.
        /// </summary>
        /// <value>Interrupting playback. Optional field.</value>
        [JsonPropertyName("interrupting_playback")]
        public bool? InterruptingPlayback { get; set; }

        /// <summary>
        ///     Pausing. Optional field.
        /// </summary>
        /// <value>Pausing. Optional field.</value>
        [JsonPropertyName("pausing")]
        public bool? Pausing { get; set; }

        /// <summary>
        ///     Resuming. Optional field.
        /// </summary>
        /// <value>Resuming. Optional field.</value>
        [JsonPropertyName("resuming")]
        public bool? Resuming { get; set; }

        /// <summary>
        ///     Seeking playback location. Optional field.
        /// </summary>
        /// <value>Seeking playback location. Optional field.</value>
        [JsonPropertyName("seeking")]
        public bool? Seeking { get; set; }

        /// <summary>
        ///     Skipping to the next context. Optional field.
        /// </summary>
        /// <value>Skipping to the next context. Optional field.</value>
        [JsonPropertyName("skipping_next")]
        public bool? SkippingNext { get; set; }

        /// <summary>
        ///     Skipping to the previous context. Optional field.
        /// </summary>
        /// <value>Skipping to the previous context. Optional field.</value>
        [JsonPropertyName("skipping_prev")]
        public bool? SkippingPrev { get; set; }

        /// <summary>
        ///     Toggling repeat context flag. Optional field.
        /// </summary>
        /// <value>Toggling repeat context flag. Optional field.</value>
        [JsonPropertyName("toggling_repeat_context")]
        public bool? TogglingRepeatContext { get; set; }

        /// <summary>
        ///     Toggling shuffle flag. Optional field.
        /// </summary>
        /// <value>Toggling shuffle flag. Optional field.</value>
        [JsonPropertyName("toggling_shuffle")]
        public bool? TogglingShuffle { get; set; }

        /// <summary>
        ///     Toggling repeat track flag. Optional field.
        /// </summary>
        /// <value>Toggling repeat track flag. Optional field.</value>
        [JsonPropertyName("toggling_repeat_track")]
        public bool? TogglingRepeatTrack { get; set; }

        /// <summary>
        ///     Transfering playback between devices. Optional field.
        /// </summary>
        /// <value>Transfering playback between devices. Optional field.</value>
        [JsonPropertyName("transferring_playback")]
        public bool? TransferringPlayback { get; set; }
    }
}
