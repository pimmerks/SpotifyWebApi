namespace Spotify.Model.Exception
{
    using System;

    /// <summary>
    /// An error you should (according to Spotify) never recieve.
    /// </summary>
    public class InternalServerErrorException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InternalServerErrorException"/> class.
        /// </summary>
        /// <param name="message">The exception message.</param>
        public InternalServerErrorException(string message)
            : base(message)
        {
        }
    }
}