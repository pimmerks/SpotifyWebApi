// <copyright file="WebResponse.cs" company="companyPlaceholder">
// Copyright (c) companyPlaceholder. All rights reserved.
// </copyright>

namespace SpotifyWebApi.Model
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// The <see cref="WebResponse{T}"/>.
    /// </summary>
    public class WebResponse<T>
    {
        /// <summary>
        /// The response.
        /// </summary>
        public T Response { get; set; }

        /// <summary>
        /// Gets or sets the status code of the html request.
        /// </summary>
        public HttpStatusCode StatusCode { get; set; }
    }
}
