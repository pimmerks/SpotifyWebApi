namespace Spotify.WebApi.Model.Exceptions
{
    using System;

    /// <summary>
    /// Exception can be thrown on all uri errors.
    /// </summary>
    public class SpotifyUriException : BaseSpotifyException
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SpotifyUriException"/> class.
        /// </summary>
        /// <param name="message">An optional message.</param>
        public SpotifyUriException(string? message)
            : base(message)
        {
        }
    }
}
