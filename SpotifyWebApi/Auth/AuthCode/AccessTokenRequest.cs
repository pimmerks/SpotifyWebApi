namespace SpotifyWebApi.Auth.AuthCode
{
    using Newtonsoft.Json;

    /// <summary>
    /// The <see cref="AccessTokenRequest"/> class.
    /// </summary>
    internal class AccessTokenRequest
    {
        /// <summary>
        /// The grant type.
        /// </summary>
        [JsonProperty("grant_type")]
        public string GrantType { get; set; }

        /// <summary>
        /// The code.
        /// </summary>
        [JsonProperty("code")]
        public string Code { get; set; }

        /// <summary>
        /// The redirect uri.
        /// </summary>
        [JsonProperty("redirect_uri")]
        public string RedirectUri { get; set; }
    }
}