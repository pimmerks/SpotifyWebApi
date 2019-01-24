namespace Spotify.Model.Exception
{
    using System;

    /// <summary>
    /// The server is currently unable to handle the request due to a temporary condition which will be alleviated after some delay.
    /// </summary>
    public class ServiceUnavailableException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceUnavailableException"/> class.
        /// </summary>
        /// <param name="message">The exception message.</param>
        public ServiceUnavailableException(string message)
            : base(message)
        {
        }
    }
}