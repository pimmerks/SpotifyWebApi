namespace SpotifyWebApi.Api
{
    using System;
    using System.Collections.Generic;
    using System.Dynamic;
    using System.Linq;
    using System.Net.Http;
    using System.Text;
    using System.Text.Json;
    using System.Threading.Tasks;
    using Business;
    using Model;
    using Model.Auth;
    using Model.Exception;

    /// <summary>
    /// The <see cref="BaseApi"/> used for all the other APIs.
    /// </summary>
    public abstract class BaseApi : IDisposable
    {
        private readonly HttpClient httpClient;

        private readonly bool shouldDisposeHttpClient;

        /// <summary>
        /// Disposes the <see cref="BaseApi"/>.
        /// Also disposes the http client if <see cref="shouldDisposeHttpClient"/> is true.
        /// </summary>
        public void Dispose()
        {
            if (this.shouldDisposeHttpClient)
            {
                this.httpClient.Dispose();
            }
        }

        /// <summary>
        /// Gets the base spotify URI
        /// </summary>
        protected const string BaseUri = "https://api.spotify.com/v1/";

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseApi"/> class.
        /// </summary>
        /// <param name="token">A valid <see cref="Token"/>.</param>
        protected BaseApi(Token token)
        {
            this.httpClient = new HttpClient();
            this.shouldDisposeHttpClient = true;

            if (token == null)
            {
                return;
            }

            // Validate token
            Validation.ValidateToken(token);
            this.Token = token;
        }

        protected BaseApi(Token token, HttpClient client)
        {
            this.httpClient = client;
            this.shouldDisposeHttpClient = false;

            if (token == null)
            {
                return;
            }

            // Validate token
            Validation.ValidateToken(token);
            this.Token = token;
        }

        /// <summary>
        /// Gets the <see cref="Token"/>.
        /// </summary>
        protected Token Token { get; private set; }

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
        protected static Uri MakeUri(string relativeUrl, params(string queryParameter, string? value)[] parameters)
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

        protected string AddQueryParameters(string relativeUrl, params KeyValuePair<string, string>[] parameters)
        {
            if (relativeUrl.StartsWith("/")) { relativeUrl = relativeUrl.Substring(1); }

            var p = parameters
                    .Where(x => !string.IsNullOrEmpty(x.Key) && !string.IsNullOrEmpty(x.Value))
                    .ToList();

            var queryParameters = string.Empty;
            if (p.Any())
            {
                queryParameters += "?" + string.Join("&", p.Select(x => $"{x.Key}={x.Value}"));
            }

            return $"{relativeUrl}{queryParameters}";
        }

        #endregion Static methods

        /// <summary>
        /// Updates the token after it has been refreshed.
        /// </summary>
        /// <param name="token">The updated token.</param>
        protected void UpdateToken(Token token)
        {
            // Validate token
            Validation.ValidateToken(token);
            this.Token = token;
        }

        /// <summary>
        /// Make a get request.
        /// </summary>
        /// <param name="relativeUrl">The relative url (starting with '/').</param>
        /// <typeparam name="TResponse">The response type.</typeparam>
        /// <returns>The response.</returns>
        /// <exception cref="ApiException">Throws when the response is not an success.</exception>
        protected async Task<TResponse> GetAsync<TResponse>(string relativeUrl)
        {
            var response = await this.httpClient.GetAsync(BaseUri + relativeUrl);
            var content = await response.Content.ReadAsStringAsync();
            if (response.IsSuccessStatusCode)
            {
                return JsonSerializer.Deserialize<TResponse>(content);
            }

            // If non success throw
            var error = JsonSerializer.Deserialize<Error>(content);
            throw new ApiException(error);
        }

        /// <summary>
        /// Make a get request.
        /// </summary>
        /// <param name="relativeUrl">The relative url (starting with '/').</param>
        /// <typeparam name="TResponse">The response type.</typeparam>
        /// <returns>The response.</returns>
        /// <exception cref="ApiException">Throws when the response is not an success.</exception>
        protected async Task<TResponse> GetAsync<TResponse>(string relativeUrl, params KeyValuePair<string, string>[] queryParameters)
        {
            var response = await this.httpClient.GetAsync(BaseUri + relativeUrl);
            var content = await response.Content.ReadAsStringAsync();
            if (response.IsSuccessStatusCode)
            {
                return JsonSerializer.Deserialize<TResponse>(content);
            }

            // If non success throw
            var error = JsonSerializer.Deserialize<Error>(content);
            throw new ApiException(error);
        }

        /// <summary>
        /// Make a post request.
        /// </summary>
        /// <param name="relativeUrl">The relative url (starting with '/').</param>
        /// <param name="data">The data to post.</param>
        /// <typeparam name="TResponse">The response type.</typeparam>
        /// <returns>The response.</returns>
        /// <exception cref="ApiException">Throws when the response is not an success.</exception>
        protected async Task<TResponse> PostAsync<TResponse>(string relativeUrl, object data)
        {
            var json = new StringContent(JsonSerializer.Serialize(data), Encoding.UTF8, "application/json");

            var response = await this.httpClient.PostAsync(BaseUri + relativeUrl, json);
            var content = await response.Content.ReadAsStringAsync();

            if (response.IsSuccessStatusCode)
            {
                return JsonSerializer.Deserialize<TResponse>(content);
            }

            // If non success throw
            var error = JsonSerializer.Deserialize<Error>(content);
            throw new ApiException(error);
        }

        // TODO: Add Api GET,POST,ETC methods here.
    }
}
