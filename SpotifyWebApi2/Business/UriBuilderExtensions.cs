namespace Spotify.WebApi.Business
{
    using System;
    using System.Web;
    using Model.Exceptions;

    public static class UriBuilderExtensions
    {
        /// <summary>
        /// Adds the specified parameter to the Query String.
        /// </summary>
        /// <param name="uriBuilder">The uri builder.</param>
        /// <param name="paramName">Name of the parameter to add.</param>
        /// <param name="paramValue">Value for the parameter to add.</param>
        /// <param name="ignoreOverride">Do not throw an exception when trying to override an parameter.</param>
        /// <returns>Url with added parameter.</returns>
        public static UriBuilder AddParameter(
            this UriBuilder uriBuilder, string? paramName, string? paramValue, bool ignoreOverride = false)
        {
            if (string.IsNullOrWhiteSpace(paramName) || string.IsNullOrWhiteSpace(paramValue))
            {
                return uriBuilder;
            }

            var query = HttpUtility.ParseQueryString(uriBuilder.Query);

            if (!string.IsNullOrEmpty(query[paramName]) && !ignoreOverride)
            {
                throw new BaseSpotifyException($"You are trying to override {paramName}.");
            }
            
            query[paramName] = paramValue;
            uriBuilder.Query = query.ToString();
            return uriBuilder;
        }
    }
}
