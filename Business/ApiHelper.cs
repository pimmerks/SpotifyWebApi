namespace SpotifyWebApi.Business
{
    using System;
    using System.Collections.Specialized;
    using System.IO;
    using System.Net;
    using Model;
    using Model.Auth;
    using Newtonsoft.Json;

    /// <summary>
    /// The <see cref="ApiHelper"/>.
    /// </summary>
    public class ApiHelper
    {
        public const string BaseUri = "https://api.spotify.com/v1";

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiHelper"/> class.
        /// </summary>
        public ApiHelper()
        {
        }

        public static HttpWebRequest CreateRequest(Uri uri, Token token)
        {
            var request = WebRequest.CreateHttp(uri);
            request.ContentType = "application/x-www-form-urlencoded";
            return request;
        }

        public static WebResponse<string> GetJsonFromUrl(Uri url, Token token)
        {
            var json = "";

            var request = CreateRequest(url, token);

            var headers = new NameValueCollection
            {
                ["Authorization"] = token.Type + " " + token.AccessToken
            };

            request.Headers = new WebHeaderCollection
            {
                headers
            };

            var response = (HttpWebResponse)request.GetResponse();

            // Get the stream containing content returned by the server.
            var dataStream = response.GetResponseStream();

            // Open the stream using a StreamReader for easy access.
            var reader = new StreamReader(dataStream ?? throw new NullReferenceException());

            // Read the content.
            json += reader.ReadToEnd();

            return new WebResponse<string>
            {
                Response = json,
                StatusCode = response.StatusCode
            };
        }

        public static WebResponse<T> JsonToObject<T>(WebResponse<string> json)
        {
            if (json == null)
            {
                throw new ArgumentNullException(nameof(json));
            }

            return new WebResponse<T>
            {
                StatusCode = json.StatusCode,
                Response = JsonConvert.DeserializeObject<T>(json.Response)
            };
        }

        public static T JsonToObject<T>(string json)
        {
            if (json == null)
            {
                throw new ArgumentNullException(nameof(json));
            }

            return JsonConvert.DeserializeObject<T>(json);
        }

        public static WebResponse<T> GetObjectFromUrl<T>(Uri url, Token token)
        {
            return JsonToObject<T>(GetJsonFromUrl(url, token));
        }

        public static Uri GetUri(string endpoint)
        {
            return new Uri(BaseUri + endpoint, UriKind.Absolute);
        }

        public static string Base64Encode(string plainText)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            return System.Convert.ToBase64String(plainTextBytes);
        }

        public static string Base64Decode(string base64EncodedData)
        {
            var base64EncodedBytes = System.Convert.FromBase64String(base64EncodedData);
            return System.Text.Encoding.UTF8.GetString(base64EncodedBytes);
        }
    }
}
