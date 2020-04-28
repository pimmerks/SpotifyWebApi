namespace SpotifyWebApi.Auth
{
    using System;
    using System.Collections.Generic;
    using System.Collections.Specialized;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Net.Http;
    using System.Net.Http.Headers;
    using System.Text;
    using System.Threading.Tasks;
    using Business;
    using Model.Auth;
    using Model.Enum;
    using Model.Exception;
    using Newtonsoft.Json;

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
        /// For more info see https://developer.spotify.com/web-api/authorization-guide/#authorization_code_flow</param>
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

            var result = JsonConvert.DeserializeObject<Token>(responseContent);
            result.AuthenticationType = TokenAuthenticationType.AuthorizationCode;
            return result;
        }

        /// <summary>
        /// Requests a refresh token from the spotify web api.
        /// </summary>
        /// <param name="parameters">The authentication parameters.</param>
        /// <param name="oldToken">The old token.</param>
        /// <returns>A new refreshed token.</returns>
        public static async Task<Token> RefreshTokenAsync(AuthParameters parameters, Token oldToken)
        {
            if (string.IsNullOrEmpty(oldToken.RefreshToken))
            {
                throw new ValidationException("Refresh token was null or empty!");
            }

            using var httpClient = new HttpClient();

            var requestContent = new FormUrlEncodedContent(new[]
            {
                new KeyValuePair<string, string>("grant_type", "refresh_token"),
                new KeyValuePair<string, string>("refresh_token", oldToken.RefreshToken),
            });

            httpClient.DefaultRequestHeaders.TryAddWithoutValidation(
                "Authorization",
                "Basic " + ApiHelper.Base64Encode($"{parameters.ClientId}:{parameters.ClientSecret}"));

            using var response = await httpClient.PostAsync("https://accounts.spotify.com/api/token", requestContent);

            var responseContent = await response.Content.ReadAsStringAsync();
            if (!response.IsSuccessStatusCode)
            {
                throw new Exception(responseContent);
            }

            var newToken = JsonConvert.DeserializeObject<Token>(responseContent);
            newToken.RefreshToken = oldToken.RefreshToken;
            newToken.AuthenticationType = TokenAuthenticationType.AuthorizationCode;
            return newToken;
        }

        /// <summary>
        /// Processes the callback and returns the <see cref="Token"/>.
        /// </summary>
        /// <param name="parameters">The parameters used in <see cref="GetUrl"/>.</param>
        /// <param name="code">The retrieved code.</param>
        /// <param name="error">The retrieved error.</param>
        /// <returns>The new token.</returns>
        [Obsolete("Please use the new async method. This method will get removed.")]
        public static Token ProcessCallback(AuthParameters parameters, string code, string error = "")
        {
            var req = ApiHelper.CreateRequest(new Uri("https://accounts.spotify.com/api/token"));

            var headers = new NameValueCollection
            {
                ["Authorization"] = "Basic " + ApiHelper.Base64Encode($"{parameters.ClientId}:{parameters.ClientSecret}"),
            };

            req.Headers = new WebHeaderCollection
            {
                headers
            };

            var postData = "grant_type=authorization_code" +
                           $"&code={code}" +
                           $"&redirect_uri={parameters.RedirectUri}";
            var data = Encoding.ASCII.GetBytes(postData);

            req.Method = "POST";
            req.ContentType = "application/x-www-form-urlencoded";
            req.ContentLength = data.Length;

            using (var stream = req.GetRequestStream())
            {
                stream.Write(data, 0, data.Length);
            }

            using var response = (HttpWebResponse)req.GetResponse();

            // Get the stream containing content returned by the server.
            var dataStream = response.GetResponseStream();

            // Open the stream using a StreamReader for easy access.
            var reader = new StreamReader(dataStream ?? throw new InvalidOperationException());

            // Read the content.
            var json = reader.ReadToEnd();

            var result = JsonConvert.DeserializeObject<Token>(json);
            result.AuthenticationType = TokenAuthenticationType.AuthorizationCode;
            return result;
        }

        /// <summary>
        /// Requests a refresh token from the spotify web api.
        /// </summary>
        /// <param name="parameters">The authentication parameters.</param>
        /// <param name="oldToken">The old token.</param>
        /// <returns>A new refreshed token.</returns>
        [Obsolete("Please use the new async method. This method will get removed.")]
        public static Token RefreshToken(AuthParameters parameters, Token oldToken)
        {
            if (string.IsNullOrEmpty(oldToken.RefreshToken))
            {
                throw new ValidationException("Refresh token was null or empty!");
            }

            var req = ApiHelper.CreateRequest(new Uri("https://accounts.spotify.com/api/token"));

            var headers = new NameValueCollection
            {
                ["Authorization"] = "Basic " + ApiHelper.Base64Encode($"{parameters.ClientId}:{parameters.ClientSecret}"),
            };

            req.Headers = new WebHeaderCollection
            {
                headers
            };

            var postData = "grant_type=refresh_token" +
                           $"&refresh_token={oldToken.RefreshToken}";
            var data = Encoding.ASCII.GetBytes(postData);

            req.Method = "POST";
            req.ContentType = "application/x-www-form-urlencoded";
            req.ContentLength = data.Length;

            using (var stream = req.GetRequestStream())
            {
                stream.Write(data, 0, data.Length);
            }

            using var response = (HttpWebResponse)req.GetResponse();

            // Get the stream containing content returned by the server.
            var dataStream = response.GetResponseStream();

            // Open the stream using a StreamReader for easy access.
            var reader = new StreamReader(dataStream ?? throw new InvalidOperationException());

            // Read the content.
            var json = reader.ReadToEnd();

            var newToken = JsonConvert.DeserializeObject<Token>(json);
            newToken.RefreshToken = oldToken.RefreshToken;
            newToken.AuthenticationType = TokenAuthenticationType.AuthorizationCode;
            return newToken;
        }
    }
}
