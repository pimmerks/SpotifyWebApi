namespace Spotify.WebApi.Model.Objects.Albums
{
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class SimpleArtist
    {
        /// <summary>
        /// Known external URLs for this artist.
        /// </summary>
        [JsonPropertyName("external_urls")]
        public Dictionary<string, string> ExternalUrls { get; private set; }

        /// <summary>
        /// A link to the Web API endpoint providing full details of the artist.
        /// </summary>
        [JsonPropertyName("href")]
        public string Href { get; private set; }

        /// <summary>
        /// The Spotify ID for the artist.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; private set; }

        /// <summary>
        /// The name of the artist.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; private set; }

        /// <summary>
        /// The object type: "artist"
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; private set; }

        /// <summary>
        /// The Spotify URI for the artist.
        /// </summary>
        [JsonPropertyName("uri")]
        public string Uri { get; private set; }
    }
}
