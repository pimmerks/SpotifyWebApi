// <copyright file="EnumExtensions.cs" company="companyPlaceholder">
// Copyright (c) companyPlaceholder. All rights reserved.
// </copyright>

namespace SpotifyWebApi.Model.Enum
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// The <see cref="EnumExtensions"/>.
    /// </summary>
    public static class EnumExtensions
    {
        public static string AsString(this AlbumType albumType)
        {
            switch (albumType)
            {
                case AlbumType.Album:
                    return "album";
                case AlbumType.Single:
                    return "single";
                case AlbumType.AppearsOn:
                    return "appears_on";
                case AlbumType.Compilation:
                    return "compilation";
                default:
                    throw new ArgumentOutOfRangeException(nameof(albumType), albumType, null);
            }
        }
    }
}
