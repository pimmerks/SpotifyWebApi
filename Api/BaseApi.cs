namespace SpotifyWebApi.Api
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Model.Auth;

    /// <summary>
    /// The <see cref="BaseApi"/> used for all the other APIs.
    /// </summary>
    public abstract class BaseApi
    {
        /// <summary>
        /// Gets the <see cref="Token"/>.
        /// </summary>
        protected Token Token { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseApi"/> class.
        /// </summary>
        protected BaseApi(Token token)
        {
            this.Token = token;
        }

        protected string AddMarketCode(string sign, string market)
        {
            return market.Equals("") ? "" : $"{sign}market=" + market;
        }
    }
}
