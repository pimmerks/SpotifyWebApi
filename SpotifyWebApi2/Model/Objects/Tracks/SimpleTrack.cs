namespace Spotify.WebApi.Model.Objects.Tracks
{
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using Albums;

    public class SimpleTrack
    {
        /// <summary>
        /// The artists who performed the track. Each artist object includes a link in href to more detailed information about the artist.
        /// </summary>
        [JsonPropertyName("artists")]
        public List<SimpleArtist> Artists { get; private set; }

        /// <summary>
        /// A list of the countries in which the track can be played, identified by their ISO 3166-1 alpha-2 code.
        /// </summary>
        [JsonPropertyName("available_markets")]
        public List<string> AvailableMarkets { get; private set; }

        /// <summary>
        /// The disc number (usually 1 unless the album consists of more than one disc).
        /// </summary>
        [JsonPropertyName("disc_number")]
        public int DiscNumber { get; private set; }

        /// <summary>
        /// The track length in milliseconds.
        /// </summary>
        [JsonPropertyName("duration_ms")]
        public int DurationMs { get; private set; }

        /// <summary>
        /// Whether or not the track has explicit lyrics ( true = yes it does; false = no it does not OR unknown).
        /// </summary>
        [JsonPropertyName("explicit")]
        public bool Explicit { get; private set; }

        /// <summary>
        /// External URLs for this track.
        /// </summary>
        [JsonPropertyName("external_urls")]
        public ExternalUrl ExternalUrls { get; private set; }

        /// <summary>
        /// A link to the Web API endpoint providing full details of the track.
        /// </summary>
        [JsonPropertyName("href")]
        public string Href { get; private set; }

        /// <summary>
        /// The Spotify ID for the track.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; private set; }

        /// <summary>
        /// Part of the response when Track Relinking is applied. If true , the track is playable in the given market. Otherwise false.
        /// </summary>
        [JsonPropertyName("is_playable")]
        public bool IsPlayable { get; private set; }

        /// <summary>
        /// Part of the response when Track Relinking is applied and is only part of the response if the track linking, in fact, exists. The requested track has been replaced with a different track. The track in the linked_from object contains information about the originally requested track.
        /// </summary>
        [JsonPropertyName("linked_from")]
        public LinkedTrack LinkedFrom { get; private set; }

        /// <summary>
        /// The name of the track.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; private set; }

        /// <summary>
        /// A URL to a 30 second preview (MP3 format) of the track.
        /// </summary>
        [JsonPropertyName("preview_url")]
        public string PreviewUrl { get; private set; }

        /// <summary>
        /// The number of the track. If an album has several discs, the track number is the number on the specified disc.
        /// </summary>
        [JsonPropertyName("track_number")]
        public int TrackNumber { get; private set; }

        /// <summary>
        /// The object type: “track”.
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; private set; }

        /// <summary>
        /// The Spotify URI for the track.
        /// </summary>
        [JsonPropertyName("uri")]
        public string Uri { get; private set; }
    }
}
