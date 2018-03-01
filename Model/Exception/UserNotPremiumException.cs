namespace SpotifyWebApi.Model.Exception
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;
    using System.Text;
    using System.Threading.Tasks;

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