namespace Spotify.WebApi.Model.Objects.Episodes
{
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using Spotify.WebApi.Model.Objects.Albums;

    /// <summary>
    /// A simplified episode.
    /// </summary>
    public class SimpleEpisode
    {
        /// <summary>
        /// A URL to a 30 second preview (MP3 format) of the episode. null if not available.
        /// </summary>
        [JsonPropertyName("audio_preview_url")]
        public string AudioPreviewUrl { get; set; }

        /// <summary>
        /// A description of the episode.
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// The episode length in milliseconds.
        /// </summary>
        [JsonPropertyName("duration_ms")]
        public int DurationMs { get; set; }

        /// <summary>
        /// Whether or not the episode has explicit content (true = yes it does; false = no it does not OR unknown).
        /// </summary>
        [JsonPropertyName("explicit")]
        public bool Explicit { get; set; }

        /// <summary>
        /// External URLs for this episode.
        /// </summary>
        [JsonPropertyName("external_urls")]
        public ExternalUrl ExternalUrls { get; set; }

        /// <summary>
        /// A link to the Web API endpoint providing full details of the episode.
        /// </summary>
        [JsonPropertyName("href")]
        public string Href { get; set; }

        /// <summary>
        /// The Spotify ID for the episode.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// The cover art for the episode in various sizes, widest first.
        /// </summary>
        [JsonPropertyName("images")]
        public List<Image> Images { get; set; }

        /// <summary>
        /// True if the episode is hosted outside of Spotify’s CDN.
        /// </summary>
        [JsonPropertyName("is_externally_hosted")]
        public bool IsExternallyHosted { get; set; }

        /// <summary>
        /// True if the episode is playable in the given market. Otherwise false.
        /// </summary>
        [JsonPropertyName("is_playable")]
        public bool IsPlayable { get; set; }

        /// <summary>
        /// Note: This field is deprecated and might be removed in the future. Please use the languages field instead. The language used in the episode, identified by a ISO 639 code.
        /// </summary>
        [JsonPropertyName("language")]
        public string Language { get; set; }

        /// <summary>
        /// A list of the languages used in the episode, identified by their ISO 639 code.
        /// </summary>
        [JsonPropertyName("languages")]
        public List<string> Languages { get; set; }

        /// <summary>
        /// The name of the episode.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// The date the episode was first released, for example "1981-12-15". Depending on the precision, it might be shown as "1981" or "1981-12".
        /// </summary>
        [JsonPropertyName("release_date")]
        public string ReleaseDate { get; set; }

        /// <summary>
        /// The precision with which release_date value is known: "year", "month", or "day".
        /// </summary>
        [JsonPropertyName("release_date_precision")]
        public string ReleaseDatePrecision { get; set; }

        /// <summary>
        /// The user’s most recent position in the episode. Set if the supplied access token is a user token and has the scope ‘user-read-playback-position’.
        /// </summary>
        [JsonPropertyName("resume_point")]
        public ResumePoint ResumePoint { get; set; }

        /// <summary>
        /// The object type: “episode”.
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        /// The Spotify URI for the episode.
        /// </summary>
        [JsonPropertyName("uri")]
        public string Uri { get; set; }
    }
}
