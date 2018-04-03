using System.Runtime.CompilerServices;
[assembly: InternalsVisibleTo("SpotifyWebApi.Auth")]

namespace SpotifyWebApi.Model.Auth
{
    using System;
    using Newtonsoft.Json;
    using Uri;

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
        public DateTime TokenGenerated { get; private set; }

        /// <summary>
        /// Gets a value indicating whether this instance is expired.
        /// </summary>
        public bool IsExpired => DateTime.Now > this.TokenGenerated.AddSeconds(this.ExpiresIn);

        /// <summary>
        /// Gets a value indicating wheter this token can be used to access personal data.
        /// </summary>
        public bool CanAccessPersonalData { get; internal set; } = true;

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
        /// <returns>The newly made <see cref="Token"/>.</returns>
        public static Token Make(
            string accessToken,
            string refreshToken,
            string tokenType = "Bearer",
            int expiresIn = 3600,
            DateTime? tokenGenerated = null,
            string scope = null,
            bool canAccessPersonalData = true)
        {
            return new Token
            {
                AccessToken = accessToken,
                RefreshToken = refreshToken,
                Type = tokenType,
                ExpiresIn = expiresIn,
                TokenGenerated = tokenGenerated ?? DateTime.Now,
                Scope = scope ?? string.Empty,
                CanAccessPersonalData = canAccessPersonalData
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
    }
}
