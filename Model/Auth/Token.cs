using Newtonsoft.Json;
using System;

namespace SpotifyWebApi.Model.Auth
{
    public class Token
    {
        [JsonProperty("access_token")]
        public string AccessToken { get; set; }

        [JsonProperty("token_type")]
        public string Type { get; set; }

        [JsonProperty("scope")]
        public string Scope { get; set; }

        [JsonProperty("expires_in")]
        public int ExpiresIn { get; set; }

        [JsonProperty("refresh_token")]
        public string RefreshToken { get; set; }

        public DateTime TokenGenerated { get; }

        public bool IsExpired => DateTime.Now > this.TokenGenerated.AddSeconds(this.ExpiresIn);

        public Token()
        {
            this.TokenGenerated = DateTime.Now;
        }
    }
}
