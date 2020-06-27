namespace Spotify.WebApi.Model.Exceptions
{
    using System;

    /// <summary>
    /// Base class for all spotify exceptions.
    /// </summary>
    public class BaseSpotifyException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BaseSpotifyException"/> class.
        /// </summary>
        /// <param name="message">An optional message.</param>
        public BaseSpotifyException(string? message)
            : base(message)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseSpotifyException"/> class.
        /// </summary>
        /// <param name="message">An optional message.</param>
        /// <param name="innerException">An optional inner <see cref="Exception"/>.</param>
        public BaseSpotifyException(string? message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
