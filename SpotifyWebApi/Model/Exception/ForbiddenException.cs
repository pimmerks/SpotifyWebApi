namespace Spotify.Model.Exception
{
    using System;

    /// <summary>
    /// The server understood the request, but is refusing to fulfill it.
    /// </summary>
    public class ForbiddenException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ForbiddenException"/> class.
        /// </summary>
        /// <param name="message">The exception message.</param>
        public ForbiddenException(string message)
            : base(message)
        {
        }
    }
}