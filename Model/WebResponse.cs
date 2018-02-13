namespace SpotifyWebApi.Model
{
    using System.Net;

    /// <summary>
    /// The <see cref="WebResponse{T}" />.
    /// </summary>
    /// <typeparam name="T">The type of <see cref="WebResponse{T}"/></typeparam>
    public class WebResponse<T>
    {
        /// <summary>
        /// The response.
        /// </summary>
        public T Response { get; set; }

        /// <summary>
        /// Gets or sets the status code of the html request.
        /// </summary>
        public HttpStatusCode StatusCode { get; set; }
    }
}
