namespace SpotifyWebApi.Api
{
    using Model.Auth;

    /// <summary>
    /// The <see cref="BaseApi"/> used for all the other APIs.
    /// </summary>
    public abstract class BaseApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BaseApi"/> class.
        /// </summary>
        /// <param name="token">A valid <see cref="Token"/>.</param>
        protected BaseApi(Token token)
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
        /// <param name="sign">The sign to add, usually '&' or '?'.</param>
        /// <param name="market">The market string to add.</param>
        /// <returns>A new query containing the sign with the market.</returns>
        protected static string AddMarketCode(string sign, string market)
        {
            return market.Equals(string.Empty) ? string.Empty : $"{sign}market=" + market;
        }
    }
}
