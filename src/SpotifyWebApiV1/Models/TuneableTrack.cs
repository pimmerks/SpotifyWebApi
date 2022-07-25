namespace SpotifyWebApi.Models
{
    using System.Text.Json.Serialization;

    /// <summary>
    /// </summary>
    public class TuneableTrack
    {
        /// <summary>
        ///     A confidence measure from 0.0 to 1.0 of whether the track is acoustic. 1.0 represents high confidence the track is
        ///     acoustic.
        /// </summary>
        /// <value>
        ///     A confidence measure from 0.0 to 1.0 of whether the track is acoustic. 1.0 represents high confidence the track
        ///     is acoustic.
        /// </value>
        [JsonPropertyName("acousticness")]
        public float? Acousticness { get; set; }

        /// <summary>
        ///     Danceability describes how suitable a track is for dancing based on a combination of musical elements including
        ///     tempo, rhythm stability, beat strength, and overall regularity. A value of 0.0 is least danceable and 1.0 is most
        ///     danceable.
        /// </summary>
        /// <value>
        ///     Danceability describes how suitable a track is for dancing based on a combination of musical elements including
        ///     tempo, rhythm stability, beat strength, and overall regularity. A value of 0.0 is least danceable and 1.0 is most
        ///     danceable.
        /// </value>
        [JsonPropertyName("danceability")]
        public float? Danceability { get; set; }

        /// <summary>
        ///     The duration of the track in milliseconds.
        /// </summary>
        /// <value>The duration of the track in milliseconds. </value>
        [JsonPropertyName("duration_ms")]
        public int? DurationMs { get; set; }

        /// <summary>
        ///     Energy is a measure from 0.0 to 1.0 and represents a perceptual measure of intensity and activity. Typically,
        ///     energetic tracks feel fast, loud, and noisy. For example, death metal has high energy, while a Bach prelude scores
        ///     low on the scale. Perceptual features contributing to this attribute include dynamic range, perceived loudness,
        ///     timbre, onset rate, and general entropy.
        /// </summary>
        /// <value>
        ///     Energy is a measure from 0.0 to 1.0 and represents a perceptual measure of intensity and activity. Typically,
        ///     energetic tracks feel fast, loud, and noisy. For example, death metal has high energy, while a Bach prelude scores
        ///     low on the scale. Perceptual features contributing to this attribute include dynamic range, perceived loudness,
        ///     timbre, onset rate, and general entropy.
        /// </value>
        [JsonPropertyName("energy")]
        public float? Energy { get; set; }

        /// <summary>
        ///     Predicts whether a track contains no vocals. \"Ooh\" and \"aah\" sounds are treated as instrumental in this
        ///     context. Rap or spoken word tracks are clearly \"vocal\". The closer the instrumentalness value is to 1.0, the
        ///     greater likelihood the track contains no vocal content. Values above 0.5 are intended to represent instrumental
        ///     tracks, but confidence is higher as the value approaches 1.0.
        /// </summary>
        /// <value>
        ///     Predicts whether a track contains no vocals. \"Ooh\" and \"aah\" sounds are treated as instrumental in this
        ///     context. Rap or spoken word tracks are clearly \"vocal\". The closer the instrumentalness value is to 1.0, the
        ///     greater likelihood the track contains no vocal content. Values above 0.5 are intended to represent instrumental
        ///     tracks, but confidence is higher as the value approaches 1.0.
        /// </value>
        [JsonPropertyName("instrumentalness")]
        public float? Instrumentalness { get; set; }

        /// <summary>
        ///     Gets or Sets Key
        /// </summary>
        [JsonPropertyName("key")]
        public int? Key { get; set; }

        /// <summary>
        ///     Detects the presence of an audience in the recording. Higher liveness values represent an increased probability
        ///     that the track was performed live. A value above 0.8 provides strong likelihood that the track is live.
        /// </summary>
        /// <value>
        ///     Detects the presence of an audience in the recording. Higher liveness values represent an increased probability
        ///     that the track was performed live. A value above 0.8 provides strong likelihood that the track is live.
        /// </value>
        [JsonPropertyName("liveness")]
        public float? Liveness { get; set; }

        /// <summary>
        ///     Gets or Sets Loudness
        /// </summary>
        [JsonPropertyName("loudness")]
        public float? Loudness { get; set; }

        /// <summary>
        ///     Gets or Sets Mode
        /// </summary>
        [JsonPropertyName("mode")]
        public int? Mode { get; set; }

        /// <summary>
        ///     The popularity of the track. The value will be between 0 and 100, with 100 being the most popular. The popularity
        ///     is calculated by algorithm and is based, in the most part, on the total number of plays the track has had and how
        ///     recent those plays are. _**Note**: When applying track relinking via the `market` parameter, it is expected to find
        ///     relinked tracks with popularities that do not match `min_*`, `max_*`and `target_*` popularities. These relinked
        ///     tracks are accurate replacements for unplayable tracks with the expected popularity scores. Original, non-relinked
        ///     tracks are available via the `linked_from` attribute of the [relinked track
        ///     response](/documentation/general/guides/track-relinking-guide)._
        /// </summary>
        /// <value>
        ///     The popularity of the track. The value will be between 0 and 100, with 100 being the most popular. The
        ///     popularity is calculated by algorithm and is based, in the most part, on the total number of plays the track has
        ///     had and how recent those plays are. _**Note**: When applying track relinking via the `market` parameter, it is
        ///     expected to find relinked tracks with popularities that do not match `min_*`, `max_*`and `target_*` popularities.
        ///     These relinked tracks are accurate replacements for unplayable tracks with the expected popularity scores.
        ///     Original, non-relinked tracks are available via the `linked_from` attribute of the [relinked track
        ///     response](/documentation/general/guides/track-relinking-guide)._
        /// </value>
        [JsonPropertyName("popularity")]
        public float? Popularity { get; set; }

        /// <summary>
        ///     Speechiness detects the presence of spoken words in a track. The more exclusively speech-like the recording (e.g.
        ///     talk show, audio book, poetry), the closer to 1.0 the attribute value. Values above 0.66 describe tracks that are
        ///     probably made entirely of spoken words. Values between 0.33 and 0.66 describe tracks that may contain both music
        ///     and speech, either in sections or layered, including such cases as rap music. Values below 0.33 most likely
        ///     represent music and other non-speech-like tracks.
        /// </summary>
        /// <value>
        ///     Speechiness detects the presence of spoken words in a track. The more exclusively speech-like the recording
        ///     (e.g. talk show, audio book, poetry), the closer to 1.0 the attribute value. Values above 0.66 describe tracks that
        ///     are probably made entirely of spoken words. Values between 0.33 and 0.66 describe tracks that may contain both
        ///     music and speech, either in sections or layered, including such cases as rap music. Values below 0.33 most likely
        ///     represent music and other non-speech-like tracks.
        /// </value>
        [JsonPropertyName("speechiness")]
        public float? Speechiness { get; set; }

        /// <summary>
        ///     Gets or Sets Tempo
        /// </summary>
        [JsonPropertyName("tempo")]
        public float? Tempo { get; set; }

        /// <summary>
        ///     Gets or Sets TimeSignature
        /// </summary>
        [JsonPropertyName("time_signature")]
        public int? TimeSignature { get; set; }

        /// <summary>
        ///     A measure from 0.0 to 1.0 describing the musical positiveness conveyed by a track. Tracks with high valence sound
        ///     more positive (e.g. happy, cheerful, euphoric), while tracks with low valence sound more negative (e.g. sad,
        ///     depressed, angry).
        /// </summary>
        /// <value>
        ///     A measure from 0.0 to 1.0 describing the musical positiveness conveyed by a track. Tracks with high valence
        ///     sound more positive (e.g. happy, cheerful, euphoric), while tracks with low valence sound more negative (e.g. sad,
        ///     depressed, angry).
        /// </value>
        [JsonPropertyName("valence")]
        public float? Valence { get; set; }
    }
}
