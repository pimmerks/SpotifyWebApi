namespace SpotifyWebApi.Models
{
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    /// <summary>
    /// </summary>
    public class Segment
    {
        /// <summary>
        ///     The starting point (in seconds) of the segment.
        /// </summary>
        /// <value>The starting point (in seconds) of the segment.</value>
        [JsonPropertyName("start")]
        public decimal? Start { get; set; }

        /// <summary>
        ///     The duration (in seconds) of the segment.
        /// </summary>
        /// <value>The duration (in seconds) of the segment.</value>
        [JsonPropertyName("duration")]
        public decimal? Duration { get; set; }

        /// <summary>
        ///     The confidence, from 0.0 to 1.0, of the reliability of the segmentation. Segments of the song which are difficult
        ///     to logically segment (e.g: noise) may correspond to low values in this field.
        /// </summary>
        /// <value>
        ///     The confidence, from 0.0 to 1.0, of the reliability of the segmentation. Segments of the song which are
        ///     difficult to logically segment (e.g: noise) may correspond to low values in this field.
        /// </value>
        [JsonPropertyName("confidence")]
        public decimal? Confidence { get; set; }

        /// <summary>
        ///     The onset loudness of the segment in decibels (dB). Combined with `loudness_max` and `loudness_max_time`, these
        ///     components can be used to describe the \"attack\" of the segment.
        /// </summary>
        /// <value>
        ///     The onset loudness of the segment in decibels (dB). Combined with `loudness_max` and `loudness_max_time`, these
        ///     components can be used to describe the \"attack\" of the segment.
        /// </value>
        [JsonPropertyName("loudness_start")]
        public decimal? LoudnessStart { get; set; }

        /// <summary>
        ///     The peak loudness of the segment in decibels (dB). Combined with `loudness_start` and `loudness_max_time`, these
        ///     components can be used to describe the \"attack\" of the segment.
        /// </summary>
        /// <value>
        ///     The peak loudness of the segment in decibels (dB). Combined with `loudness_start` and `loudness_max_time`, these
        ///     components can be used to describe the \"attack\" of the segment.
        /// </value>
        [JsonPropertyName("loudness_max")]
        public decimal? LoudnessMax { get; set; }

        /// <summary>
        ///     The segment-relative offset of the segment peak loudness in seconds. Combined with `loudness_start` and
        ///     `loudness_max`, these components can be used to desctibe the \"attack\" of the segment.
        /// </summary>
        /// <value>
        ///     The segment-relative offset of the segment peak loudness in seconds. Combined with `loudness_start` and
        ///     `loudness_max`, these components can be used to desctibe the \"attack\" of the segment.
        /// </value>
        [JsonPropertyName("loudness_max_time")]
        public decimal? LoudnessMaxTime { get; set; }

        /// <summary>
        ///     The offset loudness of the segment in decibels (dB). This value should be equivalent to the loudness_start of the
        ///     following segment.
        /// </summary>
        /// <value>
        ///     The offset loudness of the segment in decibels (dB). This value should be equivalent to the loudness_start of
        ///     the following segment.
        /// </value>
        [JsonPropertyName("loudness_end")]
        public decimal? LoudnessEnd { get; set; }

        /// <summary>
        ///     Pitch content is given by a “chroma” vector, corresponding to the 12 pitch classes C, C#, D to B, with values
        ///     ranging from 0 to 1 that describe the relative dominance of every pitch in the chromatic scale. For example a C
        ///     Major chord would likely be represented by large values of C, E and G (i.e. classes 0, 4, and 7).  Vectors are
        ///     normalized to 1 by their strongest dimension, therefore noisy sounds are likely represented by values that are all
        ///     close to 1, while pure tones are described by one value at 1 (the pitch) and others near 0. As can be seen below,
        ///     the 12 vector indices are a combination of low-power spectrum values at their respective pitch frequencies.
        ///     <img src="https://developer.spotify.com/assets/audio/Pitch_vector.png" />
        /// </summary>
        /// <value>
        ///     Pitch content is given by a “chroma” vector, corresponding to the 12 pitch classes C, C#, D to B, with values
        ///     ranging from 0 to 1 that describe the relative dominance of every pitch in the chromatic scale. For example a C
        ///     Major chord would likely be represented by large values of C, E and G (i.e. classes 0, 4, and 7).  Vectors are
        ///     normalized to 1 by their strongest dimension, therefore noisy sounds are likely represented by values that are all
        ///     close to 1, while pure tones are described by one value at 1 (the pitch) and others near 0. As can be seen below,
        ///     the 12 vector indices are a combination of low-power spectrum values at their respective pitch frequencies.
        ///     <img src="https://developer.spotify.com/assets/audio/Pitch_vector.png" />
        /// </value>
        [JsonPropertyName("pitches")]
        public List<decimal?> Pitches { get; set; }

        /// <summary>
        ///     Timbre is the quality of a musical note or sound that distinguishes different types of musical instruments, or
        ///     voices. It is a complex notion also referred to as sound color, texture, or tone quality, and is derived from the
        ///     shape of a segment’s spectro-temporal surface, independently of pitch and loudness. The timbre feature is a vector
        ///     that includes 12 unbounded values roughly centered around 0. Those values are high level abstractions of the
        ///     spectral surface, ordered by degree of importance.  For completeness however, the first dimension represents the
        ///     average loudness of the segment; second emphasizes brightness; third is more closely correlated to the flatness of
        ///     a sound; fourth to sounds with a stronger attack; etc. See an image below representing the 12 basis functions (i.e.
        ///     template segments). <img src="https://developer.spotify.com/assets/audio/Timbre_basis_functions.png" />  The
        ///     actual timbre of the segment is best described as a linear combination of these 12 basis functions weighted by the
        ///     coefficient values: timbre = c1 x b1 + c2 x b2 + ... + c12 x b12, where c1 to c12 represent the 12 coefficients and
        ///     b1 to b12 the 12 basis functions as displayed below. Timbre vectors are best used in comparison with each other.
        /// </summary>
        /// <value>
        ///     Timbre is the quality of a musical note or sound that distinguishes different types of musical instruments, or
        ///     voices. It is a complex notion also referred to as sound color, texture, or tone quality, and is derived from the
        ///     shape of a segment’s spectro-temporal surface, independently of pitch and loudness. The timbre feature is a vector
        ///     that includes 12 unbounded values roughly centered around 0. Those values are high level abstractions of the
        ///     spectral surface, ordered by degree of importance.  For completeness however, the first dimension represents the
        ///     average loudness of the segment; second emphasizes brightness; third is more closely correlated to the flatness of
        ///     a sound; fourth to sounds with a stronger attack; etc. See an image below representing the 12 basis functions (i.e.
        ///     template segments). <img src="https://developer.spotify.com/assets/audio/Timbre_basis_functions.png" />  The
        ///     actual timbre of the segment is best described as a linear combination of these 12 basis functions weighted by the
        ///     coefficient values: timbre = c1 x b1 + c2 x b2 + ... + c12 x b12, where c1 to c12 represent the 12 coefficients and
        ///     b1 to b12 the 12 basis functions as displayed below. Timbre vectors are best used in comparison with each other.
        /// </value>
        [JsonPropertyName("timbre")]
        public List<decimal?> Timbre { get; set; }
    }
}
