namespace SpotifyWebApi.Business
{
    using System;
    using System.Net.Http;
    using System.Net.Http.Headers;
    using System.Text;
    using System.Threading.Tasks;
    using Model;
    using Model.Auth;
    using Newtonsoft.Json;

    /// <summary>
    /// The <see cref="ApiClient"/> class used for communicating with a REST service.
    /// </summary>
    public static class ApiClient
    {
        /// <summary>
        /// Gets from an uri asynchronously.
        /// </summary>
        /// <typeparam name="T">The expected return object.</typeparam>
        /// <param name="uri">The request URI.</param>
        /// <param name="token">Optional. A valid <see cref="Token"/>.</param>
        /// <returns>The response of the HTTP GET.</returns>
        public static async Task<WebResponse> GetAsync<T>(Uri uri, Token token = null)
        {
            using (var client = MakeHttpClient(token))
            {
                var response = await client.GetAsync(uri);
                var responseString = await response.Content.ReadAsStringAsync();

                return response.IsSuccessStatusCode
                    ? WebResponse.Make(JsonConvert.DeserializeObject<T>(responseString), response.StatusCode)
                    : WebResponse.Make(JsonConvert.DeserializeObject<Error>(responseString), response.StatusCode);
            }
        }

        /// <summary>
        /// Posts to an uri asynchronously.
        /// </summary>
        /// <typeparam name="T">The expected return object.</typeparam>
        /// <param name="uri">The request URI.</param>
        /// <param name="body">The body of the request.</param>
        /// <param name="token">Optional. A valid <see cref="Token"/>.</param>
        /// <returns>The response of the HTTP POST.</returns>
        public static async Task<WebResponse> PostAsync<T>(Uri uri, object body, Token token = null)
        {
            using (var client = MakeHttpClient(token))
            {
                var content = new StringContent(JsonConvert.SerializeObject(body), Encoding.UTF8, "application/json");

                var response = await client.PostAsync(uri, content);
                var responseString = await response.Content.ReadAsStringAsync();

                return response.IsSuccessStatusCode
                           ? WebResponse.Make(JsonConvert.DeserializeObject<T>(responseString), response.StatusCode)
                           : WebResponse.Make(JsonConvert.DeserializeObject<Error>(responseString), response.StatusCode);
            }
        }

        /// <summary>
        /// Puts to an uri asynchronously.
        /// </summary>
        /// <typeparam name="T">The expected return object.</typeparam>
        /// <param name="uri">The request URI.</param>
        /// <param name="body">The body of the request.</param>
        /// <param name="token">Optional. A valid <see cref="Token"/>.</param>
        /// <returns>The response of the HTTP PUT.</returns>
        public static async Task<WebResponse> PutAsync<T>(Uri uri, object body, Token token = null)
        {
            using (var client = MakeHttpClient(token))
            {
                var content = new StringContent(JsonConvert.SerializeObject(body), Encoding.UTF8, "application/json");

                var response = await client.PutAsync(uri, content);
                var responseString = await response.Content.ReadAsStringAsync();

                return response.IsSuccessStatusCode
                           ? WebResponse.Make(JsonConvert.DeserializeObject<T>(responseString), response.StatusCode)
                           : WebResponse.Make(JsonConvert.DeserializeObject<Error>(responseString), response.StatusCode);
            }
        }

        /// <summary>
        /// Deletes from an uri asynchronously.
        /// </summary>
        /// <typeparam name="T">The expected return object.</typeparam>
        /// <param name="uri">The request URI.</param>
        /// <param name="token">Optional. A valid <see cref="Token"/>.</param>
        /// <returns>The response of the HTTP DELETE.</returns>
        public static async Task<WebResponse> DeleteAsync<T>(Uri uri, Token token = null)
        {
            using (var client = MakeHttpClient(token))
            {
                var response = await client.DeleteAsync(uri);
                var responseString = await response.Content.ReadAsStringAsync();

                return response.IsSuccessStatusCode
                           ? WebResponse.Make(JsonConvert.DeserializeObject<T>(responseString), response.StatusCode)
                           : WebResponse.Make(JsonConvert.DeserializeObject<Error>(responseString), response.StatusCode);
            }
        }

        /// <summary>
        /// Makes the HTTP client.
        /// </summary>
        /// <param name="token">Optional. A valid <see cref="Token"/>.</param>
        /// <returns>A newly created <see cref="HttpClient"/> containing the authentication provided by the token.</returns>
        private static HttpClient MakeHttpClient(Token token = null)
        {
            var client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Add(
                MediaTypeWithQualityHeaderValue.Parse("application/x-www-form-urlencoded"));

            if (token != null)
                client.DefaultRequestHeaders.Authorization = AuthenticationHeaderValue.Parse(token.ToHeaderString());

            return client;
        }
    }
}
