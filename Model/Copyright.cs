using Newtonsoft.Json;

namespace SpotifyWebApi.Model
{
    public class Copyright
    {
        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

    }
}
