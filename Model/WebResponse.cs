namespace SpotifyWebApi.Model
{
    using System;
    using System.Net;

    /// <summary>
    /// The <see cref="WebResponse" />.
    /// </summary>
    public class WebResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WebResponse"/> class.
        /// </summary>
        /// <param name="response">The response.</param>
        /// <param name="statusCode">The status code.</param>
        private WebResponse(object response, HttpStatusCode statusCode)
        {
            this.Response = response;
            this.StatusCode = statusCode;
        }

        /// <summary>
        /// The response.
        /// </summary>
        public object Response { get; set; }

        public Type Type => this.Response.GetType();

        /// <summary>
        /// Gets or sets the status code of the html request.
        /// </summary>
        public HttpStatusCode StatusCode { get; set; }

        /// <summary>
        /// Makes the specified response.
        /// </summary>
        /// <param name="response">The response.</param>
        /// <param name="statusCode">The status code.</param>
        /// <returns>The new webresponse.</returns>
        public static WebResponse Make(object response, HttpStatusCode statusCode)
        {
            return new WebResponse(response, statusCode);
        }
    }
}
