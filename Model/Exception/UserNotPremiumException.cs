namespace SpotifyWebApi.Model.Exception
{
    using System;

    /// <summary>
    /// The <see cref="UserNotPremiumException"/>.
    /// </summary>
    public class UserNotPremiumException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserNotPremiumException"/> class.
        /// </summary>
        /// <param name="message">The message that describes the error.</param>
        public UserNotPremiumException(string message)
            : base(message)
        {
        }
    }
}