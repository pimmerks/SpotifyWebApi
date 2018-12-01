namespace SpotifyWebApi.Model
{
    using System;
    using System.Net;

    /// <summary>
    /// A wrapper class for any web request.
    /// </summary>
    /// <typeparam name="TResponse">The expected response type.</typeparam>
    public class WebResponse<TResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WebResponse{T}"/> class.
        /// </summary>
        /// <param name="response">The response.</param>
        /// <param name="statusCode">The status code.</param>
        private WebResponse(TResponse response, HttpStatusCode statusCode)
        {
            this.Response = response;
            this.StatusCode = statusCode;
        }

        /// <summary>
        /// The response.
        /// </summary>
        public TResponse Response { get; }

        /// <summary>
        /// Gets or sets the status code of the html request.
        /// </summary>
        public HttpStatusCode StatusCode { get; }

        /// <summary>
        /// Makes the specified response.
        /// </summary>
        /// <typeparam name="T">The response</typeparam>
        /// <param name="response">The response.</param>
        /// <param name="statusCode">The status code.</param>
        /// <returns>The new <see cref="WebResponse"/>.</returns>
        public static WebResponse<T> Make<T>(T response, HttpStatusCode statusCode)
        {
            return new WebResponse<T>(response, statusCode);
        }
    }
}
