namespace Spotify.Model.Enum
{
    using System;

    /// <summary>
    /// The <see cref="SearchType"/>.
    /// </summary>
    [Flags]
    public enum SearchType
    {
        /// <summary>
        /// TODO
        /// </summary>
        Album = 0,

        /// <summary>
        /// TODO
        /// </summary>
        Artist = 1 << 0,

        /// <summary>
        /// TODO
        /// </summary>
        Playlist = 1 << 1,

        /// <summary>
        /// TODO
        /// </summary>
        Track = 1 << 2
    }
}
