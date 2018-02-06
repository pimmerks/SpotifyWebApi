using Newtonsoft.Json;

namespace SpotifyWebApi.Model
{
    public class Cursor
    {
        [JsonProperty("after")]
        public string After { get; set; }
    }
}
