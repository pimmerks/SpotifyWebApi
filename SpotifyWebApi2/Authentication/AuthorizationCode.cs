namespace Spotify.WebApi.Authentication
{
    using System;
    using System.Collections.Generic;
    using System.Collections.Specialized;
    using System.IO;
    using System.Net;
    using System.Net.Http;
    using System.Text;
    using System.Threading.Tasks;
    using Spotify.WebApi.Business;
    using Spotify.WebApi.Model.Authentication;

    /// <summary>
    /// The <see cref="AuthorizationCode"/>.
    /// </summary>
    public static class AuthorizationCode
    {
        /// <summary>
        /// Retrieves the authentication url for authenticating with the spotify web api.
        /// </summary>
        /// <param name="parameters">The <see cref="AuthParameters"/> to use while creating the url.</param>
        /// <param name="state">The state to use while creating the url.
        /// For more info see 'https://developer.spotify.com/web-api/authorization-guide/#authorization_code_flow'</param>
        /// <returns>The url that the user can use to authenticate this application.</returns>
        public static string GetUrl(AuthParameters parameters, string state)
        {
            return $"https://accounts.spotify.com/authorize/?" +
                   $"client_id={parameters.ClientId}" +
                   $"&response_type=code" +
                   $"&redirect_uri={parameters.RedirectUri}" +
                   $"&scope={parameters.Scopes}" +
                   $"&state={state}" +
                   $"&show_dialog={(parameters.ShowDialog ? "true" : "false")}";
        }

        /// <summary>
        /// Processes the callback and returns the <see cref="Token"/> async.
        /// </summary>
        /// <param name="parameters">The parameters used in <see cref="GetUrl"/>.</param>
        /// <param name="code">The retrieved code.</param>
        /// <param name="error">The retrieved error.</param>
        /// <returns>The new token.</returns>
        public static async Task<Token> ProcessCallbackAsync(AuthParameters parameters, string code, string error = "")
        {
            if (!string.IsNullOrWhiteSpace(error))
            {
                throw new Exception(error);
            }

            using var httpClient = new HttpClient();

            using var response = await httpClient.PostAsync(
                "https://accounts.spotify.com/api/token",
                new FormUrlEncodedContent(new[]
                {
                    new KeyValuePair<string, string>("grant_type", "authorization_code"),
                    new KeyValuePair<string, string>("code", code),
                    new KeyValuePair<string, string>("redirect_uri", parameters.RedirectUri),
                    new KeyValuePair<string, string>("client_id", parameters.ClientId),
                    new KeyValuePair<string, string>("client_secret", parameters.ClientSecret),
                }));

            var responseContent = await response.Content.ReadAsStringAsync();
            if (!response.IsSuccessStatusCode)
            {
                throw new Exception(responseContent);
            }

            return new Serializer().Deserialize<Token>(responseContent);
        }

        // /// <summary>
        // /// Requests a refresh token from the spotify web api.
        // /// </summary>
        // /// <param name="parameters">The authentication parameters.</param>
        // /// <param name="oldToken">The old token.</param>
        // /// <returns>A new refreshed token.</returns>
        // public static async Task<Token> RefreshTokenAsync(AuthParameters parameters, Token oldToken)
        // {
        //     if (string.IsNullOrEmpty(oldToken.RefreshToken))
        //     {
        //         throw new ValidationException("Refresh token was null or empty!");
        //     }
        //
        //     using var httpClient = new HttpClient();
        //
        //     var requestContent = new FormUrlEncodedContent(new[]
        //     {
        //         new KeyValuePair<string, string>("grant_type", "refresh_token"),
        //         new KeyValuePair<string, string>("refresh_token", oldToken.RefreshToken),
        //     });
        //
        //     httpClient.DefaultRequestHeaders.TryAddWithoutValidation(
        //         "Authorization",
        //         "Basic " + ApiHelper.Base64Encode($"{parameters.ClientId}:{parameters.ClientSecret}"));
        //
        //     using var response = await httpClient.PostAsync("https://accounts.spotify.com/api/token", requestContent);
        //
        //     var responseContent = await response.Content.ReadAsStringAsync();
        //     if (!response.IsSuccessStatusCode)
        //     {
        //         throw new Exception(responseContent);
        //     }
        //
        //     return Serializer.Deserialize<Token>(responseContent);
        // }
    }
}
