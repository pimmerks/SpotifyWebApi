namespace SpotifyWebApi.Model.Exception
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using Newtonsoft.Json;

    /// <summary>
    /// The base class for any Spotify error.
    /// </summary>
    public class BaseErrorException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BaseErrorException"/> class.
        /// </summary>
        /// <param name="response">The response retrieved.</param>
        public BaseErrorException(string response)
            : base(response)
        {
            this.Error = JsonConvert.DeserializeObject<ErrorResponse>(response).Error;
        }

        /// <summary>
        /// The <see cref="Error"/> retrieved from the Spotify web api.
        /// </summary>
        public Error Error { get; }
    }
}
