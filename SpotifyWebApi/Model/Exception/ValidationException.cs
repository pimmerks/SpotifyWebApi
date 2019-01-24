// <copyright file="ValidationException.cs" company="companyPlaceholder">
// Copyright (c) companyPlaceholder. All rights reserved.
// </copyright>

namespace Spotify.Model.Exception
{
    using System;

    /// <summary>
    /// The <see cref="ValidationException"/>.
    /// </summary>
    public class ValidationException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ValidationException"/> class.
        /// </summary>
        /// <param name="message">The validation message.</param>
        public ValidationException(string message)
            : base(message)
        {
        }
    }
}
