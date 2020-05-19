namespace Spotify.WebApi.Business
{
    using System;
    using System.Collections.Specialized;
    using System.Runtime.CompilerServices;

    internal static class UriHelper
    {
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
