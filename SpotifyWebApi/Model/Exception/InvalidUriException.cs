namespace SpotifyWebApi.Model.Exception
{
    using System;

    /// <summary>
    /// Exception that gets thrown when creating a spotify uri from a non valid string.
    /// </summary>
    public class InvalidUriException : BaseErrorException
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InvalidUriException"/> class.
        /// </summary>
        /// <param name="message">The message that describes the error.</param>
        public InvalidUriException(string message)
            : base(message)
        {
        }
    }
}
