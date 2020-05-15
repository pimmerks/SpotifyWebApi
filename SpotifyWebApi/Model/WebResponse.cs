namespace SpotifyWebApi.Model
{
    using System;
    using System.Net;

    /// <summary>
    /// The <see cref="WebResponse" />.
    /// </summary>
    public class WebResponse<T>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WebResponse{T}"/> class.
        /// </summary>
        /// <param name="response">The response.</param>
        /// <param name="statusCode">The status code.</param>
        private WebResponse(T response, HttpStatusCode statusCode)
        {
            this.Response = response;
            this.StatusCode = statusCode;
        }

        /// <summary>
        /// The response.
        /// </summary>
        public T Response { get; set; }

        /// <summary>
        /// Gets the type of the response.
        /// </summary>
        public Type Type => typeof(T);

        /// <summary>
        /// Gets or sets the status code of the html request.
        /// </summary>
        public HttpStatusCode StatusCode { get; set; }

        /// <summary>
        /// Makes the specified response.
        /// </summary>
        /// <param name="response">The response.</param>
        /// <param name="statusCode">The status code.</param>
        /// <returns>The new web response.</returns>
        public static WebResponse<TOut> Make<TOut>(TOut response, HttpStatusCode statusCode)
        {
            return new WebResponse<TOut>(response, statusCode);
        }
    }
}
