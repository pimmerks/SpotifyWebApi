namespace SpotifyWebApi.Auth.AuthorizationCode
{
    using Newtonsoft.Json;

    /// <summary>
    /// TODO
    /// </summary>
    internal class AccessTokenRequest
    {
        /// <summary>
        /// TODO
        /// </summary>
        [JsonProperty("grant_type")]
        public string GrantType { get; set; }

        /// <summary>
        /// TODO
        /// </summary>
        [JsonProperty("code")]
        public string Code { get; set; }

        /// <summary>
        /// TODO
        /// </summary>
        [JsonProperty("redirect_uri")]
        public string RedirectUri { get; set; }
    }
}