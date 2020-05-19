namespace Spotify.WebApi.Model.Objects.Artists
{
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using Albums;
    using Users;

    public class Artist
    {
        /// <summary>
        /// Known external URLs for this artist.
        /// </summary>
        [JsonPropertyName("external_urls")]
        public ExternalUrl ExternalUrls { get; set; }

        /// <summary>
        /// Information about the followers of the artist.
        /// </summary>
        [JsonPropertyName("followers")]
        public Followers Followers { get; set; }

        /// <summary>
        /// A list of the genres the artist is associated with. For example: "Prog Rock" , "Post-Grunge". (If not yet classified, the array is empty.)
        /// </summary>
        [JsonPropertyName("genres")]
        public List<string> Genres { get; set; }

        /// <summary>
        /// A link to the Web API endpoint providing full details of the artist.
        /// </summary>
        [JsonPropertyName("href")]
        public string Href { get; set; }

        /// <summary>
        /// The Spotify ID for the artist.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// Images of the artist in various sizes, widest first.
        /// </summary>
        [JsonPropertyName("images")]
        public List<Image> Images { get; set; }

        /// <summary>
        /// The name of the artist.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// The popularity of the artist. The value will be between 0 and 100, with 100 being the most popular. The artist’s popularity is calculated from the popularity of all the artist’s tracks.
        /// </summary>
        [JsonPropertyName("popularity")]
        public int Popularity { get; set; }

        /// <summary>
        /// The object type: "artist"
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        /// The Spotify URI for the artist.
        /// </summary>
        [JsonPropertyName("uri")]
        public string Uri { get; set; }
    }
}
