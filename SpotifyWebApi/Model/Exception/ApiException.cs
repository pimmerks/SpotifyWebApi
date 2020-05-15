namespace SpotifyWebApi.Model.Exception
{
    using System;

    /// <summary>
    /// The <see cref="ApiException"/>.
    /// </summary>
    public class ApiException : Exception
    {
        public Error Error { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="BadGatewayException"/> class.
        /// </summary>
        /// <param name="message">The exception message.</param>
        public ApiException(Error error)
            : base($"[{error.Status}] {error.Message}")
        {
            this.Error = error;
        }
    }
}
