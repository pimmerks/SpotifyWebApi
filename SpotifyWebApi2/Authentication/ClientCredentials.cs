namespace Spotify.WebApi.Authentication
{
    using System;
    using System.Collections.Specialized;
    using System.IO;
    using System.Net;
    using System.Text;
    using System.Threading.Tasks;
    using Model.Authentication;

    /// <summary>
    /// The <see cref="ClientCredentials"/>.
    /// </summary>
    public static class ClientCredentials
    {
        /// <summary>
        /// Retrieves a valid token from the Spotify web api.
        /// </summary>
        /// <param name="parameters">The <see cref="AuthParameters"/> used for this token.</param>
        /// <returns>A valid <see cref="Token"/>.</returns>
        public static async Task<Token> GetTokenAsync(AuthParameters parameters)
        {
            return null;
        }
    }
}
