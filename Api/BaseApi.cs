namespace SpotifyWebApi.Api
{
    using System;
    using System.Collections.Specialized;
    using System.Net;
    using System.Net.Http;
    using Model.Auth;

    /// <summary>
    /// The <see cref="BaseApi"/> used for all the other APIs.
    /// </summary>
    public abstract class BaseApi
    {
        /// <summary>
        /// Gets the base spotify URI
        /// </summary>
        protected const string BaseUri = "https://api.spotify.com/v1/";

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseApi"/> class.
        /// </summary>
        /// <param name="token">A valid <see cref="Token"/>.</param>
        protected BaseApi(Token token = null)
        {
            this.Token = token;
        }

        /// <summary>
        /// Gets the <see cref="Token"/>.
        /// </summary>
        protected Token Token { get; }

        /// <summary>
        /// An helper function to add a market code at the end of a query string.
        /// </summary>
        /// <param name="sign">The sign to add, usually '&amp;' or '?'.</param>
        /// <param name="market">The market string to add.</param>
        /// <returns>A new query containing the sign with the market.</returns>
        protected static string AddMarketCode(string sign, string market)
        {
            return market.Equals(string.Empty) ? string.Empty : $"{sign}market=" + market;
        }

        /// <summary>
        /// Makes a Spotify uri from the <see cref="BaseUri"/> and the provided <paramref name="relativeUrl"/>.
        /// </summary>
        /// <param name="relativeUrl">The relative URL.</param>
        /// <returns>The full request uri.</returns>
        protected static Uri MakeUri(string relativeUrl)
        {
            if (relativeUrl.StartsWith("/")) { relativeUrl = relativeUrl.Substring(1); }
            return new Uri(BaseUri + relativeUrl);
        }
    }
}
