namespace SpotifyWebApi.Models
{
    using System.Text.Json.Serialization;

    /// <summary>
    /// </summary>
    public class Section
    {
        /// <summary>
        ///     The starting point (in seconds) of the section.
        /// </summary>
        /// <value>The starting point (in seconds) of the section.</value>
        [JsonPropertyName("start")]
        public decimal? Start { get; set; }

        /// <summary>
        ///     The duration (in seconds) of the section.
        /// </summary>
        /// <value>The duration (in seconds) of the section.</value>
        [JsonPropertyName("duration")]
        public decimal? Duration { get; set; }

        /// <summary>
        ///     The confidence, from 0.0 to 1.0, of the reliability of the section's \"designation\".
        /// </summary>
        /// <value>The confidence, from 0.0 to 1.0, of the reliability of the section's \"designation\".</value>
        [JsonPropertyName("confidence")]
        public decimal? Confidence { get; set; }

        /// <summary>
        ///     The overall loudness of the section in decibels (dB). Loudness values are useful for comparing relative loudness of
        ///     sections within tracks.
        /// </summary>
        /// <value>
        ///     The overall loudness of the section in decibels (dB). Loudness values are useful for comparing relative loudness
        ///     of sections within tracks.
        /// </value>
        [JsonPropertyName("loudness")]
        public decimal? Loudness { get; set; }

        /// <summary>
        ///     The overall estimated tempo of the section in beats per minute (BPM). In musical terminology, tempo is the speed or
        ///     pace of a given piece and derives directly from the average beat duration.
        /// </summary>
        /// <value>
        ///     The overall estimated tempo of the section in beats per minute (BPM). In musical terminology, tempo is the speed
        ///     or pace of a given piece and derives directly from the average beat duration.
        /// </value>
        [JsonPropertyName("tempo")]
        public decimal? Tempo { get; set; }

        /// <summary>
        ///     The confidence, from 0.0 to 1.0, of the reliability of the tempo. Some tracks contain tempo changes or sounds which
        ///     don't contain tempo (like pure speech) which would correspond to a low value in this field.
        /// </summary>
        /// <value>
        ///     The confidence, from 0.0 to 1.0, of the reliability of the tempo. Some tracks contain tempo changes or sounds
        ///     which don't contain tempo (like pure speech) which would correspond to a low value in this field.
        /// </value>
        [JsonPropertyName("tempo_confidence")]
        public decimal? TempoConfidence { get; set; }

        /// <summary>
        ///     The estimated overall key of the section. The values in this field ranging from 0 to 11 mapping to pitches using
        ///     standard Pitch Class notation (E.g. 0 = C, 1 = C♯/D♭, 2 = D, and so on). If no key was detected, the value is -1.
        /// </summary>
        /// <value>
        ///     The estimated overall key of the section. The values in this field ranging from 0 to 11 mapping to pitches using
        ///     standard Pitch Class notation (E.g. 0 = C, 1 = C♯/D♭, 2 = D, and so on). If no key was detected, the value is -1.
        /// </value>
        [JsonPropertyName("key")]
        public int? Key { get; set; }

        /// <summary>
        ///     The confidence, from 0.0 to 1.0, of the reliability of the key. Songs with many key changes may correspond to low
        ///     values in this field.
        /// </summary>
        /// <value>
        ///     The confidence, from 0.0 to 1.0, of the reliability of the key. Songs with many key changes may correspond to
        ///     low values in this field.
        /// </value>
        [JsonPropertyName("key_confidence")]
        public decimal? KeyConfidence { get; set; }

        /// <summary>
        ///     Indicates the modality (major or minor) of a section, the type of scale from which its melodic content is derived.
        ///     This field will contain a 0 for \"minor\", a 1 for \"major\", or a -1 for no result. Note that the major key (e.g.
        ///     C major) could more likely be confused with the minor key at 3 semitones lower (e.g. A minor) as both keys carry
        ///     the same pitches.
        /// </summary>
        /// <value>
        ///     Indicates the modality (major or minor) of a section, the type of scale from which its melodic content is
        ///     derived. This field will contain a 0 for \"minor\", a 1 for \"major\", or a -1 for no result. Note that the major
        ///     key (e.g. C major) could more likely be confused with the minor key at 3 semitones lower (e.g. A minor) as both
        ///     keys carry the same pitches.
        /// </value>
        [JsonPropertyName("mode")]
        public decimal? Mode { get; set; }

        /// <summary>
        ///     The confidence, from 0.0 to 1.0, of the reliability of the `mode`.
        /// </summary>
        /// <value>The confidence, from 0.0 to 1.0, of the reliability of the `mode`.</value>
        [JsonPropertyName("mode_confidence")]
        public decimal? ModeConfidence { get; set; }

        /// <summary>
        ///     Gets or Sets TimeSignature
        /// </summary>
        [JsonPropertyName("time_signature")]
        public int? TimeSignature { get; set; }

        /// <summary>
        ///     The confidence, from 0.0 to 1.0, of the reliability of the `time_signature`. Sections with time signature changes
        ///     may correspond to low values in this field.
        /// </summary>
        /// <value>
        ///     The confidence, from 0.0 to 1.0, of the reliability of the `time_signature`. Sections with time signature
        ///     changes may correspond to low values in this field.
        /// </value>
        [JsonPropertyName("time_signature_confidence")]
        public decimal? TimeSignatureConfidence { get; set; }
    }
}
