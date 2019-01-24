namespace Spotify.Model.Exception
{
    using System;

    /// <summary>
    /// The request could not be understood by the server due to malformed syntax.
    /// </summary>
    public class BadRequestException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BadRequestException"/> class.
        /// </summary>
        /// <param name="message">The exception message.</param>
        public BadRequestException(string message)
            : base(message)
        {
        }
    }
}