namespace SpotifyWebApi.NewModels
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    /// <summary>
    /// </summary>
    public class EpisodeBase : PlayableBase
    {
        /// <summary>
        ///     A URL to a 30 second preview (MP3 format) of the episode. `null` if not available.
        /// </summary>
        /// <value>A URL to a 30 second preview (MP3 format) of the episode. `null` if not available. </value>
        [JsonProperty(PropertyName = "audio_preview_url")]
        public string AudioPreviewUrl { get; set; }

        /// <summary>
        ///     A description of the episode. HTML tags are stripped away from this field, use `html_description` field in case
        ///     HTML tags are needed.
        /// </summary>
        /// <value>
        ///     A description of the episode. HTML tags are stripped away from this field, use `html_description` field in case
        ///     HTML tags are needed.
        /// </value>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        ///     A description of the episode. This field may contain HTML tags.
        /// </summary>
        /// <value>A description of the episode. This field may contain HTML tags. </value>
        [JsonProperty(PropertyName = "html_description")]
        public string HtmlDescription { get; set; }

        /// <summary>
        ///     The episode length in milliseconds.
        /// </summary>
        /// <value>The episode length in milliseconds. </value>
        [JsonProperty(PropertyName = "duration_ms")]
        public int? DurationMs { get; set; }

        /// <summary>
        ///     Whether or not the episode has explicit content (true = yes it does; false = no it does not OR unknown).
        /// </summary>
        /// <value>Whether or not the episode has explicit content (true = yes it does; false = no it does not OR unknown). </value>
        [JsonProperty(PropertyName = "explicit")]
        public bool? _Explicit { get; set; }

        /// <summary>
        ///     External URLs for this episode.
        /// </summary>
        /// <value>External URLs for this episode. </value>
        [JsonProperty(PropertyName = "external_urls")]
        public ExternalUrl ExternalUrls { get; set; }

        /// <summary>
        ///     A link to the Web API endpoint providing full details of the episode.
        /// </summary>
        /// <value>A link to the Web API endpoint providing full details of the episode. </value>
        [JsonProperty(PropertyName = "href")]
        public string Href { get; set; }

        /// <summary>
        ///     The [Spotify ID](/documentation/web-api/#spotify-uris-and-ids) for the episode.
        /// </summary>
        /// <value>The [Spotify ID](/documentation/web-api/#spotify-uris-and-ids) for the episode. </value>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        ///     The cover art for the episode in various sizes, widest first.
        /// </summary>
        /// <value>The cover art for the episode in various sizes, widest first. </value>
        [JsonProperty(PropertyName = "images")]
        public List<Image> Images { get; set; }

        /// <summary>
        ///     True if the episode is hosted outside of Spotify's CDN.
        /// </summary>
        /// <value>True if the episode is hosted outside of Spotify's CDN. </value>
        [JsonProperty(PropertyName = "is_externally_hosted")]
        public bool? IsExternallyHosted { get; set; }

        /// <summary>
        ///     True if the episode is playable in the given market. Otherwise false.
        /// </summary>
        /// <value>True if the episode is playable in the given market. Otherwise false. </value>
        [JsonProperty(PropertyName = "is_playable")]
        public bool? IsPlayable { get; set; }

        /// <summary>
        ///     The language used in the episode, identified by a [ISO 639](https://en.wikipedia.org/wiki/ISO_639) code. This field
        ///     is deprecated and might be removed in the future. Please use the `languages` field instead.
        /// </summary>
        /// <value>
        ///     The language used in the episode, identified by a [ISO 639](https://en.wikipedia.org/wiki/ISO_639) code. This
        ///     field is deprecated and might be removed in the future. Please use the `languages` field instead.
        /// </value>
        [JsonProperty(PropertyName = "language")]
        public string Language { get; set; }

        /// <summary>
        ///     A list of the languages used in the episode, identified by their [ISO 639-1](https://en.wikipedia.org/wiki/ISO_639)
        ///     code.
        /// </summary>
        /// <value>
        ///     A list of the languages used in the episode, identified by their [ISO
        ///     639-1](https://en.wikipedia.org/wiki/ISO_639) code.
        /// </value>
        [JsonProperty(PropertyName = "languages")]
        public List<string> Languages { get; set; }

        /// <summary>
        ///     The name of the episode.
        /// </summary>
        /// <value>The name of the episode. </value>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        ///     The date the episode was first released, for example `\"1981-12-15\"`. Depending on the precision, it might be
        ///     shown as `\"1981\"` or `\"1981-12\"`.
        /// </summary>
        /// <value>
        ///     The date the episode was first released, for example `\"1981-12-15\"`. Depending on the precision, it might be
        ///     shown as `\"1981\"` or `\"1981-12\"`.
        /// </value>
        [JsonProperty(PropertyName = "release_date")]
        public string ReleaseDate { get; set; }

        /// <summary>
        ///     The precision with which `release_date` value is known.
        /// </summary>
        /// <value>The precision with which `release_date` value is known. </value>
        [JsonProperty(PropertyName = "release_date_precision")]
        public string ReleaseDatePrecision { get; set; }

        /// <summary>
        ///     The user's most recent position in the episode. Set if the supplied access token is a user token and has the scope
        ///     'user-read-playback-position'.
        /// </summary>
        /// <value>
        ///     The user's most recent position in the episode. Set if the supplied access token is a user token and has the
        ///     scope 'user-read-playback-position'.
        /// </value>
        [JsonProperty(PropertyName = "resume_point")]
        public ResumePoint ResumePoint { get; set; }

        /// <summary>
        ///     The object type.
        /// </summary>
        /// <value>The object type. </value>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        ///     The [Spotify URI](/documentation/web-api/#spotify-uris-and-ids) for the episode.
        /// </summary>
        /// <value>The [Spotify URI](/documentation/web-api/#spotify-uris-and-ids) for the episode. </value>
        [JsonProperty(PropertyName = "uri")]
        public string Uri { get; set; }

        /// <summary>
        ///     Included in the response when a content restriction is applied. See [Restriction
        ///     Object](/documentation/web-api/reference/#object-episoderestrictionobject) for more details.
        /// </summary>
        /// <value>
        ///     Included in the response when a content restriction is applied. See [Restriction
        ///     Object](/documentation/web-api/reference/#object-episoderestrictionobject) for more details.
        /// </value>
        [JsonProperty(PropertyName = "restrictions")]
        public EpisodeRestriction Restrictions { get; set; }
    }
}
