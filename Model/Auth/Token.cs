namespace SpotifyWebApi.Model.Auth
{
    using System;
    using Newtonsoft.Json;

    /// <summary>
    /// The <see cref="Token" /> class.
    /// </summary>
    public class Token
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Token"/> class.
        /// </summary>
        public Token()
        {
            this.TokenGenerated = DateTime.Now;
        }

        /// <summary>
        /// Gets or sets the access token.
        /// </summary>
        [JsonProperty("access_token")]
        public string AccessToken { get; set; }

        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        [JsonProperty("token_type")]
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets the scope.
        /// </summary>
        [JsonProperty("scope")]
        public string Scope { get; set; }

        /// <summary>
        /// Gets or sets the expires in.
        /// </summary>
        [JsonProperty("expires_in")]
        public int ExpiresIn { get; set; }

        /// <summary>
        /// Gets or sets the refresh token.
        /// </summary>
        [JsonProperty("refresh_token")]
        public string RefreshToken { get; set; }

        /// <summary>
        /// Gets the token generated.
        /// </summary>
        public DateTime TokenGenerated { get; }

        /// <summary>
        /// Gets a value indicating whether this instance is expired.
        /// </summary>
        public bool IsExpired => DateTime.Now > this.TokenGenerated.AddSeconds(this.ExpiresIn);

        /// <summary>
        /// Creates a header string from this instance.
        /// </summary>
        /// <returns>The web header string.</returns>
        public string ToHeaderString()
        {
            return this.Type + " " + this.AccessToken;
        }
    }
}
