using Newtonsoft.Json;

namespace SpotifyWebApi.Model
{
    public class Error
    {
        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }
}
