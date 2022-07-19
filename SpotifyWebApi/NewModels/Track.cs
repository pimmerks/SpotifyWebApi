namespace SpotifyWebApi.NewModels
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    /// <summary>
    /// </summary>
    public class Track : PlayableBase
    {
        /// <summary>
        ///     The album on which the track appears. The album object includes a link in `href` to full information about the
        ///     album.
        /// </summary>
        /// <value>
        ///     The album on which the track appears. The album object includes a link in `href` to full information about the
        ///     album.
        /// </value>
        [JsonProperty(PropertyName = "album")]
        public SimplifiedAlbum Album { get; set; }

        /// <summary>
        ///     The artists who performed the track. Each artist object includes a link in `href` to more detailed information
        ///     about the artist.
        /// </summary>
        /// <value>
        ///     The artists who performed the track. Each artist object includes a link in `href` to more detailed information
        ///     about the artist.
        /// </value>
        [JsonProperty(PropertyName = "artists")]
        public List<Artist> Artists { get; set; }

        /// <summary>
        ///     A list of the countries in which the track can be played, identified by their [ISO 3166-1
        ///     alpha-2](http://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) code.
        /// </summary>
        /// <value>
        ///     A list of the countries in which the track can be played, identified by their [ISO 3166-1
        ///     alpha-2](http://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) code.
        /// </value>
        [JsonProperty(PropertyName = "available_markets")]
        public List<string> AvailableMarkets { get; set; }

        /// <summary>
        ///     The disc number (usually `1` unless the album consists of more than one disc).
        /// </summary>
        /// <value>The disc number (usually `1` unless the album consists of more than one disc). </value>
        [JsonProperty(PropertyName = "disc_number")]
        public int? DiscNumber { get; set; }

        /// <summary>
        ///     The track length in milliseconds.
        /// </summary>
        /// <value>The track length in milliseconds. </value>
        [JsonProperty(PropertyName = "duration_ms")]
        public int? DurationMs { get; set; }

        /// <summary>
        ///     Whether or not the track has explicit lyrics ( `true` = yes it does; `false` = no it does not OR unknown).
        /// </summary>
        /// <value>Whether or not the track has explicit lyrics ( `true` = yes it does; `false` = no it does not OR unknown). </value>
        [JsonProperty(PropertyName = "explicit")]
        public bool? _Explicit { get; set; }

        /// <summary>
        ///     Known external IDs for the track.
        /// </summary>
        /// <value>Known external IDs for the track. </value>
        [JsonProperty(PropertyName = "external_ids")]
        public ExternalId ExternalIds { get; set; }

        /// <summary>
        ///     Known external URLs for this track.
        /// </summary>
        /// <value>Known external URLs for this track. </value>
        [JsonProperty(PropertyName = "external_urls")]
        public ExternalUrl ExternalUrls { get; set; }

        /// <summary>
        ///     A link to the Web API endpoint providing full details of the track.
        /// </summary>
        /// <value>A link to the Web API endpoint providing full details of the track. </value>
        [JsonProperty(PropertyName = "href")]
        public string Href { get; set; }

        /// <summary>
        ///     The [Spotify ID](/documentation/web-api/#spotify-uris-and-ids) for the track.
        /// </summary>
        /// <value>The [Spotify ID](/documentation/web-api/#spotify-uris-and-ids) for the track. </value>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        ///     Part of the response when [Track Relinking](/documentation/general/guides/track-relinking-guide/) is applied. If
        ///     `true`, the track is playable in the given market. Otherwise `false`.
        /// </summary>
        /// <value>
        ///     Part of the response when [Track Relinking](/documentation/general/guides/track-relinking-guide/) is applied. If
        ///     `true`, the track is playable in the given market. Otherwise `false`.
        /// </value>
        [JsonProperty(PropertyName = "is_playable")]
        public bool? IsPlayable { get; set; }

        /// <summary>
        ///     Part of the response when [Track Relinking](/documentation/general/guides/track-relinking-guide/) is applied, and
        ///     the requested track has been replaced with different track. The track in the `linked_from` object contains
        ///     information about the originally requested track.
        /// </summary>
        /// <value>
        ///     Part of the response when [Track Relinking](/documentation/general/guides/track-relinking-guide/) is applied,
        ///     and the requested track has been replaced with different track. The track in the `linked_from` object contains
        ///     information about the originally requested track.
        /// </value>
        [JsonProperty(PropertyName = "linked_from")]
        public Track LinkedFrom { get; set; }

        /// <summary>
        ///     Included in the response when a content restriction is applied. See [Restriction
        ///     Object](/documentation/web-api/reference/#object-trackrestrictionobject) for more details.
        /// </summary>
        /// <value>
        ///     Included in the response when a content restriction is applied. See [Restriction
        ///     Object](/documentation/web-api/reference/#object-trackrestrictionobject) for more details.
        /// </value>
        [JsonProperty(PropertyName = "restrictions")]
        public TrackRestriction Restrictions { get; set; }

        /// <summary>
        ///     The name of the track.
        /// </summary>
        /// <value>The name of the track. </value>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        ///     The popularity of the track. The value will be between 0 and 100, with 100 being the most popular.
        ///     <br />
        ///     The popularity of a track is a value between 0 and 100, with 100 being the most popular. The popularity is
        ///     calculated by algorithm and is based, in the most part, on the total number of plays the track has had and how
        ///     recent those plays are.
        ///     <br />
        ///     Generally speaking, songs that are being played a lot now will have a higher popularity than songs that
        ///     were played a lot in the past. Duplicate tracks (e.g. the same track from a single and an album) are rated
        ///     independently. Artist and album popularity is derived mathematically from track popularity. _**Note**: the
        ///     popularity value may lag actual popularity by a few days: the value is not updated in real time._
        /// </summary>
        /// <value>
        ///     The popularity of the track. The value will be between 0 and 100, with 100 being the most popular.
        ///     <br />
        ///     The popularity of a track is a value between 0 and 100, with 100 being the most popular. The popularity is
        ///     calculated by algorithm and is based, in the most part, on the total number of plays the track has had and how
        ///     recent those plays are.
        ///     <br />
        ///     Generally speaking, songs that are being played a lot now will have a higher popularity than songs that
        ///     were played a lot in the past. Duplicate tracks (e.g. the same track from a single and an album) are rated
        ///     independently. Artist and album popularity is derived mathematically from track popularity. _**Note**: the
        ///     popularity value may lag actual popularity by a few days: the value is not updated in real time._
        /// </value>
        [JsonProperty(PropertyName = "popularity")]
        public int? Popularity { get; set; }

        /// <summary>
        ///     A link to a 30 second preview (MP3 format) of the track. Can be `null`
        /// </summary>
        /// <value>A link to a 30 second preview (MP3 format) of the track. Can be `null` </value>
        [JsonProperty(PropertyName = "preview_url")]
        public string PreviewUrl { get; set; }

        /// <summary>
        ///     The number of the track. If an album has several discs, the track number is the number on the specified disc.
        /// </summary>
        /// <value>The number of the track. If an album has several discs, the track number is the number on the specified disc. </value>
        [JsonProperty(PropertyName = "track_number")]
        public int? TrackNumber { get; set; }

        /// <summary>
        ///     The object type: \"track\".
        /// </summary>
        /// <value>The object type: \"track\". </value>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        ///     The [Spotify URI](/documentation/web-api/#spotify-uris-and-ids) for the track.
        /// </summary>
        /// <value>The [Spotify URI](/documentation/web-api/#spotify-uris-and-ids) for the track. </value>
        [JsonProperty(PropertyName = "uri")]
        public string Uri { get; set; }

        /// <summary>
        ///     Whether or not the track is from a local file.
        /// </summary>
        /// <value>Whether or not the track is from a local file. </value>
        [JsonProperty(PropertyName = "is_local")]
        public bool? IsLocal { get; set; }
    }
}
