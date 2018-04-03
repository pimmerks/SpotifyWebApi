// <copyright file="ImplicitGrant.cs" company="companyPlaceholder">
// Copyright (c) companyPlaceholder. All rights reserved.
// </copyright>

namespace SpotifyWebApi.Auth
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Model.Auth;
    using Model.Enum;

    /// <summary>
    /// The <see cref="ImplicitGrant"/>.
    /// </summary>
    public static class ImplicitGrant
    {
        /// <summary>
        /// Retrieves the authentication url for authenticating with the spotify web api.
        /// </summary>
        /// <param name="parameters">The <see cref="AuthParameters"/> to use while creating the url.</param>
        /// <param name="state">The state to use while creating the url.
        /// For more info see 'https://developer.spotify.com/web-api/authorization-guide/#implicit_grant_flow'</param>
        /// <returns>The url that the user can use to authenticate this application.</returns>
        public static string GetUrl(AuthParameters parameters, string state)
        {
            var scopes = string.Join(
                " ",
                parameters.Scopes.ToString()
                          .Split(new[] { ", " }, StringSplitOptions.None)
                          .Select(i => (int)Enum.Parse(parameters.Scopes.GetType(), i))
                          .Cast<Scope>()
                          .Select(x => x.AsString())
                          .ToList());

            return $"https://accounts.spotify.com/authorize/?" +
                   $"client_id={parameters.ClientId}" +
                   $"&response_type=token" +
                   $"&redirect_uri={parameters.RedirectUri}" +
                   $"&scope={scopes}" +
                   $"&state={state}" +
                   $"&show_dialog={(parameters.ShowDialog ? "true" : "false")}";
        }

        /// <summary>
        /// Creates a token from the callback url.
        /// </summary>
        /// <param name="accessToken">The accesstoken.</param>
        /// <param name="tokenType">The tokentype.</param>
        /// <param name="expiresIn">The expires in.</param>
        /// <param name="state">The state</param>
        /// <returns>A valid <see cref="Token"/>.</returns>
        public static Token Callback(string accessToken, string tokenType, int expiresIn, string state)
        {
            return Token.Make(accessToken, null, tokenType, expiresIn);
        }
    }
}
