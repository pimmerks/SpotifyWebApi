namespace SpotifyWebApi.Models.Auth
{
    using System;
    using System.Text.Json.Serialization;

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
        }

        /// <summary>
        /// Gets or sets the access token.
        /// </summary>
        [JsonPropertyName("access_token")]
        public string AccessToken { get; set; }

        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        [JsonPropertyName("token_type")]
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets the scope.
        /// </summary>
        [JsonPropertyName("scope")]
        public string Scope { get; set; }

        /// <summary>
        /// Gets or sets the expires in.
        /// </summary>
        [JsonPropertyName("expires_in")]
        public int ExpiresIn { get; set; }

        /// <summary>
        /// Gets or sets the refresh token.
        /// </summary>
        [JsonPropertyName("refresh_token")]
        public string RefreshToken { get; set; }

        /// <summary>
        /// Gets the token generated.
        /// </summary>
        [JsonPropertyName("token_generated")]
        public DateTime TokenGenerated { get; set; } = DateTime.UtcNow;

        /// <summary>
        /// Gets a value indicating whether this instance is expired.
        /// </summary>
        [JsonIgnore]
        public bool IsExpired => DateTime.UtcNow > this.TokenGenerated.AddSeconds(this.ExpiresIn);

        /// <summary>
        /// Gets a value indicating wheter this token can be used to access personal data.
        /// </summary>
        [JsonPropertyName("can_access_personal_data")]
        public bool CanAccessPersonalData { get; internal set; } = true;

        /// <summary>
        /// Gets a value indicating the authentication type of this token.
        /// </summary>
        [JsonPropertyName("token_authentication_type")]
        public TokenAuthenticationType AuthenticationType { get; internal set; }

        /// <summary>
        /// Creates a token.
        /// </summary>
        /// <param name="accessToken">The access token.</param>
        /// <param name="refreshToken">The refresh token.</param>
        /// <param name="tokenType">The token type.</param>
        /// <param name="expiresIn">The expires in value.</param>
        /// <param name="tokenGenerated">The datetime the token was generated.</param>
        /// <param name="scope">The scope of the token.</param>
        /// <param name="canAccessPersonalData">If the token can access personal data.</param>
        /// <param name="authenticationType">The authentication type of the token.</param>
        /// <returns>The newly made <see cref="Token"/>.</returns>
        public static Token Make(
            string accessToken,
            string refreshToken,
            string tokenType = "Bearer",
            int expiresIn = 3600,
            DateTime? tokenGenerated = null,
            string scope = null,
            bool canAccessPersonalData = true,
            TokenAuthenticationType authenticationType = TokenAuthenticationType.AuthorizationCode)
        {
            return new Token
            {
                AccessToken = accessToken,
                RefreshToken = refreshToken,
                Type = tokenType,
                ExpiresIn = expiresIn,
                TokenGenerated = tokenGenerated ?? DateTime.UtcNow,
                Scope = scope ?? string.Empty,
                CanAccessPersonalData = canAccessPersonalData,
                AuthenticationType = authenticationType
            };
        }

        /// <summary>
        /// Creates a header string from this instance.
        /// </summary>
        /// <returns>The web header string.</returns>
        public string ToHeaderString()
        {
            return this.Type + " " + this.AccessToken;
        }

        /// <inheritdoc />
        public override string ToString()
        {
            return $"AccessToken: {this.AccessToken}, RefreshToken: {this.RefreshToken}";
        }
    }
}
