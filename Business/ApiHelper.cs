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
        /// <summary>
        /// The base uri for all api requests.
        /// </summary>
        public const string BaseUri = "https://api.spotify.com/v1";

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiHelper"/> class.
        /// </summary>
        public ApiHelper()
        {
        }

        /// <summary>
        /// Creates a new <see cref="HttpWebRequest"/> from the specified <paramref name="uri"/>.
        /// </summary>
        /// <param name="uri">The uri of the request.</param>
        /// <returns>A new <see cref="HttpWebRequest"/> from the specified uri.</returns>
        public static HttpWebRequest CreateRequest(Uri uri)
        {
            var request = WebRequest.CreateHttp(uri);
            request.ContentType = "application/x-www-form-urlencoded";
            return request;
        }

        /// <summary>
        /// Retrieves json from an url.
        /// </summary>
        /// <param name="url">The url to retrieve json from.</param>
        /// <param name="token">A valid <see cref="Token"/>.</param>
        /// <returns>A <see cref="WebResponse{T}"/> object containing response information and the retrieved json.
        /// </returns>
        public static WebResponse<string> GetJsonFromUrl(Uri url, Token token)
        {
            var json = string.Empty;

            var request = CreateRequest(url);

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

        /// <summary>
        /// Converts an <see cref="WebResponse"/> of <see cref="string"/> to an object.
        /// </summary>
        /// <typeparam name="T">The expected type to return.</typeparam>
        /// <param name="json">The json string wrapped in a <see cref="WebResponse"/>.</param>
        /// <returns>The <see cref="WebResponse{T}"/>.</returns>
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

        /// <summary>
        /// TODO
        /// </summary>
        /// <typeparam name="T">TODO</typeparam>
        /// <param name="json">TODO</param>
        /// <returns>TODO</returns>
        public static T JsonToObject<T>(string json)
        {
            if (json == null)
            {
                throw new ArgumentNullException(nameof(json));
            }

            return JsonConvert.DeserializeObject<T>(json);
        }

        /// <summary>
        /// TODO
        /// </summary>
        /// <typeparam name="T">TODO</typeparam>
        /// <param name="url">TODO</param>
        /// <param name="token">TODO</param>
        /// <returns>TODO</returns>
        public static WebResponse<T> GetObjectFromUrl<T>(Uri url, Token token)
        {
            return JsonToObject<T>(GetJsonFromUrl(url, token));
        }

        /// <summary>
        /// TODO
        /// </summary>
        /// <param name="endpoint">TODO</param>
        /// <returns>TODO</returns>
        public static Uri GetUri(string endpoint)
        {
            return new Uri(BaseUri + endpoint, UriKind.Absolute);
        }

        /// <summary>
        /// TODO
        /// </summary>
        /// <param name="plainText">TODO</param>
        /// <returns>TODO</returns>
        public static string Base64Encode(string plainText)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            return System.Convert.ToBase64String(plainTextBytes);
        }
    }
}
