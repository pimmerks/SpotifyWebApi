namespace SpotifyWebApi.Models
{
    using System.Text.Json.Serialization;

    /// <summary>
    /// </summary>
    public class AudioAnalysisTrack
    {
        /// <summary>
        ///     The exact number of audio samples analyzed from this track. See also `analysis_sample_rate`.
        /// </summary>
        /// <value>The exact number of audio samples analyzed from this track. See also `analysis_sample_rate`.</value>
        [JsonPropertyName("num_samples")]
        public int? NumSamples { get; set; }

        /// <summary>
        ///     Length of the track in seconds.
        /// </summary>
        /// <value>Length of the track in seconds.</value>
        [JsonPropertyName("duration")]
        public decimal? Duration { get; set; }

        /// <summary>
        ///     This field will always contain the empty string.
        /// </summary>
        /// <value>This field will always contain the empty string.</value>
        [JsonPropertyName("sample_md5")]
        public string SampleMd5 { get; set; }

        /// <summary>
        ///     An offset to the start of the region of the track that was analyzed. (As the entire track is analyzed, this should
        ///     always be 0.)
        /// </summary>
        /// <value>
        ///     An offset to the start of the region of the track that was analyzed. (As the entire track is analyzed, this
        ///     should always be 0.)
        /// </value>
        [JsonPropertyName("offset_seconds")]
        public int? OffsetSeconds { get; set; }

        /// <summary>
        ///     The length of the region of the track was analyzed, if a subset of the track was analyzed. (As the entire track is
        ///     analyzed, this should always be 0.)
        /// </summary>
        /// <value>
        ///     The length of the region of the track was analyzed, if a subset of the track was analyzed. (As the entire track
        ///     is analyzed, this should always be 0.)
        /// </value>
        [JsonPropertyName("window_seconds")]
        public int? WindowSeconds { get; set; }

        /// <summary>
        ///     The sample rate used to decode and analyze this track. May differ from the actual sample rate of this track
        ///     available on Spotify.
        /// </summary>
        /// <value>
        ///     The sample rate used to decode and analyze this track. May differ from the actual sample rate of this track
        ///     available on Spotify.
        /// </value>
        [JsonPropertyName("analysis_sample_rate")]
        public int? AnalysisSampleRate { get; set; }

        /// <summary>
        ///     The number of channels used for analysis. If 1, all channels are summed together to mono before analysis.
        /// </summary>
        /// <value>The number of channels used for analysis. If 1, all channels are summed together to mono before analysis.</value>
        [JsonPropertyName("analysis_channels")]
        public int? AnalysisChannels { get; set; }

        /// <summary>
        ///     The time, in seconds, at which the track's fade-in period ends. If the track has no fade-in, this will be 0.0.
        /// </summary>
        /// <value>The time, in seconds, at which the track's fade-in period ends. If the track has no fade-in, this will be 0.0.</value>
        [JsonPropertyName("end_of_fade_in")]
        public decimal? EndOfFadeIn { get; set; }

        /// <summary>
        ///     The time, in seconds, at which the track's fade-out period starts. If the track has no fade-out, this should match
        ///     the track's length.
        /// </summary>
        /// <value>
        ///     The time, in seconds, at which the track's fade-out period starts. If the track has no fade-out, this should
        ///     match the track's length.
        /// </value>
        [JsonPropertyName("start_of_fade_out")]
        public decimal? StartOfFadeOut { get; set; }

        /// <summary>
        ///     Gets or Sets Loudness
        /// </summary>
        [JsonPropertyName("loudness")]
        public float? Loudness { get; set; }

        /// <summary>
        ///     Gets or Sets Tempo
        /// </summary>
        [JsonPropertyName("tempo")]
        public float? Tempo { get; set; }

        /// <summary>
        ///     The confidence, from 0.0 to 1.0, of the reliability of the `tempo`.
        /// </summary>
        /// <value>The confidence, from 0.0 to 1.0, of the reliability of the `tempo`.</value>
        [JsonPropertyName("tempo_confidence")]
        public decimal? TempoConfidence { get; set; }

        /// <summary>
        ///     Gets or Sets TimeSignature
        /// </summary>
        [JsonPropertyName("time_signature")]
        public int? TimeSignature { get; set; }

        /// <summary>
        ///     The confidence, from 0.0 to 1.0, of the reliability of the `time_signature`.
        /// </summary>
        /// <value>The confidence, from 0.0 to 1.0, of the reliability of the `time_signature`.</value>
        [JsonPropertyName("time_signature_confidence")]
        public decimal? TimeSignatureConfidence { get; set; }

        /// <summary>
        ///     Gets or Sets Key
        /// </summary>
        [JsonPropertyName("key")]
        public int? Key { get; set; }

        /// <summary>
        ///     The confidence, from 0.0 to 1.0, of the reliability of the `key`.
        /// </summary>
        /// <value>The confidence, from 0.0 to 1.0, of the reliability of the `key`.</value>
        [JsonPropertyName("key_confidence")]
        public decimal? KeyConfidence { get; set; }

        /// <summary>
        ///     Gets or Sets Mode
        /// </summary>
        [JsonPropertyName("mode")]
        public int? Mode { get; set; }

        /// <summary>
        ///     The confidence, from 0.0 to 1.0, of the reliability of the `mode`.
        /// </summary>
        /// <value>The confidence, from 0.0 to 1.0, of the reliability of the `mode`.</value>
        [JsonPropertyName("mode_confidence")]
        public decimal? ModeConfidence { get; set; }

        /// <summary>
        ///     An [Echo Nest Musical Fingerprint (ENMFP)](https://academiccommons.columbia.edu/doi/10.7916/D8Q248M4) codestring
        ///     for this track.
        /// </summary>
        /// <value>
        ///     An [Echo Nest Musical Fingerprint (ENMFP)](https://academiccommons.columbia.edu/doi/10.7916/D8Q248M4) codestring
        ///     for this track.
        /// </value>
        [JsonPropertyName("codestring")]
        public string Codestring { get; set; }

        /// <summary>
        ///     A version number for the Echo Nest Musical Fingerprint format used in the codestring field.
        /// </summary>
        /// <value>A version number for the Echo Nest Musical Fingerprint format used in the codestring field.</value>
        [JsonPropertyName("code_version")]
        public decimal? CodeVersion { get; set; }

        /// <summary>
        ///     An [EchoPrint](https://github.com/spotify/echoprint-codegen) codestring for this track.
        /// </summary>
        /// <value>An [EchoPrint](https://github.com/spotify/echoprint-codegen) codestring for this track.</value>
        [JsonPropertyName("echoprintstring")]
        public string Echoprintstring { get; set; }

        /// <summary>
        ///     A version number for the EchoPrint format used in the echoprintstring field.
        /// </summary>
        /// <value>A version number for the EchoPrint format used in the echoprintstring field.</value>
        [JsonPropertyName("echoprint_version")]
        public decimal? EchoprintVersion { get; set; }

        /// <summary>
        ///     A [Synchstring](https://github.com/echonest/synchdata) for this track.
        /// </summary>
        /// <value>A [Synchstring](https://github.com/echonest/synchdata) for this track.</value>
        [JsonPropertyName("synchstring")]
        public string Synchstring { get; set; }

        /// <summary>
        ///     A version number for the Synchstring used in the synchstring field.
        /// </summary>
        /// <value>A version number for the Synchstring used in the synchstring field.</value>
        [JsonPropertyName("synch_version")]
        public decimal? SynchVersion { get; set; }

        /// <summary>
        ///     A Rhythmstring for this track. The format of this string is similar to the Synchstring.
        /// </summary>
        /// <value>A Rhythmstring for this track. The format of this string is similar to the Synchstring.</value>
        [JsonPropertyName("rhythmstring")]
        public string Rhythmstring { get; set; }

        /// <summary>
        ///     A version number for the Rhythmstring used in the rhythmstring field.
        /// </summary>
        /// <value>A version number for the Rhythmstring used in the rhythmstring field.</value>
        [JsonPropertyName("rhythm_version")]
        public decimal? RhythmVersion { get; set; }
    }
}
