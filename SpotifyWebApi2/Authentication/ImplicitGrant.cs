namespace Spotify.WebApi.Authentication
{
    using Spotify.WebApi.Model.Authentication;

    /// <summary>
    /// The <see cref="ImplicitGrant"/>.
    /// </summary>
    public static class ImplicitGrant
    {
        /// <summary>
        /// Retrieves the authentication url for authenticating with the spotify web api.
        /// </summary>
        /// <param name="parameters">The <see cref="AuthParameters"/> to use while creating the url.</param>
        /// <param name="state">The state to use while creating the url.
        /// For more info see 'https://developer.spotify.com/web-api/authorization-guide/#implicit_grant_flow'</param>
        /// <returns>The url that the user can use to authenticate this application.</returns>
        public static string GetUrl(AuthParameters parameters, string state)
        {
            return $"https://accounts.spotify.com/authorize/?" +
                   $"client_id={parameters.ClientId}" +
                   $"&response_type=token" +
                   $"&redirect_uri={parameters.RedirectUri}" +
                   $"&scope={parameters.Scopes}" +
                   $"&state={state}" +
                   $"&show_dialog={(parameters.ShowDialog ? "true" : "false")}";
        }

        /// <summary>
        /// Creates a token from the callback url.
        /// </summary>
        /// <param name="accessToken">The access token.</param>
        /// <param name="tokenType">The token type.</param>
        /// <param name="expiresIn">The expires in.</param>
        /// <returns>A valid <see cref="Token"/>.</returns>
        public static Token Callback(string accessToken, string tokenType, int expiresIn)
        {
            return Token.Make(
                accessToken,
                null,
                tokenType,
                expiresIn,
                authenticationType: TokenAuthenticationType.ImplicitGrant);
        }
    }
}
