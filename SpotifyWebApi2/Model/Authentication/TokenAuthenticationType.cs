namespace Spotify.WebApi.Model.Authentication
{
    /// <summary>
    /// Enum defining token types.
    /// </summary>
    public enum TokenAuthenticationType
    {
        /// <summary>
        /// Token generated using Authorization Code.
        /// </summary>
        AuthorizationCode = 0,

        /// <summary>
        /// Token generated using Client Credentials.
        /// </summary>
        ClientCredentials = 1,

        /// <summary>
        /// Token generated using Implicit Grant.
        /// </summary>
        ImplicitGrant = 2,
    }
}