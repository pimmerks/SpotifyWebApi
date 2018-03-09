namespace SpotifyWebApi.Business
{
    using System;
    using System.Net;
    using Model.Auth;

    /// <summary>
    /// The <see cref="ApiHelper"/>.
    /// </summary>
    public static class ApiHelper
    {
        /// <summary>
        /// The base uri for all api requests.
        /// </summary>
        public const string BaseUri = "https://api.spotify.com/v1";

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
        /// TODO
        /// </summary>
        /// <typeparam name="T">TODO</typeparam>
        /// <param name="url">TODO</param>
        /// <param name="token">TODO</param>
        /// <returns>TODO</returns>
        public static Model.WebResponse GetObjectFromUrl<T>(Uri url, Token token)
        {
            return null; // JsonToObject<T>(GetJsonFromUrl(url, token));
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
