namespace SpotifyWebApi.Model.Enum
{
    using System;

    /// <summary>
    /// The <see cref="SearchType"/>.
    /// </summary>
    [Flags]
    public enum SearchType
    {
        Album = 0,
        Artist = 1 << 0,
        Playlist = 1 << 1,
        Track = 1 << 2
    }
}
