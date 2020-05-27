namespace Spotify.WebApi.Business
{
    using System;
    using System.Collections.Specialized;
    using System.Runtime.CompilerServices;

    /// <summary>
    /// Static uri helper class.
    /// </summary>
    internal static class UriHelper
    {
        /// <summary>
        /// Creates an <see cref="UriBuilder"/> with the default <see cref="ISpotifyWebApi.BaseUri"/>.
        /// </summary>
        /// <param name="relativeUri">The relative uri to add to the base uri.</param>
        /// <returns>The created <see cref="UriBuilder"/>.</returns>
        public static UriBuilder FromUri(string relativeUri)
        {
            var tryUri = new Uri(relativeUri, UriKind.RelativeOrAbsolute);

            if (!tryUri.IsAbsoluteUri)
            {
                return new UriBuilder(ISpotifyWebApi.BaseUri + relativeUri);
            }

            return new UriBuilder(tryUri);
        }
    }
}
