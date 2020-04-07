namespace SpotifyWebApi.Api
{
    using System;
    using System.Collections.Generic;
    using System.Dynamic;
    using System.Linq;
    using System.Threading.Tasks;
    using Business;
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
        protected BaseApi(Token token)
        {
            if (token == null)
            {
                return;
            }

            // Validate token
            Validation.ValidateToken(token);
            this.Token = token;
        }

        /// <summary>
        /// Updates the token when you refreshed it.
        /// </summary>
        /// <param name="token">The updated token.</param>
        protected void UpdateToken(Token token)
        {
            // Validate token
            Validation.ValidateToken(token);
            this.Token = token;
        }

        /// <summary>
        /// Gets the <see cref="Token"/>.
        /// </summary>
        protected Token Token { get; private set; }

        // TODO: Add Api GET,POST,ETC methods here.

        #region Static methods

        /// <summary>
        /// Makes a Spotify url from the <see cref="BaseUri"/> and the provided <paramref name="relativeUrl"/>.
        /// </summary>
        /// <param name="relativeUrl">The relative URL.</param>
        /// <returns>The full request uri.</returns>
        protected static Uri MakeUri(string relativeUrl)
        {
            if (relativeUrl.StartsWith("/")) { relativeUrl = relativeUrl.Substring(1); }
            return new Uri(BaseUri + relativeUrl);
        }

        /// <summary>
        /// Makes a Spotify uri from the <see cref="BaseUri"/> and the provided <paramref name="relativeUrl"/>.
        /// Also adding any query parameters.
        /// </summary>
        /// <param name="relativeUrl">The relative URL.</param>
        /// <param name="parameters">A list of query parameters.
        /// Note: When a parameter value is null or empty, the query will not contain the query parameter.</param>
        /// <returns>The full request uri.</returns>
        protected static Uri MakeUri(string relativeUrl, params(string queryParameter, string value)[] parameters)
        {
            if (relativeUrl.StartsWith("/")) { relativeUrl = relativeUrl.Substring(1); }

            var p = parameters.Where(x => !string.IsNullOrEmpty(x.queryParameter) && !string.IsNullOrEmpty(x.value)).ToList();

            var queryParameters = string.Empty;
            if (p.Any())
            {
                queryParameters += "?" + string.Join("&", p.Select(x => $"{x.queryParameter}={x.value}"));
            }

            return new Uri(BaseUri + relativeUrl + queryParameters);
        }

        #endregion Static methods
    }
}
