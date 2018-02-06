using Newtonsoft.Json;

namespace SpotifyWebApi.Model
{
    public class Image
    {
        [JsonProperty("height")]
        public int? Height { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("width")]
        public int? Width { get; set; }
    }
}
