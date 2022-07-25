namespace SpotifyWebApi.Models
{
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    /// <summary>
    /// </summary>
    public class AudioAnalysis
    {
        /// <summary>
        ///     Gets or Sets Meta
        /// </summary>
        [JsonPropertyName("meta")]
        public AudioAnalysisMeta Meta { get; set; }

        /// <summary>
        ///     Gets or Sets Track
        /// </summary>
        [JsonPropertyName("track")]
        public AudioAnalysisTrack Track { get; set; }

        /// <summary>
        ///     The time intervals of the bars throughout the track. A bar (or measure) is a segment of time defined as a given
        ///     number of beats.
        /// </summary>
        /// <value>
        ///     The time intervals of the bars throughout the track. A bar (or measure) is a segment of time defined as a given
        ///     number of beats.
        /// </value>
        [JsonPropertyName("bars")]
        public List<TimeInterval> Bars { get; set; }

        /// <summary>
        ///     The time intervals of beats throughout the track. A beat is the basic time unit of a piece of music; for example,
        ///     each tick of a metronome. Beats are typically multiples of tatums.
        /// </summary>
        /// <value>
        ///     The time intervals of beats throughout the track. A beat is the basic time unit of a piece of music; for
        ///     example, each tick of a metronome. Beats are typically multiples of tatums.
        /// </value>
        [JsonPropertyName("beats")]
        public List<TimeInterval> Beats { get; set; }

        /// <summary>
        ///     Sections are defined by large variations in rhythm or timbre, e.g. chorus, verse, bridge, guitar solo, etc. Each
        ///     section contains its own descriptions of tempo, key, mode, time_signature, and loudness.
        /// </summary>
        /// <value>
        ///     Sections are defined by large variations in rhythm or timbre, e.g. chorus, verse, bridge, guitar solo, etc. Each
        ///     section contains its own descriptions of tempo, key, mode, time_signature, and loudness.
        /// </value>
        [JsonPropertyName("sections")]
        public List<Section> Sections { get; set; }

        /// <summary>
        ///     Each segment contains a roughly conisistent sound throughout its duration.
        /// </summary>
        /// <value>Each segment contains a roughly conisistent sound throughout its duration.</value>
        [JsonPropertyName("segments")]
        public List<Segment> Segments { get; set; }

        /// <summary>
        ///     A tatum represents the lowest regular pulse train that a listener intuitively infers from the timing of perceived
        ///     musical events (segments).
        /// </summary>
        /// <value>
        ///     A tatum represents the lowest regular pulse train that a listener intuitively infers from the timing of
        ///     perceived musical events (segments).
        /// </value>
        [JsonPropertyName("tatums")]
        public List<TimeInterval> Tatums { get; set; }
    }
}
