using Newtonsoft.Json;

namespace SpotifyWebApi.Model
{
    public class Followers
    {
        [JsonProperty("href")]
        public string Href { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }
    }
}
