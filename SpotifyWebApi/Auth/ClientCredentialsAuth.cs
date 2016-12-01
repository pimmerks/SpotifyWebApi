using Newtonsoft.Json;
using SpotifyWebApi.Model.Auth;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyWebApi.Auth
{
    public static class ClientCredentialsAuth
    {
        public static Token RequestToken(string clientId, string clientSecret)
        {
            Token token = null;
            using (var client = new WebClient())
            {
                var headers = new NameValueCollection();
                headers["Authorization"] = "Basic " + Base64Encode(clientId + ":" + clientSecret);
                headers["Content-Type"] = "application/x-www-form-urlencoded";


                client.Headers = new WebHeaderCollection();
                client.Headers.Add(headers);

                var response = client.UploadString("https://accounts.spotify.com/api/token", "grant_type=client_credentials");
                token = GetTokenFromText(response);
                token.TokenGenerated = DateTime.Now;
            }
            return token;
        }

        private static Token GetTokenFromText(string text)
        {
            Token token = null;
            token = JsonConvert.DeserializeObject<Token>(text);
            return token;
        }

        private static string Base64Encode(string plainText)
        {
            var plainTextBytes = Encoding.UTF8.GetBytes(plainText);
            return Convert.ToBase64String(plainTextBytes);
        }

        private static string Base64Decode(string base64EncodedData)
        {
            var base64EncodedBytes = Convert.FromBase64String(base64EncodedData);
            return Encoding.UTF8.GetString(base64EncodedBytes);
        }
    }
}
