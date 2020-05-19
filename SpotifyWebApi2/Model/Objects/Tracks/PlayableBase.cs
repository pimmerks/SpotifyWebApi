namespace Spotify.WebApi.Model.Objects.Tracks
{
    using System.Text.Json.Serialization;
    using Albums;

    public abstract class PlayableBase
    {
        /// <summary>
        /// The name of the track or episode.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; private set; }
        
        /// <summary>
        /// The object type, "track", "episode", etc.
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; private set; }

        /// <summary>
        /// The Spotify URI for the track.
        /// </summary>
        [JsonPropertyName("uri")]
        public string Uri { get; private set; }
        
        /// <summary>
        /// A link to the Web API endpoint providing full details of the track/episode.
        /// </summary>
        [JsonPropertyName("href")]
        public string Href { get; private set; }

        /// <summary>
        /// The Spotify ID for the track/episode.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; private set; }

        /// <summary>
        /// Known external URLs for this track.
        /// </summary>
        [JsonPropertyName("external_urls")]
        public ExternalUrl ExternalUrls { get; private set; }
    }
}
