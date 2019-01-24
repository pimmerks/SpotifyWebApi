namespace Spotify.Model.Enum
{
    using System;

    /// <summary>
    /// Enum AlbumType
    /// </summary>
    [Flags]
    public enum AlbumType
    {
        /// <summary>
        /// The album
        /// </summary>
        Album = 1,

        /// <summary>
        /// The single
        /// </summary>
        Single = 2,

        /// <summary>
        /// The appears on
        /// </summary>
        AppearsOn = 4,

        /// <summary>
        /// The compilation
        /// </summary>
        Compilation = 8
    }
}