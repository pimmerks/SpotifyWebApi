namespace SpotifyWebApi.Auth
{
    using System;
    using System.Collections.Generic;
    using System.Collections.Specialized;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Net.Http.Headers;
    using System.Text;
    using System.Threading.Tasks;
    using Business;
    using Model.Auth;
    using Newtonsoft.Json;

    /// <summary>
    /// The <see cref="ClientCredentials"/>.
    /// </summary>
    public static class ClientCredentials
    {
        /// <summary>
        /// Retrieves a valid token from the Spotify web api.
        /// </summary>
        /// <param name="parameters">The <see cref="AuthParameters"/> used for this token.</param>
        /// <returns>A valid <see cref="Token"/>.</returns>
        public static Token GetToken(AuthParameters parameters)
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

            var data = Encoding.ASCII.GetBytes("grant_type=client_credentials");

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

            var token = JsonConvert.DeserializeObject<Token>(json);
            token.CanAccessPersonalData = false;

            return token;
        }
    }
}
