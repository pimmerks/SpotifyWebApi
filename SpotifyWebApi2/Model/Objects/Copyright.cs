namespace Spotify.WebApi.Model.Objects
{
    using System.Text.Json.Serialization;

    public class Copyright
    {
        /// <summary>
        /// Gets or sets the text.
        /// </summary>
        [JsonPropertyName("text")]
        public string Text { get; set; }

        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
