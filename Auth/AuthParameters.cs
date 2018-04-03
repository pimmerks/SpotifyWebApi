namespace SpotifyWebApi.Auth
{
    using Model.Enum;

    /// <summary>
    /// The <see cref="AuthParameters"/>.
    /// </summary>
    public class AuthParameters
    {
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
        /// Gets or sets a value indicating wheter to show the login screen every time the user is requested to login.
        /// </summary>
        public bool ShowDialog { get; set; }

        /// <summary>
        /// Gets or sets the authentication scopes.
        /// </summary>
        public Scope Scopes { get; set; }
    }
}
