namespace Spotify.WebApi.Model.Exceptions
{
    using System;

    /// <summary>
    /// Base class for all spotify exceptions.
    /// </summary>
    public class BaseSpotifyException : Exception
    {
        public BaseSpotifyException(string? message)
            : base(message)
        {
        }
        
        public BaseSpotifyException(string? message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
