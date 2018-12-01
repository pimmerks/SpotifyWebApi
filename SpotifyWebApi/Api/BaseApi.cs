namespace SpotifyWebApi.Api
{
    using System;
    using System.Collections.Generic;
    using System.Dynamic;
    using System.Linq;
    using System.Net.Http;
    using System.Net.Http.Headers;
    using System.Text;
    using System.Threading.Tasks;
    using Business;
    using global::SpotifyWebApi.Model;
    using Model.Auth;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// The <see cref="BaseApi"/> used for all the other APIs.
    /// </summary>
    public abstract class BaseApi
    {
        /// <summary>
        /// Gets the base spotify URI
        /// </summary>
        protected const string BaseUri = "https://api.spotify.com/v1/";

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseApi"/> class.
        /// </summary>
        /// <param name="token">A valid <see cref="Token"/>.</param>
        /// <param name="httpClient">The <see cref="System.Net.Http.HttpClient"/> to be used for every request to the api.</param>
        protected BaseApi(Token token, HttpClient httpClient)
        {
            if (token == null)
            {
                return;
            }

            this.HttpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient));

            // Validate token
            Validation.ValidateToken(token);
            this.Token = token;

            httpClient.DefaultRequestHeaders.Accept.Add(
                MediaTypeWithQualityHeaderValue.Parse("application/x-www-form-urlencoded"));
            httpClient.DefaultRequestHeaders.Authorization = AuthenticationHeaderValue.Parse(this.Token.ToHeaderString());
        }

        /// <summary>
        /// Gets the <see cref="Token"/>.
        /// </summary>
        protected Token Token { get; }

        /// <summary>
        /// Gets the <see cref="System.Net.Http.HttpClient"/>.
        /// </summary>
        protected HttpClient HttpClient { get; }

        #region Methods

        /// <summary>
        /// Gets from an uri asynchronously.
        /// </summary>
        /// <typeparam name="T">The expected return object.</typeparam>
        /// <param name="uri">The request URI.</param>
        /// <returns>The response of the HTTP GET.</returns>
        public async Task<WebResponse<T>> GetAsync<T>(Uri uri)
        {
            var response = await this.HttpClient.GetAsync(uri);
            var responseString = await response.Content.ReadAsStringAsync();

            Validation.ValidateResponseCode(response.StatusCode, responseString);

            return WebResponse<T>.Make(DeserializeObject<T>(responseString), response.StatusCode);
        }

        /// <summary>
        /// Posts to an uri asynchronously.
        /// </summary>
        /// <typeparam name="T">The expected return object.</typeparam>
        /// <param name="uri">The request URI.</param>
        /// <param name="body">The body of the request.</param>
        /// <returns>The response of the HTTP POST.</returns>
        public async Task<WebResponse<T>> PostAsync<T>(Uri uri, object body)
        {
            var content = new StringContent(SerializeObject(body), Encoding.UTF8, "application/json");

            var response = await this.HttpClient.PostAsync(uri, content);
            var responseString = await response.Content.ReadAsStringAsync();

            Validation.ValidateResponseCode(response.StatusCode, responseString);

            return WebResponse<T>.Make(DeserializeObject<T>(responseString), response.StatusCode);
        }

        /// <summary>
        /// Puts to an uri asynchronously.
        /// </summary>
        /// <typeparam name="T">The expected return object.</typeparam>
        /// <param name="uri">The request URI.</param>
        /// <param name="body">The body of the request.</param>
        /// <returns>The response of the HTTP PUT.</returns>
        public async Task<WebResponse<T>> PutAsync<T>(Uri uri, object body)
        {
            var content = new StringContent(SerializeObject(body), Encoding.UTF8, "application/json");

            var response = await this.HttpClient.PutAsync(uri, content);
            var responseString = await response.Content.ReadAsStringAsync();

            Validation.ValidateResponseCode(response.StatusCode, responseString);

            return WebResponse<T>.Make(DeserializeObject<T>(responseString), response.StatusCode);
        }

        /// <summary>
        /// Deletes from an uri asynchronously.
        /// </summary>
        /// <typeparam name="T">The expected return object.</typeparam>
        /// <param name="uri">The request URI.</param>
        /// <returns>The response of the HTTP DELETE.</returns>
        public async Task<WebResponse<T>> DeleteAsync<T>(Uri uri)
        {
            var response = await this.HttpClient.DeleteAsync(uri);
            var responseString = await response.Content.ReadAsStringAsync();

            Validation.ValidateResponseCode(response.StatusCode, responseString);

            return WebResponse<T>.Make(DeserializeObject<T>(responseString), response.StatusCode);
        }

        #endregion Methods

        #region Static methods

        /// <summary>
        /// Makes a Spotify url from the <see cref="BaseUri"/> and the provided <paramref name="relativeUrl"/>.
        /// </summary>
        /// <param name="relativeUrl">The relative URL.</param>
        /// <returns>The full request uri.</returns>
        protected static Uri MakeUri(string relativeUrl)
        {
            if (relativeUrl.StartsWith("/")) { relativeUrl = relativeUrl.Substring(1); }
            return new Uri(BaseUri + relativeUrl);
        }

        /// <summary>
        /// Makes a Spotify uri from the <see cref="BaseUri"/> and the provided <paramref name="relativeUrl"/>.
        /// Also adding any query parameters.
        /// </summary>
        /// <param name="relativeUrl">The relative URL.</param>
        /// <param name="parameters">A list of query parameters.
        /// Note: When a parameter value is null or empty, the query will not contain the query parameter.</param>
        /// <returns>The full request uri.</returns>
        protected static Uri MakeUri(string relativeUrl, params(string queryParameter, string value)[] parameters)
        {
            if (relativeUrl.StartsWith("/")) { relativeUrl = relativeUrl.Substring(1); }

            var p = parameters.Where(x => !string.IsNullOrEmpty(x.queryParameter) && !string.IsNullOrEmpty(x.value)).ToList();

            var queryParameters = string.Empty;
            if (p.Any())
            {
                queryParameters += "?" + string.Join("&", p.Select(x => $"{x.queryParameter}={x.value}"));
            }

            return new Uri(BaseUri + relativeUrl + queryParameters);
        }

        #endregion Static methods

        /// <summary>
        /// Custom deserialization with StringEnumConverter.
        /// </summary>
        /// <typeparam name="T">The type of the expected object.</typeparam>
        /// <param name="json">The json to deserialize.</param>
        /// <returns>The deserialized object.</returns>
        private static T DeserializeObject<T>(string json)
        {
            return JsonConvert.DeserializeObject<T>(json, new StringEnumConverter(true));
        }

        /// <summary>
        /// Custom serialization with StringEnumConverter.
        /// </summary>
        /// <param name="obj">The object to serialize.</param>
        /// <returns>The serialized JSON.</returns>
        private static string SerializeObject(object obj)
        {
            return JsonConvert.SerializeObject(obj, new StringEnumConverter(true));
        }
    }
}
