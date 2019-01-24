namespace Spotify.Model.Exception
{
    using System;

    /// <summary>
    /// Rate limiting has been applied.
    /// See <see href="https://developer.spotify.com/documentation/web-api/#rate-limiting">here</see>.
    /// </summary>
    public class TooManyRequestsException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TooManyRequestsException"/> class.
        /// </summary>
        /// <param name="message">The exception message.</param>
        public TooManyRequestsException(string message)
            : base(message)
        {
        }
    }
}