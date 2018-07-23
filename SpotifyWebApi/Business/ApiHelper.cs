namespace SpotifyWebApi.Business
{
    using System;
    using System.Net;
    using Model.Auth;

    /// <summary>
    /// The <see cref="ApiHelper"/>.
    /// </summary>
    internal static class ApiHelper
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
        /// Encodes a string to Base64.
        /// </summary>
        /// <param name="plainText">The string to encode.</param>
        /// <returns>The base 64 encoded string.</returns>
        public static string Base64Encode(string plainText)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            return System.Convert.ToBase64String(plainTextBytes);
        }
    }
}
