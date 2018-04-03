namespace SpotifyWebApi.Auth
{
    using System;
    using System.Collections.Specialized;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using Business;
    using Model.Auth;
    using Model.Enum;
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
        /// For more info see 'https://developer.spotify.com/web-api/authorization-guide/#authorization_code_flow'</param>
        /// <returns>The url that the user can use to authenticate this application.</returns>
        public static string GetUrl(AuthParameters parameters, string state)
        {
            var scopes = string.Join(
                " ",
                parameters.Scopes.ToString()
                    .Split(new[] { ", " }, StringSplitOptions.None)
                    .Select(i => (int)Enum.Parse(parameters.Scopes.GetType(), i))
                    .Cast<Scope>()
                    .Select(x => x.AsString())
                    .ToList());

            return $"https://accounts.spotify.com/authorize/?" +
                   $"client_id={parameters.ClientId}" +
                   $"&response_type=code" +
                   $"&redirect_uri={parameters.RedirectUri}" +
                   $"&scope={scopes}" +
                   $"&state={state}" +
                   $"&show_dialog={(parameters.ShowDialog ? "true" : "false")}";
        }

        /// <summary>
        /// Processes the callback and returns the <see cref="Token"/>.
        /// </summary>
        /// <param name="parameters">The parameters used in <see cref="GetUrl"/>.</param>
        /// <param name="code">The retrieved code.</param>
        /// <param name="error">The retrieved error.</param>
        /// <returns>The new token.</returns>
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

            var response = (HttpWebResponse)req.GetResponse();

            // Get the stream containing content returned by the server.
            var dataStream = response.GetResponseStream();

            // Open the stream using a StreamReader for easy access.
            var reader = new StreamReader(dataStream ?? throw new InvalidOperationException());

            // Read the content.
            var json = reader.ReadToEnd();

            return JsonConvert.DeserializeObject<Token>(json);
        }
    }
}
