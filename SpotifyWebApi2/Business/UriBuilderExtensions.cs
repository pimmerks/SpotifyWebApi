namespace Spotify.WebApi.Business
{
    using System;

    /// <summary>
    /// Extension methods for a <see cref="UriBuilder"/>.
    /// </summary>
    public static class UriBuilderExtensions
    {
        /// <summary>
        /// Adds the specified parameter to the Query String.
        /// </summary>
        /// <param name="uriBuilder">The uri builder.</param>
        /// <param name="paramName">Name of the parameter to add.</param>
        /// <param name="paramValue">Value for the parameter to add.</param>
        /// <typeparam name="T">The type of the parameter.</typeparam>
        /// <returns>Url with added parameter.</returns>
        public static UriBuilder AddParameter<T>(
            this UriBuilder uriBuilder, string paramName, T? paramValue)
            where T : struct
        {
            return uriBuilder.AddParameter(paramName, paramValue.ToString());
        }

        /// <summary>
        /// Adds the specified parameter to the Query String.
        /// </summary>
        /// <param name="uriBuilder">The uri builder.</param>
        /// <param name="paramName">Name of the parameter to add.</param>
        /// <param name="paramValue">Value for the parameter to add.</param>
        /// <returns>Url with added parameter.</returns>
        public static UriBuilder AddParameter(
            this UriBuilder uriBuilder, string paramName, string? paramValue)
        {
            if (string.IsNullOrWhiteSpace(paramName) || string.IsNullOrWhiteSpace(paramValue))
            {
                return uriBuilder;
            }

            var query = uriBuilder.Query;

            if (string.IsNullOrEmpty(query))
            {
                query = "?";
            }
            else
            {
                query += "&";
            }

            query += $"{paramName}={paramValue}";

            uriBuilder.Query = query;
            return uriBuilder;
        }
    }
}
