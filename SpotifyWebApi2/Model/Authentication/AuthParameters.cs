namespace Spotify.WebApi.Model.Authentication
{
    using WebApi.Authentication;

    /// <summary>
    /// Authentication parameters for authenticating with the Spotify web api.
    /// </summary>
    public class AuthParameters
    {
        public AuthParameters(string clientId, string clientSecret, string redirectUri, string scopes)
        {
            this.ClientId = clientId;
            this.ClientSecret = clientSecret;
            this.RedirectUri = redirectUri;
            this.Scopes = scopes;
        }

        /// <summary>
        /// Gets or sets the authentication client id.
        /// </summary>
        public string ClientId { get; set; }

        /// <summary>
        /// Gets or sets the authentication client secret.
        /// Note that this is only used for the <see cref="AuthorizationCode"/> flow.
        /// </summary>
        public string ClientSecret { get; set; }

        /// <summary>
        /// Gets or sets the authentication redirect uri.
        /// </summary>
        public string RedirectUri { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to show the login screen every time the user is requested to login.
        /// </summary>
        public bool ShowDialog { get; set; }

        /// <summary>
        /// Gets or sets the authentication scopes.
        /// </summary>
        public string Scopes { get; set; }
    }
}
