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
        public string ClientId { get; set; }
        public string ClientSecret { get; set; }
        public string RedirectUri { get; set; }
        public bool ShowDialog { get; set; }
        public Scope Scopes { get; set; }
    }
}
