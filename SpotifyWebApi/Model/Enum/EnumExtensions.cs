namespace SpotifyWebApi.Model.Enum
{
    using System;

    /// <summary>
    /// The <see cref="EnumExtensions" />.
    /// </summary>
    public static class EnumExtensions
    {
        /// <summary>
        /// Ases the string.
        /// </summary>
        /// <param name="albumType">Type of the album.</param>
        /// <returns>System.String.</returns>
        /// <exception cref="ArgumentOutOfRangeException">albumType - null</exception>
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
