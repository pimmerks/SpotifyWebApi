namespace Spotify.Model.Exception
{
    using System;

    /// <summary>
    /// The server was acting as a gateway or proxy and received an invalid response from the upstream server.
    /// </summary>
    public class BadGatewayException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BadGatewayException"/> class.
        /// </summary>
        /// <param name="message">The exception message.</param>
        public BadGatewayException(string message)
            : base(message)
        {
        }
    }
}