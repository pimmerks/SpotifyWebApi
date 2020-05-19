namespace Spotify.WebApi.Model.Objects.Playback
{
    using System.Text.Json.Serialization;
    using Albums;

    public class Context
    {
        /// <summary>
        /// External URLs for this context.
        /// </summary>
        [JsonPropertyName("external_urls")]
        public ExternalUrl ExternalUrls { get; private set; }

        /// <summary>
        /// A link to the Web API endpoint providing full details of the track.
        /// </summary>
        [JsonPropertyName("href")]
        public string Href { get; private set; }

        /// <summary>
        /// The object type, e.g. “artist”, “playlist”, “album”.
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; private set; }

        /// <summary>
        /// The Spotify URI for the context.
        /// </summary>
        [JsonPropertyName("uri")]
        public string Uri { get; private set; }
    }
}
