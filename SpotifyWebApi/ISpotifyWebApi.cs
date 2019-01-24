namespace Spotify
{
    using Api.Album;
    using Api.Artist;
    using Api.Browse;
    using Api.Follow;
    using Api.Personalization;
    using Api.Player;
    using Api.Playlist;
    using Api.Search;
    using Api.Track;
    using Api.UserLibrary;
    using Api.UserProfile;

    /// <summary>
    /// The <see cref="ISpotifyWebApi"/>.
    /// </summary>
    public interface ISpotifyWebApi
    {
        /// <summary>
        /// Gets the implementation of <see cref="IAlbumApi"/>.
        /// </summary>
        IAlbumApi Album { get; }

        /// <summary>
        /// Gets the implementation of <see cref="IArtistApi"/>.
        /// </summary>
        IArtistApi Artist { get; }

        /// <summary>
        /// Gets the implementation of <see cref="IBrowseApi"/>.
        /// </summary>
        IBrowseApi Browse { get; }

        /// <summary>
        /// Gets the implementation of <see cref="IFollowApi"/>.
        /// </summary>
        IFollowApi Follow { get; }

        /// <summary>
        /// Gets the implementation of <see cref="IPersonalizationApi"/>.
        /// </summary>
        IPersonalizationApi Personalization { get; }

        /// <summary>
        /// Gets the implementation of <see cref="IPlayerApi"/>.
        /// </summary>
        IPlayerApi Player { get; }

        /// <summary>
        /// Gets the implementation of <see cref="IPlaylistApi"/>.
        /// </summary>
        IPlaylistApi Playlist { get; }

        /// <summary>
        /// Gets the implementation of <see cref="ISearchApi"/>.
        /// </summary>
        ISearchApi Search { get; }

        /// <summary>
        /// Gets the implementation of <see cref="ITrackApi"/>.
        /// </summary>
        ITrackApi Track { get; }

        /// <summary>
        /// Gets the implementation of <see cref="IUserLibraryApi"/>.
        /// </summary>
        IUserLibraryApi UserLibrary { get; }

        /// <summary>
        /// Gets the implementation of <see cref="IUserProfileApi"/>.
        /// </summary>
        IUserProfileApi UserProfile { get; }
    }
}
