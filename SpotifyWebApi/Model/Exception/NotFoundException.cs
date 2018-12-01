namespace SpotifyWebApi.Model.Exception
{
    using System;

    /// <summary>
    /// The <see cref="NotFoundException"/>.
    /// </summary>
    public class NotFoundException : BaseErrorException
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NotFoundException"/> class.
        /// </summary>
        /// <param name="message">The message that describes the error.</param>
        public NotFoundException(string message)
            : base(message)
        {
        }
    }
}
