namespace Spotify.WebApi.Model.Authentication
{
    using System;

    /// <summary>
    /// The <see cref="Token" /> class.
    /// </summary>
    public class Token
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Token"/> class.
        /// </summary>
        private Token()
        {
        }

        /// <summary>
        /// Gets or sets the access token.
        /// </summary>
        public string AccessToken { get; set; }

        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets the scope.
        /// </summary>
        public string? Scopes { get; set; }

        /// <summary>
        /// Gets or sets the expires in.
        /// </summary>
        public int ExpiresIn { get; set; }

        /// <summary>
        /// Gets or sets the refresh token.
        /// </summary>
        public string? RefreshToken { get; set; }

        /// <summary>
        /// Gets the token generated.
        /// </summary>
        public DateTime TokenGenerated { get; set; } = DateTime.UtcNow;

        /// <summary>
        /// Gets a value indicating whether this instance is expired.
        /// </summary>
        public bool IsExpired => DateTime.UtcNow > this.TokenGenerated.AddSeconds(this.ExpiresIn);

        /// <summary>
        /// Gets a value indicating wheter this token can be used to access personal data.
        /// </summary>
        public bool CanAccessPersonalData { get; internal set; } = true;

        /// <summary>
        /// Gets a value indicating the authentication type of this token.
        /// </summary>
        public TokenAuthenticationType AuthenticationType { get; internal set; }

        /// <summary>
        /// Creates a token.
        /// </summary>
        /// <param name="accessToken">The access token.</param>
        /// <param name="refreshToken">The refresh token.</param>
        /// <param name="tokenType">The token type.</param>
        /// <param name="expiresIn">The expires in value.</param>
        /// <param name="tokenGenerated">The datetime the token was generated.</param>
        /// <param name="scopes">The scopes of the token.</param>
        /// <param name="canAccessPersonalData">If the token can access personal data.</param>
        /// <param name="authenticationType">The authentication type of the token.</param>
        /// <returns>The newly made <see cref="Token"/>.</returns>
        public static Token Make(
            string accessToken,
            string? refreshToken = null,
            string tokenType = "Bearer",
            int expiresIn = 3600,
            DateTime? tokenGenerated = null,
            string scopes = null,
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
                Scopes = scopes,
                CanAccessPersonalData = canAccessPersonalData,
                AuthenticationType = authenticationType
            };
        }

        /// <inheritdoc />
        public override string ToString()
        {
            return $"AccessToken: {this.AccessToken}, RefreshToken: {this.RefreshToken}";
        }
    }
}
