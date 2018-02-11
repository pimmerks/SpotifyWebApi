// <copyright file="AuthParameters.cs" company="companyPlaceholder">
// Copyright (c) companyPlaceholder. All rights reserved.
// </copyright>

namespace SpotifyWebApi.Auth
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Model.Enum;

    /// <summary>
    /// The <see cref="AuthParameters"/>.
    /// </summary>
    public class AuthParameters
    {
        /// <summary>
        /// Gets or sets the authentication client id.
        /// </summary>
        public string ClientId { get; set; }

        /// <summary>
        /// Gets or sets the authentication client secret.
        /// </summary>
        public string ClientSecret { get; set; }

        /// <summary>
        /// Gets or sets the authentication redirect uri.
        /// </summary>
        public string RedirectUri { get; set; }

        /// <summary>
        /// Gets or sets a value indicating wheter to show the login screen every time the user is requested to login.
        /// </summary>
        public bool ShowDialog { get; set; }

        /// <summary>
        /// Gets or sets the authentication scopes.
        /// </summary>
        public Scope Scopes { get; set; }
    }
}
