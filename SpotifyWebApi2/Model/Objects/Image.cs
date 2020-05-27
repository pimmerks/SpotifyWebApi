namespace Spotify.WebApi.Model.Objects
{
    using System.Text.Json.Serialization;

    public class Image
    {
        [JsonPropertyName("height")]
        public int Height { get; set; }

        [JsonPropertyName("width")]
        public int Width { get; set; }

        [JsonPropertyName("url")]
        public string Url { get; set; }
    }
}
